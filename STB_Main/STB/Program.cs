using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDG_Core;

namespace STB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GVars.InitializeVariables();
            GVars.Modules.Add(new UCModule { Name = "Google to txt", UCControl = "ConvertLatLong" });
            GVars.Modules.Add(new UCModule { Name = "New Job Folder", UCControl = "NewJobFolder" });
            Application.Run(new Main());
        }
    }
}
