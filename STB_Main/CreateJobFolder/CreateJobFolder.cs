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
using System.Xml;
using System.Xml.Linq;

namespace CreateJobFolder
{
    public partial class CreateJobFolder: UserControl
    {
        public static List<JobTemplate> Templates;

        public CreateJobFolder()
        {
            InitializeComponent();
        }

        private void LoadForm(object s,EventArgs e)
        {
            Templates = CompileList();
            UCFunctions.AlignandColor(this);
            foreach (JobTemplate template in Templates)
            {
                listBox1.Items.Add(template.MetaData.Name);
            }
        }

        private List<JobTemplate> CompileList()
        {
            List<JobTemplate> templates = new List<JobTemplate> { };
            List<string> templateFiles = new List<string> { };
#if DEBUG
            templateFiles.Add(@"C:\Users\Nathan White\Documents\Source Code\STB\STB_Main\STB\SampleTemplate.xml");
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
                foreach (XElement element in basedir.Descendants("Subdir").Elements())
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

        private FolderTemplate CompileFolderTemplate(XElement Source)
        {
            FolderTemplate template = new FolderTemplate
            {
                Name = Source.Element("Name").Value,
                Hidden = bool.Parse(Source.Element("Hidden").Value),
                Contents = new List<object> { }
            };

            foreach (XElement element in Source.Descendants("Subdir").Descendants())
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

        private FileTemplate CompileFileTemplate(XElement Source)
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

        private void SetTreeView(object s, EventArgs e)
        {
            if (listBox1.SelectedIndex > listBox1.Items.Count - 1)
            {
                return;
            }
            string name = listBox1.GetItemText(listBox1.SelectedItem);
            JobTemplate template = Templates.Where(x => x.MetaData.Name == name).First();

            if (treeView1.Nodes.Count > 0)
            {
                treeView1.Nodes.Clear();
            }

            TreeNode node = new TreeNode
            {
                Text = template.MetaData.Name
            };
            node.Nodes.Add("Creation Date: " + template.MetaData.CreationDate.Date.ToString());
            node.Nodes.Add("Folder Name: " + template.MasterDirectory.Name);
            TreeNode contents = node.Nodes.Add("Contents");
            foreach (object content in template.MasterDirectory.Contents)
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
            treeView1.Nodes.Add(node);
        }

        private TreeNode GetFolderNode(FolderTemplate template)
        {
            TreeNode node = new TreeNode(template.Name);
            node.Nodes.Add("Hidden: " + template.Hidden);
            TreeNode contents = node.Nodes.Add("Contents");
            foreach (object content in template.Contents)
            {
                switch (content.GetType().Name.ToLower())
                {
                    case "Folder":
                        {
                            contents.Nodes.Add(GetFolderNode((FolderTemplate)content));
                            break;
                        }
                    case "File":
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

        private TreeNode GetFileNode(FileTemplate template)
        {
            TreeNode node = new TreeNode(template.Name);
            node.Nodes.Add("Source: " + template.Source);
            node.Nodes.Add("Hidden: " + template.Hidden);
            node.Nodes.Add("Read Only: " + template.ReadOnly);
            return node;
        }
    }
}
