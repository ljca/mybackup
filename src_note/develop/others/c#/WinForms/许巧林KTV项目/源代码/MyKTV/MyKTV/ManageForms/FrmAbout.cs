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
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 窗体初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAbout_Load(object sender, EventArgs e)
        {
            this.Text = "关于我们";
            txtGroup.Text = "未知！";
            txtVersion.Text = "V1.0";
            textBox3.Text = "yl_hh_gg@yeah.net";
            //SongUtil.admin.Init();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }
    }
}
