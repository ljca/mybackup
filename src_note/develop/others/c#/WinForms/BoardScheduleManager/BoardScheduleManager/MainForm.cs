using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardScheduleManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            if ( DialogResult.OK == MessageBox.Show("是否退出程序?", "提示", MessageBoxButtons.OKCancel))
            {//退出程序
                Application.Exit();
            }
        }

        private void tsmiBookRoom_Click(object sender, EventArgs e)
        {
            BookRoomForm bookForm = new BookRoomForm();
            bookForm.MdiParent = this;//指定父窗体
            bookForm.Show();//打开预定窗体
        }

        private void tsmiSelect_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm();
            selectForm.MdiParent = this;//指定父窗体
            selectForm.Show();//打开预定窗体
        }
    }
}
