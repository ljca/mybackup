using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSearch
{
    public partial class FrmShowM : Form
    {
        public FrmShowM()
        {
            InitializeComponent();
        }

        #region 字段！
        /// <summary>
        /// 歌曲名！
        /// </summary>
        public static string SongName = "";

        /// <summary>
        /// 歌手名！
        /// </summary>
        public static string SingerName = "";

        /// <summary>
        /// 歌曲拼音！
        /// </summary>
        public static string SongAb = "";

        /// <summary>
        /// 歌曲类型！
        /// </summary>
        public static string SongType = "";

        /// <summary>
        /// 歌曲物理文件地址！
        /// </summary>
        public static string SongUrl = "";

        #endregion


        private void FrmShowM_Load(object sender, EventArgs e)
        {
           #region 窗体初始化！
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            
            StartPosition = FormStartPosition.CenterScreen;
            this.txtSongName.ForeColor = Color.Blue;
            this.txtSingerName.ForeColor = Color.Blue;
            this.txtSongType.ForeColor = Color.Blue;
            this.txtSongAb.ForeColor = Color.Blue;
            this.txtSongUrl.ForeColor = Color.Blue;
#endregion

            #region 赋值
            this.txtSongName.Text = SongName;
            this.txtSingerName.Text = SingerName;
            this.txtSongType.Text = SongType;
            this.txtSongAb.Text = SongAb;
            this.txtSongUrl.Text = SongUrl;
            #endregion

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            if (DeleteData() == 1)
            {
                MessageBox.Show("", "");
            }
            else
            {
                MessageBox.Show("", "");
            }

        }


        /// <summary>
        /// 保存数据的方法！
        /// </summary>
        /// <returns></returns>
        private bool Save()
        {
            try
            {

                return true;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }



        /// <summary>
        /// 删除数据！
        /// </summary>
        /// <returns></returns>
        private int DeleteData()
        {

            try
            {

                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
                throw;
            }
        
        }

    }
}
