using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDG_Core;

namespace STB
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            AlignandColor(CmdClose, Lbltitle, this);
        }

        private void ExitProgram(object sender, EventArgs e)
        {
            Close();
        }
        
        private void LoadApp(object s, EventArgs e)
        {
            TxtNameFull.Text = Properties.Settings.Default.UserFull;
            TxtNameInitials.Text = Properties.Settings.Default.UserInitials;
            CmbDrive.SelectedItem = Properties.Settings.Default.DriveLetter;
        }

        private void ComputeInitials(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNameFull.Text))
            {
                return;
            }
            string[] parts = TxtNameFull.Text.Split(' ');
            string initials = "";
            foreach (string part in parts)
            {
                initials += part[0];
            }
            TxtNameInitials.Text = initials;
        }

        private void SaveButton(object s, EventArgs e)
        {
            Properties.Settings.Default.UserFull = TxtNameFull.Text;
            Properties.Settings.Default.UserInitials = TxtNameInitials.Text;
            Properties.Settings.Default.DriveLetter = CmbDrive.GetItemText(CmbDrive.SelectedItem);
            Properties.Settings.Default.FirstStart = false;
            Properties.Settings.Default.Save();
            ExitProgram(this, new EventArgs());
        }

        public static void AlignandColor(Button CloseButton, Label Title, Form Window)
        {
            List<Control> ProcessedControls = new List<Control> { };

            //Close button
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseOverBackColor = Color.Red;
            CloseButton.FlatAppearance.MouseDownBackColor = Color.Red;
            CloseButton.ForeColor = GVars.ActivePallete.Text;
            CloseButton.BackColor = GVars.ActivePallete.Background;
            CloseButton.Location = new Point(Window.Size.Width - CloseButton.Size.Width, 0);
            ProcessedControls.Add(CloseButton);
            
            //Title label
            Title.TextAlign = ContentAlignment.MiddleCenter;
            Title.Text = "Program Settings";
#if DEBUG
            Title.Text += " [DEBUG]";
#endif
            Title.BackColor = GVars.ActivePallete.Background;
            Title.ForeColor = GVars.ActivePallete.Text;
            Title.Location = new Point(0, 0);
            Title.Size = new Size(Window.Width - CloseButton.Width, CloseButton.Height);
            Title.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            ProcessedControls.Add(Title);

            Window.BackColor = GVars.ActivePallete.Background;

            //Handle all other controls.
            foreach (Control control in Window.Controls)
            {
                Log.ToDebug(control.Name + " | " + control.Text + " | " + control.GetType().ToString());
                if (!ProcessedControls.Contains(control))
                {
                    switch (control.GetType().Name.ToLower())
                    {
                        case "label":
                            {
                                var lbl = (Label)control;
                                lbl.BackColor = GVars.ActivePallete.Background;
                                lbl.ForeColor = GVars.ActivePallete.Text;
                                ProcessedControls.Add(lbl);
                                break;
                            }
                        case "textbox":
                            {
                                var txtbox = (TextBox)control;
                                txtbox.BorderStyle = BorderStyle.None;
                                txtbox.BackColor = GVars.ActivePallete.Background;
                                txtbox.ForeColor = GVars.ActivePallete.Text;
                                txtbox.Height += 2;
                                ProcessedControls.Add(txtbox);
                                Label underline = new Label
                                {
                                    BorderStyle = BorderStyle.None,
                                    BackColor = GVars.ActivePallete.Foreground,
                                    AutoSize = false,
                                    Location = new Point(txtbox.Location.X, txtbox.Location.Y + txtbox.Height + 1),
                                    Size = new Size(txtbox.Width, 2)
                                };
                                Window.Controls.Add(underline);

                                break;
                            }
                        case "button":
                            {
                                var btn = (Button)control;
                                btn.FlatStyle = FlatStyle.Flat;
                                btn.FlatAppearance.BorderSize = 1;
                                btn.FlatAppearance.BorderColor = GVars.ActivePallete.Foreground;
                                btn.FlatAppearance.MouseOverBackColor = GVars.ActivePallete.Foreground;
                                btn.FlatAppearance.MouseDownBackColor = GVars.ActivePallete.Highlight;
                                btn.BackColor = GVars.ActivePallete.Background;
                                btn.ForeColor = GVars.ActivePallete.Text;
                                btn.Font = new Font(btn.Font.FontFamily.Name, 10);
                                btn.Text = btn.Text.ToUpper();

                                break;
                            }
                        case "listbox":
                            {
                                var lstbox = (ListBox)control;
                                lstbox.BorderStyle = BorderStyle.FixedSingle;
                                lstbox.BackColor = GVars.ActivePallete.Background;
                                lstbox.ForeColor = GVars.ActivePallete.Text;
                                break;
                            }
                        case "panel":
                            {
                                var pnl = (Panel)control;
                                pnl.BorderStyle = BorderStyle.FixedSingle;
                                pnl.BackColor = GVars.ActivePallete.Background;
                                break;
                            }
                        case "combobox":
                            {
                                var cmb = (ComboBox)control;
                                cmb.FlatStyle = FlatStyle.Flat;
                                cmb.ForeColor = GVars.ActivePallete.Text;
                                cmb.BackColor = GVars.ActivePallete.Background;
                                cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                                break;
                            }
                    }
                }
                else
                {
                    Log.ToDebug("Control already processed.");
                }
            }
        }
    }
}
