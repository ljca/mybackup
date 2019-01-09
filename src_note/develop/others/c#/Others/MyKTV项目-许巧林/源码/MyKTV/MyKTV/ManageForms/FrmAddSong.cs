using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKTV.ManageForms
{
    public partial class FrmAddSong : Form
    {
        public FrmAddSong()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAddSong_Load(object sender, EventArgs e)
        {
            #region
            //FrmAdmin.admin.Init();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MdiParent = MyKTV.ManageForms.FrmAdmin.admin;
            this.ShowInTaskbar = false;
            this.ForeColor = Color.Blue;
            this.txtSongab.ForeColor = Color.Blue;
            this.txtSongN.ForeColor = Color.Blue;
            this.txtSongName.ForeColor = Color.Blue;
            this.cboSongType.ForeColor = Color.Blue;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            #endregion
            #region 赋值！

            this.txtSongN.Text = KTVUtil.SongName;
            this.txtSongab.Text = KTVUtil.SongAb;
            this.txtSinger.Text = KTVUtil.SingerName;
            //this.txtSongName.Text = KTVUtil.Song;
            this.cboSongType.Text = KTVUtil.SongType;
            #endregion
            SongTypeList();
        }
#region 按钮事件
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchSinger();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SelectFile();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(InsertSong() == 1)
               {
                   MessageBox.Show("保存成功！", "提示");
                   this.Close();
               }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     

#endregion
 
        #region 其他方法
        /// <summary>
        /// 选择音乐！
        /// </summary>
        public string SelectFile()
        {
            ofdBrowse.Title = "请选择媒体文件：";
            ofdBrowse.FileName = null;

            ofdBrowse.InitialDirectory = "E:\\";
            ofdBrowse.Filter = "mp3格式声音(*.mp3)|*.mp3|aac压缩文件(*.aac;*.m4a;*.m3u)|*.aac;*.m4a;*.m3u|视频文件(*.mp4;*.wmv)|*.mp4;*.wmv|所有文件(*.*)|*.*";
            ofdBrowse.FilterIndex = 1;
            if (ofdBrowse.ShowDialog() == DialogResult.OK)
            {
                this.txtSongName.Text = ofdBrowse.SafeFileName.Substring(0,ofdBrowse.SafeFileName.Length - 4);
                this.txtSongN.Text = this.txtSongName.Text;
                return this.ofdBrowse.SafeFileName;
            }
            return null;
        }

        /// <summary>
        /// 歌曲类型列表
        /// </summary>
        private void SongTypeList()
        {
            string sql = "select * from [song_type]";
            DBHelper.ds = new DataSet("song_type");
            DBHelper.da = new System.Data.SqlClient.SqlDataAdapter(sql, DBHelper.constr);
            DBHelper.da.Fill(DBHelper.ds, "song_type");
            this.cboSongType.ValueMember = "songtype_id";
            this.cboSongType.DisplayMember = "songtype_name";
            this.cboSongType.DataSource = DBHelper.ds.Tables["song_type"];
        }

        #region
        /// <summary>
        /// 搜索歌手
        /// </summary>
        /// <returns></returns>
        public bool SearchSinger()
        {
            //if()
            //{
            DBHelper.sql = "select singer_name from [singer_info]";
            DBHelper.OpenCon();
            DBHelper.cm = new System.Data.SqlClient.SqlCommand(DBHelper.sql, DBHelper.Cn);
            DBHelper.dreader = DBHelper.cm.ExecuteReader();
            while(DBHelper.dreader.Read())
            {
                StringBuilder bulier = new StringBuilder();
                bulier.AppendFormat("歌手a\t歌手b",DBHelper.dreader[0],DBHelper.dreader[0]);
                MessageBox.Show("歌手:" + bulier.ToString());
                DBHelper.dreader.Close();
                DBHelper.CloseCon();
                return true;
            }
            return false;
 
        }
        #endregion

        #region 非空验证！
        /// <summary>
        /// 非空验证！
        /// </summary>
        public bool Check()
        {
            if (this.txtSongab.Text.Trim().Equals(string.Empty) || this.txtSongN.Text.Trim().Equals(string.Empty) || this.txtSongName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("项不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //this.txtSinger.ResetText();
                this.txtSongab.ResetText();
                this.txtSongN.ResetText();
                this.txtSongName.ResetText();
                this.txtSongName.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region 添加歌曲！
        /// <summary>
        ///添加歌曲
        /// </summary>
        public int InsertSong()
        {
            if (Check() /*非空验证通过后，则插入数据到数据库！*/ )
            {
                DBHelper.sql = string.Format(@"insert into [song_info](song_name,song_ab) values('{0}','{1}' go insert into [song_type](songtype_name) vaules('{2}')) go insert into [singer_info](song_name) vaules('{3}') go ",txtSongN.Text,txtSongab.Text.Trim(),cboSongType.Text.Trim(),txtSinger.Text.Trim());
                try
                {
                    DBHelper.OpenCon();
                    DBHelper.cm = new System.Data.SqlClient.SqlCommand(DBHelper.sql, DBHelper.Cn);
                    if (DBHelper.cm.ExecuteNonQuery() != 0)
                    {
                        return DBHelper.cm.ExecuteNonQuery();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return -1;
                    throw;
                }

                finally
                {
                    DBHelper.CloseCon();
                }
            }
            return 0;
        }
        #endregion

        #endregion
    }
}
