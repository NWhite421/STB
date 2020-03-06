using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDG_Core
{
    [Obsolete]
    public class Logging
    {
        

        public static void AddToDebug(string Message)
        {
            Log.AddWarning("Obsolete function Logging.AddToDebug used", Log.GetStackTrace());
            /*string formattedMessage = GetDateTime() + "[DEBUG]: " + Message;
            Debug.WriteLine(formattedMessage);*/
        }

        public static void AddToLog(string Message)
        {
#if DEBUG
            Log.AddWarning("Obsolete function Logging.AddToLog used", Log.GetStackTrace());
            //string formattedMessage = GetDateTime() + "[INFO]: " + Message;
            //Debug.WriteLine(formattedMessage);
#else
            //TODO: Add actual logging
#endif
        }

        public static void AddWarningToLog(string Message)
        {
#if DEBUG
            Log.AddWarning("Obsolete function Logging.AddWarningToLog used", Log.GetStackTrace());
            //string formattedMessage = GetDateTime() + "[WARNING]: " + Message;
            //Debug.WriteLine(formattedMessage);
#else
            //TODO: Add actual logging
#endif
        }

        public static void AddErrorToLog(string Message)
        {
#if DEBUG
            Log.AddWarning("Obsolete function Logging.AddErrorToLog used", Log.GetStackTrace());
            //string formattedMessage = GetDateTime() + "[ERROR]: " + Message;
            //Debug.WriteLine(formattedMessage);
#else
            //TODO: Add actual logging
#endif
        }
    }
}
