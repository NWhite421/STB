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
    /// <summary>
    /// Global variables
    /// </summary>
    public class GVars
    {
        /// <summary>
        /// Active color pallete.
        /// </summary>
        public static ColorPallete ActivePallete { get; set; }
        /// <summary>
        /// List of active modules to display in the list.
        /// </summary>
        public static List<UCModule> Modules { get; set; }
        /// <summary>
        /// Custom "open job folder" fields.
        /// </summary>
        public static List<List<string>> CustomFields { get; set; }
        /// <summary>
        /// Username of user spelled out.
        /// </summary>
        public static string UsernameFull { get; set; }
        /// <summary>
        /// Username of user in initial format.
        /// </summary>
        public static string UsernameInitials { get; set; }
        /// <summary>
        /// The drive of the work directory.
        /// </summary>
        public static string DriveLetter { get; set; }

        /// <summary>
        /// A list of citys with their associated county and state plane zone.
        /// </summary>
        public static Dictionary<string, string[]> CityReference { get; set; }

        /// <summary>
        /// Paths to all AppData folders and references.
        /// </summary>
        public class AppDataFolders
        {
            /// <summary>
            /// Paths to all folders.
            /// </summary>
            public class Folders
            {
                ///<summary>
                ///LocalAppData base folder.
                ///</summary>
                public static string LocalAppData { get; set; }
                /// <summary>
                /// Application log folder.
                /// </summary>
                public static string Logs { get; set; }

                public static string FolderTemplates { get; set; }
            }
            /// <summary>
            /// App name
            /// </summary>
            public static string AppName { get; set; }
            /// <summary>
            /// Path to log file.
            /// </summary>
            public static string LogFile { get; set; }
        }

        /// <summary>
        /// Initializes base variables for use in other classes and modules.
        /// </summary>
        /// <returns></returns>
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

            AppDataFolders.AppName = "Survey Toolbox";
            AppDataFolders.Folders.LocalAppData = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                AppDataFolders.AppName
                );
            AppDataFolders.Folders.Logs = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                AppDataFolders.AppName,
                "Logs"
                );
            AppDataFolders.Folders.FolderTemplates = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                AppDataFolders.AppName,
                "Folder Templates"
                );
            AppDataFolders.LogFile = Path.Combine(
                AppDataFolders.Folders.Logs,
                AppDataFolders.AppName + " " + DateTime.Now.ToString("MM-dd-yyyy") + ".log");

            CompileFieldList();

            return true;
        }

        /// <summary>
        /// Compiles field list from txt file to usable lists.
        /// </summary>
        public static void CompileFieldList()
        {
            List<List<string>> ret = new List<List<string>> { };

            string directory = Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                "TemplateDocs",
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

            directory = Path.Combine(
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                "TemplateDocs",
                "City reference.txt"
            );

            Dictionary<string, string[]> dick = new Dictionary<string, string[]>();
            foreach (string line in File.ReadAllLines(directory))
            {
                string[] parts = line.Split(',');
                string city = parts[0].ToLower();
                string[] info = new string[] { parts[1], parts[3] };
                try
                {
                    dick.Add(city, info);
                }
                catch
                {

                }
            }
            CityReference = dick;
        }
    }
}
