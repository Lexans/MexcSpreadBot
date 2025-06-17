namespace MexcSpreadBot
{
    partial class FormPairs
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
            dataGridView1 = new DataGridView();
            pairIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            baseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quoteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isIgnoredDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            priceMexcDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            volumeH24MexcDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maxLeverageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceScaleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountScaleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceUnitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maxVolDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            symbolDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pairBindingSource = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            параToolStripMenuItem = new ToolStripMenuItem();
            открытьMexcToolStripMenuItem = new ToolStripMenuItem();
            открытьСписокDexToolStripMenuItem = new ToolStripMenuItem();
            загрузитьСDexscreenerToolStripMenuItem = new ToolStripMenuItem();
            парыToolStripMenuItem = new ToolStripMenuItem();
            загрузитьCMexcToolStripMenuItem = new ToolStripMenuItem();
            загрузитьДанныеСMexcToolStripMenuItem = new ToolStripMenuItem();
            найтиНаDexToolStripMenuItem = new ToolStripMenuItem();
            загрузитьЦеныСDexScreenerToolStripMenuItem = new ToolStripMenuItem();
            выставитьИгнорируемыеПарыToolStripMenuItem = new ToolStripMenuItem();
            задатьИгноируемыеToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            backgroundWorkerDex = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pairBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { pairIdDataGridViewTextBoxColumn, baseDataGridViewTextBoxColumn, quoteDataGridViewTextBoxColumn, isIgnoredDataGridViewCheckBoxColumn, priceMexcDataGridViewTextBoxColumn, volumeH24MexcDataGridViewTextBoxColumn, maxLeverageDataGridViewTextBoxColumn, priceScaleDataGridViewTextBoxColumn, amountScaleDataGridViewTextBoxColumn, priceUnitDataGridViewTextBoxColumn, maxVolDataGridViewTextBoxColumn, symbolDataGridViewTextBoxColumn });
            dataGridView1.DataSource = pairBindingSource;
            dataGridView1.Location = new Point(12, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 384);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.ColumnHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;
            // 
            // pairIdDataGridViewTextBoxColumn
            // 
            pairIdDataGridViewTextBoxColumn.DataPropertyName = "PairId";
            pairIdDataGridViewTextBoxColumn.HeaderText = "PairId";
            pairIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            pairIdDataGridViewTextBoxColumn.Name = "pairIdDataGridViewTextBoxColumn";
            pairIdDataGridViewTextBoxColumn.ReadOnly = true;
            pairIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // baseDataGridViewTextBoxColumn
            // 
            baseDataGridViewTextBoxColumn.DataPropertyName = "Base";
            baseDataGridViewTextBoxColumn.HeaderText = "Base";
            baseDataGridViewTextBoxColumn.MinimumWidth = 6;
            baseDataGridViewTextBoxColumn.Name = "baseDataGridViewTextBoxColumn";
            baseDataGridViewTextBoxColumn.ReadOnly = true;
            baseDataGridViewTextBoxColumn.Width = 125;
            // 
            // quoteDataGridViewTextBoxColumn
            // 
            quoteDataGridViewTextBoxColumn.DataPropertyName = "Quote";
            quoteDataGridViewTextBoxColumn.HeaderText = "Quote";
            quoteDataGridViewTextBoxColumn.MinimumWidth = 6;
            quoteDataGridViewTextBoxColumn.Name = "quoteDataGridViewTextBoxColumn";
            quoteDataGridViewTextBoxColumn.ReadOnly = true;
            quoteDataGridViewTextBoxColumn.Width = 125;
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
            // priceMexcDataGridViewTextBoxColumn
            // 
            priceMexcDataGridViewTextBoxColumn.DataPropertyName = "PriceMexc";
            priceMexcDataGridViewTextBoxColumn.HeaderText = "PriceMexc";
            priceMexcDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceMexcDataGridViewTextBoxColumn.Name = "priceMexcDataGridViewTextBoxColumn";
            priceMexcDataGridViewTextBoxColumn.ReadOnly = true;
            priceMexcDataGridViewTextBoxColumn.Width = 125;
            // 
            // volumeH24MexcDataGridViewTextBoxColumn
            // 
            volumeH24MexcDataGridViewTextBoxColumn.DataPropertyName = "VolumeH24Mexc";
            volumeH24MexcDataGridViewTextBoxColumn.HeaderText = "VolumeH24Mexc";
            volumeH24MexcDataGridViewTextBoxColumn.MinimumWidth = 6;
            volumeH24MexcDataGridViewTextBoxColumn.Name = "volumeH24MexcDataGridViewTextBoxColumn";
            volumeH24MexcDataGridViewTextBoxColumn.ReadOnly = true;
            volumeH24MexcDataGridViewTextBoxColumn.Width = 125;
            // 
            // maxLeverageDataGridViewTextBoxColumn
            // 
            maxLeverageDataGridViewTextBoxColumn.DataPropertyName = "MaxLeverage";
            maxLeverageDataGridViewTextBoxColumn.HeaderText = "MaxLeverage";
            maxLeverageDataGridViewTextBoxColumn.MinimumWidth = 6;
            maxLeverageDataGridViewTextBoxColumn.Name = "maxLeverageDataGridViewTextBoxColumn";
            maxLeverageDataGridViewTextBoxColumn.ReadOnly = true;
            maxLeverageDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceScaleDataGridViewTextBoxColumn
            // 
            priceScaleDataGridViewTextBoxColumn.DataPropertyName = "PriceScale";
            priceScaleDataGridViewTextBoxColumn.HeaderText = "PriceScale";
            priceScaleDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceScaleDataGridViewTextBoxColumn.Name = "priceScaleDataGridViewTextBoxColumn";
            priceScaleDataGridViewTextBoxColumn.ReadOnly = true;
            priceScaleDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountScaleDataGridViewTextBoxColumn
            // 
            amountScaleDataGridViewTextBoxColumn.DataPropertyName = "AmountScale";
            amountScaleDataGridViewTextBoxColumn.HeaderText = "AmountScale";
            amountScaleDataGridViewTextBoxColumn.MinimumWidth = 6;
            amountScaleDataGridViewTextBoxColumn.Name = "amountScaleDataGridViewTextBoxColumn";
            amountScaleDataGridViewTextBoxColumn.ReadOnly = true;
            amountScaleDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceUnitDataGridViewTextBoxColumn
            // 
            priceUnitDataGridViewTextBoxColumn.DataPropertyName = "PriceUnit";
            priceUnitDataGridViewTextBoxColumn.HeaderText = "PriceUnit";
            priceUnitDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceUnitDataGridViewTextBoxColumn.Name = "priceUnitDataGridViewTextBoxColumn";
            priceUnitDataGridViewTextBoxColumn.ReadOnly = true;
            priceUnitDataGridViewTextBoxColumn.Width = 125;
            // 
            // maxVolDataGridViewTextBoxColumn
            // 
            maxVolDataGridViewTextBoxColumn.DataPropertyName = "MaxVol";
            maxVolDataGridViewTextBoxColumn.HeaderText = "MaxVol";
            maxVolDataGridViewTextBoxColumn.MinimumWidth = 6;
            maxVolDataGridViewTextBoxColumn.Name = "maxVolDataGridViewTextBoxColumn";
            maxVolDataGridViewTextBoxColumn.ReadOnly = true;
            maxVolDataGridViewTextBoxColumn.Width = 125;
            // 
            // symbolDataGridViewTextBoxColumn
            // 
            symbolDataGridViewTextBoxColumn.DataPropertyName = "Symbol";
            symbolDataGridViewTextBoxColumn.HeaderText = "Symbol";
            symbolDataGridViewTextBoxColumn.MinimumWidth = 6;
            symbolDataGridViewTextBoxColumn.Name = "symbolDataGridViewTextBoxColumn";
            symbolDataGridViewTextBoxColumn.ReadOnly = true;
            symbolDataGridViewTextBoxColumn.Width = 125;
            // 
            // pairBindingSource
            // 
            pairBindingSource.DataSource = typeof(Data.Pair);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { параToolStripMenuItem, парыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // параToolStripMenuItem
            // 
            параToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьMexcToolStripMenuItem, открытьСписокDexToolStripMenuItem, загрузитьСDexscreenerToolStripMenuItem });
            параToolStripMenuItem.Name = "параToolStripMenuItem";
            параToolStripMenuItem.Size = new Size(59, 24);
            параToolStripMenuItem.Text = "Пара";
            // 
            // открытьMexcToolStripMenuItem
            // 
            открытьMexcToolStripMenuItem.Name = "открытьMexcToolStripMenuItem";
            открытьMexcToolStripMenuItem.Size = new Size(258, 26);
            открытьMexcToolStripMenuItem.Text = "Открыть mexc";
            открытьMexcToolStripMenuItem.Click += открытьMexcToolStripMenuItem_Click;
            // 
            // открытьСписокDexToolStripMenuItem
            // 
            открытьСписокDexToolStripMenuItem.Name = "открытьСписокDexToolStripMenuItem";
            открытьСписокDexToolStripMenuItem.Size = new Size(258, 26);
            открытьСписокDexToolStripMenuItem.Text = "Открыть список Dex";
            открытьСписокDexToolStripMenuItem.Click += открытьСписокDexToolStripMenuItem_Click;
            // 
            // загрузитьСDexscreenerToolStripMenuItem
            // 
            загрузитьСDexscreenerToolStripMenuItem.Name = "загрузитьСDexscreenerToolStripMenuItem";
            загрузитьСDexscreenerToolStripMenuItem.Size = new Size(258, 26);
            загрузитьСDexscreenerToolStripMenuItem.Text = "Загрузить с DexScreener";
            загрузитьСDexscreenerToolStripMenuItem.Click += загрузитьСDexscreenerToolStripMenuItem_Click;
            // 
            // парыToolStripMenuItem
            // 
            парыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { загрузитьCMexcToolStripMenuItem, загрузитьДанныеСMexcToolStripMenuItem, найтиНаDexToolStripMenuItem, загрузитьЦеныСDexScreenerToolStripMenuItem, выставитьИгнорируемыеПарыToolStripMenuItem, задатьИгноируемыеToolStripMenuItem });
            парыToolStripMenuItem.Name = "парыToolStripMenuItem";
            парыToolStripMenuItem.Size = new Size(62, 24);
            парыToolStripMenuItem.Text = "Пары";
            // 
            // загрузитьCMexcToolStripMenuItem
            // 
            загрузитьCMexcToolStripMenuItem.Name = "загрузитьCMexcToolStripMenuItem";
            загрузитьCMexcToolStripMenuItem.Size = new Size(326, 26);
            загрузитьCMexcToolStripMenuItem.Text = "Синхронизировать пары c mexc";
            загрузитьCMexcToolStripMenuItem.Click += загрузитьCMexcToolStripMenuItem_Click;
            // 
            // загрузитьДанныеСMexcToolStripMenuItem
            // 
            загрузитьДанныеСMexcToolStripMenuItem.Name = "загрузитьДанныеСMexcToolStripMenuItem";
            загрузитьДанныеСMexcToolStripMenuItem.Size = new Size(326, 26);
            загрузитьДанныеСMexcToolStripMenuItem.Text = "Загрузить данные с mexc";
            загрузитьДанныеСMexcToolStripMenuItem.Click += загрузитьДанныеСMexcToolStripMenuItem_Click;
            // 
            // найтиНаDexToolStripMenuItem
            // 
            найтиНаDexToolStripMenuItem.Name = "найтиНаDexToolStripMenuItem";
            найтиНаDexToolStripMenuItem.Size = new Size(326, 26);
            найтиНаDexToolStripMenuItem.Text = "Найти все пары на DexScreener";
            найтиНаDexToolStripMenuItem.Click += найтиНаDexToolStripMenuItem_Click;
            // 
            // загрузитьЦеныСDexScreenerToolStripMenuItem
            // 
            загрузитьЦеныСDexScreenerToolStripMenuItem.Name = "загрузитьЦеныСDexScreenerToolStripMenuItem";
            загрузитьЦеныСDexScreenerToolStripMenuItem.Size = new Size(326, 26);
            загрузитьЦеныСDexScreenerToolStripMenuItem.Text = "Загрузить все цены с DexScreener";
            загрузитьЦеныСDexScreenerToolStripMenuItem.Click += загрузитьЦеныСDexScreenerToolStripMenuItem_Click;
            // 
            // выставитьИгнорируемыеПарыToolStripMenuItem
            // 
            выставитьИгнорируемыеПарыToolStripMenuItem.Name = "выставитьИгнорируемыеПарыToolStripMenuItem";
            выставитьИгнорируемыеПарыToolStripMenuItem.Size = new Size(326, 26);
            выставитьИгнорируемыеПарыToolStripMenuItem.Text = "Задать игнорируемые пары";
            выставитьИгнорируемыеПарыToolStripMenuItem.Click += выставитьИгнорируемыеПарыToolStripMenuItem_Click;
            // 
            // задатьИгноируемыеToolStripMenuItem
            // 
            задатьИгноируемыеToolStripMenuItem.Name = "задатьИгноируемыеToolStripMenuItem";
            задатьИгноируемыеToolStripMenuItem.Size = new Size(326, 26);
            задатьИгноируемыеToolStripMenuItem.Text = "Задать игнорируемые dex-пары";
            задатьИгноируемыеToolStripMenuItem.Click += задатьИгноируемыеDexПарыToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripProgressBar1, toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 18);
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(13, 20);
            toolStripStatusLabel1.Text = " ";
            // 
            // backgroundWorkerDex
            // 
            backgroundWorkerDex.WorkerReportsProgress = true;
            backgroundWorkerDex.WorkerSupportsCancellation = true;
            backgroundWorkerDex.DoWork += backgroundWorkerDex_DoWork;
            backgroundWorkerDex.ProgressChanged += backgroundWorkerDex_ProgressChanged;
            backgroundWorkerDex.RunWorkerCompleted += backgroundWorkerDex_RunWorkerCompleted;
            // 
            // FormPairs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormPairs";
            Text = "Фьючерсные пары";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pairBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem парыToolStripMenuItem;
        private ToolStripMenuItem загрузитьCMexcToolStripMenuItem;
        private ToolStripMenuItem найтиНаDexToolStripMenuItem;
        private ToolStripMenuItem параToolStripMenuItem;
        private ToolStripMenuItem открытьMexcToolStripMenuItem;
        private DataGridViewTextBoxColumn chainIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pairAddressDataGridViewTextBoxColumn;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerDex;
        private ToolStripMenuItem открытьСписокDexToolStripMenuItem;
        private ToolStripMenuItem загрузитьСDexscreenerToolStripMenuItem;
        private ToolStripMenuItem загрузитьЦеныСDexScreenerToolStripMenuItem;
        private DataGridViewTextBoxColumn volumeH24DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn volScaleDataGridViewTextBoxColumn;
        private ToolStripMenuItem загрузитьДанныеСMexcToolStripMenuItem;
        private DataGridViewTextBoxColumn pairIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn baseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quoteDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isIgnoredDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn priceMexcDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn volumeH24MexcDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maxLeverageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceScaleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountScaleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceUnitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maxVolDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn symbolDataGridViewTextBoxColumn;
        private BindingSource pairBindingSource;
        private ToolStripMenuItem выставитьИгнорируемыеПарыToolStripMenuItem;
        private ToolStripMenuItem задатьИгноируемыеToolStripMenuItem;
    }
}