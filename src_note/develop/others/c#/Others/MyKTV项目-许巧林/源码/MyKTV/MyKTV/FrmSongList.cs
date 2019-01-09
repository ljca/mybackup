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
    public partial class FrmSongList : Form
    {
        public FrmSongList()
        {
            InitializeComponent();
        }
       public static string sql = @"select a.song_name,singer_name from [song_info] as a,[singer_info] as b where a.singer_id = b.singer_id";

        /// <summary>
        /// 窗体初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSongList_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.dgvMusicList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.ShowInTaskbar = false;
            SongList(sql);
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
            //this.Close();
            KTVUtil.Login();
        }

        private void tsbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region 其他事件！

        private void dgvMusicList_MouseHover(object sender, EventArgs e)
        {
            this.dgvMusicList.Cursor = Cursors.Hand;
        }

        #endregion


        private void dgvMusicList_Click(object sender, EventArgs e)
        {
            FrmPlay ls = new FrmPlay();
            ls.Play(SongUrl());
        }


        /// <summary>
        /// 歌曲列表
        /// </summary>
        /// <returns></returns>
        public bool SongList(string sql)
        {
            if(1 + 1 == 2)
            {
                try
                {
                    this.dgvMusicList.AutoGenerateColumns = false;
                    DBHelper.ds = new DataSet("song_info");
                    DBHelper.da = new System.Data.SqlClient.SqlDataAdapter(sql, DBHelper.constr);
                    if (DBHelper.ds.Tables["song_info"] != null)
                    {
                        DBHelper.ds.Tables["song_info"].Clear();
                    }
                    DBHelper.da.Fill(DBHelper.ds, "song_info");
                    this.dgvMusicList.DataSource = DBHelper.ds.Tables["song_info"];
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                    throw;
                }
            }
        }

        /// <summary>
        /// 媒体文件路径！
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public string SongUrl()
        {
            if (this.dgvMusicList.SelectedRows.Count == 1)
            {
                sql = string.Format(@"select song_url,song_name from song_info
where song_name like '%{0}%' ", this.dgvMusicList.SelectedRows[0].Cells["SongName"].Value.ToString());
                DBHelper.OpenCon();
                try
                {

                    DBHelper.cm = new System.Data.SqlClient.SqlCommand(sql, DBHelper.Cn);
                    DBHelper.dreader = DBHelper.cm.ExecuteReader();
                    while (DBHelper.dreader.Read())
                    {
                        string url = string.Format(@"{0}\{1}", DBHelper.dreader["song_url"].ToString(), DBHelper.dreader["song_name"].ToString());
                        return url;
                    }
                    DBHelper.dreader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                    throw;
                }

                finally
                {
                    DBHelper.CloseCon();
                }
                return null;
            }
            else
            {
                MessageBox.Show("暂不支持多个媒体文件播放！", "系统提示！");
                MessageBox.Show("媒体文件路径错误！", "系统提示！");
            }
            return null;
        }



    }
}
