using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MDG_Core
{
    /// <summary>
    /// Custom converter functions.
    /// </summary>
    public class Converter
    {
        /// <summary>
        /// Checks Input to determine if it is a good job number (format wise).
        /// </summary>
        /// <param name="Input">String to check.</param>
        /// <returns>Formatted job number in yyyy-mm-jjj format or empty if failed format.</returns>
        public static string ToJobNumber(string Input)
        {
            return ToJobNumber(Input, false);
        }

        /// <summary>
        /// Checks Input to determine if it is a good job number (format wise).
        /// </summary>
        /// <param name="Input">String to check.</param>
        /// <param name="ShortYear">True to return only last two digits for year. False for full year.</param>
        /// <returns>Formatted job number in yyyy-mm-jjj format or empty if failed format.</returns>
        public static string ToJobNumber(string Input, bool ShortYear)
        {
            string shortNoHyphans = @"^\d{7}$";
            string longNoHyphans = @"^\d{9}$";
            string shortHyphans = @"^\d{2}-\d{2}-\d{3}";
            string longHyphans = @"^\d{4}-\d{2}-\d{3}";

            //if the input format isnt even a valid format.
            if (
                !Regex.IsMatch(Input, shortNoHyphans) &&
                !Regex.IsMatch(Input, longNoHyphans) &&
                !Regex.IsMatch(Input, shortHyphans) &&
                !Regex.IsMatch(Input, longHyphans)
            )
            {
                return "";
            }
            string output = "";
            if (Regex.IsMatch(Input, shortNoHyphans))
            {
                Log.ToDebug("Converted Input from short (no hypans) to full job number");
                if (ShortYear)
                {
                    output = Input.Insert(2, "-").Insert(5, "-");
                }
                else
                {
                    output = Input.Insert(2, "-").Insert(5, "-").Insert(0, "20");
                }
            }
            else if (Regex.IsMatch(Input, longNoHyphans))
            {
                Log.ToDebug("Converted Input from long (no hypans) to full job number");
                if (ShortYear)
                {
                    output = Input.Insert(4, "-").Insert(7, "-").Remove(0,2);
                }
                else
                {
                    output = Input.Insert(4, "-").Insert(7, "-");
                }
            }
            else if (Regex.IsMatch(Input, shortHyphans))
            {
                Log.ToDebug("Converted Input from short (with hypans) to full job number");
                if (ShortYear)
                {
                    output = Input;
                }
                else
                {
                    output = Input.Insert(0, "20");
                }
            }
            else if (Regex.IsMatch(Input, longHyphans))
            {
                Log.ToDebug("Input is long (no hypans), a full job number");
                if (ShortYear)
                {
                    output = Input.Remove(0, 2);
                }
                else
                {
                    output = Input;
                }
            }
            if (string.IsNullOrEmpty(output))
            {
                return output;
            }
            else
            {
                string year = output.Split('-')[0];
                string month = output.Split('-')[1];
                if (DateTime.TryParse(month + "/15/" + year, out DateTime yearD))
                {
                    if (yearD.Year > DateTime.Now.Year)
                    {
                        MessageBox.Show("The job number provided contains a year that is later than this year.", "Formatting Error");
                        return "";
                    }
                    return output;
                }
                else
                {
                    MessageBox.Show("The job number provided contains a month that is not an actual month.", "Formatting Error");
                    return "";
                }
            }
        }

        /// <summary>
        /// Converts inputed job number into file path.
        /// </summary>
        /// <param name="Input">Formatted job number in yyyy-mm-jjj format.</param>
        /// <returns>Path to job folder.</returns>
        public static string JobNumberToPath(string Input)
        {
            string outp = "";

#if LAPTOP
            outp = GVars.DriveLetter + "\\";
#elif DEBUG
            outp = @"C:\Users\Nathan White\Documents\Test";
#else
            outp = GVars.DriveLetter + "\\";;
#endif
            string[] components = Input.Split('-');
            outp = Path.Combine(
                outp,
                components[0],
                components[1] + "-" + components[0],
                components[1] + "-" + components[2]
                );

            return outp;
        }
    }
}
