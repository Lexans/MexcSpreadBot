namespace MexcSpreadBot
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ñïðåäûToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<FormSpread>().Any())
            {
                var fs = new FormSpread();
                fs.Show();
            }
        }

        private void ïàðûToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<FormPairs>().Any())
            {
                var fs = new FormPairs();
                fs.Show();
            }
        }
    }
}
