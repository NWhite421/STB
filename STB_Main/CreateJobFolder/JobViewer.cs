using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDG_Core;
using System.IO;
using System.Reflection;
using System.Xml.Linq;
using System.Xml;
using System.Diagnostics;
using iwantedue.Windows.Forms;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Outlook;
using System.Runtime.InteropServices;

namespace CreateJobFolder
{
    public partial class JobViewer : UserControl
    {

        public JobViewer()
        {
            InitializeComponent();
            UCFunctions.AlignandColor(this);
            dataGridNotes.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridNotes.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
        }

        #region INTERNAL VARIABLES

        /// <summary>
        /// XML data file.
        /// </summary>
        private string XMLPath { get; set; }

        /// <summary>
        /// Job Log file
        /// </summary>
        private string LogPath { get; set; }

        /// <summary>
        /// The base directory of the current job. Returns null if no job is selected.
        /// </summary>
        private string JobPath
        {
            get
            {
                if (string.IsNullOrEmpty(XMLPath))
                {
                    return null;
                }
                else
                {
                    return Path.GetDirectoryName(XMLPath);
                }
            }
        }

        /// <summary>
        /// Writes the <paramref name="Message"/> to the current job log.
        /// </summary>
        /// <param name="Message">Message to write.</param>
        internal void AddNoteToLog(string Message)
        {
            if (string.IsNullOrEmpty(Message) || string.IsNullOrEmpty(LogPath))
            {
                return;
            }
            string header = "[" + DateTime.Now.ToString("MM-dd-yy hh:mm tt") + "] ";
            string[] lines = new string[] { header + Message };
            File.AppendAllLines(LogPath, lines);
        }

        /// <summary>
        /// Updates the XML file with the updated information.
        /// </summary>
        /// <param name="Document">XDocument item to save.</param>
        internal void UpdateXML(XDocument Document)
        {
            File.Delete(XMLPath);
            Document.Save(Path.Combine(XMLPath));
            File.SetAttributes(XMLPath, File.GetAttributes(XMLPath) | FileAttributes.Hidden);
        }

        /// <summary>
        /// Microsoft Office application.
        /// </summary>
        private readonly Microsoft.Office.Interop.Outlook.Application _application = new Microsoft.Office.Interop.Outlook.Application();

        #endregion

        #region GENERAL

        /// <summary>
        /// Open a job and update all variables and lists.
        /// </summary>
        private void OpenJob(object s, EventArgs e)
        {
            string jobNumber = Converter.ToJobNumber(TxtJobNumber.Text);
            if (string.IsNullOrEmpty(jobNumber))
            {
                return;
            }
            string xmlPath = Path.Combine(Converter.JobNumberToPath(jobNumber), "jobXML.xml");
            string logPath = Path.Combine(Converter.JobNumberToPath(jobNumber), "job.log");
            Log.ToDebug(xmlPath);
            if (!File.Exists(xmlPath))
            {
                string source = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "JobXML.xml");
                File.Copy(source, xmlPath);
                File.SetAttributes(xmlPath, File.GetAttributes(xmlPath) | FileAttributes.Hidden);
                Log.ToDebug("JobXML.xml file created at " + xmlPath);
                var stream = File.Create(logPath);
                stream.Close();
                File.SetAttributes(logPath, File.GetAttributes(logPath) | FileAttributes.Hidden);
                Log.ToDebug("job.log file created at " + logPath);
            }
            else { Log.ToDebug("File was found."); }
            XMLPath = xmlPath;
            LogPath = logPath;
            AddNoteToLog("Job created on " + DateTime.Now.ToString("MM-dd-yy"));
            LblCurrentJob.Text = jobNumber.Remove(0,2);
            cbType.SelectedIndex = 1;
            PopulateLists();
        }

