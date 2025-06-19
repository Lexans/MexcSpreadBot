using MexcSpreadBot;
using MexcSpreadBot.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Text.Json;

public class DexScreenerHelper
{
    private static readonly HttpClient httpClient = new HttpClient
    {
        Timeout = TimeSpan.FromSeconds(10)
    };

    public static async Task UpdateDexDataAsync(Pair pair = null)
    {
        var context = new DataBaseContextExchange();
        var dexList = new List<Dex>();

        if (pair == null)
            dexList = await context.Dexes
            .Where(d => !d.IsIgnored && !d.Pair.IsIgnored)
            .AsNoTracking()
            .ToListAsync();
        else
            dexList = await context.Dexes
            .Where(d => !d.IsIgnored && d.Pair.PairId == pair.PairId)
            .AsNoTracking()
            .ToListAsync();


        var groupedByChain = dexList
            .GroupBy(d => d.ChainId)
            .ToDictionary(g => g.Key, g => g.ToList());

        var allRequests = new List<(string ChainId, List<Dex> DexBatch)>();

        foreach (var (chainId, dexes) in groupedByChain)
        {
            for (int i = 0; i < dexes.Count; i += ConstantsValues.DexScreenerMaxBatchSize)
            {
                var batch = dexes.Skip(i).Take(ConstantsValues.DexScreenerMaxBatchSize).ToList();
                allRequests.Add((chainId, batch));
            }
        }

        using var semaphore = new SemaphoreSlim(ConstantsValues.DexScreenerMaxThreads);

        var tasks = allRequests.Select(async (batch) =>
        {
            await semaphore.WaitAsync();
            try
            {
                await ProcessDexBatchAsync(context, batch.ChainId, batch.DexBatch);
            }
            finally
            {
                semaphore.Release();
            }
        });

        await Task.WhenAll(tasks);
    }

