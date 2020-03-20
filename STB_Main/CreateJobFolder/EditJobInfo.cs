using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MDG_Core;

namespace CreateJobFolder
{
    public partial class EditJobInfo : Form
    {
        public XDocument XMLDocument { get; set; }

        //internal static XElement Information { get; set; }

        public EditJobInfo(string Job)
        {
            InitializeComponent();
            FormFunctions.AlignandColor(this);

            XDocument doc = XDocument.Load(Job);
            XMLDocument = doc;
            var info = doc.Root.Element("Information");
            try
            {
                TxtJobNumber.Text = TryElement(info, "JobNumber");
                TxtCommonName.Text = TryElement(info, "CommonName");
                TxtParcel.Text = TryElement(info, "Parcel");
                TxtAddress.Text = TryElement(info, "Address");
                TxtCity.Text = TryElement(info, "City");
                TxtCounty.Text = TryElement(info, "County");
                TxtZone.Text = TryElement(info, "SPZ");
            }
            catch
            {

            }
        }

        public void TextboxExit(object s, EventArgs e)
        {
            var control = (TextBox)s;
            var name = control.Name;
            switch (name.ToLower())
            {
                case "txtcommonname":
                {
                    AssignValueToElement("CommonName", TxtCommonName.Text);
                    break;
                }
                case "txtparcel":
                    {
                        AssignValueToElement("Parcel", TxtParcel.Text);
                        break;
                    }
                case "txtaddress":
                    {
                        AssignValueToElement("Address", TxtAddress.Text);
                        break;
                    }
                case "txtcity":
                    {
                        string city = TxtCity.Text.Replace("Saint ", "St").Replace(".","");
                        try
                        {
                            string citylc = city.ToLower();
                            string[] info = GVars.CityReference[citylc];
                            AssignValueToElement("City", city);
                            TxtCounty.Text = info[0];
                            TxtZone.Text = info[1];
                            AssignValueToElement("County", info[0]);
                            AssignValueToElement("SPZ", info[1]);
                        }
                        catch
                        {
                            MessageBox.Show("The city entered does not exist. (If using \"Saint\", use St instead).");
                        }
                        break;
                    }
            }
        }

        private void AssignValueToElement(string element, string value)
        {
            XMLDocument.Root.Element("Information").Element(element).Value = value;
        }

        private string TryElement(XElement element, string search)
        {
            string ret = "";
            try
            {
                string value = element.Element(search).Value;
                if (string.IsNullOrEmpty(value))
                {
                    return ret;
                }
                else
                {
                    return value;
                }
            }
            catch
            {

                return ret;
            }
        }

        private void SaveInfo(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelJob(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
