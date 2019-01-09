using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKTV
{
    public partial class FrmPlay : Form
    {
        public FrmPlay()
        {
            InitializeComponent();
        }

        
        /// <summary>
        /// 窗体初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPlay_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ForeColor = Color.Blue;
            this.lstbMusicList.ForeColor = Color.Blue;
            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SelectFile();
        }

        /// <summary>
        /// 添加媒体文件
        /// </summary>
        /// <returns>返回文件路径</returns>
        public string SelectFile()
        {
            ofdMusic.Title = "请选择媒体文件：";
            ofdMusic.FileName = null;
            ofdMusic.Filter = @"mp3格式声音(*.mp3)|*.mp3|aac压缩音频(*.aac;*.m3u;*.m4a)|*.aac;*.m3u;*.m4a|视频文件(*.mp4;*.wma)|*.mp4;*.wma|其他文件(*.lrc)|*.lrc";
            ofdMusic.FilterIndex = 1;
            ofdMusic.InitialDirectory = @"E:\";
            if (ofdMusic.ShowDialog() == DialogResult.OK)
            {
                lstbMusicList.Items.Add(this.ofdMusic.FileName);
                axWmKTVPlayer.URL = this.ofdMusic.FileName;

                if (SongUtil.mainform == null)
                {
                    SongUtil.mainform = new MyKTV.FrmMain();
                    
                    SongUtil.mainform.Text = "正在播放---" + ofdMusic.SafeFileName;

                }
                return ofdMusic.SafeFileName;
            }
            return null;
        }


        /// <summary>
        /// 单曲循环
        /// </summary>
        public void songfor()
        {

            if (true)
            {
                this.axWmKTVPlayer.URL = this.lstbMusicList.SelectedItem.ToString();
                this.axWmKTVPlayer.Ctlcontrols.play();
            }
        }

    }
}