        /// <summary>
        /// Opens file explorer to the current job file.
        /// </summary>
        private void OpenJobFolder(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(XMLPath))
            {
                Log.ToDebug("Link clicked with no job selected.");
                return;
            }
            string path = Path.GetDirectoryName(XMLPath);
            Process.Start(path);
        }

        /// <summary>
        /// Opens file explorer to the current field data folder.
        /// </summary>
        private void LnkOpenFieldData(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(XMLPath))
            {
                Log.ToDebug("Link clicked with no job selected.");
                return;
            }
            string path = Path.GetDirectoryName(XMLPath) + "\\Field Data";
            Process.Start("explorer.exe", path);
        }

        /// <summary>
        /// Recenters center three squares.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        private void ResizeForm(object s, EventArgs e)
        {
            int width = this.Width;
            int spacing = 4;
            int nWidth = (width - (spacing * 4)) / 3;
            PnlFieldData.Width = nWidth;
            PnlTasks.Width = nWidth;
            PnlTasks.Location = new Point(spacing + nWidth + spacing, PnlTasks.Location.Y);
            PnlEmails.Width = nWidth;
            PnlEmails.Location = new Point(spacing + nWidth + spacing + nWidth + spacing, PnlEmails.Location.Y);
        }

        /// <summary>
        /// Populates all the lists with their relevant information.
        /// </summary>
        private void PopulateLists()
        {
            if (string.IsNullOrEmpty(XMLPath) || string.IsNullOrEmpty(LogPath) || string.IsNullOrEmpty(JobPath))
            {
                Log.AddError("The lists in the View Job module tried to be populated without a job being selected.");
                return;
            }
            DataGridView table;
            XDocument doc = XDocument.Load(XMLPath);

            //Notes list
            XElement elements = doc.Root.Element("Notes");
            table = dataGridNotes;
            if (table.Rows.Count > 0)
            {
                table.Rows.Clear();
            }

            foreach (XElement e in elements.Elements("Entry"))
            {
                string date = e.Element("Date").Value;
                string author = e.Element("Author").Value;
                string note = e.Element("Note").Value;
                table.Rows.Add(date, author, note);
            }

            //Email list
            elements = doc.Root.Element("Emails");
            table = dataGridEmails;
            if (table.Rows.Count > 0)
            {
                table.Rows.Clear();
            }

            foreach (XElement e in elements.Elements("Entry"))
            {
                string date = DateTime.Parse(e.Element("Date").Value).ToString("MM-dd-yy hh:mm tt");
                string name = e.Element("Name").Value;
                table.Rows.Add(date, name);
            }

            //Files list
            elements = doc.Root.Element("FieldData");
            table = dataGridFieldData;
            if (table.Rows.Count > 0)
            {
                table.Rows.Clear();
            }

            foreach (XElement e in elements.Elements("Entry"))
            {
                string date = DateTime.Parse(e.Element("Date").Value).ToString("MM-dd-yy hh:mm tt");
                string name = e.Element("Name").Value;
                table.Rows.Add(date, name);
            }
        }
        
        #endregion

        #region NOTES

        /// <summary>
        /// Adds a note to the job by the user.
        /// </summary>
        /// <remarks>Updated 03-19-20</remarks>
        private void AddNoteToJob(object s, EventArgs e)
        {
            if (string.IsNullOrEmpty(XMLPath))
            {
                return;
            }

            string dateEntry = DateTime.Now.ToString("MM-dd-yy hh:mm tt");
            string name = GVars.UsernameInitials;
            XDocument doc = XDocument.Load(XMLPath);
            XElement notes = doc.Root.Element("Notes");
            XElement entry = new XElement("Entry",
                new XElement("Date", dateEntry),
                new XElement("Author", name),
                new XElement("Note", TxtNote.Text)
                );
            notes.Add(entry);

            string logEntry = string.Format("New note entry: {0}|{1}|{2}", dateEntry, GVars.UsernameFull, TxtNote.Text);
            AddNoteToLog(logEntry);
            UpdateXML(doc);
            PopulateLists();
            TxtNote.Text = string.Empty;
        }

        /// <summary>
        /// Clears the TxtNotes field.
        /// </summary>
        /// <remarks>Updated 03-19-20</remarks>
        private void ClearNoteField(object s, EventArgs e)
        {
            TxtNote.Text = string.Empty;
        }
        
        /// <summary>
        /// Removes a log item from the job.
        /// </summary>
        /// <remarks>Updated 03-19-20</remarks>
        private void RemoveEntry(object sender, EventArgs e)
        {
            if (dataGridNotes.SelectedRows.Count == 0 || string.IsNullOrEmpty(XMLPath) || string.IsNullOrEmpty(LogPath))
            {
                Log.ToDebug("Attemped to delete note, failed to provide enough passive information.");
                return;
            }

            string dateSelected = dataGridNotes.Rows[dataGridNotes.SelectedRows[0].Index].Cells[0].Value.ToString();
            Log.ToDebug("Currently selected log has a date of " + dateSelected);

            XDocument doc = XDocument.Load(XMLPath);
            XElement notes = doc.Root.Element("Notes");
            var XmlEntry = notes.Elements("Entry").Where(x => x.Element("Date").Value == dateSelected).FirstOrDefault();

            var res = MessageBox.Show("You are about to delete the entry dated\n\n" + dateSelected + "\n\nAre you sure you wish to continue?", "Confirm deletion", MessageBoxButtons.YesNo);
            if (res.Equals(DialogResult.No))
            {
                Log.ToDebug("Deleting log entry cancelled.");
                return;
            }

            string logEntry = string.Format("New note entry: {0}|{1}|{2}", XmlEntry.Element("Date").Value, XmlEntry.Element("Author").Value, XmlEntry.Element("Note").Value);
            AddNoteToLog(logEntry);
            XmlEntry.Remove();
            UpdateXML(doc);
            PopulateLists();
        }

        /// <summary>
        /// Exports note list to a text file with deliniation marks (|).
        /// </summary>
        /// <remarks>Updated 03-19-20</remarks>
        private void ExportNotes(object sender, EventArgs e)
        {
            if (dataGridNotes.Rows.Count <= 0 || string.IsNullOrEmpty(XMLPath) || string.IsNullOrEmpty(JobPath))
            {
                Log.ToDebug("Too few passive arguments were found.");
                return;
            }
            List<string> notes = new List<string> { };
            notes.Add("Date|Author|Note");
            foreach (DataGridViewRow row in dataGridNotes.Rows)
            {
                notes.Add(row.Cells[0].Value.ToString() + "|" + row.Cells[1].Value.ToString() + "|" + row.Cells[2].Value.ToString());
            }
            string path = Path.Combine(
                JobPath,
                "Notes export.txt");
            Log.ToDebug("Note path: " + path);
            File.AppendAllLines(path, notes);
            string logEntry = string.Format("Notes were exported to text file.");
            AddNoteToLog(logEntry);
            Log.AddInfo(logEntry + " (" + TxtJobNumber.Text + ")");
        }

        #endregion

        #region EMAIL
        
        /// <summary>
        /// Enable drag and drop feature for e-mails.
        /// </summary>
        /// <remarks>Updated 03-19-20</remarks>
        private void DragEmailEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("FileGroupDescriptor"))
            {
                e.Effect = DragDropEffects.Copy;
            } else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// Handle dropping of e-mail from outlook into folder.
        /// </summary>
        /// <remarks>Updated 03-19-20 - Contains unoriginal code</remarks>
        private void DragEmailDrop(object sender, DragEventArgs e)
        {
            List<string> lstResults = new List<string> { };
            if (string.IsNullOrEmpty(JobPath))
            {
                return;
            }
            try
            {
                if (e.Data.GetDataPresent("FileGroupDescriptor"))
                {
                    foreach (MailItem mailItem in _application.ActiveExplorer().Selection)
                    {
                        string eMailFolder = Path.Combine(JobPath, "E-Mails");
                        if (!Directory.Exists(eMailFolder))
                        {
                            Directory.CreateDirectory(eMailFolder);
                        }

                        string strFile = Path.Combine(eMailFolder, FixFileName(mailItem.Subject + ".msg"));
                        lstResults.Add(strFile);
                        mailItem.SaveAs(strFile);

                        string dateEntry = DateTime.Now.ToString();
                        string name = GVars.UsernameInitials;
                        XDocument doc = XDocument.Load(XMLPath);
                        XElement notes = doc.Root.Element("Emails");
                        XElement entry = new XElement("Entry",
                            new XElement("Date", dateEntry),
                            new XElement("Author", name),
                            new XElement("Name", FixFileName(mailItem.Subject)),
                            new XElement("Path", strFile)
                            );
                        notes.Add(entry);

                        AddNoteToLog(GVars.UsernameFull + " added e-mail to job record.");
                        UpdateXML(doc);
                        PopulateLists();
                    }
                }
            }
            catch
            {
                Log.AddError("Could not process e-mail drop.");
            }
        }

        /// <summary>
        /// Open a e-mail through the list.
        /// </summary>
        /// <remarks>Updated 03-19-20</remarks>
        private void EmailOpen(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridEmails.SelectedRows.Count < 1 || string.IsNullOrEmpty(XMLPath))
            {
                return;
            }
            string name = dataGridEmails.CurrentRow.Cells[1].Value.ToString();
            XDocument doc = XDocument.Load(XMLPath);
            XElement emailNodes = doc.Root.Element("Emails");
            XElement email = emailNodes.Elements().Where(x => x.Element("Name").Value.ToLower() == name.ToLower()).FirstOrDefault();
            string path = email.Element("Path").Value;
            Process.Start(path);
        }

        /// <summary>
        /// Removes an e-mail from the job.
        /// </summary>
        /// <remarks>Updated 03-19-20</remarks>
        private void EmailDelete(object sender, EventArgs e)
        {
            if (dataGridEmails.SelectedRows.Count == 0 || string.IsNullOrEmpty(XMLPath))
            {
                return;
            }
            string name = dataGridEmails.SelectedRows[0].Cells[1].Value.ToString();
            string confirmMessage = string.Format("Are you sure you want to delete \"{0}\" from the job?", name);
            var ret = MessageBox.Show(confirmMessage, "Confirm deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ret.Equals(DialogResult.No))
            {
                Log.ToDebug("Deletion cancelled.");
                return;
            }
            XDocument doc = XDocument.Load(XMLPath);
            XElement emailNodes = doc.Root.Element("Emails");
            XElement email = emailNodes.Elements().Where(x => x.Element("Name").Value.ToLower() == name.ToLower()).FirstOrDefault();
            if (email == null)
            {
                Log.AddWarning("How the fuck did you select an email that doesn't exist?");
                return;
            }
            string path = email.Element("Path").Value;
            email.Remove();
            string logEntry = GVars.UsernameFull + " deleted " + name + " from the job.";
            AddNoteToLog(logEntry);
            Log.AddInfo(logEntry);
            UpdateXML(doc);
            PopulateLists();
        }

        /// <summary>
        /// Fixes the name of an email to be filename complient.
        /// </summary>
        /// <param name="pFileName">String of e-mail</param>
        /// <returns>Formatted name</returns>
        /// <remarks>Updated 03-19-20 - Not original code</remarks>
        private string FixFileName(string pFileName)
        {
            var invalidChars = Path.GetInvalidFileNameChars();
            if (pFileName.IndexOfAny(invalidChars) >= 0)
            {
                pFileName = invalidChars.Aggregate(pFileName, (current, invalidChar) => current.Replace(invalidChar, Convert.ToChar("_")));
            }
            return pFileName;
        }

        #endregion

        #region TASKS



        #endregion

        private void PopulateFieldDataList()
        {
            if (dataGridFieldData.Rows.Count > 0)
            {
                dataGridFieldData.Rows.Clear();
            }

            XDocument doc = XDocument.Load(XMLPath);
            XElement data = doc.Root.Element("FieldData");
            List<List<string>> entries = new List<List<string>> { };
            foreach (XElement element in data.Elements("Entry"))
            {
                string date = DateTime.Parse(element.Element("Date").Value).ToString("MM-dd-yy hh:mmtt").ToUpper();
                string name = element.Element("Name").Value;
                dataGridFieldData.Rows.Add(date, name);
            }
        }

        private void DragFieldEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void DragFieldDrop(object sender, DragEventArgs e)
        {
            if (string.IsNullOrEmpty(XMLPath))
            {
                return;
            }
            string fieldFolder = Path.Combine(Path.GetDirectoryName(XMLPath), "Field Data");
            if (!Directory.Exists(fieldFolder))
            {
                Directory.CreateDirectory(fieldFolder);
            }
            //wrap standard IDataObject in OutlookDataObject
            string[] listarray = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            List<string> list = listarray.ToList();

            for (int fileIndex = 0; fileIndex < list.Count; fileIndex++)
            {
                //use the fileindex to get the name and data stream
                string filename = list[fileIndex];

                string type = cbType.GetItemText(cbType.SelectedItem);
                if (string.IsNullOrEmpty(type))
                {
                    return;
                }
                string date = File.GetLastWriteTime(filename).ToString("MM-dd-yy");
                string extension = filename.Substring(filename.Length-3, 3);
                string formattedName = string.Format("{0} {1} {2}.{3}", LblCurrentJob.Text, type, date, extension);
                string savePath = Path.Combine(fieldFolder, formattedName);
                //save the file stream using its name to the application path
                File.Move(filename, savePath);

                string dateEntry = DateTime.Now.ToString();
                string name = GVars.UsernameInitials;
                XDocument doc = XDocument.Load(XMLPath);
                XElement notes = doc.Root.Element("FieldData");
                XElement entry = new XElement("Entry",
                    new XElement("Date", dateEntry),
                    new XElement("Author", name),
                    new XElement("Name", type + " (" + extension + ")"),
                    new XElement("Path", savePath)
                    );
                notes.Add(entry);

                List<string> logEntry = new List<string> { };
                logEntry.Add(String.Format("[{0}]: {1} added {2} to job.", dateEntry, GVars.UsernameFull, type));
                File.AppendAllLines(LogPath, logEntry);

                File.Delete(XMLPath);
                doc.Save(Path.Combine(XMLPath));
                File.SetAttributes(XMLPath, File.GetAttributes(XMLPath) | FileAttributes.Hidden);

            }
            PopulateFieldDataList();
        }

        private void HandleKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Log.ToDebug("Enter key pressed");
                OpenJob(this, new EventArgs());
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
