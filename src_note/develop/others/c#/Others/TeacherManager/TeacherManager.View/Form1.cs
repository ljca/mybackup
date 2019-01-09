using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeacherManager.Model;

namespace TeacherManager.View
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }
        //实例化业务实例对象
        private TeacherManager.BLL.TeacherManager tm = new TeacherManager.BLL.TeacherManager();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvTeacherList.AutoGenerateColumns = false;//禁止自动生成列
            List<Teacher> list = tm.GetAllTeacher(); //获取所有的教师集合
            dgvTeacherList.DataSource = list;//绑定数据源 ,但是不会绑定年级信息
            // 循环设置年级信息
            for (int i = 0; i < dgvTeacherList.Rows.Count; i++) 
            {
                dgvTeacherList.Rows[i].Cells["TeachGrade"].Value =
                    list[i].TeachGrade.GradeName; // 设置年级信息
            }
        }

        private void dgvTeacherList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {//判断是否选中行
                return;
            }//获取点击行
            DataGridViewRow dr = dgvTeacherList.Rows[e.RowIndex];
            DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dr.Cells["OPS"];//获取checkbox单元格
            //判断当前复选框的 选中状态情况
            if (cell.EditedFormattedValue.ToString().ToLower() == "false")
            {
                //设置选择当前行
                cell.Value = true;
                dr.Selected = false;//不允许选中
                //设置选中行样式
                dr.DefaultCellStyle.BackColor = Color.BlueViolet;
                dr.DefaultCellStyle.ForeColor = Color.White;
            }
            else
            {
                //设置取消选择当前行
                cell.Value = false;
                dr.Selected = false;//不允许选中
                //还原未选择样式
                dr.DefaultCellStyle.BackColor = Color.White;
                dr.DefaultCellStyle.ForeColor = Color.Black;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //要删除的所有 教师编号
            List<string> deleteTids = new List<string>();
            
            //遍历所有的行
            foreach (DataGridViewRow dr in dgvTeacherList.Rows)
            {//获取要删除的数据
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dr.Cells["OPS"];//获取checkbox单元格
                if (cell.EditedFormattedValue.ToString().ToLower() == "true")
                {//判断是否选中
                    deleteTids.Add(dr.Cells["Tid"].Value.ToString());
                }
            }
            if (deleteTids.Count == 0)
            {
                MessageBox.Show("亲，你没有选择任何数据!\n请勾选要删除的数据!~~"); return;
            }
            MessageBox.Show("选中的数据ID有:\n"+string.Join(",",deleteTids.ToArray()));
            //TODO 接下来 就该去做删除了
        }
    }
}
