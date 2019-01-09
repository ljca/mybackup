using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKTV.ManageForms
{
    public partial class FrmPhotoPath : Form
    {
        public FrmPhotoPath()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPhotoPath_Load(object sender, EventArgs e)
        {
            #region 
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MdiParent = MyKTV.ManageForms.FrmAdmin.admin;
            this.ShowInTaskbar = false;
            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;
            this.ForeColor = Color.Blue;
            this.txtNewSource.ForeColor = Color.Blue;
            this.txtOldSource.ForeColor = Color.Blue;
            this.txtNewSource.Focus();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            #endregion
        }
        #region 
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            this.fdbPicture.Description = "请选择图片路径:";
            this.fdbPicture.ShowNewFolderButton = false;
            this.fdbPicture.SelectedPath = "E:\\";
            if(this.fdbPicture.ShowDialog() == DialogResult.OK)
            {
                this.txtNewSource.Text = this.fdbPicture.SelectedPath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!txtNewSource.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("保存路径成功！");
                this.Close();
            }
            else if (txtNewSource.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请选择路径！");
                this.txtNewSource.Focus();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
