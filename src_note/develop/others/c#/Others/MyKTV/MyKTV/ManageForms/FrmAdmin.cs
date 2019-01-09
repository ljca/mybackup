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
        public static FrmAdmin admin = new FrmAdmin();
        public FrmAdmin()
        {
            InitializeComponent();
           
        }
        
        /// <summary>
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
            if(KTVUtil.searchsinger == null || KTVUtil.searchsinger.IsDisposed)
            {
                KTVUtil.searchsinger = new MyKTV.ManageForms.FrmSearchSinger();
                
                KTVUtil.searchsinger.Show();
            }
        }

        /// <summary>
        /// 搜素歌曲信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmSearchSong_Click(object sender, EventArgs e)
        {
            if(KTVUtil.searchsong == null || KTVUtil.searchsong.IsDisposed)
            {
                KTVUtil.searchsong = new MyKTV.ManageForms.FrmSearchSong();
               
                KTVUtil.searchsong.Show();
            }

        }

        /// <summary>
        /// 增加歌曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmEditSong_Click(object sender, EventArgs e)
        {
            if(KTVUtil.addsong == null || KTVUtil.addsong.IsDisposed)
            {
                KTVUtil.addsong = new MyKTV.ManageForms.FrmAddSong();

                KTVUtil.addsong.Show();
            }
        }

        /// <summary>
        /// 设置歌手图片路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmSetPsource_Click(object sender, EventArgs e)
        {
            if(KTVUtil.photopath == null || KTVUtil.photopath.IsDisposed)
            {
                KTVUtil.photopath = new MyKTV.ManageForms.FrmPhotoPath();
               
                KTVUtil.photopath.Show();
            }  
        }

        /// <summary>
        /// 设置歌曲路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmSetSsource_Click(object sender, EventArgs e)
        {
            if (KTVUtil.songpath == null || KTVUtil.songpath.IsDisposed)
            {
                KTVUtil.songpath = new MyKTV.ManageForms.FrmSongPath();
                KTVUtil.songpath.Show();
            }
        }


        /// <summary>
        /// 新增歌手
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmAddSinger_Click(object sender, EventArgs e)
        {
            if (KTVUtil.edit == null || KTVUtil.edit.IsDisposed)
            {
                KTVUtil.edit = new MyKTV.ManageForms.FrmEditSinger();
                
                KTVUtil.edit.Show();
               
            }
            
            //KTVUtil.EditSinger();
        }

        /// <summary>
        ///显示帮助窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mstsmHelp_Click(object sender, EventArgs e)
        {
            KTVUtil.about = null;

            if(KTVUtil.about == null || KTVUtil.about.IsDisposed)
            {
                KTVUtil.about = new MyKTV.ManageForms.FrmAbout();

                KTVUtil.about.ShowDialog();
                KTVUtil.about.Dispose();

            }
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


        /// <summary>
        /// 初始化窗体
        /// </summary>
        public void Init()
        {
            //FrmAdmin.admin.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            MdiParent = FrmAdmin.admin;
            this.ShowInTaskbar = false;
            this.ForeColor = Color.Blue;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

    }
}
