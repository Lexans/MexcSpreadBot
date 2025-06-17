using CryptoExchange.Net.CommonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MexcSpreadBot.Data
{
    public class Pair
    {
        public int PairId { get; set; }
        public string Base { get; set; }
        public string Quote { get; set; }
        public bool IsIgnored { get; set; }
        public double? PriceMexc { get; set; }
        public double? VolumeH24Mexc { get; set; }
        public int MaxLeverage { get; set; }
        public int PriceScale { get; set; }
        public int AmountScale { get; set; }
        public double PriceUnit { get; set; }
        public int MaxVol { get; set; }


        public List<Dex> Dexes { get; set; } = new();

        public string Symbol
        {
            get
            {
                return $"{Base}_{Quote}";
            }
        }

        public override string ToString()
        {
            return Symbol;
        }
    }
}
