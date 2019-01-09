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
    public partial class frmChaKan : Form
    {
        public frmChaKan()
        {
            InitializeComponent();
        }
        //窗体加载
        private void frmChaKan_Load(object sender, EventArgs e)
        {

        }
        //打开修改窗口
        private void tsmiXiuGai_Click(object sender, EventArgs e)
        {
            frmXiuGai obj = new frmXiuGai();
            obj.ShowDialog();
        }
    }
}
