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

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 显示考试信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmShowEaxmInfo_Click(object sender, EventArgs e)
        {
            FrmShowInfo showinfo = null;
           //如果窗体对象为空或者窗体对象已经释放则打开窗体
            if(showinfo == null || showinfo.IsDisposed)
            {
                showinfo = new FrmShowInfo();
                showinfo.MdiParent = this;
                showinfo.Show();
            }
        }

        /// <summary>
        /// 录入考试信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmAddExamInfo_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 统计考试信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmJInfo_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出吗？", "退出提示！",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if(result == DialogResult.OK)
            {
                Application.Exit();
            }
        }


    }
}
