using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using MDG_Core;

namespace ConvertLatLong
{
    class Program
    {
        public static string JobNumber = "";
        public static int PointNumber = 0;
        static void Main(string[] args)
        {
            Console.Title = "Lat Long Converter " + Assembly.GetExecutingAssembly().GetName().Version;
            var arguments = args.ToList();
            if (arguments.Count() < 1)
            {
                //Logging.AddErrorToLog("Please drag a file onto this program to start.");
                Environment.Exit(-1);
                return;
            }
            if (arguments.Count() != 1 && arguments.Count() != 3)
            {
                //Logging.AddErrorToLog("An invalid number of parameters was passed. (" + arguments.Count() + ")");
                Environment.Exit(-1);
                return;
            }
            if (arguments[0].Substring(arguments[0].Length - 4) != ".txt")
            {
                //Logging.AddErrorToLog("File provided is not a text file, please provide a text file.");
                Environment.Exit(-1);
                return;
            }
            if (arguments.Count() == 1)
            {
                arguments.Add("");
                arguments.Add("1000");
            }
            ProcessFile(arguments);
            Console.ReadKey();
        }
       
        static string ConvertJobNumberToPath(string JobNumber)
        {
            string path = "Z:\\";
            string[] parts = JobNumber.Split('-');
            if (parts[0].Length == 2)
            {
                parts[0] = "20" + parts[0];
            }
            path = Path.Combine(
                path,
                parts[0],
                parts[1] + "-" + parts[0],
                parts[1] + "-" + parts[2]
            );
            return path;
        }

        static void ProcessFile(List<string> args)
        {
            string file = args[0];
            string jobNo = args[1];
            int PointNo = Convert.ToInt32(args[2]);

            if (PointNumber == 0 && PointNo > 0)
            {
                PointNumber = PointNo;
            } else
            {
                if (PointNumber <= 0)
                {
                    PointNumber = 1000;
                }
            }

            var parsed = HandleParsing(file);

            string path = Path.GetDirectoryName(file) + "\\" + Path.GetFileNameWithoutExtension(file) + "_convert " + DateTime.Now.ToString("MM-dd-yy") + ".txt";
            if (!string.IsNullOrEmpty(jobNo))
            {
                path = Path.Combine(ConvertJobNumberToPath(jobNo), Path.GetFileName(path));
            }
            File.WriteAllLines(path, parsed);
            Environment.Exit(1);
        }
        
        static List<string> HandleParsing(string path)
        {
            StreamReader reader = new StreamReader(path);

            int lineIndex = 0;
            int lineNumber = 0;
            List<string> parsed = new List<string>();
            string line;
            string parsedLine = "";
            while ((line = reader.ReadLine()) != null)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    switch (lineIndex)
                    {
                        case 0:
                            {
                                parsedLine = PointNumber + lineNumber + "," + line.Replace("\"N ", ",-").Replace("\"W", ",").Replace("°", "-").Replace("\'", "-");
                                lineIndex++;
                                break;
                            }
                        case 1:
                            {
                                lineIndex++;
                                break;
                            }
                        case 2:
                            {
                                parsedLine += line.Substring(1, line.Length - 2);
                                Console.WriteLine(parsedLine);
                                parsed.Add(parsedLine);
                                lineNumber++;
                                lineIndex = 0;
                                break;
                            }
                    }
                }
            }
            reader.Close();
            return parsed;
        }
    }
}
