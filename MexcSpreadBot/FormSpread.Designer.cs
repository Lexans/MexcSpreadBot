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
            menuStrip1 = new MenuStrip();
            параToolStripMenuItem = new ToolStripMenuItem();
            открытьMexcToolStripMenuItem = new ToolStripMenuItem();
            открытьDexcscreenerToolStripMenuItem = new ToolStripMenuItem();
            парыToolStripMenuItem = new ToolStripMenuItem();
            получитьВсеЦеныToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            numericUpDownVolumeMexcMin = new NumericUpDown();
            label5 = new Label();
            checkBoxDexMore = new CheckBox();
            button1 = new Button();
            buttonFilter = new Button();
            numericUpDownV5MMin = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            numericUpDownSpreadMax = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            numericUpDownSpreadMin = new NumericUpDown();
            spreadBindingSource = new BindingSource(components);
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            priceChangeM5DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSpread).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVolumeMexcMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownV5MMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpreadMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpreadMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spreadBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSpread
            // 
            dataGridViewSpread.AllowUserToAddRows = false;
            dataGridViewSpread.AllowUserToDeleteRows = false;
            dataGridViewSpread.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewSpread.AutoGenerateColumns = false;
            dataGridViewSpread.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSpread.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, priceChangeM5DataGridViewTextBoxColumn, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12 });
            dataGridViewSpread.DataSource = spreadBindingSource;
            dataGridViewSpread.Location = new Point(12, 31);
            dataGridViewSpread.Name = "dataGridViewSpread";
            dataGridViewSpread.ReadOnly = true;
            dataGridViewSpread.RowHeadersWidth = 51;
            dataGridViewSpread.Size = new Size(927, 323);
            dataGridViewSpread.TabIndex = 0;
            dataGridViewSpread.ColumnHeaderMouseClick += dataGridViewSpread_ColumnHeaderMouseClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { параToolStripMenuItem, парыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(951, 28);
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
            groupBox1.Controls.Add(numericUpDownVolumeMexcMin);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(checkBoxDexMore);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(buttonFilter);
            groupBox1.Controls.Add(numericUpDownV5MMin);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(numericUpDownSpreadMax);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericUpDownSpreadMin);
            groupBox1.Location = new Point(12, 369);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(678, 90);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Фильтр";
            // 
            // numericUpDownVolumeMexcMin
            // 
            numericUpDownVolumeMexcMin.Location = new Point(399, 41);
            numericUpDownVolumeMexcMin.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownVolumeMexcMin.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownVolumeMexcMin.Name = "numericUpDownVolumeMexcMin";
            numericUpDownVolumeMexcMin.Size = new Size(91, 27);
            numericUpDownVolumeMexcMin.TabIndex = 11;
            numericUpDownVolumeMexcMin.Value = new decimal(new int[] { 500000, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(225, 43);
            label5.Name = "label5";
            label5.Size = new Size(175, 20);
            label5.TabIndex = 10;
            label5.Text = "VolumeH24Mexc, USD > ";
            // 
            // checkBoxDexMore
            // 
            checkBoxDexMore.AutoSize = true;
            checkBoxDexMore.Checked = true;
            checkBoxDexMore.CheckState = CheckState.Checked;
            checkBoxDexMore.Location = new Point(225, 66);
            checkBoxDexMore.Name = "checkBoxDexMore";
            checkBoxDexMore.Size = new Size(168, 24);
            checkBoxDexMore.TabIndex = 9;
            checkBoxDexMore.Text = "Объем DEX > MEXC";
            checkBoxDexMore.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(512, 15);
            button1.Name = "button1";
            button1.Size = new Size(142, 29);
            button1.TabIndex = 8;
            button1.Text = "Убрать фильтр";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonFilter
            // 
            buttonFilter.Location = new Point(512, 50);
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
            numericUpDownV5MMin.Location = new Point(399, 13);
            numericUpDownV5MMin.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownV5MMin.Name = "numericUpDownV5MMin";
            numericUpDownV5MMin.Size = new Size(91, 27);
            numericUpDownV5MMin.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(225, 13);
            label4.Name = "label4";
            label4.Size = new Size(156, 20);
            label4.TabIndex = 5;
            label4.Text = "VolumeM5Dex, USD >";
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
            numericUpDownSpreadMin.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // spreadBindingSource
            // 
            spreadBindingSource.DataSource = typeof(Data.Spread);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Symbol";
            dataGridViewTextBoxColumn1.HeaderText = "Symbol";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "SpreadPercent";
            dataGridViewTextBoxColumn2.HeaderText = "SpreadPercent";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "MexcPrice";
            dataGridViewTextBoxColumn3.HeaderText = "MexcPrice";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "DexPrice";
            dataGridViewTextBoxColumn4.HeaderText = "DexPrice";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "BaseTokenNameDex";
            dataGridViewTextBoxColumn5.HeaderText = "BaseTokenNameDex";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "QuoteTokenSymbolDex";
            dataGridViewTextBoxColumn6.HeaderText = "QuoteTokenSymbolDex";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "VolumeM5Dex";
            dataGridViewTextBoxColumn7.HeaderText = "VolumeM5Dex";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "VolumeH1Dex";
            dataGridViewTextBoxColumn8.HeaderText = "VolumeH1Dex";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "VolumeH24Dex";
            dataGridViewTextBoxColumn9.HeaderText = "VolumeH24Dex";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "VolumeH24Mexc";
            dataGridViewTextBoxColumn10.HeaderText = "VolumeH24Mexc";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Width = 125;
            // 
            // priceChangeM5DataGridViewTextBoxColumn
            // 
            priceChangeM5DataGridViewTextBoxColumn.DataPropertyName = "PriceChangeM5";
            priceChangeM5DataGridViewTextBoxColumn.HeaderText = "PriceChangeM5";
            priceChangeM5DataGridViewTextBoxColumn.MinimumWidth = 6;
            priceChangeM5DataGridViewTextBoxColumn.Name = "priceChangeM5DataGridViewTextBoxColumn";
            priceChangeM5DataGridViewTextBoxColumn.ReadOnly = true;
            priceChangeM5DataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "ChainId";
            dataGridViewTextBoxColumn11.HeaderText = "ChainId";
            dataGridViewTextBoxColumn11.MinimumWidth = 6;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "PairAddress";
            dataGridViewTextBoxColumn12.HeaderText = "PairAddress";
            dataGridViewTextBoxColumn12.MinimumWidth = 6;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            dataGridViewTextBoxColumn12.Width = 125;
            // 
            // FormSpread
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 471);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewSpread);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormSpread";
            Text = "Спреды";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSpread).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVolumeMexcMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownV5MMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpreadMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpreadMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)spreadBindingSource).EndInit();
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
        private CheckBox checkBoxDexMore;
        private Label label5;
        private NumericUpDown numericUpDownVolumeMexcMin;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn priceChangeM5DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private BindingSource spreadBindingSource;
    }
}