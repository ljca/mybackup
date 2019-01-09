using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKTV
{
    public partial class FrmSingerType : Form
    {
        public FrmSingerType()
        {
            InitializeComponent();
        }

        

        private void FrmSingerType_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ShowInTaskbar = false;
            this.ForeColor = Color.Blue;
            
        }

        #region 按钮事件
        private void tsbtnMain_Click(object sender, EventArgs e)
        {
            this.Close();
            SongUtil.MainForm();
        }

        private void tsbtnWhile_Click(object sender, EventArgs e)
        {

        }

        private void tsbtnCutsong_Click(object sender, EventArgs e)
        {

        }

        private void tsbtnPlayed_Click(object sender, EventArgs e)
        {
            this.Close();
            SongUtil.Requested_Played();
        }

        private void tsbtnServer_Click(object sender, EventArgs e)
        {
            KTVUtil.Login();
        }

        private void tsbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            SongUtil.SingerName_Request();
        }

        private void lblMainLand_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblHT_Click(object sender, EventArgs e)
        {
            this.Close();
            SongUtil.singertype();
        }

        private void lblEA_Click(object sender, EventArgs e)
        {
            this.Close();
            SongUtil.singertype();
        }

        private void lblH_Click(object sender, EventArgs e)
        {
            this.Close();
            SongUtil.singertype();
        }

        #endregion
        #region 鼠标悬停事件
        private void lblMainLand_MouseHover(object sender, EventArgs e)
        {
            Inc();
        }

        private void lblHT_MouseHover(object sender, EventArgs e)
        {
            Inc();
        }

        private void lblH_MouseHover(object sender, EventArgs e)
        {
            Inc();
        }

        private void lblEA_MouseHover(object sender, EventArgs e)
        {
            Inc();
        }
        #endregion

        /// <summary>
        /// 鼠标悬停事件
        /// </summary>
        public void Inc()
        {
            this.lblMainLand.Cursor = Cursors.Hand;
            this.lblHT.Cursor = Cursors.Hand;
            this.lblH.Cursor = Cursors.Hand;
            this.lblEA.Cursor = Cursors.Hand;
        }


    }
}
