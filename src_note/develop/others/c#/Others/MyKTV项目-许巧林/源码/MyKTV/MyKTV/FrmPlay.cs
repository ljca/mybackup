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
            SelectFile();
            //this.axWmKTVPlayer.URL = KTVUtil.GetFileSource();
        }

        /// <summary>
        /// 添加媒体文件
        /// </summary>
        /// <returns>返回文件路径</returns>
        public string SelectFile()
        {
            DialogResult re = MessageBox.Show("媒体文件尚未选择？是否选择？","提示！",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(re == System.Windows.Forms.DialogResult.Yes){
                OpenFileDialog ofdMusic = new OpenFileDialog();
                ofdMusic.Title = "请选择媒体文件：";
                ofdMusic.FileName = null;
                ofdMusic.Filter = @"mp3格式声音(*.mp3)|*.mp3|aac压缩音频(*.aac;*.m3u;*.m4a)|*.aac;*.m3u;*.m4a|视频文件(*.mp4;*.wma)|*.mp4;*.wma|所有文件(*.*)|*.*";
                ofdMusic.FilterIndex = 1;
                ofdMusic.InitialDirectory = @"E:\";
                if (ofdMusic.ShowDialog() == DialogResult.OK)
                {
                    lstbMusicList.Items.Add(ofdMusic.SafeFileName);
                    axWmKTVPlayer.URL = ofdMusic.FileName;
                        FrmMain.songname = ofdMusic.SafeFileName;
                        FrmMain.nextsong = "未知";
                    return ofdMusic.FileName;
                }
            }
            return null;
        }


        /// <summary>
        /// 单曲循环
        /// </summary>
        public void songfor()
        {
            if (lstbMusicList.SelectedItems.Count == 1)
            {
                this.axWmKTVPlayer.URL = "";
                MessageBox.Show("未选择媒体文件！");
            }
            else
            {
                MessageBox.Show("暂不支持播放多项播放！");
            }
        }


        /// <summary>
        /// 播放歌曲！
        /// </summary>
        public void Play(string source)
        {
            axWmKTVPlayer.URL = source;
            //axWmKTVPlayer.Ctlcontrols.play();
        }

    }
}
