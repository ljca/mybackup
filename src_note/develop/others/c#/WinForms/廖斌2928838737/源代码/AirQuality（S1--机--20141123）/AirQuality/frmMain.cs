using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirQuality
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //打开---录入界面
        private void tsmiLuRu_Click(object sender, EventArgs e)
        {
            frmLuRu obj = new frmLuRu();
            obj.MdiParent = this;
            obj.Show();
        }
        //打开--- 查询界面
        private void tsmiChaXun_Click(object sender, EventArgs e)
        {
            frmChaXun obj = new frmChaXun();
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
