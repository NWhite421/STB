using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;
using System.IO;

namespace MDG_Core
{
    public class GVars
    {
        public static ColorPallete ActivePallete;
        public static List<UCModule> Modules;
        public static List<List<string>> CustomFields;

        public static bool InitializeVariables()
        {
            ActivePallete = new ColorPallete
            {
                Name = "Dark",
                Background = Color.FromArgb(27, 38, 44),
                Foreground = Color.FromArgb(15, 76, 117),
                Highlight = Color.FromArgb(50, 130, 184),
                Text = Color.White
            };

            Modules = new List<UCModule> { };

            CompileFieldList();

            return true;
        }



        public static void CompileFieldList()
        {
            List<List<string>> ret = new List<List<string>> { };

            string directory = Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                "CustomDirectories.txt"
            );

            Log.ToDebug(directory);
            /*if (!Directory.Exists(directory))
            {
                Log.AddError("CustomDirectories.txt does not exist. Please ensure that the file is present.");
                return;
            }*/

            foreach (string line in File.ReadAllLines(directory))
            {
                if (line.StartsWith("//") || string.IsNullOrEmpty(line)) { Log.ToDebug("Skipping line: " + line); }
                else { ret.Add(line.Split(';').ToList()); }
            }
            CustomFields = ret;
        }
    }
}
