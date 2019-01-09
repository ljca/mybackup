using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyKTV;
using MyKTV.ManageForms;
namespace MyKTV
{

    /// <summary>
    /// 自定义类,用以KTV系统客户端窗体的跳转
    /// </summary>
    public class SongUtil
    {
        #region 窗体赋值
        /// <summary>
        /// 字数点歌窗体
        /// </summary>
        public static FrmOrdereByWordCount wordrequest = null;

        /// <summary>
        /// 跳转到字数点歌窗体
        /// </summary>
        public static void Words_Request()
        {
            if (wordrequest == null || wordrequest.IsDisposed)
            {
                wordrequest = new MyKTV.FrmOrdereByWordCount();
                //if (color.ShowDialog() == DialogResult.OK)
                //{
                //    wordrequest.ForeColor = color.Color;
                //}
                wordrequest.Show();
            }
            else
            {
                wordrequest.Show();
            }
        }

        /// <summary>
        /// 金榜排行
        /// </summary>
        public static FrmGoldRequest request = null;

        /// <summary>
        /// 跳转到金榜排行窗体
        /// </summary>
        public static void Goldrequest()
        {

            if (request == null || request.IsDisposed)
            {
                request = new MyKTV.FrmGoldRequest();
                //if (color.ShowDialog() == DialogResult.OK)
                //{
                //    request.ForeColor = color.Color;
                //}
                request.Show();
            }
            else
            {
                request.Show();
            }
        }

        /// <summary>
        /// 已点歌曲窗体
        /// </summary>
        public static FrmOrderSongList songlist_2 = null;

        /// <summary>
        /// 跳转到已点歌曲窗体
        /// </summary>
        public static void Requested_Played()
        {
            if (songlist_2 == null || songlist_2.IsDisposed)
            {
                songlist_2 = new MyKTV.FrmOrderSongList();
                songlist_2.Show();
            }
            else
            {
                songlist_2.Show();
            }
        }

        /// <summary>
        /// 播放歌曲窗体
        /// </summary>
        public static FrmPlay play = null;

        /// <summary>
        /// 跳转到播放歌曲窗体
        /// </summary>
        public static void Play()
        {
            if (play == null || play.IsDisposed)
            {
                play = new MyKTV.FrmPlay();
                play.Show();
            }

        }

        /// <summary>
        /// 歌手点歌窗体
        /// </summary>
        public static FrmOrderBySinger singer = null;
        /// <summary>
        /// 跳转到歌手点歌窗体
        /// </summary>
        public static void SingerName_Request()
        {
            if (singer == null || singer.IsDisposed)
            {
                singer = new MyKTV.FrmOrderBySinger();
                //if (color.ShowDialog() == DialogResult.OK)
                //{
                //    singer.ForeColor = color.Color;
                //}

                singer.Show();
            }
            else if (singer != null || !singer.IsDisposed)
            {
                singer.Show();
            }
        }

        /// <summary>
        /// 类别点歌窗体
        /// </summary>
        public static FrmOrderBySongType songtype = null;
        /// <summary>
        /// 跳转到歌曲类别点歌窗体
        /// </summary>
        public static void SongType_Request()
        {
            if (songtype == null || songtype.IsDisposed)
            {
                songtype = new MyKTV.FrmOrderBySongType();

                //if (color.ShowDialog() == DialogResult.OK)
                //{
                //    songtype.ForeColor = color.Color;
                //}
                songtype.Show();
            }
            else
            {
                songtype.Show();
            }
        }

        /// <summary>
        /// KTV点歌系统主窗体
        /// </summary>
        public static FrmMain mainform = null;

        /// <summary>
        /// 跳转到KTV点歌系统主窗体
        /// </summary>
        public static void MainForm()
        {
            if (mainform == null || mainform.IsDisposed)
            {
                mainform = new MyKTV.FrmMain();
                //if (color.ShowDialog() == DialogResult.OK)
                //{
                //    mainform.ForeColor = color.Color;
                //}
                mainform.Show();
            }
            else
            {
                mainform.Show();
            }

        }

        /// <summary>
        /// 拼音点歌窗体
        /// </summary>
        public static FrmOrderBySongName songab = null;

        /// <summary>
        /// 跳转到拼音点歌窗体
        /// </summary>
        public static void SingerAb_Request()
        {
            if (songab == null || songab.IsDisposed)
            {
                songab = new MyKTV.FrmOrderBySongName();
                //if (color.ShowDialog() == DialogResult.OK)
                //{
                //    songab.ForeColor = color.Color;
                //}
                songab.Show();
            }
            else
            {
                songab.Show();
            }

        }

        /// <summary>
        /// 歌手类别点歌
        /// </summary>
        public static FrmSingerType SingerType = null;

        /// <summary>
        /// 歌手类别点歌窗体1
        /// </summary>
        public static void BySingerType()
        {
            if (SingerType == null || SingerType.IsDisposed)
            {
                SingerType = new MyKTV.FrmSingerType();
                //if (color.ShowDialog() == DialogResult.OK)
                //{
                //    SingerType.ForeColor = color.Color;
                //}
                SingerType.Show();
            }
            else if (SingerType != null || !SingerType.IsDisposed)
            {
                SingerType.Show();
            }

        }

        /// <summary>
        /// 歌手类别点歌窗体
        /// </summary>
        public static FrmSingerType_2 singertype_2 = null;

        /// <summary>
        /// 歌手类别点歌窗体2
        /// </summary>
        public static void singertype()
        {
            if (singertype_2 == null || singertype_2.IsDisposed)
            {
                singertype_2 = new MyKTV.FrmSingerType_2();
                //if (color.ShowDialog() == DialogResult.OK)
                //{
                //    singertype_2.ForeColor = color.Color;
                //}
                singertype_2.Show();
            }
            else if (singertype_2 != null || !singertype_2.IsDisposed)
            {
                singertype_2.Show();
            }

        }

        /// <summary>
        /// 跳转到歌曲列表窗体
        /// </summary>
        public static FrmSongList songlist = null;
        /// <summary>
        /// 跳转到歌曲列表窗体
        /// </summary>
        public static void SongOfWindows()
        {
            if (songlist == null || songlist.IsDisposed)
            {
                songlist = new MyKTV.FrmSongList();
                songlist.Show();
            }
        }

        /// <summary>
        /// <summary>
        /// 选择颜色
        /// </summary>
        //public static ColorDialog color = new ColorDialog();
        #endregion
        #region 各窗体的跳转

        #endregion
    }
}
