namespace MexcSpreadBot
{
    partial class FormSpread
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
            dataGridViewSpread = new DataGridView();
            symbolDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            spreadPercentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mexcPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dexPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            baseTokenNameDexDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quoteTokenSymbolDexDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            volumeM5DexDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            volumeH1DexDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            volumeH24DexDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            volumeH24MexcDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            chainIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pairAddressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            spreadBindingSource = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            параToolStripMenuItem = new ToolStripMenuItem();
            открытьMexcToolStripMenuItem = new ToolStripMenuItem();
            открытьDexcscreenerToolStripMenuItem = new ToolStripMenuItem();
            парыToolStripMenuItem = new ToolStripMenuItem();
            получитьВсеЦеныToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            button1 = new Button();
            buttonFilter = new Button();
            numericUpDownV5MMin = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            numericUpDownSpreadMax = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            numericUpDownSpreadMin = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSpread).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spreadBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownV5MMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpreadMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpreadMin).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSpread
            // 
            dataGridViewSpread.AllowUserToAddRows = false;
            dataGridViewSpread.AllowUserToDeleteRows = false;
            dataGridViewSpread.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewSpread.AutoGenerateColumns = false;
            dataGridViewSpread.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSpread.Columns.AddRange(new DataGridViewColumn[] { symbolDataGridViewTextBoxColumn, spreadPercentDataGridViewTextBoxColumn, mexcPriceDataGridViewTextBoxColumn, dexPriceDataGridViewTextBoxColumn, baseTokenNameDexDataGridViewTextBoxColumn, quoteTokenSymbolDexDataGridViewTextBoxColumn, volumeM5DexDataGridViewTextBoxColumn, volumeH1DexDataGridViewTextBoxColumn, volumeH24DexDataGridViewTextBoxColumn, volumeH24MexcDataGridViewTextBoxColumn, chainIdDataGridViewTextBoxColumn, pairAddressDataGridViewTextBoxColumn });
            dataGridViewSpread.DataSource = spreadBindingSource;
            dataGridViewSpread.Location = new Point(12, 31);
            dataGridViewSpread.Name = "dataGridViewSpread";
            dataGridViewSpread.ReadOnly = true;
            dataGridViewSpread.RowHeadersWidth = 51;
            dataGridViewSpread.Size = new Size(776, 302);
            dataGridViewSpread.TabIndex = 0;
            dataGridViewSpread.ColumnHeaderMouseClick += dataGridViewSpread_ColumnHeaderMouseClick;
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
            // spreadPercentDataGridViewTextBoxColumn
            // 
            spreadPercentDataGridViewTextBoxColumn.DataPropertyName = "SpreadPercent";
            spreadPercentDataGridViewTextBoxColumn.HeaderText = "SpreadPercent";
            spreadPercentDataGridViewTextBoxColumn.MinimumWidth = 6;
            spreadPercentDataGridViewTextBoxColumn.Name = "spreadPercentDataGridViewTextBoxColumn";
            spreadPercentDataGridViewTextBoxColumn.ReadOnly = true;
            spreadPercentDataGridViewTextBoxColumn.Width = 125;
            // 
            // mexcPriceDataGridViewTextBoxColumn
            // 
            mexcPriceDataGridViewTextBoxColumn.DataPropertyName = "MexcPrice";
            mexcPriceDataGridViewTextBoxColumn.HeaderText = "MexcPrice";
            mexcPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            mexcPriceDataGridViewTextBoxColumn.Name = "mexcPriceDataGridViewTextBoxColumn";
            mexcPriceDataGridViewTextBoxColumn.ReadOnly = true;
            mexcPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // dexPriceDataGridViewTextBoxColumn
            // 
            dexPriceDataGridViewTextBoxColumn.DataPropertyName = "DexPrice";
            dexPriceDataGridViewTextBoxColumn.HeaderText = "DexPrice";
            dexPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            dexPriceDataGridViewTextBoxColumn.Name = "dexPriceDataGridViewTextBoxColumn";
            dexPriceDataGridViewTextBoxColumn.ReadOnly = true;
            dexPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // baseTokenNameDexDataGridViewTextBoxColumn
            // 
            baseTokenNameDexDataGridViewTextBoxColumn.DataPropertyName = "BaseTokenNameDex";
            baseTokenNameDexDataGridViewTextBoxColumn.HeaderText = "BaseTokenNameDex";
            baseTokenNameDexDataGridViewTextBoxColumn.MinimumWidth = 6;
            baseTokenNameDexDataGridViewTextBoxColumn.Name = "baseTokenNameDexDataGridViewTextBoxColumn";
            baseTokenNameDexDataGridViewTextBoxColumn.ReadOnly = true;
            baseTokenNameDexDataGridViewTextBoxColumn.Width = 125;
            // 
            // quoteTokenSymbolDexDataGridViewTextBoxColumn
            // 
            quoteTokenSymbolDexDataGridViewTextBoxColumn.DataPropertyName = "QuoteTokenSymbolDex";
            quoteTokenSymbolDexDataGridViewTextBoxColumn.HeaderText = "QuoteTokenSymbolDex";
            quoteTokenSymbolDexDataGridViewTextBoxColumn.MinimumWidth = 6;
            quoteTokenSymbolDexDataGridViewTextBoxColumn.Name = "quoteTokenSymbolDexDataGridViewTextBoxColumn";
            quoteTokenSymbolDexDataGridViewTextBoxColumn.ReadOnly = true;
            quoteTokenSymbolDexDataGridViewTextBoxColumn.Width = 125;
            // 
            // volumeM5DexDataGridViewTextBoxColumn
            // 
            volumeM5DexDataGridViewTextBoxColumn.DataPropertyName = "VolumeM5Dex";
            volumeM5DexDataGridViewTextBoxColumn.HeaderText = "VolumeM5Dex";
            volumeM5DexDataGridViewTextBoxColumn.MinimumWidth = 6;
            volumeM5DexDataGridViewTextBoxColumn.Name = "volumeM5DexDataGridViewTextBoxColumn";
            volumeM5DexDataGridViewTextBoxColumn.ReadOnly = true;
            volumeM5DexDataGridViewTextBoxColumn.Width = 125;
            // 
            // volumeH1DexDataGridViewTextBoxColumn
            // 
            volumeH1DexDataGridViewTextBoxColumn.DataPropertyName = "VolumeH1Dex";
            volumeH1DexDataGridViewTextBoxColumn.HeaderText = "VolumeH1Dex";
            volumeH1DexDataGridViewTextBoxColumn.MinimumWidth = 6;
            volumeH1DexDataGridViewTextBoxColumn.Name = "volumeH1DexDataGridViewTextBoxColumn";
            volumeH1DexDataGridViewTextBoxColumn.ReadOnly = true;
            volumeH1DexDataGridViewTextBoxColumn.Width = 125;
            // 
            // volumeH24DexDataGridViewTextBoxColumn
            // 
            volumeH24DexDataGridViewTextBoxColumn.DataPropertyName = "VolumeH24Dex";
            volumeH24DexDataGridViewTextBoxColumn.HeaderText = "VolumeH24Dex";
            volumeH24DexDataGridViewTextBoxColumn.MinimumWidth = 6;
            volumeH24DexDataGridViewTextBoxColumn.Name = "volumeH24DexDataGridViewTextBoxColumn";
            volumeH24DexDataGridViewTextBoxColumn.ReadOnly = true;
            volumeH24DexDataGridViewTextBoxColumn.Width = 125;
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
            // spreadBindingSource
            // 
            spreadBindingSource.DataSource = typeof(Data.Spread);
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
            параToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьMexcToolStripMenuItem, открытьDexcscreenerToolStripMenuItem });
            параToolStripMenuItem.Name = "параToolStripMenuItem";
            параToolStripMenuItem.Size = new Size(59, 24);
            параToolStripMenuItem.Text = "Пара";
            // 
            // открытьMexcToolStripMenuItem
            // 
            открытьMexcToolStripMenuItem.Name = "открытьMexcToolStripMenuItem";
            открытьMexcToolStripMenuItem.Size = new Size(242, 26);
            открытьMexcToolStripMenuItem.Text = "Открыть Mexc";
            открытьMexcToolStripMenuItem.Click += открытьMexcToolStripMenuItem_Click;
            // 
            // открытьDexcscreenerToolStripMenuItem
            // 
            открытьDexcscreenerToolStripMenuItem.Name = "открытьDexcscreenerToolStripMenuItem";
            открытьDexcscreenerToolStripMenuItem.Size = new Size(242, 26);
            открытьDexcscreenerToolStripMenuItem.Text = "Открыть Dexcscreener";
            открытьDexcscreenerToolStripMenuItem.Click += открытьDexcscreenerToolStripMenuItem_Click;
            // 
            // парыToolStripMenuItem
            // 
            парыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { получитьВсеЦеныToolStripMenuItem });
            парыToolStripMenuItem.Name = "парыToolStripMenuItem";
            парыToolStripMenuItem.Size = new Size(62, 24);
            парыToolStripMenuItem.Text = "Пары";
            // 
            // получитьВсеЦеныToolStripMenuItem
            // 
            получитьВсеЦеныToolStripMenuItem.Name = "получитьВсеЦеныToolStripMenuItem";
            получитьВсеЦеныToolStripMenuItem.Size = new Size(279, 26);
            получитьВсеЦеныToolStripMenuItem.Text = "Перезагрузить все данные";
            получитьВсеЦеныToolStripMenuItem.Click += получитьВсеЦеныToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(buttonFilter);
            groupBox1.Controls.Add(numericUpDownV5MMin);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(numericUpDownSpreadMax);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericUpDownSpreadMin);
            groupBox1.Location = new Point(12, 348);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(604, 90);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Фильтр";
            // 
            // button1
            // 
            button1.Location = new Point(456, 20);
            button1.Name = "button1";
            button1.Size = new Size(142, 29);
            button1.TabIndex = 8;
            button1.Text = "Убрать фильтр";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonFilter
            // 
            buttonFilter.Location = new Point(456, 55);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(142, 29);
            buttonFilter.TabIndex = 7;
            buttonFilter.Text = "Фильтровать";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += buttonFilter_Click;
            // 
            // numericUpDownV5MMin
            // 
            numericUpDownV5MMin.DecimalPlaces = 1;
            numericUpDownV5MMin.Location = new Point(297, 57);
            numericUpDownV5MMin.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownV5MMin.Name = "numericUpDownV5MMin";
            numericUpDownV5MMin.Size = new Size(91, 27);
            numericUpDownV5MMin.TabIndex = 6;
            numericUpDownV5MMin.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 34);
            label4.Name = "label4";
            label4.Size = new Size(214, 20);
            label4.TabIndex = 5;
            label4.Text = "VolumeM5Dex не менее, USD:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 59);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 4;
            label3.Text = "от";
            // 
            // numericUpDownSpreadMax
            // 
            numericUpDownSpreadMax.DecimalPlaces = 1;
            numericUpDownSpreadMax.Location = new Point(144, 57);
            numericUpDownSpreadMax.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownSpreadMax.Name = "numericUpDownSpreadMax";
            numericUpDownSpreadMax.Size = new Size(74, 27);
            numericUpDownSpreadMax.TabIndex = 3;
            numericUpDownSpreadMax.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 59);
            label2.Name = "label2";
            label2.Size = new Size(26, 20);
            label2.TabIndex = 2;
            label2.Text = "до";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 1;
            label1.Text = "Спред, %:";
            // 
            // numericUpDownSpreadMin
            // 
            numericUpDownSpreadMin.DecimalPlaces = 1;
            numericUpDownSpreadMin.Location = new Point(39, 57);
            numericUpDownSpreadMin.Name = "numericUpDownSpreadMin";
            numericUpDownSpreadMin.Size = new Size(67, 27);
            numericUpDownSpreadMin.TabIndex = 0;
            numericUpDownSpreadMin.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // FormSpread
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewSpread);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormSpread";
            Text = "Спреды";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSpread).EndInit();
            ((System.ComponentModel.ISupportInitialize)spreadBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownV5MMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpreadMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpreadMin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewSpread;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem параToolStripMenuItem;
        private ToolStripMenuItem открытьMexcToolStripMenuItem;
        private ToolStripMenuItem открытьDexcscreenerToolStripMenuItem;
        private ToolStripMenuItem парыToolStripMenuItem;
        private ToolStripMenuItem получитьВсеЦеныToolStripMenuItem;
        private DataGridViewTextBoxColumn symbolDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn spreadPercentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mexcPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dexPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn baseTokenNameDexDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quoteTokenSymbolDexDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn volumeM5DexDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn volumeH1DexDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn volumeH24DexDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn volumeH24MexcDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn chainIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pairAddressDataGridViewTextBoxColumn;
        private BindingSource spreadBindingSource;
        private GroupBox groupBox1;
        private Label label3;
        private NumericUpDown numericUpDownSpreadMax;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDownSpreadMin;
        private Button buttonFilter;
        private NumericUpDown numericUpDownV5MMin;
        private Label label4;
        private Button button1;
    }
}