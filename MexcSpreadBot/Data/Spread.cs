namespace MexcSpreadBot.Data
{
    public class Spread
    {
        public string Symbol { get; set; }
        public double SpreadPercent { get; set; }
        public double MexcPrice { get; set; }
        public double DexPrice { get; set; }
        public string BaseTokenNameDex { get; set; }
        public string QuoteTokenSymbolDex { get; set; }
        public double VolumeM5Dex { get; set; }
        public double VolumeH1Dex { get; set; }
        public double VolumeH24Dex { get; set; }
        public double VolumeH24Mexc { get; set; }
        public string ChainId { get; set; }
        public string PairAddress { get; set; }
    }
}
