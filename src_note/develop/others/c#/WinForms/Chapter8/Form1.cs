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

namespace Chapter8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //实例化xml对象
            XmlDocument xml = new XmlDocument();
            //加载xml文件
            xml.Load("user.xml");
            //获取根节点
            XmlNode node = xml.DocumentElement;
            //遍历或者直接获取
            foreach (XmlNode item in node.ChildNodes)
            {
                //获取节点名字和内容
                string text = item.Name + ":" + item.InnerText;
                //获取属性值
                string type = item.Attributes["type"].Value;
                txtLog.Text += text +"("+type+")" + "\r\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //实例化xml对象
            XmlDocument xml = new XmlDocument();
            //加载xml文件
            xml.Load("users.xml");
            //获取根节点
            XmlNode root = xml.DocumentElement;
            //遍历或者直接获取
            foreach (XmlNode item in root.ChildNodes)
            {
                string text = 
                    string.Format(
                    "名字:{0} 性别:{1} 年龄:{2}",
                    item["username"].InnerText,
                    item["sex"].InnerText,
                    item["age"].InnerText);
                txtLog.Text += "\r\n" + text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //创建对象解析xml
            XmlDocument xml = new XmlDocument();
            //加载xml
            xml.Load("test.xml");
            //获取根节点
            XmlNode root = xml.DocumentElement;//school
            //遍历
            foreach (XmlNode item in root.ChildNodes)
            {//grade
                string gradeName = item.Attributes["name"].Value;
                foreach (XmlNode classNode in item.ChildNodes)
                {//class
                    string className = classNode.Attributes["name"].Value;
                    string teacher = classNode.Attributes["teacher"].Value;
                    string text = string.Format(
                        "{0}{1}  班主任:{2} 学生有：{3}",
                        gradeName,className,teacher,classNode.InnerText
                        );
                    txtLog.Text += "\r\n" + text;
                }
            }
        }
    }
}
