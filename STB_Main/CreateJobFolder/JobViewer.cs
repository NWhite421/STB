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

namespace CreateJobFolder
{
    public partial class JobViewer : UserControl
    {
        private string XMLPath { get; set; }
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
            Log.ToDebug(xmlPath);
            if (!File.Exists(xmlPath))
            {
                string source = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "JobXML.xml");
                File.Copy(source, xmlPath);
                File.SetAttributes(xmlPath, File.GetAttributes(xmlPath) | FileAttributes.Hidden);
                Log.ToDebug("JobXML.xml file created at " + xmlPath);
            }
            else { Log.ToDebug("File was found."); }
            XMLPath = xmlPath;
            LblCurrentJob.Text = jobNumber;
            PopulateNoteList(CompileNotes(XMLPath));
        }

        private void AddNoteToJob(object s, EventArgs e)
        {
            if (string.IsNullOrEmpty(XMLPath))
            {
                return;
            }

            string dateEntry = DateTime.Now.ToString();
            string name;
#if DEBUG
            name = "test";
#elif LAPTOP
            name = "test";
#else
            //TODO: Add name grab function
#endif
            XDocument doc = XDocument.Load(XMLPath);
            XElement notes = doc.Root.Element("Notes");
            XElement entry = new XElement("Entry",
                new XElement("Date", dateEntry),
                new XElement("Author", name),
                new XElement("Note", TxtNote.Text)
                );
            notes.Add(entry);

            File.Delete(XMLPath);
            doc.Save(Path.Combine(XMLPath));
            File.SetAttributes(XMLPath, File.GetAttributes(XMLPath) | FileAttributes.Hidden);
            PopulateNoteList(CompileNotes(XMLPath));
            TxtNote.Text = string.Empty;
        }

        private void ClearNoteField(object s, EventArgs e)
        {
            TxtNote.Text = string.Empty;
        }

        private List<List<string>> CompileNotes(string path)
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
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();
            }
            foreach (List<string> note in Notes)
            {
                dataGridView1.Rows.Add(note[0], note[1], note[2]);
            }
        }
    }
}
