using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //打开维护窗口
        private void tsmiWeiHu_Click(object sender, EventArgs e)
        {
            frmWeiHu obj = new frmWeiHu();
            obj.MdiParent = this;
            obj.Show();
        }
        //退出
        private void tsmiTuiChu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
