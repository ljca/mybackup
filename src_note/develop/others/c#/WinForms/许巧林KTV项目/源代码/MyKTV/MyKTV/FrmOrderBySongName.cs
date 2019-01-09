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
    public partial class FrmOrderBySongName : Form
    {
        public FrmOrderBySongName()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmOrderBySongName_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.dgvMusicList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusicList.AutoGenerateColumns = false;
            this.lblSongName.Text = "请输入歌曲名称或拼音缩写";
            this.txtSongName.Text = "ZJL";
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmSongList list = new FrmSongList();
            string sql = string.Format(@"select a.song_name,b.singer_name from song_info as a inner join singer_info as b on b.singer_id = a.singer_id where a.song_ab like '%{0}%' ", txtSongName.Text);// or a.song_name like '%{1}%' ", txtSongName.Text, txtSongName.Text);
            list.SongList(sql);
            
        }


    }
}
