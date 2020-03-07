using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MDG_Core
{
    public class GVars
    {
        public static ColorPallete ActivePallete;

        public static List<UCModule> Modules;

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

            return true;
        }
    }
}
