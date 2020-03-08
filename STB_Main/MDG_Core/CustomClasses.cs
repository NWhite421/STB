using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MDG_Core
{
    public class ColorPallete
    {
        public string Name;
        public Color Background;
        public Color Foreground;
        public Color Highlight;
        public Color Text;
    }

    public class UCModule
    {
        public string Name;
        public string UCControl;
    }

    public class FileTemplate
    {
        public string Name;
        public string Source;
        public bool ReadOnly;
        public bool Hidden;
    }

    public class FolderTemplate
    {
        public string Name;
        public bool Hidden;
        public List<object> Contents;
    }

    public class MetaData
    {
        public string Name;
        public DateTime CreationDate;
    }

    public class JobTemplate
    {
        public FolderTemplate MasterDirectory;
        public MetaData MetaData;
    }
}
