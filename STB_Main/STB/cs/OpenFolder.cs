using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MDG_Core;
using System.IO;
using System.Diagnostics;

namespace STB
{
    public class OpenFolder
    {        
        public static void OpenFolderLocation(string path)
        {
            if ( !string.IsNullOrEmpty(Converter.ToJobNumber(path)) )
            {
                Process.Start("explorer.exe", Converter.JobNumberToPath(path));
            }
            else if ( GVars.CustomFields.Where(x => x[0].ToLower() == path.ToLower()).Count() > 0 )
            {
                var field = GVars.CustomFields.Where(x => x[0].ToLower() == path.ToLower()).First();
                Process.Start("explorer.exe", field[1]);
            }
            else
            {
                Log.AddInfo("Job Number " + path + " does not exist and is not a special field.");
            }
        }
    }
}
