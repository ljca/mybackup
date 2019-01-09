using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetSongSourse
{
    public partial class FrmSetsongSourse : Form
    {

        public FrmSetsongSourse()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化窗体
        /// 如果初始路径不为空则将光标移动到新的路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSetsongSourse_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.BackColor = Color.White;
            this.ForeColor = Color.Blue;
            this.HelpButton = true;

            if (this.txtOldSourse.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("初始路径为空！\n请指定初始路径！！");
            }
            else
            {
                this.txtNewSourse.Focus();
            }

            //按esc键可返回到窗体
            this.CancelButton = this.btnCancel;
            //如果用户选择了路径，按回车键可直接保存
            this.AcceptButton = this.btnSave;

        }



        /// <summary>
        /// 选择路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog FbdSelectFolder = this.FbdSelectFolder;
            FbdSelectFolder.Description = "请选择路径:";
            FbdSelectFolder.SelectedPath = "C:\\";
            FbdSelectFolder.ShowNewFolderButton = true;
            if (FbdSelectFolder.ShowDialog() == DialogResult.OK)
            {

                //fs.SelectedPath = Path;
                //Path = fs.SelectedPath;
                this.txtNewSourse.Text = FbdSelectFolder.SelectedPath;
            }
        }

        /// <summary>
        /// 保存歌曲路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtNewSourse.Text.Trim().ToString().Equals(string.Empty))
            {

                MessageBox.Show("还未选择路径！");
            }
            else
            {
                MessageBox.Show("设置路径成功！");
                this.Close();
            }
        }

        /// <summary>
        /// 如果用户单击了取消按钮则关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
        
}
