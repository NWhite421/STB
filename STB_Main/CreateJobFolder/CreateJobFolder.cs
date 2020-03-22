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
using System.Xml.Linq;
using System.IO;
using System.Reflection;

namespace CreateJobFolder
{
    public partial class CreateJobFolder: UserControl
    {
        public static List<JobTemplate> Templates { get; set; }
        public static JobTemplate CurrentTemplate { get; set; }
        public static string BaseDir { get; set; }
        public class JobNumber
        {
            public static string Year { get; set; }
            public static string Month { get; set; }
            public static string Number { get; set; }
        }

        public CreateJobFolder()
        {
            InitializeComponent();
        }

        private void LoadForm(object s,EventArgs e)
        {
            Templates = Functions.CompileList();
            UCFunctions.AlignandColor(this);
            foreach (JobTemplate template in Templates)
            {
                LbTemplates.Items.Add(template.MetaData.Name);
            }
#if DEBUG
            string containingFolder = @"C:\Users\Nathan White\Documents\Test\";
            containingFolder = Path.Combine(
                containingFolder,
                DateTime.Now.Year.ToString(),
                DateTime.Now.ToString("MM") + "-" + DateTime.Now.Year.ToString()
                );
#else
            string containingFolder = Path.Combine(
                GVars.DriveLetter + @"\",
                DateTime.Now.Year.ToString(),
                DateTime.Now.ToString("MM") + "-" + DateTime.Now.Year.ToString()
                );
#endif
            Log.ToDebug(containingFolder);
            if (!Directory.Exists(containingFolder))
            {
                Directory.CreateDirectory(containingFolder);
            }
            int jobNumber = 1;
            foreach (string folder in Directory.GetDirectories(containingFolder))
            {
                if (folder.Contains(string.Format("{0}-{1}", DateTime.Now.ToString("MM"), jobNumber.ToString("000"))))
                {
                    jobNumber++;
                }
            }
            string newNumber = DateTime.Now.ToString("yyyyMM") + jobNumber.ToString("000");
            Log.ToDebug(newNumber);
            TxtJobNumber.Text = Converter.ToJobNumber(newNumber).Remove(0,2);
            JobNumber.Year = Converter.ToJobNumber(newNumber).Split('-')[0];
            JobNumber.Month = Converter.ToJobNumber(newNumber).Split('-')[1];
            JobNumber.Number = Converter.ToJobNumber(newNumber).Split('-')[2];
        }
        
        private void SetTreeView(object s, EventArgs e)
        {
            if (LbTemplates.SelectedIndex > LbTemplates.Items.Count - 1)
            {
                return;
            }

            string name = LbTemplates.GetItemText(LbTemplates.SelectedItem);
            JobTemplate template = Templates.Where(x => x.MetaData.Name == name).First();

            if (TvTemplateDetail.Nodes.Count > 0)
            {
                TvTemplateDetail.Nodes.Clear();
            }

            TreeNode node = new TreeNode
            {
                Text = template.MetaData.Name
            };
            //Metadata
            node.Nodes.Add("Creation Date: " + template.MetaData.CreationDate.Date.ToString());

            TreeNode contents = node.Nodes.Add("Contents");
            contents.Nodes.Add(Functions.CompileXMLToNode(template.MasterDirectory));

            TvTemplateDetail.Nodes.Add(node);

            CurrentTemplate = template;
        }
        
        private void CreateFolder(object sender, EventArgs e)
        {
            string jobNumber = Converter.ToJobNumber(TxtJobNumber.Text);
            if (string.IsNullOrEmpty(jobNumber))
            {
                Log.AddInfo("job number provided is not a job number.");
                return;
            }
        }
    }

    internal class Functions
    {
        /// <summary>
        /// Beatuifys variables in the string to their real-world counterpart.
        /// </summary>
        /// <param name="source">The string to beautify.</param>
        /// <returns>A formatted string.</returns>
        public static string BeautifyName(string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                Log.AddError("No job number was provided.");
                return null;
            }
            string ret = source.Replace(
                "%%Job_Number%%", CreateJobFolder.JobNumber.Month + "-" + CreateJobFolder.JobNumber.Number
                );
            return ret;
        }

