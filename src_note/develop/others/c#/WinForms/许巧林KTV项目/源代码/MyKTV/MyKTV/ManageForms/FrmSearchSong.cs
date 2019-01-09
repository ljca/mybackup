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
        string sql = @"select a.song_name,a.song_ab,a.song_play_count,b.songtype_name from [song_info] as a,[song_type] as b
where b.songtype_id = a.songtype_id";

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
            this.dgvSearchSong.ForeColor = Color.Blue;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ContextMenuStrip = this.cmsMusicsearch;
            this.dgvSearchSong.CellBorderStyle = DataGridViewCellBorderStyle.None;
            this.dgvSearchSong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            #endregion
            FillData();
            //SearchSong(this.sql);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!txtSongName.Text.Trim().Equals(string.Empty))
            {
                string sql = string.Format(@"select a.song_name,a.song_ab,a.song_play_count,b.songtype_name from [song_info] as a
inner join [song_type] as b on b.songtype_id = a.songtype_id
where song_name like '%{0}%' and songtype_name = '{1}' ", this.txtSongName.Text.Trim(), this.cboSongType.Text);
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
                this.dgvSearchSong.AutoGenerateColumns = false;
                DBHelper.ds = new DataSet("song_info");
                DBHelper.da = new SqlDataAdapter(strsql, DBHelper.constr);
                if (DBHelper.ds.Tables["song_info"] != null)
                {
                    DBHelper.ds.Tables["song_info"].Clear();
                }

                DBHelper.da.Fill(DBHelper.ds, "song_info");
                this.dgvSearchSong.DataSource = DBHelper.ds.Tables["song_info"];
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

        private void tsmsEdit_Click(object sender, EventArgs e)
        {
            if (EditSong())
            {
                KTVUtil.AddSongOfWindows();
            }
            else
            {
                MessageBox.Show("暂不支持多行修改！");
                return;
            }
        }

        private void tsmsDel_Click(object sender, EventArgs e)
        {
            if(DelSong())
            {
                MessageBox.Show("删除成功！","删除提示！");
                SearchSong(this.sql);
            }
            else
            {
                MessageBox.Show("删除数据失败！","删除提示！");
                return;
            }
        }
        #endregion

        #region

        /// <summary>
        /// 编辑歌手！
        /// </summary>
        /// <returns>真！</returns>
        public bool EditSong()
        {
            if (this.dgvSearchSong.SelectedRows.Count == 1)
            {
                KTVUtil.SongName = this.dgvSearchSong.SelectedRows[0].Cells["SongName"].Value.ToString();
                KTVUtil.SongAb = this.dgvSearchSong.SelectedRows[0].Cells["SongAb"].Value.ToString();
                KTVUtil.SongType = this.dgvSearchSong.SelectedRows[0].Cells["SongType"].Value.ToString();
                //KTVUtil.SingerName = this.dgvSearchSong.SelectedRows[0].Cells[""].Value.ToString();
                return true;
            }
            return false;
        }

        /// <summary>
        /// 删除歌曲！
        /// </summary>
        /// <returns></returns>
        private bool DelSong()
        {
            DialogResult re = MessageBox.Show("确定要删除歌曲记录吗？", "删除提示！");
            if (this.dgvSearchSong.SelectedRows.Count == 1)
            {
                if (re == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        DBHelper.sql = string.Format(@"delete from song_info where song_name = '{0}' ",dgvSearchSong.SelectedRows[0].Cells["SongName"].Value.ToString());
                        DBHelper.OpenCon();
                        DBHelper.cm = new SqlCommand(DBHelper.sql, DBHelper.Cn);
                        if (DBHelper.cm.ExecuteNonQuery() != 0)
                        {
                            return true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return false;
                        throw;
                    }
                    finally 
                    {
                        DBHelper.CloseCon();
                    }
                }
                else
                {
                    return false;
                }

            }
            return false;
        } //删除歌手方法结束

        #endregion

    }
}
