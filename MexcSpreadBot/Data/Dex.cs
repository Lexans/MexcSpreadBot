using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MexcSpreadBot.Data
{
    public class Dex
    {
        public int DexId { get; set; }
        public string DexIdString { get; set; }
        public string ChainId { get; set; }
        public string PairAddress { get; set; }
        public string BaseTokenName { get; set; }
        public string QuoteTokenSymbol { get; set; }
        public bool IsIgnored { get; set; }
        public double? PriceUsd { get; set; }
        public double? VolumeM5 { get; set; }
        public double? VolumeH1 { get; set; }
        public double? VolumeH24 { get; set; }
        public double? LiquidityUsd { get; set; }


        public Pair Pair { get; set; }
    }
}
