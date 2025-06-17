using MexcSpreadBot.Data;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace MexcSpreadBot.Helpers
{

    public class MexcHelper
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        

        public static void PairsSetIsIgnore()
        {
            DataBaseContextExchange dbContext = new DataBaseContextExchange();
            var allPairs = dbContext.Pairs.ToList();

            foreach (var pair in allPairs)
            {
                if (pair.VolumeH24Mexc > ConstantsValues.Max24HVolume)
                    pair.IsIgnored = true;
                else
                    pair.IsIgnored = false;

                dbContext.Pairs.Update(pair);
            }

            dbContext.SaveChanges();
        }

        /// <summary>
        /// загружает все пары c mexc 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static async Task<List<Pair>> GetAllFuturesSymbolsAsync()
        {
            var url = "https://contract.mexc.com/api/v1/contract/detail";
            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Ошибка запроса: " + response.StatusCode);
            }

            var json = await response.Content.ReadAsStringAsync();

            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;

            var resultList = new List<Pair>();

            foreach (var item in root.GetProperty("data").EnumerateArray())
            {
                //загружаем только USDT пары
                if (item.GetProperty("quoteCoin").GetString() == "USDT")
                    resultList.Add(new Pair
                    {
                        Base = item.GetProperty("baseCoin").GetString(),
                        Quote = item.GetProperty("quoteCoin").GetString(),
                        MaxLeverage = item.GetProperty("maxLeverage").GetInt32(),
                        PriceScale = item.GetProperty("priceScale").GetInt32(),
                        AmountScale = item.GetProperty("amountScale").GetInt32(),
                        PriceUnit = item.GetProperty("priceUnit").GetDouble(),
                        MaxVol = item.GetProperty("maxVol").GetInt32(),
                    });
            }

            return resultList;
        }

        /// <summary>
        /// обновляет все цены и объемы торгов с mexc
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static async Task UpdatePricesAndVolumesAsync()
        {
            var url = "https://contract.mexc.com/api/v1/contract/ticker";
            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Ошибка при запросе данных: " + response.StatusCode);
            }

            var json = await response.Content.ReadAsStringAsync();
            using var doc = JsonDocument.Parse(json);
            var data = doc.RootElement.GetProperty("data").EnumerateArray();

            // Словарь: "BTC_USDT" => (цена, объем)
            var mexcData = new Dictionary<string, (double price, double volume)>();

            foreach (var item in data)
            {
                string symbol = item.GetProperty("symbol").GetString(); // Пример: "BTC_USDT"
                double price = item.GetProperty("lastPrice").GetDouble();
                double volume = item.GetProperty("amount24").GetDouble();

                mexcData[symbol] = (price, volume);
            }

            // Обновление базы данных
            using var db = new DataBaseContextExchange();
            var pairs = await db.Pairs.ToListAsync();

            foreach (var pair in pairs)
            {
                string symbol = $"{pair.Base}_{pair.Quote}".ToUpper();

                if (mexcData.TryGetValue(symbol, out var values))
                {
                    pair.PriceMexc = values.price;
                    pair.VolumeH24Mexc = values.volume;
                }
            }

            await db.SaveChangesAsync();
        }

    }
}
