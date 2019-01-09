using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyKTV;
namespace MyKTV.ManageForms
{
    public partial class FrmSongPath : Form
    {
        public FrmSongPath()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSongPath_Load(object sender, EventArgs e)
        {
            #region 
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;
            this.ForeColor = Color.Blue;
            this.txtOldSource.ReadOnly = true;
            this.txtNewSource.Focus();
            this.txtNewSource.ForeColor = Color.Blue;
            this.txtOldSource.ForeColor = Color.Blue;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
#endregion
            SetIncSource();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            this.fbdSongSource.Description = "请选择路径：";
            this.fbdSongSource.SelectedPath = "E:\\";
            this.fbdSongSource.ShowNewFolderButton = false;
            if(fbdSongSource.ShowDialog() == DialogResult.OK)
            {
                this.txtNewSource.Text = this.fbdSongSource.SelectedPath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ReviseSource() == 1)
            {
                MessageBox.Show("保存路径成功！");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region 获取原始路径！
        /// <summary>
        /// 获取文件原始路径！
        /// </summary>
        /// <returns></returns>
        public string SetIncSource()
        {
            txtOldSource.ResetText();
            if(txtOldSource.Text.Trim().Equals(string.Empty))
            {
                try
                {
                    DBHelper.sql = @"select [resource_path] from resource_path
where resource_id = 3";
                    
                    DBHelper.OpenCon();
                    DBHelper.cm = new System.Data.SqlClient.SqlCommand(DBHelper.sql, DBHelper.Cn);
                    DBHelper.dreader = DBHelper.cm.ExecuteReader();
                    if (DBHelper.dreader.Read())
                    {
                        this.txtOldSource.Text = DBHelper.dreader["resource_path"].ToString();
                        DBHelper.dreader.Close();
                        DBHelper.CloseCon();
                        return txtOldSource.Text;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return null;
                    throw;
                }
            }
            return null;
        }
        #endregion

        #region 保存路径！！
        /// <summary>
        /// 保存路径！
        /// </summary>
        /// <returns>保存失败返回-1</returns>
        public int ReviseSource()
        {

            if (!txtNewSource.Text.Trim().Equals(string.Empty)
                && txtNewSource.Text.Trim().Substring(1, 2) == ":\\")
            {
                DBHelper.sql = string.Format(@"update resource_path  set resource_path = '{0}' where resource_id = 3", this.txtNewSource.Text);
                try
                {
                    DBHelper.OpenCon();
                    DBHelper.cm = new System.Data.SqlClient.SqlCommand(DBHelper.sql, DBHelper.Cn);
                    if (DBHelper.cm.ExecuteNonQuery() != 0)
                    {
                        return DBHelper.cm.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                    return -1;
                    throw;
                }
                finally
                {
                    DBHelper.CloseCon();
                }
            }
            else //if (txtNewSource.Text.Trim().Equals(string.Empty)
            //|| txtNewSource.Text.Trim().Substring(1,2) != @":\")
            {
                MessageBox.Show("路径无效！\n\n请重新设置路径");
                this.txtNewSource.ResetText();
                this.txtNewSource.Focus();
            }
            return 0;
        }
        #endregion

    }
}
