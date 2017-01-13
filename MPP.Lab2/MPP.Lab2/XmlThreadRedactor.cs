using System.Collections.Generic;
using System.Windows.Forms;

namespace MPP.Lab2
{
    public partial class XmlThreadRedactor : Form
    {
        public XmlThreadRedactor()
        {
            InitializeComponent();
        }
        public void TextBoxFill(string threadid, string time)
        {
            Threadidvalue.Text = threadid;
            TimeValue.Text = time;
        }
        public void LockedTextBoxFill(string threadid, string time)
        {
            ThreadId.Text = threadid;
            Time.Text = time;
        }
        public List<string> RedactoredValueList ()
        {
            List<string> strlist = new List<string> { };
            strlist.Add(Threadidvalue.Text);
            strlist.Add(TimeValue.Text);
            return strlist;
        }
        public List<string> RedactoredHeaderList()
        {
            List<string> strlist = new List<string> { };
            strlist.Add(ThreadId.Text);
            strlist.Add(Time.Text);
            return strlist;
        }

        private void Threadidvalue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TimeValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void XmlThreadRedactor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Threadidvalue.Text == "")
            {
                Threadidvalue.Text = "empty";
            }
            if (TimeValue.Text == "")
            {
                TimeValue.Text = "0";
            }
        }
    }
}
