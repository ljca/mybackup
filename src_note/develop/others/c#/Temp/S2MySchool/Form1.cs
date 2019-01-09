using MySchoolDAL;
using MySchoolModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S2MySchool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StudentService stu = new StudentService();
        GradeService gs = new GradeService();

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //DataSet ds = null;
                //DataSet绑定
                //dgvStudents.DataSource = ds.Tables["sdf"];
                //集合绑定
                List<Student> list = stu.GetAllStudent();
                //dgvStudents.DataSource = list;//第一中,展示的数据不会变
                //第二种：展示数据发生改变
                dgvStudents.DataSource =
                    new BindingList<Student>(list);


                //dgvStudents.DataSource = stu.GetAllStudent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // 显示的属性
            cboGrade.DisplayMember = "GradeName";
            // 隐藏的属性
            cboGrade.ValueMember = "GradeId";
            cboGrade.DataSource = gs.GetAllGrade();
        }

        private void cboGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            int gradeId = Convert.ToInt32(cboGrade.SelectedValue);
            List<Student> list = stu.GetStudentByGradeId(gradeId);
            //dgvStudents.DataSource = list;//第一中,展示的数据不会变
            //第二种：展示数据发生改变
            dgvStudents.DataSource = new BindingList<Student>(list);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
