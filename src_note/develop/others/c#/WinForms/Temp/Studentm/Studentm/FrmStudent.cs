using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentBLL;

namespace Studentm
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        StudentManage studenttmp = new StudentManage();
        private void FrmStudent_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.dgvStudent.AutoGenerateColumns = false;
            this.btnAct.Enabled = false;
            this.btnSeach.Enabled = false;
            FillData();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {

        }

        private void btnSeach_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 绑定集合
        /// </summary>
        public void FillData()
        {
            this.dgvStudent.DataSource = studenttmp.GetStudent();
        }


    }
}
