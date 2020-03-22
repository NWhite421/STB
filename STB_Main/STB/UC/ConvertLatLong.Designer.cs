namespace STB.UC
{
    partial class ConvertLatLong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtJobNumber = new System.Windows.Forms.TextBox();
            this.LblJNInvalid = new System.Windows.Forms.Label();
            this.TxtStartNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPNInvalid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.CmdSelectFiles = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job Number:";
            // 
            // TxtJobNumber
            // 
            this.TxtJobNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtJobNumber.Location = new System.Drawing.Point(108, 3);
            this.TxtJobNumber.Name = "TxtJobNumber";
            this.TxtJobNumber.Size = new System.Drawing.Size(432, 29);
            this.TxtJobNumber.TabIndex = 1;
            this.TxtJobNumber.TextChanged += new System.EventHandler(this.JobNumberChanged);
            // 
            // LblJNInvalid
            // 
            this.LblJNInvalid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblJNInvalid.AutoSize = true;
            this.LblJNInvalid.Location = new System.Drawing.Point(546, 6);
            this.LblJNInvalid.Name = "LblJNInvalid";
            this.LblJNInvalid.Size = new System.Drawing.Size(56, 21);
            this.LblJNInvalid.TabIndex = 2;
            this.LblJNInvalid.Text = "Invalid";
            // 
            // TxtStartNumber
            // 
            this.TxtStartNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtStartNumber.Location = new System.Drawing.Point(108, 38);
            this.TxtStartNumber.Name = "TxtStartNumber";
            this.TxtStartNumber.Size = new System.Drawing.Size(432, 29);
            this.TxtStartNumber.TabIndex = 4;
            this.TxtStartNumber.TextChanged += new System.EventHandler(this.PointNumberChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start Point:";
            // 
            // lblPNInvalid
            // 
            this.lblPNInvalid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPNInvalid.AutoSize = true;
            this.lblPNInvalid.Location = new System.Drawing.Point(546, 41);
            this.lblPNInvalid.Name = "lblPNInvalid";
            this.lblPNInvalid.Size = new System.Drawing.Size(56, 21);
            this.lblPNInvalid.TabIndex = 5;
            this.lblPNInvalid.Text = "Invalid";
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(601, 219);
            this.label3.TabIndex = 6;
            this.label3.Text = "Drop file here";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropControl);
            this.label3.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterControl);
            // 
            // LblStatus
            // 
            this.LblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(4, 416);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(52, 21);
            this.LblStatus.TabIndex = 7;
            this.LblStatus.Text = "label4";
            // 
            // CmdSelectFiles
            // 
            this.CmdSelectFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdSelectFiles.Location = new System.Drawing.Point(510, 413);
            this.CmdSelectFiles.Name = "CmdSelectFiles";
            this.CmdSelectFiles.Size = new System.Drawing.Size(98, 32);
            this.CmdSelectFiles.TabIndex = 8;
            this.CmdSelectFiles.Text = "Select Files";
            this.CmdSelectFiles.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(3, 292);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(605, 115);
            this.txtLog.TabIndex = 9;
            // 
            // ConvertLatLong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.CmdSelectFiles);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPNInvalid);
            this.Controls.Add(this.TxtStartNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblJNInvalid);
            this.Controls.Add(this.TxtJobNumber);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(300, 250);
            this.Name = "ConvertLatLong";
            this.Size = new System.Drawing.Size(611, 445);
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtJobNumber;
        private System.Windows.Forms.Label LblJNInvalid;
        private System.Windows.Forms.TextBox TxtStartNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPNInvalid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Button CmdSelectFiles;
        private System.Windows.Forms.TextBox txtLog;
    }
}
