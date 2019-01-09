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
            this.ShowInTaskbar = false;
            SongList();
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
       
        /// <summary>
        /// 歌曲列表
        /// </summary>
        /// <returns></returns>
        public bool SongList()
        {
            string sql = @"select song_name,singer_id from [song_info] as a,[singer_info] as b where a.singer_id = b.singer_id";
            if(1 + 1 == 2)
            {
                try
                {
                    this.dgvMusicList.AutoGenerateColumns = false;
                    this.dgvMusicList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    DBHelper.ds = new DataSet("song_info");
                    DBHelper.da = new System.Data.SqlClient.SqlDataAdapter(sql, DBHelper.constr);
                    if (DBHelper.ds.Tables[0] != null)
                    {
                        DBHelper.ds.Tables[0].Clear();
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
    }
}
