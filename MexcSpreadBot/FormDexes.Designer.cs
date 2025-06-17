namespace MexcSpreadBot
{
    partial class FormDexes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewDexes = new DataGridView();
            menuStrip1 = new MenuStrip();
            dexToolStripMenuItem = new ToolStripMenuItem();
            открытьВDexScreenerToolStripMenuItem = new ToolStripMenuItem();
            всеDexпарыToolStripMenuItem = new ToolStripMenuItem();
            перезагрузитьЦеныToolStripMenuItem = new ToolStripMenuItem();
            dexBindingSource = new BindingSource(components);
            dexIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dexIdStringDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            chainIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pairAddressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            baseTokenNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quoteTokenSymbolDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isIgnoredDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            priceUsdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            volumeM5DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            volumeH1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            volumeH24DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            liquidityUsdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pairDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDexes).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dexBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDexes
            // 
            dataGridViewDexes.AllowUserToAddRows = false;
            dataGridViewDexes.AllowUserToDeleteRows = false;
            dataGridViewDexes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewDexes.AutoGenerateColumns = false;
            dataGridViewDexes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDexes.Columns.AddRange(new DataGridViewColumn[] { dexIdDataGridViewTextBoxColumn, dexIdStringDataGridViewTextBoxColumn, chainIdDataGridViewTextBoxColumn, pairAddressDataGridViewTextBoxColumn, baseTokenNameDataGridViewTextBoxColumn, quoteTokenSymbolDataGridViewTextBoxColumn, isIgnoredDataGridViewCheckBoxColumn, priceUsdDataGridViewTextBoxColumn, volumeM5DataGridViewTextBoxColumn, volumeH1DataGridViewTextBoxColumn, volumeH24DataGridViewTextBoxColumn, liquidityUsdDataGridViewTextBoxColumn, pairDataGridViewTextBoxColumn });
            dataGridViewDexes.DataSource = dexBindingSource;
            dataGridViewDexes.Location = new Point(12, 31);
            dataGridViewDexes.Name = "dataGridViewDexes";
            dataGridViewDexes.ReadOnly = true;
            dataGridViewDexes.RowHeadersWidth = 51;
            dataGridViewDexes.Size = new Size(776, 407);
            dataGridViewDexes.TabIndex = 0;
            dataGridViewDexes.ColumnHeaderMouseClick += dataGridViewDexes_ColumnHeaderMouseClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dexToolStripMenuItem, всеDexпарыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // dexToolStripMenuItem
            // 
            dexToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьВDexScreenerToolStripMenuItem });
            dexToolStripMenuItem.Name = "dexToolStripMenuItem";
            dexToolStripMenuItem.Size = new Size(89, 24);
            dexToolStripMenuItem.Text = "Dex-пара";
            // 
            // открытьВDexScreenerToolStripMenuItem
            // 
            открытьВDexScreenerToolStripMenuItem.Name = "открытьВDexScreenerToolStripMenuItem";
            открытьВDexScreenerToolStripMenuItem.Size = new Size(249, 26);
            открытьВDexScreenerToolStripMenuItem.Text = "Открыть в DexScreener";
            открытьВDexScreenerToolStripMenuItem.Click += открытьВDexScreenerToolStripMenuItem_Click;
            // 
            // всеDexпарыToolStripMenuItem
            // 
            всеDexпарыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { перезагрузитьЦеныToolStripMenuItem });
            всеDexпарыToolStripMenuItem.Name = "всеDexпарыToolStripMenuItem";
            всеDexпарыToolStripMenuItem.Size = new Size(120, 24);
            всеDexпарыToolStripMenuItem.Text = "Все Dex-пары";
            // 
            // перезагрузитьЦеныToolStripMenuItem
            // 
            перезагрузитьЦеныToolStripMenuItem.Name = "перезагрузитьЦеныToolStripMenuItem";
            перезагрузитьЦеныToolStripMenuItem.Size = new Size(252, 26);
            перезагрузитьЦеныToolStripMenuItem.Text = "Перезагрузить данные";
            перезагрузитьЦеныToolStripMenuItem.Click += перезагрузитьЦеныToolStripMenuItem_Click;
            // 
            // dexBindingSource
            // 
            dexBindingSource.DataSource = typeof(Data.Dex);
            // 
            // dexIdDataGridViewTextBoxColumn
            // 
            dexIdDataGridViewTextBoxColumn.DataPropertyName = "DexId";
            dexIdDataGridViewTextBoxColumn.HeaderText = "DexId";
            dexIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            dexIdDataGridViewTextBoxColumn.Name = "dexIdDataGridViewTextBoxColumn";
            dexIdDataGridViewTextBoxColumn.ReadOnly = true;
            dexIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // dexIdStringDataGridViewTextBoxColumn
            // 
            dexIdStringDataGridViewTextBoxColumn.DataPropertyName = "DexIdString";
            dexIdStringDataGridViewTextBoxColumn.HeaderText = "DexIdString";
            dexIdStringDataGridViewTextBoxColumn.MinimumWidth = 6;
            dexIdStringDataGridViewTextBoxColumn.Name = "dexIdStringDataGridViewTextBoxColumn";
            dexIdStringDataGridViewTextBoxColumn.ReadOnly = true;
            dexIdStringDataGridViewTextBoxColumn.Width = 125;
            // 
            // chainIdDataGridViewTextBoxColumn
            // 
            chainIdDataGridViewTextBoxColumn.DataPropertyName = "ChainId";
            chainIdDataGridViewTextBoxColumn.HeaderText = "ChainId";
            chainIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            chainIdDataGridViewTextBoxColumn.Name = "chainIdDataGridViewTextBoxColumn";
            chainIdDataGridViewTextBoxColumn.ReadOnly = true;
            chainIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // pairAddressDataGridViewTextBoxColumn
            // 
            pairAddressDataGridViewTextBoxColumn.DataPropertyName = "PairAddress";
            pairAddressDataGridViewTextBoxColumn.HeaderText = "PairAddress";
            pairAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            pairAddressDataGridViewTextBoxColumn.Name = "pairAddressDataGridViewTextBoxColumn";
            pairAddressDataGridViewTextBoxColumn.ReadOnly = true;
            pairAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // baseTokenNameDataGridViewTextBoxColumn
            // 
            baseTokenNameDataGridViewTextBoxColumn.DataPropertyName = "BaseTokenName";
            baseTokenNameDataGridViewTextBoxColumn.HeaderText = "BaseTokenName";
            baseTokenNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            baseTokenNameDataGridViewTextBoxColumn.Name = "baseTokenNameDataGridViewTextBoxColumn";
            baseTokenNameDataGridViewTextBoxColumn.ReadOnly = true;
            baseTokenNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // quoteTokenSymbolDataGridViewTextBoxColumn
            // 
            quoteTokenSymbolDataGridViewTextBoxColumn.DataPropertyName = "QuoteTokenSymbol";
            quoteTokenSymbolDataGridViewTextBoxColumn.HeaderText = "QuoteTokenSymbol";
            quoteTokenSymbolDataGridViewTextBoxColumn.MinimumWidth = 6;
            quoteTokenSymbolDataGridViewTextBoxColumn.Name = "quoteTokenSymbolDataGridViewTextBoxColumn";
            quoteTokenSymbolDataGridViewTextBoxColumn.ReadOnly = true;
            quoteTokenSymbolDataGridViewTextBoxColumn.Width = 125;
            // 
            // isIgnoredDataGridViewCheckBoxColumn
            // 
            isIgnoredDataGridViewCheckBoxColumn.DataPropertyName = "IsIgnored";
            isIgnoredDataGridViewCheckBoxColumn.HeaderText = "IsIgnored";
            isIgnoredDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isIgnoredDataGridViewCheckBoxColumn.Name = "isIgnoredDataGridViewCheckBoxColumn";
            isIgnoredDataGridViewCheckBoxColumn.ReadOnly = true;
            isIgnoredDataGridViewCheckBoxColumn.Width = 125;
            // 
            // priceUsdDataGridViewTextBoxColumn
            // 
            priceUsdDataGridViewTextBoxColumn.DataPropertyName = "PriceUsd";
            priceUsdDataGridViewTextBoxColumn.HeaderText = "PriceUsd";
            priceUsdDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceUsdDataGridViewTextBoxColumn.Name = "priceUsdDataGridViewTextBoxColumn";
            priceUsdDataGridViewTextBoxColumn.ReadOnly = true;
            priceUsdDataGridViewTextBoxColumn.Width = 125;
            // 
            // volumeM5DataGridViewTextBoxColumn
            // 
            volumeM5DataGridViewTextBoxColumn.DataPropertyName = "VolumeM5";
            volumeM5DataGridViewTextBoxColumn.HeaderText = "VolumeM5";
            volumeM5DataGridViewTextBoxColumn.MinimumWidth = 6;
            volumeM5DataGridViewTextBoxColumn.Name = "volumeM5DataGridViewTextBoxColumn";
            volumeM5DataGridViewTextBoxColumn.ReadOnly = true;
            volumeM5DataGridViewTextBoxColumn.Width = 125;
            // 
            // volumeH1DataGridViewTextBoxColumn
            // 
            volumeH1DataGridViewTextBoxColumn.DataPropertyName = "VolumeH1";
            volumeH1DataGridViewTextBoxColumn.HeaderText = "VolumeH1";
            volumeH1DataGridViewTextBoxColumn.MinimumWidth = 6;
            volumeH1DataGridViewTextBoxColumn.Name = "volumeH1DataGridViewTextBoxColumn";
            volumeH1DataGridViewTextBoxColumn.ReadOnly = true;
            volumeH1DataGridViewTextBoxColumn.Width = 125;
            // 
            // volumeH24DataGridViewTextBoxColumn
            // 
            volumeH24DataGridViewTextBoxColumn.DataPropertyName = "VolumeH24";
            volumeH24DataGridViewTextBoxColumn.HeaderText = "VolumeH24";
            volumeH24DataGridViewTextBoxColumn.MinimumWidth = 6;
            volumeH24DataGridViewTextBoxColumn.Name = "volumeH24DataGridViewTextBoxColumn";
            volumeH24DataGridViewTextBoxColumn.ReadOnly = true;
            volumeH24DataGridViewTextBoxColumn.Width = 125;
            // 
            // liquidityUsdDataGridViewTextBoxColumn
            // 
            liquidityUsdDataGridViewTextBoxColumn.DataPropertyName = "LiquidityUsd";
            liquidityUsdDataGridViewTextBoxColumn.HeaderText = "LiquidityUsd";
            liquidityUsdDataGridViewTextBoxColumn.MinimumWidth = 6;
            liquidityUsdDataGridViewTextBoxColumn.Name = "liquidityUsdDataGridViewTextBoxColumn";
            liquidityUsdDataGridViewTextBoxColumn.ReadOnly = true;
            liquidityUsdDataGridViewTextBoxColumn.Width = 125;
            // 
            // pairDataGridViewTextBoxColumn
            // 
            pairDataGridViewTextBoxColumn.DataPropertyName = "Pair";
            pairDataGridViewTextBoxColumn.HeaderText = "Pair";
            pairDataGridViewTextBoxColumn.MinimumWidth = 6;
            pairDataGridViewTextBoxColumn.Name = "pairDataGridViewTextBoxColumn";
            pairDataGridViewTextBoxColumn.ReadOnly = true;
            pairDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormDexes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewDexes);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormDexes";
            Text = "FormDexes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDexes).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dexBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewDexes;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dexToolStripMenuItem;
        private ToolStripMenuItem открытьВDexScreenerToolStripMenuItem;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private ToolStripMenuItem всеDexпарыToolStripMenuItem;
        private ToolStripMenuItem перезагрузитьЦеныToolStripMenuItem;
        private DataGridViewTextBoxColumn dexIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dexIdStringDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn chainIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pairAddressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn baseTokenNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quoteTokenSymbolDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isIgnoredDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn priceUsdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn volumeM5DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn volumeH1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn volumeH24DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn liquidityUsdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pairDataGridViewTextBoxColumn;
        private BindingSource dexBindingSource;
    }
}