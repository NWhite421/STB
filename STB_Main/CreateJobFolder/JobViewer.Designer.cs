namespace CreateJobFolder
{
    partial class JobViewer
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
            this.TxtJobNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdOpenJob = new System.Windows.Forms.Button();
            this.dataGridNotes = new System.Windows.Forms.DataGridView();
            this.DateEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Writer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtNote = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LblCurrentJob = new System.Windows.Forms.Label();
            this.CmdRemove = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.CmdExport = new System.Windows.Forms.Button();
            this.PnlFieldData = new System.Windows.Forms.Panel();
            this.dataGridFieldData = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblUploadFieldData = new System.Windows.Forms.Label();
            this.PnlEmails = new System.Windows.Forms.Panel();
            this.CmdRemoveEmail = new System.Windows.Forms.Button();
            this.LblUploadEmail = new System.Windows.Forms.Label();
            this.dataGridEmails = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblOpenField = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNotes = new System.Windows.Forms.Panel();
            this.label3_header = new System.Windows.Forms.Label();
            this.label4_header = new System.Windows.Forms.Label();
            this.headerProjectInfo = new System.Windows.Forms.Label();
            this.headerEmails = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNotes)).BeginInit();
            this.PnlFieldData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFieldData)).BeginInit();
            this.PnlEmails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmails)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtJobNumber
            // 
            this.TxtJobNumber.Location = new System.Drawing.Point(88, 3);
            this.TxtJobNumber.Name = "TxtJobNumber";
            this.TxtJobNumber.Size = new System.Drawing.Size(100, 29);
            this.TxtJobNumber.TabIndex = 0;
            this.TxtJobNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Open Job:";
            // 
            // CmdOpenJob
            // 
            this.CmdOpenJob.Location = new System.Drawing.Point(194, 3);
            this.CmdOpenJob.Name = "CmdOpenJob";
            this.CmdOpenJob.Size = new System.Drawing.Size(62, 29);
            this.CmdOpenJob.TabIndex = 2;
            this.CmdOpenJob.Text = "Open";
            this.CmdOpenJob.UseVisualStyleBackColor = true;
            this.CmdOpenJob.Click += new System.EventHandler(this.OpenJob);
            // 
            // dataGridNotes
            // 
            this.dataGridNotes.AllowUserToAddRows = false;
            this.dataGridNotes.AllowUserToDeleteRows = false;
            this.dataGridNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridNotes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridNotes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateEntry,
            this.Writer,
            this.Note});
            this.dataGridNotes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridNotes.Location = new System.Drawing.Point(3, 28);
            this.dataGridNotes.Name = "dataGridNotes";
            this.dataGridNotes.ReadOnly = true;
            this.dataGridNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridNotes.Size = new System.Drawing.Size(303, 185);
            this.dataGridNotes.TabIndex = 3;
            // 
            // DateEntry
            // 
            this.DateEntry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.DateEntry.DividerWidth = 1;
            this.DateEntry.Frozen = true;
            this.DateEntry.HeaderText = "Date";
            this.DateEntry.Name = "DateEntry";
            this.DateEntry.ReadOnly = true;
            this.DateEntry.ToolTipText = "The date of the entry.";
            this.DateEntry.Width = 5;
            // 
            // Writer
            // 
            this.Writer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Writer.DividerWidth = 1;
            this.Writer.Frozen = true;
            this.Writer.HeaderText = "Author";
            this.Writer.Name = "Writer";
            this.Writer.ReadOnly = true;
            this.Writer.ToolTipText = "Who wrote the comment.";
            this.Writer.Width = 84;
            // 
            // Note
            // 
            this.Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Note.DividerWidth = 1;
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.ToolTipText = "The note.";
            // 
            // TxtNote
            // 
            this.TxtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNote.Location = new System.Drawing.Point(3, 219);
            this.TxtNote.Multiline = true;
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.Size = new System.Drawing.Size(141, 56);
            this.TxtNote.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(150, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddNoteToJob);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(150, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ClearNoteField);
            // 
            // LblCurrentJob
            // 
            this.LblCurrentJob.AutoSize = true;
            this.LblCurrentJob.Location = new System.Drawing.Point(103, 28);
            this.LblCurrentJob.Name = "LblCurrentJob";
            this.LblCurrentJob.Size = new System.Drawing.Size(71, 21);
            this.LblCurrentJob.TabIndex = 8;
            this.LblCurrentJob.Text = "xx-xx-xxx";
            // 
            // CmdRemove
            // 
            this.CmdRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdRemove.Location = new System.Drawing.Point(231, 217);
            this.CmdRemove.Name = "CmdRemove";
            this.CmdRemove.Size = new System.Drawing.Size(75, 28);
            this.CmdRemove.TabIndex = 9;
            this.CmdRemove.Text = "Remove";
            this.CmdRemove.UseVisualStyleBackColor = true;
            this.CmdRemove.Click += new System.EventHandler(this.RemoveEntry);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 49);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 21);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Open Folder";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenJobFolder);
            // 
            // CmdExport
            // 
            this.CmdExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdExport.Location = new System.Drawing.Point(231, 251);
            this.CmdExport.Name = "CmdExport";
            this.CmdExport.Size = new System.Drawing.Size(75, 28);
            this.CmdExport.TabIndex = 11;
            this.CmdExport.Text = "Export";
            this.CmdExport.UseVisualStyleBackColor = true;
            this.CmdExport.Click += new System.EventHandler(this.ExportNotes);
            // 
            // PnlFieldData
            // 
            this.PnlFieldData.Controls.Add(this.label4_header);
            this.PnlFieldData.Controls.Add(this.dataGridFieldData);
            this.PnlFieldData.Controls.Add(this.LblUploadFieldData);
            this.PnlFieldData.Location = new System.Drawing.Point(7, 59);
            this.PnlFieldData.Name = "PnlFieldData";
            this.PnlFieldData.Size = new System.Drawing.Size(309, 238);
            this.PnlFieldData.TabIndex = 12;
            // 
            // dataGridFieldData
            // 
            this.dataGridFieldData.AllowUserToAddRows = false;
            this.dataGridFieldData.AllowUserToDeleteRows = false;
            this.dataGridFieldData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridFieldData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridFieldData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridFieldData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFieldData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.dataGridFieldData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridFieldData.Location = new System.Drawing.Point(3, 28);
            this.dataGridFieldData.Name = "dataGridFieldData";
            this.dataGridFieldData.ReadOnly = true;
            this.dataGridFieldData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFieldData.Size = new System.Drawing.Size(303, 117);
            this.dataGridFieldData.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn2.DividerWidth = 1;
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.ToolTipText = "The date of the entry.";
            this.dataGridViewTextBoxColumn2.Width = 5;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DividerWidth = 1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.ToolTipText = "The note.";
            // 
            // LblUploadFieldData
            // 
            this.LblUploadFieldData.AllowDrop = true;
            this.LblUploadFieldData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUploadFieldData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblUploadFieldData.Location = new System.Drawing.Point(3, 148);
            this.LblUploadFieldData.Name = "LblUploadFieldData";
            this.LblUploadFieldData.Size = new System.Drawing.Size(303, 90);
            this.LblUploadFieldData.TabIndex = 17;
            this.LblUploadFieldData.Text = "Upload Field Data";
            this.LblUploadFieldData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblUploadFieldData.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragFieldDrop);
            this.LblUploadFieldData.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragFieldEnter);
            // 
            // PnlEmails
            // 
            this.PnlEmails.Controls.Add(this.headerEmails);
            this.PnlEmails.Controls.Add(this.CmdRemoveEmail);
            this.PnlEmails.Controls.Add(this.LblUploadEmail);
            this.PnlEmails.Controls.Add(this.dataGridEmails);
            this.PnlEmails.Location = new System.Drawing.Point(629, 59);
            this.PnlEmails.Name = "PnlEmails";
            this.PnlEmails.Size = new System.Drawing.Size(309, 311);
            this.PnlEmails.TabIndex = 14;
            // 
            // CmdRemoveEmail
            // 
            this.CmdRemoveEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdRemoveEmail.Location = new System.Drawing.Point(230, 224);
            this.CmdRemoveEmail.Name = "CmdRemoveEmail";
            this.CmdRemoveEmail.Size = new System.Drawing.Size(76, 29);
            this.CmdRemoveEmail.TabIndex = 17;
            this.CmdRemoveEmail.Text = "Remove";
            this.CmdRemoveEmail.UseVisualStyleBackColor = true;
            this.CmdRemoveEmail.Click += new System.EventHandler(this.EmailDelete);
            // 
            // LblUploadEmail
            // 
            this.LblUploadEmail.AllowDrop = true;
            this.LblUploadEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUploadEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblUploadEmail.Location = new System.Drawing.Point(3, 221);
            this.LblUploadEmail.Name = "LblUploadEmail";
            this.LblUploadEmail.Size = new System.Drawing.Size(221, 90);
            this.LblUploadEmail.TabIndex = 16;
            this.LblUploadEmail.Text = "Upload E-Mail";
            this.LblUploadEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblUploadEmail.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragEmailDrop);
            this.LblUploadEmail.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEmailEnter);
            // 
            // dataGridEmails
            // 
            this.dataGridEmails.AllowUserToAddRows = false;
            this.dataGridEmails.AllowUserToDeleteRows = false;
            this.dataGridEmails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridEmails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridEmails.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.dataGridEmails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridEmails.Location = new System.Drawing.Point(3, 28);
            this.dataGridEmails.Name = "dataGridEmails";
            this.dataGridEmails.ReadOnly = true;
            this.dataGridEmails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmails.Size = new System.Drawing.Size(303, 190);
            this.dataGridEmails.TabIndex = 15;
            this.dataGridEmails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmailOpen);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn1.DividerWidth = 1;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.ToolTipText = "The date of the entry.";
            this.dataGridViewTextBoxColumn1.Width = 5;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DividerWidth = 1;
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.ToolTipText = "The note.";
            // 
            // LblOpenField
            // 
            this.LblOpenField.AutoSize = true;
            this.LblOpenField.Location = new System.Drawing.Point(105, 49);
            this.LblOpenField.Name = "LblOpenField";
            this.LblOpenField.Size = new System.Drawing.Size(121, 21);
            this.LblOpenField.TabIndex = 15;
            this.LblOpenField.TabStop = true;
            this.LblOpenField.Text = "Open Field Data";
            this.LblOpenField.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkOpenFieldData);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.headerProjectInfo);
            this.panel1.Controls.Add(this.LblOpenField);
            this.panel1.Controls.Add(this.LblCurrentJob);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Location = new System.Drawing.Point(322, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 238);
            this.panel1.TabIndex = 16;
            // 
            // pnlNotes
            // 
            this.pnlNotes.Controls.Add(this.label3_header);
            this.pnlNotes.Controls.Add(this.dataGridNotes);
            this.pnlNotes.Controls.Add(this.TxtNote);
            this.pnlNotes.Controls.Add(this.CmdRemove);
            this.pnlNotes.Controls.Add(this.CmdExport);
            this.pnlNotes.Controls.Add(this.button3);
            this.pnlNotes.Controls.Add(this.button2);
            this.pnlNotes.Location = new System.Drawing.Point(7, 300);
            this.pnlNotes.Name = "pnlNotes";
            this.pnlNotes.Size = new System.Drawing.Size(309, 282);
            this.pnlNotes.TabIndex = 17;
            // 
            // label3_header
            // 
            this.label3_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3_header.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3_header.Location = new System.Drawing.Point(3, 0);
            this.label3_header.Name = "label3_header";
            this.label3_header.Size = new System.Drawing.Size(303, 25);
            this.label3_header.TabIndex = 12;
            this.label3_header.Text = "Job Notes";
            // 
            // label4_header
            // 
            this.label4_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4_header.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4_header.Location = new System.Drawing.Point(3, 0);
            this.label4_header.Name = "label4_header";
            this.label4_header.Size = new System.Drawing.Size(303, 25);
            this.label4_header.TabIndex = 19;
            this.label4_header.Text = "Field Data";
            // 
            // headerProjectInfo
            // 
            this.headerProjectInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerProjectInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerProjectInfo.Location = new System.Drawing.Point(1, 0);
            this.headerProjectInfo.Name = "headerProjectInfo";
            this.headerProjectInfo.Size = new System.Drawing.Size(303, 25);
            this.headerProjectInfo.TabIndex = 13;
            this.headerProjectInfo.Text = "Project Information";
            // 
            // headerEmails
            // 
            this.headerEmails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerEmails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerEmails.Location = new System.Drawing.Point(3, 0);
            this.headerEmails.Name = "headerEmails";
            this.headerEmails.Size = new System.Drawing.Size(303, 25);
            this.headerEmails.TabIndex = 18;
            this.headerEmails.Text = "Related E-Mails";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Current Job:";
            // 
            // JobViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlFieldData);
            this.Controls.Add(this.PnlEmails);
            this.Controls.Add(this.pnlNotes);
            this.Controls.Add(this.CmdOpenJob);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtJobNumber);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "JobViewer";
            this.Size = new System.Drawing.Size(1034, 706);
            this.Resize += new System.EventHandler(this.ResizeForm);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNotes)).EndInit();
            this.PnlFieldData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFieldData)).EndInit();
            this.PnlEmails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlNotes.ResumeLayout(false);
            this.pnlNotes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtJobNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdOpenJob;
        private System.Windows.Forms.DataGridView dataGridNotes;
        private System.Windows.Forms.TextBox TxtNote;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LblCurrentJob;
        private System.Windows.Forms.Button CmdRemove;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button CmdExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Writer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.Panel PnlFieldData;
        private System.Windows.Forms.Panel PnlEmails;
        private System.Windows.Forms.Label LblUploadEmail;
        private System.Windows.Forms.DataGridView dataGridEmails;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button CmdRemoveEmail;
        private System.Windows.Forms.DataGridView dataGridFieldData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label LblUploadFieldData;
        private System.Windows.Forms.LinkLabel LblOpenField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlNotes;
        private System.Windows.Forms.Label label4_header;
        private System.Windows.Forms.Label headerEmails;
        private System.Windows.Forms.Label headerProjectInfo;
        private System.Windows.Forms.Label label3_header;
        private System.Windows.Forms.Label label3;
    }
}
