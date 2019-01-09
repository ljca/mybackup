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
    public partial class FrmRevise : Form
    {
        public FrmRevise()
        {
            InitializeComponent();
        }
        #region 字段
        /// <summary>
        /// 学号！
        /// </summary>
        public static string StuId = "";
        
        /// <summary>
        /// 姓名！
        /// </summary>
        public static string StuName = "";
        
        /// <summary>
        /// 课程！
        /// </summary>
        public static string Course = "";
        
        /// <summary>
        /// 成绩！
        /// </summary>
        public static string Score = "";
        
        /// <summary>
        /// 考试时间！
        /// </summary>
        public static string ExamDate = "";
        
        /// <summary>
        /// 备注！
        /// </summary>
        public static string Remark = "";
        #endregion

        /// <summary>
        /// 初始化窗体！
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRevise_Load(object sender, EventArgs e)
        {
            this.lblStuId.Text = StuId;
            this.txtStuName.Text = StuName;
            this.txtCourse.Text = Course;
            this.txtScore.Text = Score;
            this.txtExamDate.Text = ExamDate;
            this.txtRemark.Text = Remark;
        }

        /// <summary>
        /// 保存数据！
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("确定要更改数据吗？\n可能会对数据库产生影响！", "",MessageBoxButtons.OKCancel);
            if (ds == DialogResult.OK)
            {
                if (Revise() > 0)
                {
                    MessageBox.Show("数据更新成功！","");
                    this.Close();
                } 
            }
        }

        /// <summary>
        /// 关闭窗体！
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCanCel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 修改考试信息！
        /// </summary>
        /// <returns>成功返回真！</returns>
        private int Revise()
        {
            if (CheckNull())
            {
                DBHelper.cn = new System.Data.SqlClient.SqlConnection(DBHelper.strcon);
                string sql = string.Format(@"update Sudent
set StuName = '{0}'
where StuId = '{1}'
update ExamInfo
set Course = '{2}',Score = {3},Remark = '{4}',ExamDate = '{5}'
where StuId = '{6}' ",txtStuName.Text,lblStuId.Text,txtCourse.Text,
                     txtScore.Text,txtRemark.Text,Convert.ToDateTime(txtExamDate.Text),
                     lblStuId.Text);
                try
                {
                    DBHelper.cn.Open();
                    DBHelper.cmd = new System.Data.SqlClient.SqlCommand(sql, DBHelper.cn);
                    if (DBHelper.cmd.ExecuteNonQuery() != 0)
                    {
                        return DBHelper.cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return 0;
                }
                finally
                {
                    DBHelper.cn.Close();
                }
            }

            return 0;
        }

        /// <summary>
        /// 非空验证！
        /// </summary>
        /// <returns></returns>
        private bool CheckNull()
        {
            if (!txtStuName.Text.Trim().Equals(string.Empty)
                && !txtScore.Text.Trim().Equals(string.Empty)
                && !txtCourse.Text.Trim().Equals(string.Empty)
                && !txtExamDate.Text.Trim().Equals(string.Empty))
                //&& !txtRemark.Text.Trim().Equals(string.Empty))
            {
                return true;
            }
            else
            {
                MessageBox.Show("有项不能为为空！","提示！");
                return false;
            }
        }

    }
}
