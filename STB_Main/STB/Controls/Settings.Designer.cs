namespace STB
{
    partial class Settings
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
            this.Lbltitle = new System.Windows.Forms.Label();
            this.CmdClose = new System.Windows.Forms.Button();
            this.TxtNameFull = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNameInitials = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbDrive = new System.Windows.Forms.ComboBox();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbltitle
            // 
            this.Lbltitle.Location = new System.Drawing.Point(12, 9);
            this.Lbltitle.Name = "Lbltitle";
            this.Lbltitle.Size = new System.Drawing.Size(52, 21);
            this.Lbltitle.TabIndex = 4;
            this.Lbltitle.Text = "label1";
            // 
            // CmdClose
            // 
            this.CmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdClose.FlatAppearance.BorderSize = 0;
            this.CmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CmdClose.Location = new System.Drawing.Point(575, 12);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(35, 25);
            this.CmdClose.TabIndex = 5;
            this.CmdClose.Text = "X";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.ExitProgram);
            // 
            // TxtNameFull
            // 
            this.TxtNameFull.Location = new System.Drawing.Point(102, 52);
            this.TxtNameFull.Name = "TxtNameFull";
            this.TxtNameFull.Size = new System.Drawing.Size(269, 29);
            this.TxtNameFull.TabIndex = 6;
            this.TxtNameFull.Leave += new System.EventHandler(this.ComputeInitials);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Full Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Inititials:";
            // 
            // TxtNameInitials
            // 
            this.TxtNameInitials.Location = new System.Drawing.Point(102, 102);
            this.TxtNameInitials.Name = "TxtNameInitials";
            this.TxtNameInitials.Size = new System.Drawing.Size(91, 29);
            this.TxtNameInitials.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Inititials:";
            // 
            // CmbDrive
            // 
            this.CmbDrive.FormattingEnabled = true;
            this.CmbDrive.Items.AddRange(new object[] {
            "A:",
            "B:",
            "C:",
            "D:",
            "E:",
            "F:",
            "G:",
            "H:",
            "I:",
            "J:",
            "K:",
            "L:",
            "M:",
            "N:",
            "O:",
            "P:",
            "Q:",
            "R:",
            "S:",
            "T:",
            "U:",
            "V:",
            "W:",
            "X:",
            "Y:",
            "Z:"});
            this.CmbDrive.Location = new System.Drawing.Point(102, 157);
            this.CmbDrive.Name = "CmbDrive";
            this.CmbDrive.Size = new System.Drawing.Size(103, 29);
            this.CmbDrive.TabIndex = 11;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(527, 574);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(83, 31);
            this.CmdSave.TabIndex = 12;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.SaveButton);
            // 
            // CmdCancel
            // 
            this.CmdCancel.Location = new System.Drawing.Point(12, 574);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(83, 31);
            this.CmdCancel.TabIndex = 13;
            this.CmdCancel.Text = "Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.ExitProgram);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 617);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmbDrive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNameInitials);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNameFull);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.Lbltitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Settings";
            this.Text = "w";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbltitle;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.TextBox TxtNameFull;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNameInitials;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbDrive;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdCancel;
    }
}