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
using System.Reflection;
using System.IO;

namespace STB
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            if (Properties.Settings.Default.FirstStart)
            {
                Directory.CreateDirectory(GVars.AppDataFolders.Folders.LocalAppData);
                Directory.CreateDirectory(GVars.AppDataFolders.Folders.Logs);
                Settings settings = new Settings();
                settings.Show();
            }
            GVars.UsernameFull = Properties.Settings.Default.UserFull;
            GVars.UsernameInitials = Properties.Settings.Default.UserInitials;
            GVars.DriveLetter = Properties.Settings.Default.DriveLetter;
        }

        private void ExitProgram(object sender, EventArgs e)
        {
            //TODO: Add check-for-unsaved feature
            Application.Exit();
        }

        private void MinimizeProgram(object s, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaximizeProgram(object s, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        //Handle dragging from label
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MoveTitle(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        const int _ = 10; // you can rename this variable if you like

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        Rectangle Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

#pragma warning restore CS0108 // Member hides inherited member; missing new keyword

        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }

        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }


        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }

        private void ViewJob(object sender, EventArgs e)
        {
            CreateJobFolder.JobViewer viewer = new CreateJobFolder.JobViewer
            {
                BackColor = GVars.ActivePallete.Background,
                Dock = DockStyle.Fill
            };
            if (PanelMain.Controls.Count > 0)
            {
                string name = PanelMain.Controls[0].Name;
                Log.AddInfo(string.Format("Removed \"{0}\" from panel.", name));
                PanelMain.Controls.RemoveAt(0);
            }
            PanelMain.Controls.Add(viewer);
        }

        private void NewJob(object sender, EventArgs e)
        {
            CreateJobFolder.CreateJobFolder viewer = new CreateJobFolder.CreateJobFolder
            {
                BackColor = GVars.ActivePallete.Background,
                Dock = DockStyle.Fill
            };
            if (PanelMain.Controls.Count > 0)
            {
                string name = PanelMain.Controls[0].Name;
                Log.AddInfo(string.Format("Removed \"{0}\" from panel.", name));
                PanelMain.Controls.RemoveAt(0);
            }
            PanelMain.Controls.Add(viewer);
        }

        private void ConvertLatLong(object sender, EventArgs e)
        {
            UC.ConvertLatLong viewer = new UC.ConvertLatLong
            {
                BackColor = GVars.ActivePallete.Background,
                Dock = DockStyle.Fill
            };
            if (PanelMain.Controls.Count > 0)
            {
                string name = PanelMain.Controls[0].Name;
                Log.AddInfo(string.Format("Removed \"{0}\" from panel.", name));
                PanelMain.Controls.RemoveAt(0);
            }
            PanelMain.Controls.Add(viewer);
        }

        private void HandleKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                ViewJob(this, new EventArgs());
            }
            if (e.KeyCode == Keys.F2)
            {
                NewJob(this, new EventArgs());
            }
        }

        //Actual code I wrote.
        private void LoadApp(object sender, EventArgs e)
        {
            IntFunctions.AlignandColor(CmdClose, CmdMaximize, CmdMinimize, Lbltitle, this);
            Log.AddInfo("Program successfully laoded");
            this.AcceptButton = new Button();
            this.CancelButton = new Button();
            KeyPreview = true;
        }
        
        private void OpenJob(object sender, EventArgs e)
        {
            OpenFolder.OpenFolderLocation(TxtJobNumber.Text);
        }

        private void CheckKeyPress(object sender, KeyEventArgs e)
        {
            if (!TxtJobNumber.Focused)
            {
                return;
            }
            if (e.KeyCode == Keys.Enter)
            {
                OpenJob(this, new EventArgs());
                TxtJobNumber.Text = string.Empty;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                TxtJobNumber.Text = string.Empty;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void OpenSettingsDialog(object s, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }
    }

    public class IntFunctions
    {
        public static void AlignandColor(Button CloseButton,  Button MaxButton, Button MinButton, Label Title, Form Window)
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

            //Min and Max buttons
            Button[] buttons = new Button[] { MaxButton, MinButton };
            foreach (Button btn in buttons)
            {
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = GVars.ActivePallete.Highlight;
                btn.FlatAppearance.MouseDownBackColor = GVars.ActivePallete.Highlight;
                btn.ForeColor = GVars.ActivePallete.Text;
                btn.BackColor = GVars.ActivePallete.Background;
            }

            //Setting location of min and max
            MaxButton.Location = new Point(CloseButton.Location.X - MaxButton.Size.Width, 0);
            MinButton.Location = new Point(MaxButton.Location.X - MinButton.Size.Width, 0);
            ProcessedControls.Add(MinButton);
            ProcessedControls.Add(MaxButton);

            //Title label
            Title.TextAlign = ContentAlignment.MiddleCenter;
            Title.Text = Window.Text + " " + Assembly.GetExecutingAssembly().GetName().Version;
#if DEBUG
            Title.Text += " [DEBUG]";
#endif
            Title.BackColor = GVars.ActivePallete.Background;
            Title.ForeColor = GVars.ActivePallete.Text;
            Title.Location = new Point(0, 0);
            Title.Size = new Size(Window.Width - CloseButton.Width - MaxButton.Width - MinButton.Width, MinButton.Height);
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
