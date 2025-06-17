using MexcSpreadBot.Data;
using MexcSpreadBot.Helpers;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MexcSpreadBot
{
    public partial class FormDexes : Form
    {
        Pair PairSelected;

        public FormDexes(Pair pair)
        {
            InitializeComponent();
            PairSelected = pair;
            FillTable();
        }


        private void FillTable()
        {
            var db = new DataBaseContextExchange();
            var dexesList = db.Dexes.Where(x => x.Pair.PairId == PairSelected.PairId).ToList();
            dexBindingSource.DataSource = dexesList;
            dexBindingSource.ResetBindings(false);
        }

        private void открытьВDexScreenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dex current = (Dex)dexBindingSource.Current;

            if (current != null)
                BrowserHelper.OpenUrl($"https://dexscreener.com/{current.ChainId}/{current.PairAddress}");
        }


        private async void перезагрузитьЦеныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await DexScreenerHelper.UpdateDexDataAsync(PairSelected);
            MessageBox.Show($"Успешно загружены данные c DexScreeener", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillTable();
        }

        private void dataGridViewDexes_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var cpn = dataGridViewDexes.Columns[e.ColumnIndex].DataPropertyName;
            var list = (List<Data.Dex>)dexBindingSource.DataSource;
            dexBindingSource.DataSource = list.OrderBy(x => x.GetType().GetProperty(cpn).GetValue(x)).ToList();
        }
    }
}
