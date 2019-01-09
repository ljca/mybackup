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
namespace MyKTV
{
    public partial class FrmOrderBySinger : Form
    {
        public FrmOrderBySinger()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmOrderBySinger_Load(object sender, EventArgs e)
        {
            
            //this.MdiParent = MyKTV.FrmMain.main;
            Init();
        }

        /// <summary>
        /// 初始化窗体
        /// </summary>
        public void Init()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            
            this.ShowInTaskbar = false;
            this.ForeColor = Color.Blue;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }
        #region 工具栏按钮事件
        /// <summary>
        /// 如果用户单击了服务按钮,则跳转到登录窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnServer_Click(object sender, EventArgs e)
        {
            KTVUtil.Login();
        }

        private void tsbtnMain_Click(object sender, EventArgs e)
        {
            this.Close();
            SongUtil.MainForm();
        }

        private void tsbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnPlayed_Click(object sender, EventArgs e)
        {
            this.Close();
            SongUtil.Requested_Played();
        }

        private void tsbtnCutsong_Click(object sender, EventArgs e)
        {
            this.Close();
            Play.CutSong(1);
        }

        private void tsbtnWhile_Click(object sender, EventArgs e)
        {
            this.Close();
            Play.PlayAgain();
        }
        #endregion
        #region 鼠标悬停事件
        private void lbPop_MouseHover(object sender, EventArgs e)
        {
            this.lbrf.Cursor = Cursors.Hand;
        }

        private void lbOld_MouseHover(object sender, EventArgs e)
        {
            this.lblMile.Cursor = Cursors.Hand;
        }

        private void lbGame_MouseHover(object sender, EventArgs e)
        {
            this.lblFMail.Cursor = Cursors.Hand;
        }


        #endregion
        #region 点击事件
        private void lbrf_Click(object sender, EventArgs e)
        {
            this.Close();
            SongUtil.BySingerType();
        }

        private void lblMile_Click(object sender, EventArgs e)
        {
            this.Close();
            SongUtil.BySingerType();
        }

        private void lblFMail_Click(object sender, EventArgs e)
        {
            this.Close();
            SongUtil.BySingerType();
        }





        #endregion

    }
}
