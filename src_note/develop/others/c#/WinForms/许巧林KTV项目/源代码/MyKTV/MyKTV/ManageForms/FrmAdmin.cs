using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyKTV;
namespace MyKTV.ManageForms
{
    public partial class FrmAdmin : Form
    {
        
        public FrmAdmin()
        {
            InitializeComponent();
           
        }
        public static FrmAdmin admin = new FrmAdmin();
        /// 初始化窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            IsMdiContainer = true;
            this.MainMenuStrip.ForeColor = Color.Blue;
            //this.MainMenuStrip.ContextMenuStrip.ForeColor = Color.Blue;
            this.ForeColor = Color.Blue;
            WindowState = FormWindowState.Maximized;
        }

        #region 菜单栏单击事件
        /// <summary>
        /// 搜素歌手信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmSeachSinger_Click(object sender, EventArgs e)
        {
            KTVUtil.SearchSingerOfWindows();
        }

        /// <summary>
        /// 搜素歌曲信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmSearchSong_Click(object sender, EventArgs e)
        {
            KTVUtil.SearchSongOfWindows();
        }

        /// <summary>
        /// 增加歌曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmAddSong_Click(object sender, EventArgs e)
        {
            KTVUtil.AddSongOfWindows();
        }

        /// <summary>
        /// 设置歌手图片路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmSetPsource_Click(object sender, EventArgs e)
        {
            KTVUtil.SetPhotoSourceOfWindows();
        }

        /// <summary>
        /// 设置歌曲路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmSetSsource_Click(object sender, EventArgs e)
        {
            KTVUtil.SetSongSourceOfWindows();
        }


        /// <summary>
        /// 新增歌手
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmAddSinger_Click(object sender, EventArgs e)
        {
            KTVUtil.AddSingerOfWindows();
        }

        /// <summary>
        ///显示帮助窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mstsmHelp_Click(object sender, EventArgs e)
        {
            KTVUtil.AboutOfWindows();
        }

        /// <summary>
        /// 退出后台管理系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmExit_Click(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("确定要退出KTV后台管理系统吗？","退出提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if(ds == DialogResult.OK)
            {
                this.Close();
            }
        }

        #endregion


    }
}
