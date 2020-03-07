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
        public static string Name;
        public static string Source;
        public static bool ReadOnly;
        public static bool Hidden;
    }

    public class FolderTemplate
    {
        public static string Name;
        public static bool Hidden;
        public static List<object> Contents;
    }

    public class JobTemplate
    {
        public static class MetaData
        {
            public static string Name;
            public static DateTime CreationDate;
        }
        public static FolderTemplate MasterDirectory;
    }
}
