using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExamSys
{
    public partial class FrmShowInfo : Form
    {
        public FrmShowInfo()
        {
            InitializeComponent();
        }

       

        /// <summary>
        /// 初始化窗体！
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmShowInfo_Load(object sender, EventArgs e)
        {
            this.dgvShowInfo.AutoGenerateColumns = false;
            this.dgvShowInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// 修改考试信息窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiRevise_Click(object sender, EventArgs e)
        {
            FrmRevise revise = null;
            //如果窗体对象为空或者窗体未打开则打开窗体
            if(revise == null || revise.IsDisposed)
            {
                revise = new FrmRevise();
                revise.MdiParent = this.MdiParent;

                if (SelecText())
                {
                    revise.Show();
                }
                else
                {
                    MessageBox.Show("暂不支持多行修改！");
                    return;
                }
            }
        }

        /// <summary>
        /// 根据条件查询考试信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DBHelper.sql = string.Format(@"select a.StuId,b.StuName,a.Course,a.Score,a.ExamDate,a.Remark from ExamInfo as a
inner join Sudent as b on(a.StuId = b.StuId)
where a.ExamDate like '%{0}%' and b.StuName like '%{1}%' ",txtExamDate.Text,txtStudentName.Text);
            try
            {
                DBHelper.ds = new DataSet("ExamInfo");
                DBHelper.da = new SqlDataAdapter(DBHelper.sql, DBHelper.strcon);
                if (DBHelper.ds.Tables["ExamInfo"] != null)
                {
                    DBHelper.ds.Tables["ExamInfo"].Clear();
                }
                DBHelper.da.Fill(DBHelper.ds, "ExamInfo");
                this.dgvShowInfo.DataSource = DBHelper.ds.Tables["ExamInfo"];
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        /// <summary>
        /// 获取文本！
        /// </summary>
        private bool SelecText()   
        {
            if (dgvShowInfo.SelectedRows.Count == 1)
            {
                FrmRevise.StuId = dgvShowInfo.SelectedRows[0].Cells["StuId"].Value.ToString();
                FrmRevise.StuName = dgvShowInfo.SelectedRows[0].Cells["StuName"].Value.ToString();
                FrmRevise.Course = dgvShowInfo.SelectedRows[0].Cells["Course"].Value.ToString();
                FrmRevise.Score = dgvShowInfo.SelectedRows[0].Cells["Score"].Value.ToString();
                FrmRevise.ExamDate = dgvShowInfo.SelectedRows[0].Cells["ExamDate"].Value.ToString();
                FrmRevise.Remark = dgvShowInfo.SelectedRows[0].Cells["Remark"].Value.ToString();
                return true;
            }
            return false;
        }

    }
}
