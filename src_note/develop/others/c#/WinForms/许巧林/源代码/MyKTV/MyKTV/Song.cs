using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKTV
{
    public class Song
    {
        /// <summary>
        /// 枚举：歌曲播放状态
        /// </summary>
     enum SongPlayState
        {
            unplayed,played,again,cut
        }
        /// <summary>
        /// 歌曲名称字段
        /// </summary>
        private static string songName = null;
        /// <summary>
        /// 歌曲存放路径
        /// </summary>
        private static string songURL = null;
        /// <summary>
        /// 歌曲播放状态字段
        /// </summary>
        private SongPlayState PlayState = SongPlayState.unplayed;
        /// <summary>
        /// 歌曲名称属性
        /// </summary>
        //public static string SongName
        //{
        //    get { return songName; }
        //    //set {}
        //}
        /// <summary>
        /// 歌曲存放路径属性
        /// </summary>
        public static string SongURL = null;
        /// <summary>
        /// 歌曲播放状态属性
        /// </summary>
        //internal SongPlayState PlayState = SongPlayState.unplayed;
    }
}
