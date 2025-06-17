using CryptoExchange.Net.CommonObjects;
using MexcSpreadBot.Data;
using MexcSpreadBot.Helpers;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing.Design;
using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace MexcSpreadBot
{
    public partial class FormPairs : Form
    {
        public FormPairs()
        {
            InitializeComponent();

            BindData();
        }


        public async void BindData()
        {
            pairBindingSource.DataSource = PairHelper.GetAllPairs();
            pairBindingSource.ResetBindings(false);
        }

        private async void загрузитьCMexcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pairs = await MexcHelper.GetAllFuturesSymbolsAsync();
            var (countAdd, countDel) = PairHelper.SynchronisePairs(pairs);

            BindData();

            MessageBox.Show($"Успешно загружено c mexc {countAdd} пар, удалено {countDel} пар.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private async Task DownloadDexData(Pair pair)
        {
            var count = await DexScreenerHelper.LoadDexPairsForTokenAsync(pair.Base);
        }

        private async void загрузитьСDexscreenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pair current = (Pair)pairBindingSource.Current;
            await DownloadDexData(current);

            MessageBox.Show("Загрузка пары с dexscreener завершена. Откройте список dex двойным кликом по паре.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void backgroundWorkerDex_DoWork(object sender, DoWorkEventArgs e)
        {
            int percentFinished = 0;

            List<Pair> currentPairs = ((List<Pair>)pairBindingSource.DataSource).Where(x => !x.IsIgnored).ToList();

            for (int i = 0; i < currentPairs.Count; i++)
            {
                percentFinished = (int)((double)(i + 1) / currentPairs.Count * 100);
                backgroundWorkerDex.ReportProgress(percentFinished);

                toolStripStatusLabel1.Text = "Загрузка пар с DexScreener " + currentPairs[i].Symbol;

                try
                {
                    var task = DownloadDexData(currentPairs[i]);
                    task.Wait();
                }
                catch (Exception ex)
                {
                    Program.WriteToLog(currentPairs[i].ToString(), ex);
                }

                if (backgroundWorkerDex.CancellationPending)
                    break;
            }

        }

        private void backgroundWorkerDex_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorkerDex_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Загрузка всех пар с dexscreener завершена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void найтиНаDexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backgroundWorkerDex.RunWorkerAsync();
        }

        private void открытьMexcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pair current = (Pair)pairBindingSource.Current;

            if (current != null)
                BrowserHelper.OpenUrl($"https://futures.mexc.com/exchange/{current.Symbol}");
        }


        private void OpenDexes()
        {
            Pair current = (Pair)pairBindingSource.Current;
            if (current != null)
            {
                FormDexes fs = new FormDexes(current);
                fs.Show();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenDexes();
        }

        private void открытьСписокDexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDexes();
        }

        private async void загрузитьЦеныСDexScreenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await DexScreenerHelper.UpdateDexDataAsync();
            MessageBox.Show($"Успешно загружены цены  PriceUsd, VolumeM5, VolumeH1, VolumeH24, LiquidityUsd у всех неигнориуемых Dex пар", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void загрузитьДанныеСMexcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await MexcHelper.UpdatePricesAndVolumesAsync();
            MessageBox.Show($"Успешно загружены цены и объемы торгов с mexc", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BindData();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var cpn = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;
            var list = (List<Data.Pair>)pairBindingSource.DataSource;
            pairBindingSource.DataSource = list.OrderBy(x => x.GetType().GetProperty(cpn).GetValue(x)).ToList();
        }

        private void выставитьИгнорируемыеПарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MexcHelper.PairsSetIsIgnore();
            MessageBox.Show($"Mexc-Пары с объемом торгов больше {ConstantsValues.Max24HVolume} теперь игнорируются", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BindData();
        }

        private void задатьИгноируемыеDexПарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DexScreenerHelper.SetIsIgnoreToDexPairs();
            MessageBox.Show($"Dex-Пары с разницей в цене больше {ConstantsValues.PriceDifferenceThreshold}% и с объемом торгов меньше {ConstantsValues.DexVolumeH24Treshold}$ теперь игнорируются.",
                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BindData();
        }
    }
}
