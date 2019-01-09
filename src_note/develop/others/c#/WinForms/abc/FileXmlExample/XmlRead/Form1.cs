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

namespace XmlRead
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //XmlDocument:Load(),DocumentElement
            //XmlNode:ChildNodes,InnerText,Attributes
            //
            XmlDocument xml = new XmlDocument();
            //
            xml.Load("D:/abc/a.xml");
            //
            XmlNode root = xml.DocumentElement;

            foreach (XmlNode juwei in root.ChildNodes)
            {
                foreach (XmlNode jianzhu in juwei.ChildNodes)
                {
                    foreach (XmlNode fjname in jianzhu.ChildNodes)
                    {
                        txtConsole.Text += root.Attributes["name"].Value
                            +juwei.Attributes["name"].Value 
                            +jianzhu.Attributes["name"].Value 
                            + fjname.InnerText + "\n";
                    }
                }

            }



        }
    }
}
