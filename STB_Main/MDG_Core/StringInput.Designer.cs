namespace MDG_Core
{
    partial class StringInput
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
            this.CmdAccept = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmdAccept
            // 
            this.CmdAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdAccept.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdAccept.Location = new System.Drawing.Point(315, 144);
            this.CmdAccept.Name = "CmdAccept";
            this.CmdAccept.Size = new System.Drawing.Size(75, 30);
            this.CmdAccept.TabIndex = 0;
            this.CmdAccept.Text = "Accept";
            this.CmdAccept.UseVisualStyleBackColor = true;
            this.CmdAccept.Click += new System.EventHandler(this.AcceptInput);
            // 
            // CmdCancel
            // 
            this.CmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdCancel.Location = new System.Drawing.Point(12, 144);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(75, 30);
            this.CmdCancel.TabIndex = 1;
            this.CmdCancel.Text = "Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdClose);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 79);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // TxtValue
            // 
            this.TxtValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtValue.Location = new System.Drawing.Point(12, 91);
            this.TxtValue.Name = "TxtValue";
            this.TxtValue.Size = new System.Drawing.Size(378, 29);
            this.TxtValue.TabIndex = 3;
            // 
            // StringInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CmdCancel;
            this.ClientSize = new System.Drawing.Size(402, 186);
            this.Controls.Add(this.TxtValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.CmdAccept);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StringInputForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StringInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdAccept;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtValue;
    }
}