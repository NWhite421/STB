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

namespace CreateJobFolder
{
    public partial class CreateJobFolder: UserControl
    {
        public CreateJobFolder()
        {
            InitializeComponent();
        }

        private void LoadForm(object s,EventArgs e)
        {
            UCFunctions.AlignandColor(this);
        }
    }
}
