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
            this.CmdClose = new System.Windows.Forms.Button();
            this.CmdMinimize = new System.Windows.Forms.Button();
            this.CmdMaximize = new System.Windows.Forms.Button();
            this.Lbltitle = new System.Windows.Forms.Label();
            this.TxtJobNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdOpenJob = new System.Windows.Forms.Button();
            this.LBModules = new System.Windows.Forms.ListBox();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.CmdOptions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdClose
            // 
            this.CmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdClose.FlatAppearance.BorderSize = 0;
            this.CmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CmdClose.Location = new System.Drawing.Point(1162, 0);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(35, 25);
            this.CmdClose.TabIndex = 0;
            this.CmdClose.Text = "X";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.ExitProgram);
            // 
            // CmdMinimize
            // 
            this.CmdMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdMinimize.FlatAppearance.BorderSize = 0;
            this.CmdMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CmdMinimize.Location = new System.Drawing.Point(1080, 0);
            this.CmdMinimize.Name = "CmdMinimize";
            this.CmdMinimize.Size = new System.Drawing.Size(35, 25);
            this.CmdMinimize.TabIndex = 1;
            this.CmdMinimize.Text = "_";
            this.CmdMinimize.UseVisualStyleBackColor = true;
            this.CmdMinimize.Click += new System.EventHandler(this.MinimizeProgram);
            // 
            // CmdMaximize
            // 
            this.CmdMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdMaximize.FlatAppearance.BorderSize = 0;
            this.CmdMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdMaximize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CmdMaximize.Location = new System.Drawing.Point(1121, 0);
            this.CmdMaximize.Name = "CmdMaximize";
            this.CmdMaximize.Size = new System.Drawing.Size(35, 25);
            this.CmdMaximize.TabIndex = 2;
            this.CmdMaximize.Text = "🗖";
            this.CmdMaximize.UseVisualStyleBackColor = true;
            this.CmdMaximize.Click += new System.EventHandler(this.MaximizeProgram);
            // 
            // Lbltitle
            // 
            this.Lbltitle.Location = new System.Drawing.Point(0, 0);
            this.Lbltitle.Name = "Lbltitle";
            this.Lbltitle.Size = new System.Drawing.Size(52, 21);
            this.Lbltitle.TabIndex = 3;
            this.Lbltitle.Text = "label1";
            this.Lbltitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveTitle);
            // 
            // TxtJobNumber
            // 
            this.TxtJobNumber.Location = new System.Drawing.Point(97, 45);
            this.TxtJobNumber.Name = "TxtJobNumber";
            this.TxtJobNumber.Size = new System.Drawing.Size(134, 29);
            this.TxtJobNumber.TabIndex = 4;
            this.TxtJobNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CheckKeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Open Job:";
            // 
            // CmdOpenJob
            // 
            this.CmdOpenJob.Location = new System.Drawing.Point(237, 45);
            this.CmdOpenJob.Name = "CmdOpenJob";
            this.CmdOpenJob.Size = new System.Drawing.Size(75, 29);
            this.CmdOpenJob.TabIndex = 6;
            this.CmdOpenJob.Text = "Open";
            this.CmdOpenJob.UseVisualStyleBackColor = true;
            this.CmdOpenJob.Click += new System.EventHandler(this.OpenJob);
            // 
            // LBModules
            // 
            this.LBModules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBModules.FormattingEnabled = true;
            this.LBModules.ItemHeight = 21;
            this.LBModules.Location = new System.Drawing.Point(12, 80);
            this.LBModules.Name = "LBModules";
            this.LBModules.Size = new System.Drawing.Size(231, 613);
            this.LBModules.TabIndex = 7;
            this.LBModules.DoubleClick += new System.EventHandler(this.ChangeModule);
            // 
            // PanelMain
            // 
            this.PanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelMain.Location = new System.Drawing.Point(249, 80);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(935, 637);
            this.PanelMain.TabIndex = 8;
            // 
            // CmdOptions
            // 
            this.CmdOptions.Location = new System.Drawing.Point(873, 45);
            this.CmdOptions.Name = "CmdOptions";
            this.CmdOptions.Size = new System.Drawing.Size(92, 29);
            this.CmdOptions.TabIndex = 9;
            this.CmdOptions.Text = "Options";
            this.CmdOptions.UseVisualStyleBackColor = true;
            this.CmdOptions.Click += new System.EventHandler(this.OpenSettingsDialog);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 729);
            this.Controls.Add(this.CmdOptions);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.LBModules);
            this.Controls.Add(this.CmdOpenJob);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtJobNumber);
            this.Controls.Add(this.Lbltitle);
            this.Controls.Add(this.CmdMaximize);
            this.Controls.Add(this.CmdMinimize);
            this.Controls.Add(this.CmdClose);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Survey Toolbox";
            this.Load += new System.EventHandler(this.LoadApp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Button CmdMinimize;
        private System.Windows.Forms.Button CmdMaximize;
        private System.Windows.Forms.Label Lbltitle;
        private System.Windows.Forms.TextBox TxtJobNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdOpenJob;
        private System.Windows.Forms.ListBox LBModules;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Button CmdOptions;
    }
}

