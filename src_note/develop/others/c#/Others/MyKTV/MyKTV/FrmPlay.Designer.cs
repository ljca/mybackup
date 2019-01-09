namespace MyKTV
{
    partial class FrmPlay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlay));
            this.axWmKTVPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.lstbMusicList = new System.Windows.Forms.ListBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.ofdMusic = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.axWmKTVPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // axWmKTVPlayer
            // 
            this.axWmKTVPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWmKTVPlayer.Enabled = true;
            this.axWmKTVPlayer.Location = new System.Drawing.Point(183, 1);
            this.axWmKTVPlayer.Name = "axWmKTVPlayer";
            this.axWmKTVPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWmKTVPlayer.OcxState")));
            this.axWmKTVPlayer.Size = new System.Drawing.Size(466, 397);
            this.axWmKTVPlayer.TabIndex = 10;
            // 
            // lstbMusicList
            // 
            this.lstbMusicList.FormattingEnabled = true;
            this.lstbMusicList.ItemHeight = 15;
            this.lstbMusicList.Location = new System.Drawing.Point(0, 1);
            this.lstbMusicList.Name = "lstbMusicList";
            this.lstbMusicList.Size = new System.Drawing.Size(177, 424);
            this.lstbMusicList.TabIndex = 12;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(183, 404);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(468, 26);
            this.btnBrowse.TabIndex = 14;
            this.btnBrowse.Text = "浏览";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // ofdMusic
            // 
            this.ofdMusic.FileName = "openFileDialog1";
            // 
            // FrmPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 429);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lstbMusicList);
            this.Controls.Add(this.axWmKTVPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPlay";
            this.Text = "播放歌曲";
            this.Load += new System.EventHandler(this.FrmPlay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWmKTVPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWmKTVPlayer;
        private System.Windows.Forms.ListBox lstbMusicList;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog ofdMusic;
    }
}