using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyKTV.ManageForms;
using MyKTV;
using System.Windows.Forms;
using System.IO;

namespace MyKTV
{

    /// <summary>
    /// KTV辅助类
    /// 本类中实例化了各窗体对象，定义辅助方法
    /// </summary>
    public class KTVUtil
    {
        #region 各窗体的预定义
        /// <summary>
        /// 增加歌手窗体
        /// </summary>
        public static FrmAddSinger addsinger = null;

        public static void AddSingerOfWindows()
        {
            if (KTVUtil.addsinger == null || KTVUtil.addsinger.IsDisposed)
            {
                KTVUtil.addsinger = new MyKTV.ManageForms.FrmAddSinger();

                KTVUtil.addsinger.Show();

            }
        }

        /// <summary>
        /// 关于
        /// </summary>
        public static FrmAbout about = null;

        /// <summary>
        /// 显示帮助窗体
        /// </summary>

        public static void AboutOfWindows()
        {
            KTVUtil.about = null;

            if (KTVUtil.about == null || KTVUtil.about.IsDisposed)
            {
                KTVUtil.about = new MyKTV.ManageForms.FrmAbout();
                KTVUtil.about.ShowDialog(FrmAdmin.admin);
                KTVUtil.about.Dispose();
            }
        }

        /// <summary>
        /// 增加歌曲窗体
        /// </summary>
        public static FrmAddSong addsong = null;
       
        /// <summary>
        /// 增加歌曲窗体
        /// </summary>
        public static void AddSongOfWindows()
        {
            if (KTVUtil.addsong == null || KTVUtil.addsong.IsDisposed)
            {
                KTVUtil.addsong = new MyKTV.ManageForms.FrmAddSong();

                KTVUtil.addsong.Show();
            }
        }

        /// <summary>
        /// 设置歌曲路径窗体
        /// </summary>
        public static FrmSongPath songpath = null;

        /// <summary>
        /// 设置歌曲路径窗体
        /// </summary>
        public static void SetSongSourceOfWindows()
        {
            if (KTVUtil.songpath == null || KTVUtil.songpath.IsDisposed)
            {
                KTVUtil.songpath = new MyKTV.ManageForms.FrmSongPath();
                KTVUtil.songpath.ShowDialog(FrmAdmin.admin);
                KTVUtil.songpath.Dispose();
            }
        }


        /// <summary>
        /// 搜索歌曲窗体
        /// </summary>
        public static FrmSearchSong searchsong = null;
        /// <summary>
        /// 搜索歌曲窗体
        /// </summary>
        public static void SearchSongOfWindows()
        {
            if (KTVUtil.searchsong == null || KTVUtil.searchsong.IsDisposed)
            {
                KTVUtil.searchsong = new MyKTV.ManageForms.FrmSearchSong();

                KTVUtil.searchsong.Show();
            }
        }


        /// <summary>
        /// 设置歌手图片路径窗体
        /// </summary>
        public static FrmPhotoPath photopath = null;
       
        /// <summary>
        /// 设置歌手图片路径窗体
        /// </summary>
        public static void SetPhotoSourceOfWindows()
        {
            if (KTVUtil.photopath == null || KTVUtil.photopath.IsDisposed)
            {
                KTVUtil.photopath = new MyKTV.ManageForms.FrmPhotoPath();

                KTVUtil.photopath.ShowDialog(FrmAdmin.admin);
                KTVUtil.photopath.Dispose();
            }
        }

        /// <summary>
        /// 搜索歌手信息窗体
        /// </summary>
        public static FrmSearchSinger searchsinger = null;

        /// <summary>
        /// 搜索歌手信息窗体
        /// </summary>
        public static void SearchSingerOfWindows()
        {
            if (KTVUtil.searchsinger == null || KTVUtil.searchsinger.IsDisposed)
            {
                KTVUtil.searchsinger = new MyKTV.ManageForms.FrmSearchSinger();

                KTVUtil.searchsinger.Show();
            }
        }

        /// <summary>
        /// 登录窗体
        /// </summary>
        public static FrmLogin login = null;

        /// <summary>
        /// 如果用户单击了服务按钮，则跳转到登录窗体
        /// </summary>

        public static void Login()
        {
            if (KTVUtil.login == null || KTVUtil.login.IsDisposed)
            {
                KTVUtil.login = new MyKTV.ManageForms.FrmLogin();
                KTVUtil.login.ShowDialog();
                KTVUtil.login.Dispose();
                //return true;
            }
            //return false;

        }


        #endregion
 
        #region 字段！
        /// <summary>
        /// 歌手照片存放路径
        /// </summary>
        public static string singerPhotoPath = " ";

        /// <summary>
        /// 歌曲名！
        /// </summary>
        public static string SongName = "";

        /// <summary>
        /// 歌曲拼音名！
        /// </summary>
        public static string SongAb = "";

        /// <summary>
        /// 歌手名！
        /// </summary>
        public static string SingerName = "";

        /// <summary>
        /// 歌曲类型！
        /// </summary>
        public static string SongType = "";

        /// <summary>
        /// 歌曲物理文件名！
        /// </summary>
        public static string Song = "";
#endregion

        #region 获取媒体文件路径！
        /// <summary>
        /// 歌曲存放路径
        /// </summary>
        public static string songPath = " ";
        
        /// <summary>
        /// 获取媒体文件路径！
        /// </summary>
        /// <returns></returns>
        public static string GetFileSource()
        {
            try
            {
                DBHelper.sql = @"select song_url,song_name from song_info";
                DBHelper.OpenCon();
                DBHelper.cm = new System.Data.SqlClient.SqlCommand(DBHelper.sql, DBHelper.Cn);
                DBHelper.dreader = DBHelper.cm.ExecuteReader();
                while (DBHelper.dreader.Read())
                {
                    string songurl = SelectSource().Substring(0,3) + string.Format(@"{0}\{1}", DBHelper.dreader["song_url"], DBHelper.dreader["song_name"]);
                    return songurl;
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                DBHelper.dreader.Close();
                DBHelper.CloseCon();
            }
        }
        #endregion

        #region 选择路径！！
        /// <summary>
        /// 选择路径！
        /// </summary>
        /// <returns>返回路径！</returns>
        public static string SelectSource()
        {
            FolderBrowserDialog fdbsource = new FolderBrowserDialog();
            fdbsource.Description = "请选择媒体文件目录！";
            fdbsource.SelectedPath = "C:\\";
            if(fdbsource.ShowDialog() == DialogResult.OK)
            {
                songPath = fdbsource.SelectedPath;
                return songPath;
            }
            return null;
        }
        #endregion

        /// <summary>
        /// 退出系统
        /// </summary>
        public static void Exit()
        {
            DialogResult ds = MessageBox.Show("确定要退出吗？", "退出提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ds == DialogResult.OK)
            {
                Application.Exit();

            }
        }


    }
}
