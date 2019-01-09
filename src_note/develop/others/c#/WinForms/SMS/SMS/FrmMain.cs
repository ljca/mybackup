using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 添加用户！
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbAddUser_Click(object sender, EventArgs e)
        {
            FrmAdd add = null;

            //如果对象为空或未打开过则跳转！
            if (add == null || add.IsDisposed)
            {
                add = new FrmAdd();
                add.ShowDialog();
            }
        }

        /// <summary>
        /// 查询用户信息！
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbSearch_Click(object sender, EventArgs e)
        {
            FrmShowInfo search = null;

            //如果对象为空或未打开过则跳转！
            if (search == null || search.IsDisposed)
            {
                search = new FrmShowInfo();
                search.Show();
            }

        }

        /// <summary>
        /// 退出系统！
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbExit_Click(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("确定要退出系统吗？", "退出提示！", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            //退出系统！
            if (ds == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
