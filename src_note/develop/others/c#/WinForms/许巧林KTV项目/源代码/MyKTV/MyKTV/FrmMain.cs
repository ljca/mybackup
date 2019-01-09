using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyKTV.ManageForms;

namespace MyKTV
{
    public partial class FrmMain : Form
    {
        public static FrmMain main = new FrmMain();
        public FrmMain()
        {
            InitializeComponent();
        }
        public static string songname = "";
        public static string nextsong = "";
        /// <summary>
        /// 初始化窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            Init();
            this.ShowInTaskbar = true;
            this.ShowIcon = true;
            SongUtil.Play();
            this.txtPlayed.Text = songname;
            this.textBox2.Text = nextsong;
        }
        #region 工具栏跳转事件
        private void tsbtnServer_Click(object sender, EventArgs e)
        {
            KTVUtil.Login();  
        }

        private void pbsingerRequest_Click(object sender, EventArgs e)
        {
            //this.Hide();
            SongUtil.SingerName_Request();
        }

        private void pbabRequest_Click(object sender, EventArgs e)
        {
         
            //this.Hide();
            SongUtil.SingerAb_Request();
        }

        private void pbtypeReuest_Click(object sender, EventArgs e)
        {
            SongUtil.SongType_Request();
        }

        private void pbCharts_Click(object sender, EventArgs e)
        {
           //this.Hide();
            SongUtil.Goldrequest();
        }

        private void pbwordsRquest_Click(object sender, EventArgs e)
        {
            //this.Hide();
            SongUtil.Words_Request();
        }

        private void tsbtnPlayed_Click(object sender, EventArgs e)
        {
            //this.Hide();
            SongUtil.Requested_Played();
        }

        private void tsbtnCutsong_Click(object sender, EventArgs e)
        {
            int index = 0;
            SongUtil.Play();
            Play.CutSong(index);
            
        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            KTVUtil.Exit();
        }

        #endregion
        #region 鼠标悬停事件
        private void pbsingerRequest_MouseHover(object sender, EventArgs e)
        {
            this.pbsingerRequest.Cursor = Cursors.Hand;
        }

        private void pbabRequest_MouseHover(object sender, EventArgs e)
        {
            this.pbabRequest.Cursor = Cursors.Hand;
        }

        private void pbtypeReuest_MouseHover(object sender, EventArgs e)
        {
            this.pbtypeReuest.Cursor = Cursors.Hand;
        }

        private void pbCharts_MouseHover(object sender, EventArgs e)
        {
            this.pbCharts.Cursor = Cursors.Hand;
        }

        private void pbwordsRquest_MouseHover(object sender, EventArgs e)
        {
            this.pbwordsRquest.Cursor = Cursors.Hand;
        }

        #endregion
        #region 初始化窗体
        /// <summary>
        /// 初始化窗体
        /// </summary>
        public void Init()
        {
            //this.ForeColor = Color.Blue;
            this.txtPlayed.ForeColor = Color.Blue;
            this.textBox2.ForeColor = Color.Blue;
            this.MaximizeBox = false;
           
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

        }
        #endregion
 
        private void tsbtnWhile_Click(object sender, EventArgs e)
        {
            //this.Hide();
            SongUtil.Play();
        }


    }
}
