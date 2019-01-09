using BroseForlder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class FrmForder : Form
    {
        public FrmForder()
        {
            InitializeComponent();
        }

        private void FrmForder_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            Folder();
        }

        private void Folder()
        {
            if (tvFolder.Nodes != null)
            {
                tvFolder.Nodes.Clear();
            }
            TreeNode node = tvFolder.Nodes.Add("I:");
            foreach (string item in BroseForlderService.Dirlist(new System.IO.DirectoryInfo("I:\\")))
            {
                node.Nodes.Add(item);
            }
        }
    }
}
