﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;

namespace MDG_Core
{
    public class Converter
    {
        public static string ToJobNumber(string Input)
        {
            Log.ToDebug("Checking " + Input + " for job number compatibility.");
            string shortNoHyphans = @"^\d{7}$";
            string longNoHyphans = @"^\d{9}$";
            string shortHyphans = @"^\d{2}-\d{2}-\d{3}";
            string longHyphans = @"^\d{4}-\d{2}-\d{3}";

            string output = "";
            if (
                !Regex.IsMatch(Input, shortNoHyphans) &&
                !Regex.IsMatch(Input, longNoHyphans) &&
                !Regex.IsMatch(Input, shortHyphans) &&
                !Regex.IsMatch(Input, longHyphans)
            )
            {
                Log.ToDebug("Input does not match any format.");
                return output;
            }
            if (Regex.IsMatch(Input, shortNoHyphans))
            {
                Log.ToDebug("Converted Input from short (no hypans) to full job number");
                output = Input.Insert(2, "-").Insert(5, "-").Insert(0, "20");
                return output;
            }
            if (Regex.IsMatch(Input, longNoHyphans))
            {
                Log.ToDebug("Converted Input from long (no hypans) to full job number");
                output = Input.Insert(4, "-").Insert(7, "-");
                return output;
            }
            if (Regex.IsMatch(Input, shortHyphans))
            {
                Log.ToDebug("Converted Input from short (with hypans) to full job number");
                output = Input.Insert(0, "20");
                return output;
            }
            if (Regex.IsMatch(Input, shortNoHyphans))
            {
                Log.ToDebug("Input is long (no hypans), a full job number");
                output = Input;
                return output;
            }
            return output;
        }
    }
}
