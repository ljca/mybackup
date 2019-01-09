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
    public partial class FrmSingerType_2 : Form
    {
        public FrmSingerType_2()
        {
            InitializeComponent();
        }

        private void FrmSingerType_2_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ShowInTaskbar = false;
            this.ForeColor = Color.Blue;
        }

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
            SongUtil.BySingerType();
        }
    }
}
