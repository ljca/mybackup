using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmShowInfo
{
    public partial class FrmShowInfo : Form
    {
        public FrmShowInfo()
        {
            InitializeComponent();
        }

        string sq = "";
        private void FrmShowInfo_Load(object sender, EventArgs e)
        {
            this.txtSingerName.Text = "请输入歌手(双击文本框则清空).....";
            txtSongName.Text = "请输入歌曲(双击文本框则清空).....";
            ForeColor = Color.Blue;
            txtSingerName.ForeColor = Color.Blue;
            txtSongName.ForeColor = Color.Blue;
            label2.ForeColor = Color.Blue;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnsearh_Click(object sender, EventArgs e)
        {
            SearchSong();
        }

        private void txtSingerName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtSingerName.ResetText();
        }

        private void txtSongName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtSongName.ResetText();
        }

        #region 搜索歌手！
        /// <summary>
        /// 搜索！
        /// </summary>
        /// <returns></returns>
        private void Search()
        {
            sq = "";
            try
            {
                //if (txtSingerName.Text != "")
                //{
                DBHelper.sql = string.Format(@"
select singer_name,singer_sex,singer_photo_url,a.singertype_name
from singer_info
inner join singer_type as a on (a.singertype_id = singer_info.singertype_id)
where singer_name like '%{0}%' ", txtSingerName.Text);
                DBHelper.CheckCn();
                DBHelper.GetReader(DBHelper.sql);

                while (DBHelper.dr.Read())
                {
                    string Name = DBHelper.dr["singer_name"].ToString();
                    string sex = DBHelper.dr["singer_sex"].ToString();
                    string url = DBHelper.dr["singer_photo_url"].ToString();
                    string singertype_name = DBHelper.dr["singertype_name"].ToString();

                    sq += string.Format("歌手: {0}   歌手类别: {1}   歌手图片路径: {2}  歌手类型: {3}\n", Name, sex, url, singertype_name);
                }

                this.txtSingerName.Text = "请输入歌手(双击文本框则清空).....";
                MessageBox.Show(sq, "输出提示！");
            }
            //}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            finally
            {
                DBHelper.dr.Close();
                DBHelper.CheckCn();
            }
        }
        #endregion

        #region 搜索歌曲！
        /// <summary>
        /// 搜索歌曲
        /// </summary>
        private void SearchSong()
        {
            sq = "";
            try
            {
                //if (txtSingerName.Text != "")
                //{
                DBHelper.sql = string.Format(@"
select a.song_name,b.singer_name,c.songtype_name
from song_info as a
inner join singer_info as b on (a.singer_id = b.singer_id)
inner join song_type as c on (c.songtype_id = a.songtype_id)
where song_name like '%{0}%' ", txtSongName.Text);
                DBHelper.CheckCn();
                DBHelper.GetReader(DBHelper.sql);

                while (DBHelper.dr.Read())
                {
                    string Name = DBHelper.dr["song_name"].ToString();
                    string singer_name = DBHelper.dr["singer_name"].ToString();
                    string songtype_name = DBHelper.dr["songtype_name"].ToString();

                    sq += string.Format("歌曲: {0}   歌手: {1}   类型: {2}\n", Name,singer_name, songtype_name);
                }

                txtSongName.Text = "请输入歌曲(双击文本框则清空).....";
                MessageBox.Show(sq, "输出提示！");
            }
            //}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            finally
            {
                DBHelper.dr.Close();
                DBHelper.CheckCn();
            }
        }

        #endregion

        }
    }

