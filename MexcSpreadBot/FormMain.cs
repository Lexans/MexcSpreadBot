namespace MexcSpreadBot
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<FormSpread>().Any())
            {
                var fs = new FormSpread();
                fs.Show();
            }
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<FormPairs>().Any())
            {
                var fs = new FormPairs();
                fs.Show();
            }
        }
    }
}
