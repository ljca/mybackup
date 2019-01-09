using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TreeNode:Nodes(Add方法),Text,Tag
            for (int i = 1; i < 10; i++)
            {
                TreeNode node = tvDemo.Nodes.Add(i.ToString());
                for (int j = 1; j < 10; j++)
                {
                    node.Nodes.Add(i + " × " + j + "=" + (i * j));
                }
            }
        }
    }
}
