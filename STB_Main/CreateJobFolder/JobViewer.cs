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

namespace CreateJobFolder
{
    public partial class JobViewer : UserControl
    {
        private string XMLPath { get; set; }
        private string LogPath { get; set; }
        public JobViewer()
        {
            InitializeComponent();
            UCFunctions.AlignandColor(this);
        }

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
                File.Create(logPath);
                File.SetAttributes(logPath, File.GetAttributes(logPath) | FileAttributes.Hidden);
                Log.ToDebug("job.log file created at " + logPath);
            }
            else { Log.ToDebug("File was found."); }
            XMLPath = xmlPath;
            LogPath = logPath;
            LblCurrentJob.Text = jobNumber;
            PopulateNoteList(CompileNotes());
        }

        private void AddNoteToJob(object s, EventArgs e)
        {
            if (string.IsNullOrEmpty(XMLPath))
            {
                return;
            }

            string dateEntry = DateTime.Now.ToString();
            string name = GVars.UsernameInitials;
            XDocument doc = XDocument.Load(XMLPath);
            XElement notes = doc.Root.Element("Notes");
            XElement entry = new XElement("Entry",
                new XElement("Date", dateEntry),
                new XElement("Author", name),
                new XElement("Note", TxtNote.Text)
                );
            notes.Add(entry);

            List<string> logEntry = new List<string> { };
            logEntry.Add("[" + dateEntry + "]: Added note to job with the following information:");
            logEntry.Add("    Date: " + dateEntry);
            logEntry.Add("    Author: " + name);
            logEntry.Add("    Note: " + TxtNote.Text);
            File.AppendAllLines(LogPath, logEntry);

            File.Delete(XMLPath);
            doc.Save(Path.Combine(XMLPath));
            File.SetAttributes(XMLPath, File.GetAttributes(XMLPath) | FileAttributes.Hidden);
            PopulateNoteList(CompileNotes());
            TxtNote.Text = string.Empty;
        }

        private void ClearNoteField(object s, EventArgs e)
        {
            TxtNote.Text = string.Empty;
        }

        private List<List<string>> CompileNotes()
        {
            XDocument doc = XDocument.Load(XMLPath);
            XElement notes = doc.Root.Element("Notes");
            List<List<string>> entries = new List<List<string>> { };
            foreach (XElement element in notes.Elements("Entry"))
            {
                List<string> entry = new List<string>
                {
                    element.Element("Date").Value,
                    element.Element("Author").Value,
                    element.Element("Note").Value
                };
                entries.Add(entry);
            }
            return entries;
        }

        private void PopulateNoteList(List<List<string>> Notes)
        {
            if (dataGridNotes.Rows.Count > 0)
            {
                dataGridNotes.Rows.Clear();
            }
            foreach (List<string> note in Notes)
            {
                dataGridNotes.Rows.Add(note[0], note[1], note[2]);
            }
        }

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

        private void RemoveEntry(object sender, EventArgs e)
        {
            if (dataGridNotes.SelectedRows.Count == 0)
            {
                return;
            }
            string dateSelected = dataGridNotes.Rows[dataGridNotes.SelectedRows[0].Index].Cells[0].Value.ToString();
            Log.ToDebug("Selected row has the date of " + dateSelected);
            XDocument doc = XDocument.Load(XMLPath);
            XElement notes = doc.Root.Element("Notes");
            var XmlEntry = notes.Elements("Entry").Where(x => x.Element("Date").Value == dateSelected).FirstOrDefault();

            var res = MessageBox.Show("You are about to delete the entry dated " + dateSelected + ". Are you sure you wish to continue?", "Confirm deletion", MessageBoxButtons.YesNo);
            if (res.Equals(DialogResult.No))
            {
                return;
            }
            List<string> logEntry = new List<string> { };
            logEntry.Add("[" + DateTime.Now.ToString() + "]: " + GVars.UsernameFull + " removed note from job with the following information:");
            logEntry.Add("    Date: " + XmlEntry.Element("Date").Value);
            logEntry.Add("    Author: " + XmlEntry.Element("Author").Value);
            logEntry.Add("    Note: " + XmlEntry.Element("Note").Value);
            File.AppendAllLines(LogPath, logEntry);
            XmlEntry.Remove();
            File.Delete(XMLPath);
            doc.Save(Path.Combine(XMLPath));
            File.SetAttributes(XMLPath, File.GetAttributes(XMLPath) | FileAttributes.Hidden);
            PopulateNoteList(CompileNotes());
        }

        private void ExportNotes(object sender, EventArgs e)
        {
            if (dataGridNotes.Rows.Count <= 0)
            {
                Log.ToDebug("No notes were found.");
                return;
            }
            List<string> notes = new List<string> { };
            notes.Add("Date|Author|Note");
            foreach (DataGridViewRow row in dataGridNotes.Rows)
            {
                notes.Add(row.Cells[0].Value.ToString() + "|" + row.Cells[1].Value.ToString() + "|" + row.Cells[2].Value.ToString());
            }
            string path = Path.Combine(
                Path.GetDirectoryName(XMLPath),
                "Notes export.txt");
            Log.ToDebug("Note path: " + path);
            File.AppendAllLines(path, notes);
            List<string> logEntry = new List<string> { };
            logEntry.Add("[" + DateTime.Now.ToString() + "]: " + GVars.UsernameFull + " exported notes to a txt file.");
            File.AppendAllLines(LogPath, logEntry);
        }
    }
}
