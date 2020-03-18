using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDG_Core
{
    public partial class StringInput : Form
    {
        public string Input { get; set; }

        public StringInput()
        {
            InitializeComponent();
        }

        public StringInput(string title, string description, Icon icon)
        {
            InitializeComponent();

            this.label1.Text = title;
            this.Text = description;
            if (icon == null)
            {
                ShowIcon = false;
            }
            else
            {
                Icon = icon;
            }
        }

        public StringInput(string Message)
        {
            InitializeComponent();

            this.label1.Text = Message;
        }

        private void AcceptInput(object sender, EventArgs e)
        {
            Input = TxtValue.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CmdClose(object sender, EventArgs e)
        {
            Input = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public static DialogResult Show(string Message)
        {
            // using construct ensures the resources are freed when form is closed
            using (var form = new StringInput(Message, "Input", SystemIcons.Information))
            {
                return form.ShowDialog();
            }
        }
        public static DialogResult Show(string Message, string Title)
        {
            // using construct ensures the resources are freed when form is closed
            using (var form = new StringInput(Message, Title, SystemIcons.Information))
            {
                return form.ShowDialog();
            }
        }
        public static DialogResult Show(string Message, string Title, Icon Icon)
        {
            // using construct ensures the resources are freed when form is closed
            using (var form = new StringInput(Message, Title, Icon))
            {
                return form.ShowDialog();
            }
        }
    }
}