    private static async Task ProcessDexBatchAsync(DataBaseContextExchange context, string chainId, List<Dex> batch)
    {
        var pairAddresses = string.Join(",", batch.Select(d => d.PairAddress));
        var url = $"https://api.dexscreener.com/latest/dex/pairs/{chainId}/{pairAddresses}";

        using var httpClient = new HttpClient();
        HttpResponseMessage response;

        try
        {
            response = await httpClient.GetAsync(url);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при запросе: {ex.Message}");
            return;
        }

        if (!response.IsSuccessStatusCode)
        {
            Console.WriteLine($"Ошибка запроса: {response.StatusCode}");
            return;
        }

        var json = await response.Content.ReadAsStringAsync();

        using var document = JsonDocument.Parse(json);
        var root = document.RootElement;

        if (!root.TryGetProperty("pairs", out var pairsElement) || pairsElement.ValueKind != JsonValueKind.Array)
            return;

        foreach (var pair in pairsElement.EnumerateArray())
        {
            if (!pair.TryGetProperty("pairAddress", out var addressProp)) continue;

            var address = addressProp.GetString();
            var dex = batch.FirstOrDefault(d => d.PairAddress.Equals(address, StringComparison.OrdinalIgnoreCase));
            if (dex == null) continue;

            // Price
            if (pair.TryGetProperty("priceUsd", out var priceProp) &&
                double.TryParse(priceProp.GetString(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out var price))
            {
                dex.PriceUsd = price;
            }

            // Volume
            if (pair.TryGetProperty("volume", out var volumeObj))
            {
                if (volumeObj.TryGetProperty("m5", out var volM5))
                {
                    dex.VolumeM5 = volM5.GetDouble();
                }

                if (volumeObj.TryGetProperty("h1", out var volH1))
                {
                    dex.VolumeH1 = volH1.GetDouble();
                }

                if (volumeObj.TryGetProperty("h24", out var volH24))
                {
                    dex.VolumeH24 = volH24.GetDouble();
                }
            }

            // priceChange
            if (pair.TryGetProperty("priceChange", out var priceChangeObj))
            {
                if (priceChangeObj.TryGetProperty("m5", out var pcM5))
                {
                    dex.PriceChangeM5 = pcM5.GetDouble();
                }
            }



            // Liquidity
            if (pair.TryGetProperty("liquidity", out var liquidityObj) &&
                liquidityObj.TryGetProperty("usd", out var liquidityUsdProp))
            {
                dex.LiquidityUsd = liquidityUsdProp.GetDouble();
            }

            context.Dexes.Update(dex);
        }

        await context.SaveChangesAsync();
    }

    /// <summary>
    /// загружает пары chainID  и pairAddress выбранной валюты
    /// </summary>
    /// <param name="tokenSymbol">базовая валюта</param>
    /// <returns></returns>
    public static async Task<int> LoadDexPairsForTokenAsync(string tokenSymbol)
    {
        var dbContext = new DataBaseContextExchange();
        var pairCurrent = dbContext.Pairs.FirstOrDefault(x => x.Base == tokenSymbol);

        if (pairCurrent == null)
            return 0;

        if (string.IsNullOrWhiteSpace(tokenSymbol))
            return 0;

        string url = $"https://api.dexscreener.com/latest/dex/search?q={tokenSymbol}";

        string response = await httpClient.GetStringAsync(url);
        JObject json = JObject.Parse(response);
        JArray pairs = (JArray)json["pairs"];

        if (pairs == null || pairs.Count == 0)
            return 0;

        var dexEntries = new List<Dex>();

        foreach (var pair in pairs)
        {
            string baseSymbol = pair["baseToken"]?["symbol"]?.ToString();
            string tokenName = pair["baseToken"]?["name"]?.ToString().Trim();

            if (!string.Equals(baseSymbol.Trim(), tokenSymbol, StringComparison.OrdinalIgnoreCase))
                continue;

            //фильтруем только долларовые пары
            string quoteSymbol = pair["quoteToken"]?["symbol"]?.ToString();
            //if (!quoteSymbol.Trim().StartsWith("USDT", StringComparison.OrdinalIgnoreCase))
            //    continue;


            string chainId = pair["chainId"]?.ToString();
            string pairAddress = pair["pairAddress"]?.ToString();
            string dexIdString = pair["dexId"]?.ToString();

            if (string.IsNullOrEmpty(chainId) || string.IsNullOrEmpty(pairAddress))
                continue;

            bool alreadyExists = await dbContext.Dexes
                .AnyAsync(d => d.ChainId == chainId && d.PairAddress == pairAddress);

            if (!alreadyExists)
            {
                dexEntries.Add(new Dex
                {
                    ChainId = chainId,
                    PairAddress = pairAddress,
                    IsIgnored = false,
                    Pair = pairCurrent,
                    DexIdString = dexIdString,
                    BaseTokenName = tokenName,
                    QuoteTokenSymbol = quoteSymbol
                });
            }
        }

        if (dexEntries.Count > 0)
        {
            dbContext.Dexes.AddRange(dexEntries);
            await dbContext.SaveChangesAsync();
        }

        return dexEntries.Count;
    }


    public static void SetIsIgnoreToDexPairs()
    {
        var context = new DataBaseContextExchange();
        var dexList = new List<Dex>();

        dexList = context.Dexes
        .Where(d => !d.Pair.IsIgnored)
        .ToList();



        foreach (var dex in dexList)
        {
            context.Entry(dex).Reference(u => u.Pair).Load();

            if (dex.PriceUsd != null && dex.Pair.PriceMexc != null &&
                Math.Abs((double)(dex.PriceUsd - dex.Pair.PriceMexc)) / (dex.Pair.PriceMexc) * 100.0 > ConstantsValues.PriceDifferenceThreshold ||
                dex.VolumeH24 != null && dex.VolumeH24 <= ConstantsValues.DexVolumeH24Treshold)
                dex.IsIgnored = true;
            else
                dex.IsIgnored = false;

            context.Dexes.Update(dex);
        }

        context.SaveChanges();
    }

}