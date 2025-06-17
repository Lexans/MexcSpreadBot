using MexcSpreadBot.Data;
using MexcSpreadBot.Helpers;
using System.Data;
using System.Windows.Forms;

namespace MexcSpreadBot
{
    public partial class FormSpread : Form
    {
        public FormSpread()
        {
            InitializeComponent();
            FillTable();
        }

        private void FillTable()
        {
            var context = new DataBaseContextExchange();
            var actualDexes = context.Dexes.Where(x => !x.IsIgnored && !x.Pair.IsIgnored && (x.PriceUsd != null)).ToList();
            var spreads = new List<Spread>();

            foreach (var dex in actualDexes)
            {
                context.Entry(dex).Reference(u => u.Pair).Load();
                var spread = new Spread();
                spread.BaseTokenNameDex = dex.BaseTokenName;
                spread.ChainId = dex.ChainId;
                spread.DexPrice = (double)dex.PriceUsd;
                spread.MexcPrice = (double)dex.Pair.PriceMexc;
                spread.PairAddress = dex.PairAddress;
                spread.QuoteTokenSymbolDex = dex.QuoteTokenSymbol;
                spread.Symbol = dex.Pair.Symbol;
                spread.VolumeH24Mexc = (double)dex.Pair.VolumeH24Mexc;
                spread.VolumeH1Dex = (double)dex.VolumeH1;
                spread.VolumeH24Dex = (double)dex.VolumeH24;
                spread.VolumeM5Dex = (double)dex.VolumeM5;
                spread.SpreadPercent = Math.Round((spread.DexPrice - spread.MexcPrice) / spread.MexcPrice * 100.0, 2);

                spreads.Add(spread);
            }

            spreadBindingSource.DataSource = spreads.OrderByDescending(x => x.SpreadPercent).ToList();
            spreadBindingSource.ResetBindings(false);
        }


        private async void получитьВсеЦеныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await DexScreenerHelper.UpdateDexDataAsync();
            await MexcHelper.UpdatePricesAndVolumesAsync();
            MessageBox.Show($"Успешно загружены цены с mexc и DexScreener", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillTable();
        }

        private void открытьMexcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var current = (Spread)spreadBindingSource.Current;

            if (current != null)
                BrowserHelper.OpenUrl($"https://futures.mexc.com/exchange/{current.Symbol}");
        }

        private void открытьDexcscreenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var current = (Spread)spreadBindingSource.Current;

            if (current != null)
                BrowserHelper.OpenUrl($"https://dexscreener.com/{current.ChainId}/{current.PairAddress}");
        }

        private void dataGridViewSpread_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var cpn = dataGridViewSpread.Columns[e.ColumnIndex].DataPropertyName;
            var list = (List<Data.Spread>)spreadBindingSource.DataSource;
            spreadBindingSource.DataSource = list.OrderBy(x => x.GetType().GetProperty(cpn).GetValue(x)).ToList();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            FillTable();

            var spreads = (List<Spread>)spreadBindingSource.DataSource;
            spreadBindingSource.DataSource = spreads.Where(x =>
            Math.Abs(x.SpreadPercent) >= (double)numericUpDownSpreadMin.Value &&
            Math.Abs(x.SpreadPercent) <= (double)numericUpDownSpreadMax.Value && x.VolumeM5Dex > (double)numericUpDownV5MMin.Value).ToList();
            spreadBindingSource.ResetBindings(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillTable();
        }
    }
}
