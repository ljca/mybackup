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
    public partial class FrmOrderBySongType : Form
    {
        public FrmOrderBySongType()
        {
            InitializeComponent();
        }
        FrmSongList list = new FrmSongList();
        /// <summary>
        /// 窗体初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmOrderBySongType_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            DBHelper.sql = string.Format(@"select a.song_name,b.singer_name 
from song_info as a 
inner join singer_info as b on a.singer_id = b.singer_id
inner join song_type as c on c.songtype_id = a.songtype_id
where songtype_name = '{0}' ", GetSongType());
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


        #region 鼠标悬停事件！
        private void lbPop_MouseHover(object sender, EventArgs e)
        {
            lbPop.Cursor = Cursors.Hand;
        }

        private void lbOld_MouseHover(object sender, EventArgs e)
        {
            lbOld.Cursor = Cursors.Hand;
        }

        private void lbM_MouseHover(object sender, EventArgs e)
        {
            lbM.Cursor = Cursors.Hand;
        }

        private void lbGame_MouseHover(object sender, EventArgs e)
        {
            lbGame.Cursor = Cursors.Hand;
        }

        private void lbJ_MouseHover(object sender, EventArgs e)
        {
            lbJ.Cursor = Cursors.Hand;
        }

        private void lbSiner_MouseHover(object sender, EventArgs e)
        {
            lbSiner.Cursor = Cursors.Hand;
        }

        #endregion

        #region 标签控件双击事件！
        private void lbPop_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (list.SongList(DBHelper.sql))
            {
                FrmSongList.sql = DBHelper.sql;
                SongUtil.SongOfWindows();
            }
        }

        private void lbOld_DoubleClick(object sender, EventArgs e)
        {
            if (list.SongList(DBHelper.sql))
            {
                FrmSongList.sql = DBHelper.sql;
                SongUtil.SongOfWindows();
            }
        }

        private void lbM_Click(object sender, EventArgs e)
        {
            if (list.SongList(DBHelper.sql))
            {
                FrmSongList.sql = DBHelper.sql;
                SongUtil.SongOfWindows();
            }

        }

        private void lbGame_Click(object sender, EventArgs e)
        {
            if (list.SongList(DBHelper.sql))
            {
                FrmSongList.sql = DBHelper.sql;
                SongUtil.SongOfWindows();
            }
        }

        private void lbJ_Click(object sender, EventArgs e)
        {
            if (list.SongList(DBHelper.sql))
            {
                FrmSongList.sql = DBHelper.sql;
                SongUtil.SongOfWindows();
            }
        }

        private void lbSiner_Click(object sender, EventArgs e)
        {
            if (list.SongList(DBHelper.sql))
            {
                FrmSongList.sql = DBHelper.sql;
                SongUtil.SongOfWindows();
            }
        }
        #endregion

        #region 获得歌曲类型！
        /// <summary>
        /// 获得歌曲类型
        /// </summary>
        /// <returns></returns>
        public string GetSongType()
        {
            if(this.lbPop.Text == "热门流行")
            {
                return lbPop.Text;
            }
            else if(this.lbOld.Text == "经典老歌")
            {
                return this.lbOld.Text;
            }
            else if (this.lbM.Text == "影视金曲")
            {
                return this.lbM.Text;
            }
            else if (this.lbGame.Text == "游戏动漫")
            {
                return lbGame.Text;
            }
            else if (this.lbJ.Text == "京剧")
            {
                return lbJ.Text;
            }
            else if (this.lbSiner.Text == "儿歌")
            {
                return lbSiner.Text;
            }

            return null;
        }

        #endregion

    }
}
