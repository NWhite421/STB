using System;
using System.Diagnostics;

namespace ProgramLogging
{
    public class Logging
    {
        private static string GetDateTime()
        {
            return "[" + DateTime.Now.ToString("MM-dd-yyyy HH-mm-ss tt") + "]";
        }

        public static void AddToDebug(string Message)
        {
            string formattedMessage = GetDateTime() + "[DEBUG]: " + Message;
            Debug.WriteLine(formattedMessage);
        }

        public static void AddToLog(string Message)
        {
#if DEBUG
            string formattedMessage = GetDateTime() + "[INFO]: " + Message;
            Debug.WriteLine(formattedMessage);
#else
            //TODO: Add actual logging
#endif
        }

        public static void AddWarningToLog(string Message)
        {
#if DEBUG
            string formattedMessage = GetDateTime() + "[WARNING]: " + Message;
            Debug.WriteLine(formattedMessage);
#else
            //TODO: Add actual logging
#endif
        }

        public static void AddErrorToLog(string Message)
        {
#if DEBUG
            string formattedMessage = GetDateTime() + "[ERROR]: " + Message;
            Debug.WriteLine(formattedMessage);
#else
            //TODO: Add actual logging
#endif
        }
    }
}
