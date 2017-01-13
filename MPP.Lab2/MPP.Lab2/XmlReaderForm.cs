using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace MPP.Lab2
{
    public partial class XmlReaderForm : Form
    {
        List<TreeView> TreeViewList = new List<TreeView> { };
        int firsttime = 0;
        public XmlReaderForm()
        {
            InitializeComponent();
        }
        private void XmlPages_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "+")
            {
                string TabPageName = "XmlPage" + (XmlPages.TabCount + 1).ToString();
                TabPage newTabPage = new TabPage(TabPageName);
                newTabPage.Name = TabPageName;
                TreeView newTreeView = new TreeView();
                newTreeView.Height = 354;
                newTreeView.Width = 565;
                TreeViewList.Add(newTreeView);
                newTreeView.Parent = newTabPage;
                XmlPages.TabPages.Add(newTabPage);
                XmlPages.TabPages[XmlPages.TabCount - 1].UseVisualStyleBackColor = true;
                FileToolStripMenuItem.Enabled = true;
                OpenToolStripMenuItem.Enabled = true;
            }
            if (e.KeyChar.ToString() == "-")
            {
                if (XmlPages.TabCount > 0)
                {
                    TreeViewList.RemoveAt(TreeViewList.Count -1);
                    XmlPages.TabPages[XmlPages.TabCount - 1].Dispose();
                }
                if (XmlPages.TabCount == 0)
                {
                    FileToolStripMenuItem.Enabled = false;
                    SaveASToolStripMenuItem.Enabled = false;
                }
            }
        }
        

        private void XmlReaderForm_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            firsttime = TimeParse(TreeViewList[XmlPages.SelectedIndex].SelectedNode);
            List<string> stringHeader = MethodTextParcer(TreeViewList[XmlPages.SelectedIndex].SelectedNode.Text, 1);
            List<string> stringValue = MethodTextParcer(TreeViewList[XmlPages.SelectedIndex].SelectedNode.Text, 2);
            if (stringHeader[0] == "2" && stringValue[0] == "2")
            {
                XmlThreadRedactor threadredactor = new XmlThreadRedactor();
                threadredactor.TextBoxFill(stringValue[1], stringValue[2]);
                threadredactor.LockedTextBoxFill(stringHeader[1], stringHeader[2]);
                threadredactor.Show();
                threadredactor.FormClosed += Threadredactor_FormClosed;
            }
            if (stringHeader[0] == "1" && stringValue[0] == "1")
            {
                XmlMethodRedactor methodredactor = new XmlMethodRedactor();
                methodredactor.TextBoxFill(stringValue[1], stringValue[2], stringValue[3], stringValue[4]);
                methodredactor.LockedTextBoxFill(stringHeader[1], stringHeader[2], stringHeader[3], stringHeader[4]);
                methodredactor.Show();
                methodredactor.FormClosed += Methodredactor_FormClosed;
            }
        }
        

        private void Methodredactor_FormClosed(object sender, FormClosedEventArgs e)
        {
            TreeViewList[XmlPages.SelectedIndex].SelectedNode.Text = MethodAttributes((sender as XmlMethodRedactor).RedactoredHeaderList(), (sender as XmlMethodRedactor).RedactoredValueList());
            int difference = firsttime > TimeParse(TreeViewList[XmlPages.SelectedIndex].SelectedNode) ? -(firsttime - TimeParse(TreeViewList[XmlPages.SelectedIndex].SelectedNode)) : TimeParse(TreeViewList[XmlPages.SelectedIndex].SelectedNode) - firsttime;
            NodesRedactor(TreeViewList[XmlPages.SelectedIndex].SelectedNode, difference);
        }
        private void NodesRedactor(TreeNode node, int difference)
        {
            
            if (node.Parent != null)
            {
                node.Parent.Text = TimeRedactor(node.Parent, (difference + TimeParse(node.Parent)).ToString());
                NodesRedactor(node.Parent,difference);
            }
        }
        private int TimeParse(TreeNode node)
        {
            int time = Convert.ToInt32(MethodTimeParcer(node.Text));

            return time;
        }

        private string TimeRedactor (TreeNode node, string timevalue)
        {
            string[] buf = new string[] { "time = " };
            string time = "time = ";
            string[] ms = new string[] { "ms," };
            string ms1 = "ms,";
            node.Text = node.Text.Split(buf, StringSplitOptions.RemoveEmptyEntries)[0] + time + timevalue +
                     ms1 + node.Text.Split(ms, StringSplitOptions.RemoveEmptyEntries)[1];
            return node.Text;
        }


        private void Threadredactor_FormClosed(object sender, FormClosedEventArgs e)
        {
            TreeViewList[XmlPages.SelectedIndex].SelectedNode.Text = ThreadAttributes((sender as XmlThreadRedactor).RedactoredHeaderList(), (sender as XmlThreadRedactor).RedactoredValueList());
        }

        private List<TreeNode> TreeBuild (XmlElement node, List<TreeNode> NodesList)
        {
            NodesList.Add(TreeNodeBuild(node, new TreeNode(node.Name + Attributes(node))));
            
            return NodesList;
        }

        private TreeNode TreeNodeBuild (XmlElement node, TreeNode treenode)
        {
            if (node.ChildNodes.Count > 0)
            {
                foreach (XmlElement childnode in node.ChildNodes)
                {
                    treenode.Nodes.Add(childnode.Name + Attributes(childnode));
                    TreeNodeBuild(childnode, treenode.Nodes[treenode.Nodes.Count - 1]);
                }
            }
            return treenode;
        }

        private string Attributes (XmlElement node)
        {
            string str = "( ";
            foreach (XmlAttribute attr in node.Attributes )
            {
                str += attr.Name + " = " + attr.Value + ", ";
            }
            str += ")";
            return str;
        }
        private string ThreadAttributes (List<string> stringHeader, List<string> stringValue)
        {
                string str1 = "thread( ";
                str1 += stringHeader[0] + " = " + stringValue[0] + ", " + stringHeader[1] + " = " + stringValue[1] + "ms, " + ")";
                return str1;
        }
        private string MethodAttributes(List<string> stringHeader, List<string> stringValue)
        {

            string str2 = "method( ";
            str2 += stringHeader[0] + " = " + stringValue[0] + ", " + stringHeader[1] + " = " + stringValue[1] + "ms, " +
                    stringHeader[2] + " = " + stringValue[2] + ", " + stringHeader[3] + " = " + stringValue[3] + ", " + ")";
            return str2;
        }
        private string MethodTimeParcer (string methodname)
        {
            string ret = null;
            string[] time = null;
            string[] comma = new string[] { ", " };
            string[] t = new string[] { "time = " };
            string[] ms = new string[] { "ms" };
            time = methodname.Split(comma, StringSplitOptions.RemoveEmptyEntries)[1].Split(t, StringSplitOptions.RemoveEmptyEntries)[0].Split(ms, StringSplitOptions.RemoveEmptyEntries);
            foreach (string str in time)
            {
                ret += str;
            }
            return ret;
        }
        private List<string> MethodTextParcer (string methodtext, int index)
        {
            string[] bufstrarr1 = null;
            string[] bufstrarr2 = null;
            List<string> stringHeader = new List<string> { };
            List<string> stringValue = new List<string> { };
            if (methodtext[0] == 'm')
            {
                stringHeader.Add("1");
                stringValue.Add("1");
            }
            else
            {
                stringHeader.Add("2");
                stringValue.Add("2");
            }
            string[] str1 = new string[] { "( " };
            string[] str2 = new string[] { ",)" };
            string[] str3 = new string[] { ", " };
            string[] str4 = new string[] { " = " };
            string[] str5 = new string[] { "ms" };

            bufstrarr1 = methodtext.Split(str1, StringSplitOptions.RemoveEmptyEntries)[1].Split(str2, StringSplitOptions.RemoveEmptyEntries)[0].Split(str3, StringSplitOptions.RemoveEmptyEntries);
            
            for (int i = 0; i <= bufstrarr1.Count() - 2; i++)
            {
                bufstrarr2 = bufstrarr1[i].Split(str4, StringSplitOptions.RemoveEmptyEntries);
                stringHeader.Add(bufstrarr2[0]);
                stringValue.Add(bufstrarr2[1].Split(str5, StringSplitOptions.RemoveEmptyEntries)[0]);
            }
            if (index == 1)
            {
                return stringHeader;
            }
            return stringValue;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TreeViewList[XmlPages.SelectedIndex].Nodes.Count > 0)
            {
                MessageBox.Show("Выберите другую вкладку.", "Предупреждение");
                return;
            }
            List<TreeNode> ThreadList = new List<TreeNode> { };
            OpenFileDialog filedialog = new OpenFileDialog();
            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                foreach (TabPage tp in XmlPages.TabPages)
                {
                    if (tp.Text == filedialog.FileName.Split('\\')[filedialog.FileName.Split('\\').LongCount() - 1])
                    {
                        MessageBox.Show("Выбранный файл уже используется.", "Предупреждение");
                        return;
                    }
                }
                XmlDocument xmldoc = new XmlDocument();
                try
                {
                    xmldoc.Load(filedialog.FileName);
                }
                catch (System.Xml.XmlException)
                {
                    MessageBox.Show("Содержимое файла повреждено, либо отсутствует.", "Ошибка!");
                    return;
                }
                XmlElement root = xmldoc.DocumentElement;
                foreach (XmlElement node in root.ChildNodes)
                {
                    TreeBuild(node, ThreadList);
                }
                foreach (TreeNode t in ThreadList)
                {
                    TreeViewList[XmlPages.SelectedIndex].Nodes.Add(t);
                }
                TreeViewList[XmlPages.SelectedIndex].NodeMouseDoubleClick += XmlReaderForm_NodeMouseDoubleClick;
            }
            XmlPages.TabPages[XmlPages.SelectedIndex].Text = filedialog.FileName.Split('\\')[filedialog.FileName.Split('\\').LongCount() - 1];
            SaveASToolStripMenuItem.Enabled = true;
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog filedialog = new OpenFileDialog();
            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                foreach (TabPage tp in XmlPages.TabPages)
                {
                    if (tp.Text == filedialog.FileName.Split('\\')[filedialog.FileName.Split('\\').LongCount() - 1])
                    {
                        if (tp.Text == XmlPages.TabPages[XmlPages.SelectedIndex].Text)
                            break;
                        MessageBox.Show("Выбранный файл уже используется. Выберите другой файл для сохранения.", "Предупреждение");
                        return;
                    }
                }
                XDocument xmldoc = new XDocument();
                XElement root = new XElement("root");
                foreach (TreeNode t in TreeViewList[XmlPages.SelectedIndex].Nodes)
                {
                    root.Add(XmlTreeBuil(t));
                }
                xmldoc.Add(root);
                xmldoc.Save(filedialog.FileName);
            }
        }
        protected XElement XmlTreeBuil (TreeNode treenode)
        {
            XElement ret = null;
            List<string> stringHeader = MethodTextParcer(treenode.Text, 1);
            List<string> stringValue = MethodTextParcer(treenode.Text, 2);
            if (stringHeader[0] == "2" && stringValue[0] == "2")
            {
                XElement thread = new XElement("thread");
                XAttribute id = new XAttribute("id", stringValue[1]);
                XAttribute time = new XAttribute(stringHeader[2], stringValue[2] + "ms");
                thread.Add(id, time);
                if(treenode.Nodes.Count > 0)
                {
                    foreach (TreeNode t in treenode.Nodes)
                    {
                        thread.Add(XmlTreeBuil(t));
                    }
                }
                ret = thread;
            }
            else
            {
                XElement method = new XElement("method");
                XAttribute name = new XAttribute("name", stringValue[1]);
                XAttribute time = new XAttribute(stringHeader[2], stringValue[2]+ "ms");
                XAttribute package = new XAttribute(stringHeader[3], stringValue[3]);
                XAttribute paramscount = new XAttribute(stringHeader[4], stringValue[4]);
                method.Add(name, time, package, paramscount);
                if (treenode.Nodes.Count > 0)
                {
                    foreach (TreeNode t in treenode.Nodes)
                    {
                        method.Add(XmlTreeBuil(t));
                    }
                }
                return method;
            }
            return ret;
        }

        private void XmlPages_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex < 0)
            {
                return;
            }
            if(TreeViewList[e.TabPageIndex].Nodes.Count == 0)
            {
                SaveASToolStripMenuItem.Enabled = false;
            }
            else
            {
                SaveASToolStripMenuItem.Enabled = true;
            }
        }
    }
}