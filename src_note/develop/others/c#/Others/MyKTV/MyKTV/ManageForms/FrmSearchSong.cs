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

namespace MyKTV.ManageForms
{
    public partial class FrmSearchSong : Form
    {
        public FrmSearchSong()
        {
            InitializeComponent();
        }
        string sql = @"select song_name,songtype_name,singer_name from [song_info] as b,[singer_info] as s,
[song_type] as c
where b.singer_id = s.singer_id and c.songtype_id = b.songtype_id";

        /// <summary>
        /// 窗体初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSearchSong_Load(object sender, EventArgs e)
        {
            #region
            //this.MdiParent = FrmAdmin.admin;
            //FrmAdmin.admin.Init();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MdiParent = MyKTV.ManageForms.FrmAdmin.admin;
            this.ShowInTaskbar = false;
            this.AcceptButton = this.btnSearch;
            this.ForeColor = Color.Blue;
            this.txtSongName.ForeColor = Color.Blue;
            this.cboSongType.ForeColor = Color.Blue;
            this.dgvSearchSinger.ForeColor = Color.Blue;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ContextMenuStrip = this.cmsMusicsearch;
            this.dgvSearchSinger.CellBorderStyle = DataGridViewCellBorderStyle.None;
            this.dgvSearchSinger.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            #endregion
            FillData();
            //SearchSong(this.sql);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            if (!txtSongName.Text.Trim().Equals(string.Empty))
            {
                string sql = string.Format(@"select a.song_name,b.songtype_name,c.singer_name from song_info as a 
inner join song_type as b on b.songtype_id = a.songtype_id
inner join singer_info as c on c.singer_id = a.singer_id
where a.song_name = '{0}' and b.songtype_name = '{1}'", this.txtSongName.Text.Trim(), this.cboSongType.Text);
                SearchSong(sql);
                if (!SearchSong(sql))
                {
                    MessageBox.Show("未搜索到歌曲!");
                }
            }
            else
            {
                MessageBox.Show("歌曲名为空！");
                SearchSong(this.sql);
            }
        }

        #region
        /// <summary>
        /// 填充数据
        /// </summary>
        public void FillData()
        {
            string sql = "select * from [song_type]";
            DBHelper.ds = new DataSet("song_type");
            DBHelper.da = new System.Data.SqlClient.SqlDataAdapter(sql, DBHelper.constr);
            DBHelper.da.Fill(DBHelper.ds, "song_type");
            this.cboSongType.ValueMember = "songtype_id";
            this.cboSongType.DisplayMember = "songtype_name";
            this.cboSongType.DataSource = DBHelper.ds.Tables["song_type"];
        }

        #region 搜索歌曲
        /// <summary>
        /// 搜索歌曲
        /// </summary>
        public bool SearchSong(string strsql)
        {
            try
            {
                //sql = this.sql;
                this.dgvSearchSinger.AutoGenerateColumns = false;
                DBHelper.ds = new DataSet("song_info");

                //DBHelper.dv = new DataView(DBHelper.ds.Tables["song_info"]);
                //DBHelper.dv.RowFilter = "";
                DBHelper.da = new SqlDataAdapter(strsql, DBHelper.constr);
                if (DBHelper.ds.Tables["song_info"] != null)
                {
                    DBHelper.ds.Tables["song_info"].Clear();
                }

                DBHelper.da.Fill(DBHelper.ds, "song_info");
                this.dgvSearchSinger.DataSource = DBHelper.ds.Tables["song_info"];
                return true;
            }
            catch (Exception)
            {
                return false;
                //throw;
            }

        }
        #endregion
        #endregion
    }
}
