using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDG_Core;

namespace STB.UC
{
    public partial class NewJobFolder : UserControl
    {
        public NewJobFolder()
        {
            InitializeComponent();
        }

        private void LoadForm(object s, EventArgs e)
        {
            Common.AlignandColor(this);
        }
    }
}
