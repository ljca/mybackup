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
            //this.MdiParent = FrmAdmin.admin;
            //FrmAdmin.admin.Init();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MdiParent = MyKTV.ManageForms.FrmAdmin.admin;
            this.ShowInTaskbar = false;
            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;
            this.ForeColor = Color.Blue;
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
            if (!txtNewSource.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("保存路径成功！");
                this.Close();
            }
            else if(txtNewSource.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请选择路径！");
                this.txtNewSource.Focus();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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


        public bool ReviseSource()
        {
            try
            {

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
 
        }



    }
}
