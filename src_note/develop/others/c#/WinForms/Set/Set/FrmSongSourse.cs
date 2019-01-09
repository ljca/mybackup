using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Set
{
    public partial class FrmSetSongSourse : Form
    {
        public FrmSetSongSourse()
        {
            InitializeComponent();
        }

        private void FrmSetSongSourse_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            
            this.MinimizeBox = false;
            this.HelpButton = true;
            if (this.txtOldSourse.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请指定歌曲初始路径！！");
            }
            else
            {
                this.txtNewSourse.Focus();
            }
        }


        /// <summary>
        /// 选择路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
           
            FolderBrowserDialog fs = this.FbdSelectFolder;
            fs.Description = "请选择路径:";
            //fs.SelectedPath = "C:\\";
            fs.ShowNewFolderButton = true;
            fs.ShowDialog();
            if(fs.ShowDialog() == DialogResult.OK)
            {

                //fs.SelectedPath = Path;
                //Path = fs.SelectedPath;
                this.txtNewSourse.Text = fs.SelectedPath;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
