namespace STB
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TlSrpProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.TlSrpLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleToLatLongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabHome = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.convertToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlSrpProgressBar,
            this.TlSrpLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 602);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1016, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TlSrpProgressBar
            // 
            this.TlSrpProgressBar.Name = "TlSrpProgressBar";
            this.TlSrpProgressBar.Size = new System.Drawing.Size(100, 16);
            this.TlSrpProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // TlSrpLabel
            // 
            this.TlSrpLabel.Name = "TlSrpLabel";
            this.TlSrpLabel.Size = new System.Drawing.Size(131, 17);
            this.TlSrpLabel.Text = "toolStripStatusLabel1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.ShowShortcutKeys = false;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitProgram);
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.googleToLatLongToolStripMenuItem});
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.convertToolStripMenuItem.Text = "Convert";
            // 
            // googleToLatLongToolStripMenuItem
            // 
            this.googleToLatLongToolStripMenuItem.Name = "googleToLatLongToolStripMenuItem";
            this.googleToLatLongToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.googleToLatLongToolStripMenuItem.Text = "Google to Lat Long";
            this.googleToLatLongToolStripMenuItem.Click += new System.EventHandler(this.ConvertToLatLong);
            // 
            // TabControl
            // 
            this.TabControl.AllowDrop = true;
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.TabHome);
            this.TabControl.Location = new System.Drawing.Point(0, 32);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1016, 567);
            this.TabControl.TabIndex = 2;
            // 
            // TabHome
            // 
            this.TabHome.Location = new System.Drawing.Point(4, 30);
            this.TabHome.Name = "TabHome";
            this.TabHome.Size = new System.Drawing.Size(1008, 533);
            this.TabHome.TabIndex = 0;
            this.TabHome.Text = "Home";
            this.TabHome.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 624);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoadApp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar TlSrpProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel TlSrpLabel;
        private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleToLatLongToolStripMenuItem;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabHome;
    }
}

