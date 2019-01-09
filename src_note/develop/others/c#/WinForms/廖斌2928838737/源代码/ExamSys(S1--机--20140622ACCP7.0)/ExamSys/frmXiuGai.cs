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
    public partial class frmXiuGai : Form
    {
        public frmXiuGai()
        {
            InitializeComponent();
        }
        //保存事件
        private void btnBaoChun_Click(object sender, EventArgs e)
        {

        }
        //取消事件
        private void btnQuXiao_Click(object sender, EventArgs e)
        {
            //关闭窗口
            this.Close();
        }
    }
}
