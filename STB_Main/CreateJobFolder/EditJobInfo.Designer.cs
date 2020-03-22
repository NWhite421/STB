namespace CreateJobFolder
{
    partial class EditJobInfo
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
            this.TxtJobNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCommonName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtParcel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCounty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtZone = new System.Windows.Forms.TextBox();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.lbOtherNumbers = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtOJobNumber = new System.Windows.Forms.TextBox();
            this.lblOtherCompany = new System.Windows.Forms.Label();
            this.TxtOJobCompany = new System.Windows.Forms.TextBox();
            this.CbIsHNHNumber = new System.Windows.Forms.CheckBox();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.CmdRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtJobNumber
            // 
            this.TxtJobNumber.Enabled = false;
            this.TxtJobNumber.Location = new System.Drawing.Point(141, 12);
            this.TxtJobNumber.Name = "TxtJobNumber";
            this.TxtJobNumber.Size = new System.Drawing.Size(120, 29);
            this.TxtJobNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Job Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Common Name:";
            // 
            // TxtCommonName
            // 
            this.TxtCommonName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCommonName.Location = new System.Drawing.Point(141, 47);
            this.TxtCommonName.Name = "TxtCommonName";
            this.TxtCommonName.Size = new System.Drawing.Size(427, 29);
            this.TxtCommonName.TabIndex = 2;
            this.TxtCommonName.Leave += new System.EventHandler(this.TextboxExit);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parcel:";
            // 
            // TxtParcel
            // 
            this.TxtParcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtParcel.Location = new System.Drawing.Point(141, 82);
            this.TxtParcel.Name = "TxtParcel";
            this.TxtParcel.Size = new System.Drawing.Size(427, 29);
            this.TxtParcel.TabIndex = 4;
            this.TxtParcel.Leave += new System.EventHandler(this.TextboxExit);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Street Address:";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAddress.Location = new System.Drawing.Point(141, 117);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(427, 29);
            this.TxtAddress.TabIndex = 6;
            this.TxtAddress.Leave += new System.EventHandler(this.TextboxExit);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "City:";
            // 
            // TxtCity
            // 
            this.TxtCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCity.Location = new System.Drawing.Point(141, 152);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(427, 29);
            this.TxtCity.TabIndex = 8;
            this.TxtCity.Leave += new System.EventHandler(this.TextboxExit);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "County:";
            // 
            // TxtCounty
            // 
            this.TxtCounty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCounty.Enabled = false;
            this.TxtCounty.Location = new System.Drawing.Point(141, 187);
            this.TxtCounty.Name = "TxtCounty";
            this.TxtCounty.Size = new System.Drawing.Size(230, 29);
            this.TxtCounty.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Zone:";
            // 
            // TxtZone
            // 
            this.TxtZone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtZone.Enabled = false;
            this.TxtZone.Location = new System.Drawing.Point(431, 187);
            this.TxtZone.Name = "TxtZone";
            this.TxtZone.Size = new System.Drawing.Size(137, 29);
            this.TxtZone.TabIndex = 12;
            // 
            // CmdSave
            // 
            this.CmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdSave.Location = new System.Drawing.Point(483, 387);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(85, 28);
            this.CmdSave.TabIndex = 14;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.SaveInfo);
            // 
            // CmdCancel
            // 
            this.CmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdCancel.Location = new System.Drawing.Point(12, 387);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(85, 28);
            this.CmdCancel.TabIndex = 15;
            this.CmdCancel.Text = "Discard";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CancelJob);
            // 
            // lbOtherNumbers
            // 
            this.lbOtherNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOtherNumbers.FormattingEnabled = true;
            this.lbOtherNumbers.ItemHeight = 21;
            this.lbOtherNumbers.Location = new System.Drawing.Point(12, 222);
            this.lbOtherNumbers.Name = "lbOtherNumbers";
            this.lbOtherNumbers.Size = new System.Drawing.Size(265, 151);
            this.lbOtherNumbers.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Other Job Number:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(292, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "Number:";
            // 
            // TxtOJobNumber
            // 
            this.TxtOJobNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtOJobNumber.Location = new System.Drawing.Point(369, 246);
            this.TxtOJobNumber.Name = "TxtOJobNumber";
            this.TxtOJobNumber.Size = new System.Drawing.Size(199, 29);
            this.TxtOJobNumber.TabIndex = 18;
            // 
            // lblOtherCompany
            // 
            this.lblOtherCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOtherCompany.AutoSize = true;
            this.lblOtherCompany.Location = new System.Drawing.Point(283, 281);
            this.lblOtherCompany.Name = "lblOtherCompany";
            this.lblOtherCompany.Size = new System.Drawing.Size(80, 21);
            this.lblOtherCompany.TabIndex = 21;
            this.lblOtherCompany.Text = "Company:";
            // 
            // TxtOJobCompany
            // 
            this.TxtOJobCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtOJobCompany.Location = new System.Drawing.Point(369, 281);
            this.TxtOJobCompany.Name = "TxtOJobCompany";
            this.TxtOJobCompany.Size = new System.Drawing.Size(199, 29);
            this.TxtOJobCompany.TabIndex = 20;
            // 
            // CbIsHNHNumber
            // 
            this.CbIsHNHNumber.AutoSize = true;
            this.CbIsHNHNumber.Location = new System.Drawing.Point(391, 316);
            this.CbIsHNHNumber.Name = "CbIsHNHNumber";
            this.CbIsHNHNumber.Size = new System.Drawing.Size(177, 25);
            this.CbIsHNHNumber.TabIndex = 22;
            this.CbIsHNHNumber.Text = "Is an internal number";
            this.CbIsHNHNumber.UseVisualStyleBackColor = true;
            this.CbIsHNHNumber.CheckedChanged += new System.EventHandler(this.ChangeInternalNumber);
            // 
            // CmdAdd
            // 
            this.CmdAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdAdd.Location = new System.Drawing.Point(483, 345);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.Size = new System.Drawing.Size(85, 28);
            this.CmdAdd.TabIndex = 23;
            this.CmdAdd.Text = "Add";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.AddOtherJobNumber);
            // 
            // CmdRemove
            // 
            this.CmdRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdRemove.Location = new System.Drawing.Point(283, 345);
            this.CmdRemove.Name = "CmdRemove";
            this.CmdRemove.Size = new System.Drawing.Size(85, 28);
            this.CmdRemove.TabIndex = 24;
            this.CmdRemove.Text = "Remove";
            this.CmdRemove.UseVisualStyleBackColor = true;
            // 
            // EditJobInfo
            // 
            this.AcceptButton = this.CmdSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CmdCancel;
            this.ClientSize = new System.Drawing.Size(580, 427);
            this.Controls.Add(this.CmdRemove);
            this.Controls.Add(this.CmdAdd);
            this.Controls.Add(this.CbIsHNHNumber);
            this.Controls.Add(this.lblOtherCompany);
            this.Controls.Add(this.TxtOJobCompany);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtOJobNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbOtherNumbers);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtZone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtCounty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtParcel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCommonName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtJobNumber);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditJobInfo";
            this.Text = "EditJobInfo";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtJobNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCommonName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtParcel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCounty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtZone;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.ListBox lbOtherNumbers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtOJobNumber;
        private System.Windows.Forms.Label lblOtherCompany;
        private System.Windows.Forms.TextBox TxtOJobCompany;
        private System.Windows.Forms.CheckBox CbIsHNHNumber;
        private System.Windows.Forms.Button CmdAdd;
        private System.Windows.Forms.Button CmdRemove;
    }
}