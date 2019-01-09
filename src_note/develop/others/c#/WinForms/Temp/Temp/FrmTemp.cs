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

namespace Temp
{
    public partial class FrmTemp : Form
    {
        public FrmTemp()
        {
            InitializeComponent();
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
        }

        public void Temp()
        {
            XmlDocument xmlroot = new XmlDocument();
            xmlroot.Load(@".\..\..\temp.xml");
            XmlNode node = xmlroot.DocumentElement;
            string temp = "";
            foreach (XmlNode tempnode in node.ChildNodes)
            {
                temp += tempnode.Attributes["name"].Value.ToString();
            }
            MessageBox.Show(temp);
        }

        private void FrmTemp_Load(object sender, EventArgs e)
        {
            Temp();
        }
    }
}
