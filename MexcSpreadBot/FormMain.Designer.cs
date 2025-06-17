namespace MexcSpreadBot
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            menuStrip1 = new MenuStrip();
            окнаToolStripMenuItem = new ToolStripMenuItem();
            парыToolStripMenuItem = new ToolStripMenuItem();
            спредыToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { окнаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // окнаToolStripMenuItem
            // 
            окнаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { парыToolStripMenuItem, спредыToolStripMenuItem });
            окнаToolStripMenuItem.Name = "окнаToolStripMenuItem";
            окнаToolStripMenuItem.Size = new Size(58, 24);
            окнаToolStripMenuItem.Text = "Окна";
            // 
            // парыToolStripMenuItem
            // 
            парыToolStripMenuItem.Name = "парыToolStripMenuItem";
            парыToolStripMenuItem.Size = new Size(146, 26);
            парыToolStripMenuItem.Text = "Пары";
            парыToolStripMenuItem.Click += парыToolStripMenuItem_Click;
            // 
            // спредыToolStripMenuItem
            // 
            спредыToolStripMenuItem.Name = "спредыToolStripMenuItem";
            спредыToolStripMenuItem.Size = new Size(146, 26);
            спредыToolStripMenuItem.Text = "Спреды";
            спредыToolStripMenuItem.Click += спредыToolStripMenuItem_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(12, 31);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(776, 407);
            textBox1.TabIndex = 1;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "MexcSpreadBot";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem окнаToolStripMenuItem;
        private ToolStripMenuItem спредыToolStripMenuItem;
        private ToolStripMenuItem парыToolStripMenuItem;
        private TextBox textBox1;
    }
}
