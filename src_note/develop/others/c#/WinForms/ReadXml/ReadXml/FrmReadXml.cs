using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ReadXml
{
    public partial class FrmReadXml : Form
    {
        public FrmReadXml()
        {
            InitializeComponent();
        }

        private void FrmReadXml_Load(object sender, EventArgs e)
        {
            //加载xml文档
            XmlDocument xml = new XmlDocument();
            xml.Load(@".\..\..\Address.xml");
            XmlNode rootnode = xml.DocumentElement;
            //根节点
            TreeNode treenode = this.tvHouse.Nodes.Add(rootnode.Attributes["name"].Value);
            foreach (XmlNode node in rootnode.ChildNodes)
            {
                //获取xml文档节点属性
                //二级节点
                TreeNode nodes = treenode.Nodes.Add(node.Attributes["name"].Value);
                foreach (XmlNode item in node.ChildNodes)
                {
                    TreeNode noded = nodes.Nodes.Add(item.Attributes["name"].Value);
                    foreach (XmlNode temp in item.ChildNodes)
                    {
                        noded.Nodes.Add(temp.InnerText);
                    }
                }
            }
        }

        private void tvHouse_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }


    }
}
