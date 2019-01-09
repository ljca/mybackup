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

namespace SchoolData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 背诵、默写
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //添加根节点：学校信息
            TreeNode root = tvSchool.Nodes.Add("学校信息");
            //解析xml
            XmlDocument xml = new XmlDocument();
            xml.Load("school.xml");//加载xml文档
            XmlNode school = xml.DocumentElement;//获取根节点
            //获根节点的所有子节点

            foreach (XmlNode item in school.ChildNodes)//获取所有的Grade节点
            {//item:Grade
                // 添加年级到学校节点下
                TreeNode grade = root.Nodes.Add(item.Attributes["name"].Value); 
                //获取年级下的所有班级
                foreach (XmlNode classNode in item.ChildNodes)
                {
                    //添加班级到年级
                    TreeNode cls = grade.Nodes.Add(
                        classNode.Attributes["name"].Value);
                    cls.Tag = classNode;//存储数据
                }
            }
        }

        private void tvSchool_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //获取选中节点
            TreeNode selectedNode = tvSchool.SelectedNode;
            if (selectedNode != null && selectedNode.Level == 2)
                //验证有选择节点并且选择的是班级
            {
                //获取数据
                XmlNode node = (XmlNode)selectedNode.Tag;
                txtData.Text = "老师:" + node.Attributes["teacher"].Value;
                txtData.Text += "\r\n学生:" + node.InnerText;
            }
        }
    }
}
