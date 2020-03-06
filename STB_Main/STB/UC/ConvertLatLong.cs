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
using System.Reflection;
using System.IO;
using System.Diagnostics;

namespace STB.UC
{
    public partial class ConvertLatLong : UserControl
    {
        //Module variables
        /// <summary>
        /// True if the job number is a valid number, false if not.
        /// </summary>
        private static bool GoodJobNumber;

        /// <summary>
        /// True if the point number is a valid number, false if not.
        /// </summary>
        private static bool GoodPointNumber;

        //DONT FUCKING TOUCH
        public ConvertLatLong()
        {
            InitializeComponent();
        }

        //Internal function for Log.ToDebug.
        internal void AddNote(string Message)
        {
            string LogMessage = string.Format("[{0}]: {1}" + Environment.NewLine, DateTime.Now.ToString("h:mm:ss tt"), Message);
            txtLog.Text += LogMessage;
            LblStatus.Text = Message;
            Log.AddInfo(Message);
        }

        //Called when form is loaded.
        private void FormLoad(object sender, EventArgs e)
        {
            LblJNInvalid.Visible = false;
            GoodJobNumber = true;
            lblPNInvalid.Visible = false;
            GoodPointNumber = true;
            AddNote("Ready");
        }

        //Drag and Drop Method
        /// <summary>
        /// called when files are droped into drop area.
        /// </summary>
        private void DragDropControl(object sender, DragEventArgs e)
        {
            //Log this shit
            AddNote("Items dropped into drop area.");

            //Get list of files dropped in, even if only one.
            var fileListArray = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            var fileList = fileListArray.ToList();

            //If the list is empty, someone fucked up.
            if (fileList.Count() == 0)
            {
                Log.AddError("Nothing was dropped into the converter. (how?)");
                return;
            }

            //Log this shit
            AddNote("Drag drop returned " + fileList.Count() + " items.");

            //Call converting function with array
            ConvertFiles(fileList);
        }

        /// <summary>
        /// Called when something is dragged over the area.
        /// </summary>
        private void DragEnterControl(object sender, DragEventArgs e)
        {
            //If data is a file
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            } 
            //If data is not a file
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        //Called when the job number field text is changed
        private void JobNumberChanged(object sender, EventArgs e)
        {
            //If field is empty or a valid job number
            string jn = Converter.ToJobNumber(TxtJobNumber.Text);
            if (string.IsNullOrEmpty(TxtJobNumber.Text) || !string.IsNullOrEmpty(jn))
            {
                LblJNInvalid.Visible = false;
                GoodJobNumber = true;
            } 
            //If it aint
            else
            {
                LblJNInvalid.Visible = true;
                GoodJobNumber = false;
            }
        }

        //Called when the point number field text is changed
        private void PointNumberChange(object sender, EventArgs e)
        {
            //If field is empty or is a int that is greater than 0
            var isNumber = int.TryParse(TxtStartNumber.Text, out int result);
            if (string.IsNullOrEmpty(TxtStartNumber.Text) || isNumber && result > 0)
            {
                lblPNInvalid.Visible = false;
                GoodPointNumber = true;
            } 
            //If it aint
            else
            {
                lblPNInvalid.Visible = true;
                GoodPointNumber = false;
            }
        }

        //Convert the file list into point files
        private void ConvertFiles(List<string> Files)
        {
            //If any field is considered invalid, cancel the operation.
            if (!GoodPointNumber || !GoodJobNumber)
            {
                AddNote("Conversion failed. Job number or point number is invalid");
                return;
            }

            //Get path of converter.
            string converter = Path.Combine(
                    Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                    "ConvertLatLong.exe"
                );
            Log.ToDebug("path of converter: " + converter);

            //Determine job number and point number if fields are blank.
            string JobNo = TxtJobNumber.Text;
            string PointNo = TxtStartNumber.Text;

            if (string.IsNullOrEmpty(JobNo))
            {
                JobNo = "none";
            }
            if (string.IsNullOrEmpty(PointNo))
            {
                PointNo = "1000";
            }

            //Foreach loop for every file provided.
            int fileNo = 1;
            foreach (string file in Files)
            {
                AddNote("Processing file " + fileNo);
                Log.AddInfo("Converting file: " + file);
                //Cancel round if file is not a text file
                if (!file.Contains(".txt"))
                {
                    Log.AddError("Could not process file. File must be a .txt file.");
                    AddNote("Could not process file. File must be a .txt file.");
                    break;
                }

                //Establish program arguments
                string args = "\"" + file + "\" \"" + JobNo + "\" \"" + PointNo + "\"";
                Log.ToDebug(args);
                AddNote("Starting converter");

                //Execute converter
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = converter;
                    process.StartInfo.Arguments = args;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                    process.WaitForExit();
                    string result = process.StandardOutput.ReadToEnd();
                    Log.AddInfo("Converter returned with " + result);
                    AddNote("Converter returned with " + result);
                };
                fileNo++;
            }
        }
    }
}
