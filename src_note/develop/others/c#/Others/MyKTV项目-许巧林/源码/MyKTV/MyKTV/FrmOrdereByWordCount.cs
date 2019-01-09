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
    public partial class FrmOrdereByWordCount : Form
    {
        public FrmOrdereByWordCount()
        {
            InitializeComponent();
        }

        FrmSongList list = new FrmSongList();
        /// <summary>
        /// 窗体初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmOrdereByWordCount_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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

        #region 标签控件单击事件！
        private void lbwordsone_Click(object sender, EventArgs e)
        {
            DBHelper.sql = @"select a.song_name,b.singer_name from song_info  as a inner join singer_info as b on b.singer_id = a.singer_id where song_word_count = 1";

            if (list.SongList(DBHelper.sql))
            {
                FrmSongList.sql = DBHelper.sql;
                SongUtil.SongOfWindows();
            }
        }

        private void lbwordstwo_Click(object sender, EventArgs e)
        {
            DBHelper.sql = @"select a.song_name,b.singer_name from song_info  as a inner join singer_info as b on b.singer_id = a.singer_id where song_word_count = 2";

            if (list.SongList(DBHelper.sql))
            {
                FrmSongList.sql = DBHelper.sql;
                SongUtil.SongOfWindows();
            }
            else
            {
                MessageBox.Show("未搜索到相关长度的歌曲！");
            }
        }

        private void lbwordsthree_Click(object sender, EventArgs e)
        {
            DBHelper.sql = @"select a.song_name,b.singer_name from song_info  as a inner join singer_info as b on b.singer_id = a.singer_id where song_word_count = 3";

            if (list.SongList(DBHelper.sql))
            {
                FrmSongList.sql = DBHelper.sql;
                SongUtil.SongOfWindows();
            }
            else
            {
                MessageBox.Show("未搜索到相关长度的歌曲！");
            }
        }

        private void lbwordsfor_Click(object sender, EventArgs e)
        {
            DBHelper.sql = @"select a.song_name,b.singer_name from song_info  as a inner join singer_info as b on b.singer_id = a.singer_id where song_word_count = 4";

            if (list.SongList(DBHelper.sql))
            {
                FrmSongList.sql = DBHelper.sql;
                SongUtil.SongOfWindows();
            }
        }

        private void lbwordsfive_Click(object sender, EventArgs e)
        {
            DBHelper.sql = @"select a.song_name,b.singer_name from song_info  as a inner join singer_info as b on b.singer_id = a.singer_id where song_word_count = 5";

            if (list.SongList(DBHelper.sql))
            {
                FrmSongList.sql = DBHelper.sql;
                SongUtil.SongOfWindows();
            }
            else
            {
                MessageBox.Show("未搜索到相关长度的歌曲！");
            }
        }
        #endregion

        #region 鼠标悬停事件！
        private void lbwordsone_MouseHover(object sender, EventArgs e)
        {
            this.lbwordsone.Cursor = Cursors.Hand;
        }

        private void lbwordstwo_MouseHover(object sender, EventArgs e)
        {
            this.lbwordstwo.Cursor = Cursors.Hand;
        }

        private void lbwordsthree_MouseHover(object sender, EventArgs e)
        {
            this.lbwordsthree.Cursor = Cursors.Hand;
        }

        private void lbwordsfor_MouseHover(object sender, EventArgs e)
        {
            this.lbwordsfor.Cursor = Cursors.Hand;
        }

        private void lbwordsfive_MouseHover(object sender, EventArgs e)
        {
            this.lbwordsfive.Cursor = Cursors.Hand;
        }

        #endregion
    }
}
