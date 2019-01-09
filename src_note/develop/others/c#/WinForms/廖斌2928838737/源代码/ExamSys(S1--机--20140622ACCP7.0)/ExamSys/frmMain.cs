using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSys
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //打开查看考试信息窗口
        private void tsmiChaKan_Click(object sender, EventArgs e)
        {
            frmChaKan obj = new frmChaKan();
            obj.MdiParent = this;
            obj.Show();
        }
        //应用程序退出
        private void txmiTuiChu_Click(object sender, EventArgs e)
        {
            //退出
            Application.Exit();
        }
    }
}
