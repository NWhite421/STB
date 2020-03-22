using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MDG_Core
{
    public class XML
    {
        /// <summary>
        /// Checks the parent<paramref name="element"/> for a child element <paramref name="value"/>.
        /// </summary>
        /// <param name="element">Parent element with children nodes.</param>
        /// <param name="value">Element name of a child node.</param>
        /// <returns>Returns value of <paramref name="value"/> node or empty string if <paramref name="value"/> doesn't exist.</returns>
        public static string GetElementValue(XElement element, string value)
        {
            string ret = "";

            if (!element.HasElements || string.IsNullOrEmpty(value))
            {
                return ret;
            }

            return element.Element(value).Value;
        }

        /// <summary>
        /// Checks the parent<paramref name="element"/> for a child element <paramref name="value"/>.
        /// </summary>
        /// <param name="element">Parent element with children nodes.</param>
        /// <param name="value">Element name of a child node.</param>
        /// <param name="defaultValue">Default string if no value was found.</param>
        /// <returns>Returns value of <paramref name="value"/> node or <paramref name="defaultValue"/> if <paramref name="value"/> doesn't exist.</returns>
        public static string GetElementValue(XElement element, string value, string defaultValue)
        {
            string ret = defaultValue;

            if (!element.HasElements || string.IsNullOrEmpty(value))
            {
                return ret;
            }

            string val = element.Element(value).Value;
            if (string.IsNullOrEmpty(val))
            {
                return ret;
            }
            else
            {
                return val;
            }
        }
    }
}
