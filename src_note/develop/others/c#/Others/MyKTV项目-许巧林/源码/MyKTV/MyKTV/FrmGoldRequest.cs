using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            this.dgvSonglist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FillData();
        }

        #region 填充数据！
        /// <summary>
        /// 填充数据！
        /// </summary>
        /// <returns></returns>
        public bool FillData()
        {
            try
            {
                DBHelper.sql = @"select a.song_name,b.songtype_name,a.song_play_count
from song_info as a,song_type as b
where a.songtype_id = b.songtype_id order by a.song_play_count desc";
                dgvSonglist.AutoGenerateColumns = false;
                DBHelper.ds = new DataSet("song_info");
                DBHelper.da = new SqlDataAdapter(DBHelper.sql, DBHelper.constr);
                if (DBHelper.ds.Tables["song_info"] != null)
                {
                    DBHelper.ds.Tables["song_info"].Clear();
                }

                DBHelper.da.Fill(DBHelper.ds, "song_info");
                this.dgvSonglist.DataSource = DBHelper.ds.Tables["song_info"];
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                //throw;
            }
        }

#endregion

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

        private void dgvSonglist_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dgvSonglist.SelectedRows.Count == 1)
            {
                string source = dgvSonglist.SelectedRows[0].Cells[0].Value.ToString();
                FrmPlay play = new FrmPlay();
                play.Play(source);
            }
        }
    }
}
