using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDG_Core;

namespace STB
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ExitProgram(object sender, EventArgs e)
        {
            //TODO: Add check-for-unsaved feature
            Application.Exit();
        }

        private void LoadApp(object sender, EventArgs e)
        {
            Log.AddInfo("Program successfully laoded");
        }

        private void ConvertToLatLong(object sender, EventArgs e)
        {
            TabPage page = new TabPage
            {
                Name = "TabConvertLatLong",
                Text = TabName("Convert Lat Long"),
                AutoScroll = true
            };
            UC.ConvertLatLong convert = new UC.ConvertLatLong
            {
                Dock = DockStyle.Fill
            };

            page.Controls.Add(convert);
            TabControl.TabPages.Add(page);
            TabControl.SelectedIndex = TabControl.TabPages.IndexOf(page);
            Log.AddInfo("Converter loaded in main form.");
        }

        private string TabName(string Name)
        {
            if (Name.Length <= 20)
            {
                return Name;
            }
            else
            {
                return Name.Substring(0, 20);
            }
        }
    }
}
