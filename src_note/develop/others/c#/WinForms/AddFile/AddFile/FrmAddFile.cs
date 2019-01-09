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


namespace AddFile
{
    public partial class FrmAddFile : Form
    {
        public FrmAddFile()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 保存文件的数组
        /// </summary>
        FileInfo[] filelist = new FileInfo[500];
        
        /// <summary>
        /// 文件初始路径
        /// </summary>
        string path = "I:\\";

        private void FrmAddFile_Load(object sender, EventArgs e)
        {
            lstFile.Items.CopyTo(filelist, 0);
            lblFile.Text = "请选择媒体文件........";

            AddDir();

        }


        /// <summary>
        /// 添加文件
        /// </summary>
        private void AddFile()
        {
            OpenFileDialog ofdfile = new OpenFileDialog();
            ofdfile.Title = "请选择文件";
            ofdfile.InitialDirectory = "I:\\";
            ofdfile.FileName = null;
            ofdfile.Filter = "媒体文件(*.mp4;*.m4a;*.mp3;*.wma;*.avi)|*.mp4;*.m4a;*.mp3;*.wma;*.avi|图像文件(*.jpg;*.ico;*.bmp;*.png;*.gif)|*.jpg;*.ico;*.bmp;*.png;*.gif|文本文件(*.txt;*.log;*.ini)|*.txt;*.log;*.ini|所有文件(*.*)|*.*";
            ofdfile.FilterIndex = 1;
            if (ofdfile.ShowDialog() == DialogResult.OK)
            {
                path = ofdfile.FileName;
                lstFile.Items.Add(ofdfile.SafeFileName);
                lstFile.Items.CopyTo(filelist,lstFile.Items.Count-1);
            }
 
        }


        /// <summary>
        /// 添加目录
        /// </summary>
        private void AddDir()
        {
            FolderBrowserDialog fbdFile = new FolderBrowserDialog();
            fbdFile.Description = "请选择路径：";
            fbdFile.SelectedPath = "I:\\MUSIC";
            fbdFile.ShowNewFolderButton = false;
            if (fbdFile.ShowDialog() == DialogResult.OK)
            {
                path = fbdFile.SelectedPath;
                DirectoryInfo dir = new DirectoryInfo(path);
                FileInfo file = new FileInfo(path);
                FileInfo[] files = dir.GetFiles("*.m4a");
                foreach (FileInfo fl in dir.GetFiles("*.m4a"))
                {
                    lstFile.Items.Add(fl);
                    filelist = files;
                    lstFile.Items.CopyTo(filelist,0);
                }
                
            }
        }

        private void lstFile_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }



    }
}
