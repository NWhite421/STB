using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDG_Core
{
    public class Log
    {
        /// <summary>
        /// Send a message to the debug console. Will not log anything in release.
        /// </summary>
        /// <param name="Message">Message to display.</param>
        /// <param name="StackTrace">Return of GetStackTrace()</param>
        public static void ToDebug(string Message)
        {
#if DEBUG
            Debug.WriteLine(Functions.FormatString(Message, "DEBUG"));
#else
            return;
#endif
        }

        /// <summary>
        /// Send a message to the debug console. Will not log anything in release.
        /// </summary>
        /// <param name="Message">Message to display.</param>
        /// <param name="Level">Level of severity (overrides 'DEBUG')</param>
        /// <param name="StackTrace">Return of GetStackTrace()</param>
        public static void ToDebug(string Message, string Level)
        {
#if DEBUG
            //If an empty string is passed through the level param, execute regular ToDebug function.
            if (string.IsNullOrEmpty(Level))
            {
                ToDebug(Message);
                return;
            }
            //Add formatted string to debug.
            Debug.WriteLine(Functions.FormatString(Message, Level));
#else
            return;
#endif
        }

        /// <summary>
        /// Send a message to the log file and gives the entry an 'INFO' tag.
        /// </summary>
        /// <param name="Message">Message to display.</param>
        /// <param name="StackTrace">Return of GetStackTrace()</param>
        public static void AddInfo(string Message)
        {
#if DEBUG
            ToDebug(Message, "Info");
#else
            //TODO
#endif
        }
        
        /// <summary>
        /// Send a message to the log file and gives the entry an 'WARNING' tag.
        /// </summary>
        /// <param name="Message">Message to display.</param>
        /// <param name="StackTrace">Return of GetStackTrace()</param>
        public static void AddWarning(string Message)
        {
#if DEBUG
            ToDebug(Message, "Warning");
#else
            //TODO
#endif
        }


        /// <summary>
        /// Send a message to the log file and gives the entry an 'ERROR' tag.
        /// </summary>
        /// <param name="Message">Message to display.</param>
        /// <param name="StackTrace">Return of GetStackTrace()</param>
        public static void AddError(string Message)
        {
#if DEBUG
            ToDebug(Message, "Error");
#else
            //TODO
#endif
        }
    }

    /// <summary>
    /// Internal functions of MDG_Core.Log
    /// </summary>
    internal class Functions 
    {
        public static string ConvertStackTrace(string[] Source)
        {
            return string.Concat(Source[0], ".", Source[1], ".", Source[2]);
        }

        /// <summary>
        /// Format provided string with prefix.
        /// </summary>
        /// <param name="Message">Message to format.</param>
        /// <param name="Level">level of severity.</param>
        /// <returns></returns>
        public static string FormatString(string Message, string Level)
        {
            
            return string.Format("{0}[{1}]: {2}", GetDateTime(true).ToUpper(), Level.ToUpper(), Message);
        }

        /// <summary>
        /// Return a string with the current date and time (without brackets)
        /// </summary>
        /// <returns>Date time in 12-31-1999 12-59-58 am</returns>
        private static string GetDateTime()
        {
            return DateTime.Now.ToString("MM-dd-yyyy hh-mm-ss tt");
        }

        /// <summary>
        /// Return a string with the current date and time.
        /// </summary>
        /// <param name="Brackets">Include brackets surrounding date time.</param>
        /// <returns>Date time in 12-31-1999 12-59-58 am</returns>
        private static string GetDateTime(bool Brackets)
        {
            if (Brackets)
            {
                return "[" + DateTime.Now.ToString("MM-dd-yyyy hh-mm-ss tt") + "]";
            }
            return GetDateTime();
        }
    }

}
