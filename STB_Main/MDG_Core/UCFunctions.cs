using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDG_Core
{
    public class UCFunctions
    {
        public static void AlignandColor(UserControl Window)
        {
            List<Control> ProcessedControls = new List<Control> { };
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
                        case "maskedtextbox":
                            {
                                var txtbox = (MaskedTextBox)control;
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
                                    Size = new Size(txtbox.Width, 2),
                                    Anchor = txtbox.Anchor
                                };
                                Window.Controls.Add(underline);

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
                                    Size = new Size(txtbox.Width, 2),
                                    Anchor = txtbox.Anchor
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
                        case "treeview":
                            {
                                var trv = (TreeView)control;
                                trv.BackColor = GVars.ActivePallete.Background;
                                trv.ForeColor = GVars.ActivePallete.Text;
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
