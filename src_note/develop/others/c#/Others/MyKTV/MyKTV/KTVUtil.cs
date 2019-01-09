using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyKTV.ManageForms;
using MyKTV;
using System.Windows.Forms;

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
       public static FrmEditSinger edit = null;

       /// <summary>
       /// 关于
       /// </summary>
       public static FrmAbout about = null;

       /// <summary>
       /// 增加歌曲窗体
       /// </summary>
       public static FrmAddSong addsong = null;

       /// <summary>
       /// 设置歌曲路径窗体
       /// </summary>
       public static FrmSongPath songpath = null;

       /// <summary>
       /// 搜索歌曲窗体
       /// </summary>
       public static FrmSearchSong searchsong = null;

       /// <summary>
       /// 设置歌手图片路径窗体
       /// </summary>
       public static FrmPhotoPath photopath = null;

       /// <summary>
       /// 搜索歌手窗体
       /// </summary>
       public static FrmSearchSinger searchsinger = null;

       /// <summary>
       /// 登录窗体
       /// </summary>
       public static FrmLogin login = null;
       #endregion
       /// <summary>
       /// 歌手照片存放路径
       /// </summary>
        public static string singerPhotoPath = " ";
       
       /// <summary>
       /// 歌曲存放路径
       /// </summary>
        public static string songPath = " ";

       /// <summary>
       /// 如果用户单击了服务按钮，则跳转到登录窗体
       /// </summary>
 
       public static bool Login()
        {
            if (KTVUtil.login == null || KTVUtil.login.IsDisposed)
            {
                KTVUtil.login = new MyKTV.ManageForms.FrmLogin();
                KTVUtil.login.Show();
                return true;
            }
            return false;
        
        }

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
