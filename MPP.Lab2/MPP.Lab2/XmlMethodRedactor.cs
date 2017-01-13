using System.Collections.Generic;
using System.Windows.Forms;

namespace MPP.Lab2
{
    public partial class XmlMethodRedactor : Form
    {
        public XmlMethodRedactor()
        {
            InitializeComponent();
        }
        public void  TextBoxFill (string methodname, string time, string package, string paramscount)
        {
            nameValue.Text = methodname;
            timeValue.Text = time;
            packagevalue.Text = package;
            paramscountvalue.Text = paramscount;
        }
        public void LockedTextBoxFill (string methodname, string time, string package, string paramscount)
        {
            Methodname.Text = methodname;
            Time.Text = time;
            Package.Text = package;
            Paramscount.Text = paramscount;
        }
        public  List<string> RedactoredValueList()
        {
            List<string> strlist = new List<string> { };
            strlist.Add(nameValue.Text);
            strlist.Add(timeValue.Text);
            strlist.Add(packagevalue.Text);
            strlist.Add(paramscountvalue.Text);
            return strlist;
        }
        public  List<string> RedactoredHeaderList()
        {
            List<string> strlist = new List<string> { };
            strlist.Add(Methodname.Text);
            strlist.Add(Time.Text);
            strlist.Add(Package.Text);
            strlist.Add(Paramscount.Text);
            return strlist;
        }

        private void timeValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Close();
            }
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void paramscountvalue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Close();
            }
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void XmlMethodRedactor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (paramscountvalue.Text == "")
            {
                paramscountvalue.Text = "0";
            }
            if (packagevalue.Text == "")
            {
                packagevalue.Text = "empty";
            }
            if (nameValue.Text == "")
            {
                nameValue.Text = "empty";
            }
            if (timeValue.Text == "")
            {
                timeValue.Text = "0";
            }
        }

        private void nameValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Close();
            }
        }

        private void packagevalue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Close();
            }
        }
    }
}
