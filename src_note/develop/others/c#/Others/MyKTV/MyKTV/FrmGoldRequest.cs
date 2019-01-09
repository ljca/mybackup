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
    public partial class FrmGoldRequest : Form
    {
        public FrmGoldRequest()
        {
            InitializeComponent();
        }

        private void FrmRequest_Load(object sender, EventArgs e)
        {
            this.panel1.Dock = DockStyle.Top;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.dgvSonglist.Dock = DockStyle.Fill;
        }

        #region 工具栏按钮事件
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
        }
        #endregion
    }
}
