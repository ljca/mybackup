using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test
{
    public partial class FrmMusic : Form
    {
        public FrmMusic()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 保存歌曲文件路径的数组
        /// </summary>
        public string[] filelist = new string[10000];
        public int selectOne;
        public bool playOne = false;
        /// <summary>
        /// 选中索引
        /// </summary>
        public static int nuberOfMusic;
        /// <summary>
        /// 保存歌曲路径
        /// </summary>
        public string path;
        


        private void FrmMusic_Load(object sender, EventArgs e)
        {
            //窗体初始化
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            
            this.ForeColor = Color.Blue;
            this.HelpButton = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            //设置文本框位只读
           
            //初始化列表框
            //设置列表框的背景及字体颜色
            
            this.listPlay.BackColor = Color.WhiteSmoke;
            this.listPlay.ForeColor = Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.listPlay.Anchor = AnchorStyles.None;
            //初始化播放器
            //设置初始声音
            this.axMusicPlayer.settings.volume = 20;
            //设置声道
            this.axMusicPlayer.settings.balance = -1;
            //下一曲
            this.axMusicPlayer.Ctlcontrols.next();
            
            //指定播放器的界面
            this.axMusicPlayer.uiMode = "Mini";
            int nmber = this.axMusicPlayer.currentPlaylist.count;
            //返回播放器当前状态
            //上一曲
             this.axMusicPlayer.Ctlcontrols.previous();

             this.listPlay.Items.CopyTo(filelist,0);
             nuberOfMusic = 0;
        }

        /// <summary>
        /// 选择音频文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsBrowse_Click(object sender, EventArgs e)
        {

            //OpenFileDialog OpenMusicFile = this.OpenMusicFile;
            SelectMedia();
        }

        /// <summary>
        /// 选择媒体文件
        /// </summary>
        private string SelectMedia()
        {
            //设置浏览文件对话框的标题
            OpenMusicFile.Title = "请选择媒体文件：";
            OpenMusicFile.FileName = null;
            //制定浏览文件的初始目录
            OpenMusicFile.InitialDirectory = "E:\\";
            //筛选器
            OpenMusicFile.Filter = @"mp3格式声音(*.mp3)|*.mp3|aac压缩音频(*.aac;*.m3u;*.m4a)|*.aac;*.m3u;;*.m4a|视频文件(*.mp4;*.wmv)|*.mp4;*.wmv|所有文件(*.*)|*.*";
            OpenMusicFile.FilterIndex = 2;
            //是否记住以前选中文件的目录
            OpenMusicFile.RestoreDirectory = true;
            //是否允许选中多项文件
            OpenMusicFile.Multiselect = true;
            //是否显示帮助
            OpenMusicFile.ShowHelp = true;
            if (OpenMusicFile.ShowDialog() == DialogResult.OK)
            {
                this.listPlay.Items.Add(this.OpenMusicFile.SafeFileName);
                this.axMusicPlayer.URL = this.OpenMusicFile.FileName;
                string path = this.OpenMusicFile.FileName;
                FileInfo fi = new FileInfo(path);
                OpenFile(fi.FullName);
                string strfile = Convert.ToString(nuberOfMusic);
                strfile = fi.Name;
                //listPlay.Items.Add(fi.FullName);
               this.path = path;
            }
            return this.path;
        }


        /// <summary>
        /// 选择文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsFolder_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog fsSelectFolder = this.fsSelectFolder;
            fsSelectFolder.Description = "请选择路径：";
            //是否显示新建文件夹按钮
            fsSelectFolder.ShowNewFolderButton = true;
            //指定初始选中目录
            fsSelectFolder.SelectedPath = "C:\\";
            if (fsSelectFolder.ShowDialog() == DialogResult.OK)
            {
            
                AddFolder(fsSelectFolder.SelectedPath,listPlay);
            }
        }

       /// <summary>
       /// 打开音频文件
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
      
        private void tsmOpenMusic_Click(object sender, EventArgs e)
        {
            SelectMedia();
           OpenFile(SelectMedia());
            //Play();
        }

        private void tsbtnPlay_Click(object sender, EventArgs e)
        {
            if (this.listPlay.SelectedIndex < 0)
            {
                selectOne = 1;
                this.listPlay.SelectedIndex = 0;
            }
            else
            {
                selectOne = this.listPlay.SelectedIndex + 1;
            }
            
            Play(selectOne);
        }

    

        private void listPlay_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.tsbtnPlay_Click(sender, e);
            
        }

        private void tsbtnStop_Click(object sender, EventArgs e)
        {
            this.StopMusic("");
        }
            
        /// <summary>
        /// 打开媒体文件并添加到列表框中
        /// </summary>
        private void OpenFile(string path)
        {
            if (nuberOfMusic < 10000)
            {
                nuberOfMusic += 1;
                filelist[nuberOfMusic] = path;
            }
            else
            {
                MessageBox.Show("列表已满！不能添加音频！");
            }

        }

        /// <summary>
        /// 添加媒体文件目录的音乐到列表框中
        /// </summary>
        public void AddFolder(string path,ListBox lstPlay)
        {
            
                //返回路径
                //string Path = this.fsSelectFolder.SelectedPath;
                //this.Close();
                //MessageBox.Show("你选择的路径是：" + Path + "\n请牢记你的路径！");

                DirectoryInfo createdir = new DirectoryInfo("path");
                foreach (FileInfo file in createdir.GetFiles("*.mp3",SearchOption.TopDirectoryOnly))
                {
                    OpenFile(file.FullName);

                    string str = Convert.ToString(nuberOfMusic);
                    //for (int i = 1; i < 5 - str.Length; i++)
                    //{
                    //    str += "";
                    //}
                    str = file.Name;
                    listPlay.Items.Add(str);
                }
                foreach (DirectoryInfo d in createdir.GetDirectories())
                {
                    AddFolder(d.FullName, listPlay);
                }
        }


        
        /// <summary>
        /// 播放下一曲
        /// </summary>
        public void Next()
        {
        }
        /// <summary>
        /// 播放上一曲
        /// </summary>
        public void Previos()
        {
        }

        /// <summary>
        /// 播放音乐
        /// </summary>
        /// <param name="selectNum"></param>
        public void Play(int selectone)
        { 
               // int nmber = this.axMusicPlayer.currentPlaylist.count;
                //this.axMusicPlayer.URL = filelist[selectNum];
                this.axMusicPlayer.URL = this.listPlay.SelectedItems[0].ToString();
                //this.axMusicPlayer.Ctlcontrols.play();
                this.Text = "正在播放 -- " + listPlay.SelectedItem.ToString();
            //}
       
        }

        /// <summary>
        /// 停止播放音乐
        /// </summary>
        /// <param name="path"></param>
        public void StopMusic(string path)
        {
            //if(this.axMusicPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            //{
                this.Text = "媒体播放器";
                this.axMusicPlayer.URL = "";

                this.axMusicPlayer.Ctlcontrols.stop();
            //}
        }


            /// <summary>
        /// 打开帮助窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmHelp_Click(object sender, EventArgs e)
        {
            AboutHelp ab = new AboutHelp();
            ab.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            ab.ShowIcon = false;
            ab.MaximizeBox = false;
            ab.MinimizeBox = false;
            ab.ShowInTaskbar = false;
            ab.ShowDialog();
        }

        private void tsmAddMedia_Click(object sender, EventArgs e)
        {
            SelectMedia();
        }

    
        private void tsmsExit_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("确定要退出播放器吗？", "退出提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (re == DialogResult.OK)
            {
                Application.Exit();
            }
        }


    }
}
