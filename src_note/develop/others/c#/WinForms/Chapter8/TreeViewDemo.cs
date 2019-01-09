using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter8
{
    public partial class TreeViewDemo : Form
    {
        public TreeViewDemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region
            string text = txtNodeName.Text;
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("请输入"); return;
            }
            #endregion
            tvDemo.Nodes.Add(text);//添加到根节点
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region
            string text = txtNodeName.Text;
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("请输入"); return;
            }
            #endregion
            tvDemo.SelectedNode.Nodes.Add(text);//添加到选中节点
        }

        private void button3_Click(object sender, EventArgs e)
        {//删除选中节点
            tvDemo.SelectedNode.Remove();
        }

        private void button4_Click(object sender, EventArgs e)
        {// 清空treeview
            tvDemo.Nodes.Clear();
        }

        private void TreeViewDemo_Load(object sender, EventArgs e)
        {

        }

    }
}
