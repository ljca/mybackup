using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using MyKTV;
using MyKTV.ManageForms;

namespace MyKTV
{
    public class Play
    {
        /// <summary>
        /// 歌曲播放列表数组
        /// </summary>
        private static Song[] songList = new Song[50];
        /// <summary>
        /// 当前播放歌曲在数组中的索引
        /// </summary>
        private static int SongIndex = 0;
        #region 媒体播放器的相关方法
        /// <summary>
        /// 当前播放歌曲名
        /// </summary>
        public static void PlaySongName()
        {
 
        }
        /// <summary>
        /// 获取当前播放的歌曲
        /// </summary>
        public static void GetPlaySong()
        {
 
        }
        /// <summary>
        /// 获取下一首要播放的歌曲名
        /// </summary>
        public static void NextSong()
        {
 
        }
        /// <summary>
        /// 点播一首歌曲
        /// </summary>
        /// <param name="song"></param>
        public static void AddSong(Song song)
        {

        }
        /// <summary>
        /// 切歌
        /// </summary>
        public static void CutSong(int index)
        { 

        }
        /// <summary>
        /// 单曲循环
        /// </summary>
        public static void PlayAgain()
        {

        }
       /// <summary>
       /// 播放下一首歌
       /// </summary>
        public static void MoveOn()
        {

        }
        #endregion
    }
}