        public static TreeNode CompileXMLToNode(FolderTemplate template)
        {
            TreeNode node = new TreeNode(template.Name);
            node.Nodes.Add("Hidden: " + template.Hidden);
            TreeNode contents = node.Nodes.Add("Contents");
            foreach (object content in template.Contents)
            {
                switch (content.GetType().Name.ToLower())
                {
                    case "foldertemplate":
                        {
                            contents.Nodes.Add(GetFolderNode((FolderTemplate)content));
                            break;
                        }
                    case "filetemplate":
                        {
                            contents.Nodes.Add(GetFileNode((FileTemplate)content));
                            break;
                        }
                    default:
                        break;
                }
            }
            return node;
        }

        private static TreeNode GetFolderNode(FolderTemplate template)
        {
            TreeNode node = new TreeNode(template.Name);
            node.Nodes.Add("Hidden: " + template.Hidden);
            TreeNode contents = node.Nodes.Add("Contents");
            foreach (object content in template.Contents)
            {
                switch (content.GetType().Name.ToLower())
                {
                    case "foldertemplate":
                        {
                            contents.Nodes.Add(GetFolderNode((FolderTemplate)content));
                            break;
                        }
                    case "filetemplate":
                        {
                            contents.Nodes.Add(GetFileNode((FileTemplate)content));
                            break;
                        }
                    default:
                        break;
                }
            }
            return node;
        }

        private static TreeNode GetFileNode(FileTemplate template)
        {
            TreeNode node = new TreeNode(template.Name);
            node.Nodes.Add("Source: " + template.Source);
            node.Nodes.Add("Hidden: " + template.Hidden);
            node.Nodes.Add("Read Only: " + template.ReadOnly);
            return node;
        }

        public static List<JobTemplate> CompileList()
        {
            List<JobTemplate> templates = new List<JobTemplate> { };
            List<string> templateFiles = new List<string> { };
#if DEBUG
            string path = Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                "TemplateDocs",
                "SampleTemplate.xml");
            templateFiles.Add(path);
#else
            //TODO: Add dynamic list grab
#endif
            foreach (string file in templateFiles)
            {
                JobTemplate template = new JobTemplate { MetaData = new MetaData(), MasterDirectory = new FolderTemplate() };
                var xml = XElement.Load(file);
                var meta = xml.Element("Metadata");
                template.MetaData.Name = meta.Element("Name").Value;
                template.MetaData.CreationDate = DateTime.Parse(meta.Element("CreateDate").Value);
                var basedir = xml.Element("Entry");
                FolderTemplate basefolder = new FolderTemplate
                {
                    Name = basedir.Element("Name").Value,
                    Hidden = false,
                    Contents = new List<object> { }
                };
                foreach (XElement element in basedir.Elements("Subdir").Elements("Entry"))
                {
                    XElement type = element.Element("Type");
                    switch (type.Value)
                    {
                        case "0":
                            {
                                basefolder.Contents.Add(CompileFolderTemplate(element));
                                break;
                            }
                        case "1":
                            {
                                basefolder.Contents.Add(CompileFileTemplate(element));
                                break;
                            }
                        default:
                            break;
                    }
                }
                template.MasterDirectory = basefolder;
                templates.Add(template);
            }

            return templates;
        }
        
        private static FolderTemplate CompileFolderTemplate(XElement Source)
        {
            FolderTemplate template = new FolderTemplate
            {
                Name = Source.Element("Name").Value,
                Hidden = bool.Parse(Source.Element("Hidden").Value),
                Contents = new List<object> { }
            };

            foreach (XElement element in Source.Elements("Subdir").Elements("Entry"))
            {
                XElement type = element.Element("Type");
                switch (type.Value)
                {
                    case "0":
                        {
                            template.Contents.Add(CompileFolderTemplate(element));
                            break;
                        }
                    case "1":
                        {
                            template.Contents.Add(CompileFileTemplate(element));
                            break;
                        }
                    default:
                        break;
                }
            }

            return template;
        }

        private static FileTemplate CompileFileTemplate(XElement Source)
        {
            FileTemplate template = new FileTemplate
            {
                Name = Source.Element("Name").Value,
                Hidden = bool.Parse(Source.Element("Hidden").Value),
                ReadOnly = bool.Parse(Source.Element("Readonly").Value),
                Source = Source.Element("Source").Value
            };

            return template;
        }

    }
}
