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
            this.TxtNote = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblCurrentJob = new System.Windows.Forms.Label();
            this.CmdRemove = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.CmdExport = new System.Windows.Forms.Button();
            this.DateEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Writer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtJobNumber
            // 
            this.TxtJobNumber.Location = new System.Drawing.Point(88, 3);
            this.TxtJobNumber.Name = "TxtJobNumber";
            this.TxtJobNumber.Size = new System.Drawing.Size(100, 29);
            this.TxtJobNumber.TabIndex = 0;
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
            this.dataGridNotes.Location = new System.Drawing.Point(3, 59);
            this.dataGridNotes.Name = "dataGridNotes";
            this.dataGridNotes.ReadOnly = true;
            this.dataGridNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridNotes.Size = new System.Drawing.Size(680, 384);
            this.dataGridNotes.TabIndex = 3;
            // 
            // TxtNote
            // 
            this.TxtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNote.Location = new System.Drawing.Point(3, 449);
            this.TxtNote.Multiline = true;
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.Size = new System.Drawing.Size(680, 64);
            this.TxtNote.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(3, 519);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddNoteToJob);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(71, 519);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ClearNoteField);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Current Job:";
            // 
            // LblCurrentJob
            // 
            this.LblCurrentJob.AutoSize = true;
            this.LblCurrentJob.Location = new System.Drawing.Point(94, 35);
            this.LblCurrentJob.Name = "LblCurrentJob";
            this.LblCurrentJob.Size = new System.Drawing.Size(71, 21);
            this.LblCurrentJob.TabIndex = 8;
            this.LblCurrentJob.Text = "xx-xx-xxx";
            // 
            // CmdRemove
            // 
            this.CmdRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdRemove.Location = new System.Drawing.Point(607, 519);
            this.CmdRemove.Name = "CmdRemove";
            this.CmdRemove.Size = new System.Drawing.Size(76, 29);
            this.CmdRemove.TabIndex = 9;
            this.CmdRemove.Text = "Remove";
            this.CmdRemove.UseVisualStyleBackColor = true;
            this.CmdRemove.Click += new System.EventHandler(this.RemoveEntry);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(190, 35);
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
            this.CmdExport.Location = new System.Drawing.Point(525, 519);
            this.CmdExport.Name = "CmdExport";
            this.CmdExport.Size = new System.Drawing.Size(76, 29);
            this.CmdExport.TabIndex = 11;
            this.CmdExport.Text = "Export";
            this.CmdExport.UseVisualStyleBackColor = true;
            this.CmdExport.Click += new System.EventHandler(this.ExportNotes);
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
            // JobViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CmdExport);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.CmdRemove);
            this.Controls.Add(this.LblCurrentJob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtNote);
            this.Controls.Add(this.dataGridNotes);
            this.Controls.Add(this.CmdOpenJob);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtJobNumber);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "JobViewer";
            this.Size = new System.Drawing.Size(686, 551);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNotes)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblCurrentJob;
        private System.Windows.Forms.Button CmdRemove;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button CmdExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Writer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}
