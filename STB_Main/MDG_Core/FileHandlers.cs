using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace MDG_Core
{
    public class FileStructures
    {
        public class Files
        {
            public static void CreateFromTemplate(string Source, string Destination)
            {
                if (!File.Exists(Source))
                {
                    Log.AddError("The source file specified does not exist. Please ensure that the file is present.");
                    return;
                }
                if (!Directory.Exists(Path.GetDirectoryName(Destination)))
                {
                    Log.AddError("The destination file specified does not exist. Please make sure the path exists.");
                }
                File.Copy(Source, Destination);
            }
        }
        
        public class XMLHandler
        {
            public void Parse(string Source)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(Source);
            }
        }
    }
}
