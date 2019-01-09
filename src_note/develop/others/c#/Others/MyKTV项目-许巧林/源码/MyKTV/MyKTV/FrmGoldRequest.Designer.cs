namespace MyKTV
{
    partial class FrmGoldRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGoldRequest));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tsMusicPlay = new System.Windows.Forms.ToolStrip();
            this.tsbtnMain = new System.Windows.Forms.ToolStripButton();
            this.tsbtnWhile = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCutsong = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPlayed = new System.Windows.Forms.ToolStripButton();
            this.tsbtnServer = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancel = new System.Windows.Forms.ToolStripButton();
            this.dgvSonglist = new System.Windows.Forms.DataGridView();
            this.SongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Singer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsMusicPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonglist)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 35);
            this.panel1.TabIndex = 0;
            // 
            // tsMusicPlay
            // 
            this.tsMusicPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsMusicPlay.BackgroundImage")));
            this.tsMusicPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsMusicPlay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsMusicPlay.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnMain,
            this.tsbtnWhile,
            this.tsbtnCutsong,
            this.tsbtnPlayed,
            this.tsbtnServer,
            this.tsbtnCancel});
            this.tsMusicPlay.Location = new System.Drawing.Point(0, 492);
            this.tsMusicPlay.Name = "tsMusicPlay";
            this.tsMusicPlay.Size = new System.Drawing.Size(900, 62);
            this.tsMusicPlay.TabIndex = 14;
            this.tsMusicPlay.Text = "歌曲播放";
            // 
            // tsbtnMain
            // 
            this.tsbtnMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsbtnMain.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnMain.Image")));
            this.tsbtnMain.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbtnMain.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnMain.Name = "tsbtnMain";
            this.tsbtnMain.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbtnMain.Size = new System.Drawing.Size(68, 59);
            this.tsbtnMain.Text = "主界面";
            this.tsbtnMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnMain.Click += new System.EventHandler(this.tsbtnMain_Click);
            // 
            // tsbtnWhile
            // 
            this.tsbtnWhile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsbtnWhile.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnWhile.Image")));
            this.tsbtnWhile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbtnWhile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnWhile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnWhile.Name = "tsbtnWhile";
            this.tsbtnWhile.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbtnWhile.Size = new System.Drawing.Size(53, 59);
            this.tsbtnWhile.Text = "重唱";
            this.tsbtnWhile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnWhile.ToolTipText = "主界面";
            this.tsbtnWhile.Click += new System.EventHandler(this.tsbtnWhile_Click);
            // 
            // tsbtnCutsong
            // 
            this.tsbtnCutsong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsbtnCutsong.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCutsong.Image")));
            this.tsbtnCutsong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbtnCutsong.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCutsong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCutsong.Margin = new System.Windows.Forms.Padding(0);
            this.tsbtnCutsong.Name = "tsbtnCutsong";
            this.tsbtnCutsong.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbtnCutsong.Size = new System.Drawing.Size(53, 62);
            this.tsbtnCutsong.Text = "切歌";
            this.tsbtnCutsong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCutsong.Click += new System.EventHandler(this.tsbtnCutsong_Click);
            // 
            // tsbtnPlayed
            // 
            this.tsbtnPlayed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsbtnPlayed.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPlayed.Image")));
            this.tsbtnPlayed.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbtnPlayed.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnPlayed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPlayed.Name = "tsbtnPlayed";
            this.tsbtnPlayed.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tsbtnPlayed.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbtnPlayed.Size = new System.Drawing.Size(53, 59);
            this.tsbtnPlayed.Text = "已点";
            this.tsbtnPlayed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnPlayed.Click += new System.EventHandler(this.tsbtnPlayed_Click);
            // 
            // tsbtnServer
            // 
            this.tsbtnServer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsbtnServer.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnServer.Image")));
            this.tsbtnServer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbtnServer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnServer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnServer.Name = "tsbtnServer";
            this.tsbtnServer.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbtnServer.Size = new System.Drawing.Size(53, 59);
            this.tsbtnServer.Text = "服务";
            this.tsbtnServer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnServer.Click += new System.EventHandler(this.tsbtnServer_Click);
            // 
            // tsbtnCancel
            // 
            this.tsbtnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsbtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCancel.Image")));
            this.tsbtnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbtnCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCancel.Name = "tsbtnCancel";
            this.tsbtnCancel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tsbtnCancel.Size = new System.Drawing.Size(53, 59);
            this.tsbtnCancel.Text = "返回";
            this.tsbtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCancel.Click += new System.EventHandler(this.tsbtnCancel_Click);
            // 
            // dgvSonglist
            // 
            this.dgvSonglist.AllowUserToAddRows = false;
            this.dgvSonglist.AllowUserToDeleteRows = false;
            this.dgvSonglist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSonglist.BackgroundColor = System.Drawing.Color.Turquoise;
            this.dgvSonglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSonglist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SongName,
            this.SongType,
            this.Singer});
            this.dgvSonglist.Location = new System.Drawing.Point(0, 41);
            this.dgvSonglist.Name = "dgvSonglist";
            this.dgvSonglist.ReadOnly = true;
            this.dgvSonglist.RowTemplate.Height = 27;
            this.dgvSonglist.Size = new System.Drawing.Size(900, 448);
            this.dgvSonglist.TabIndex = 16;
            this.dgvSonglist.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSonglist_CellMouseDoubleClick);

            // 
            // SongName
            // 
            this.SongName.DataPropertyName = "song_name";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Turquoise;
            this.SongName.DefaultCellStyle = dataGridViewCellStyle7;
            this.SongName.HeaderText = "歌曲名";
            this.SongName.Name = "SongName";
            this.SongName.ReadOnly = true;
            this.SongName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SongName.Width = 255;
            // 
            // SongType
            // 
            this.SongType.DataPropertyName = "songtype_name";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Turquoise;
            this.SongType.DefaultCellStyle = dataGridViewCellStyle8;
            this.SongType.HeaderText = "歌曲类型";
            this.SongType.Name = "SongType";
            this.SongType.ReadOnly = true;
            this.SongType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SongType.Width = 255;
            // 
            // Singer
            // 
            this.Singer.DataPropertyName = "song_play_count";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Turquoise;
            this.Singer.DefaultCellStyle = dataGridViewCellStyle9;
            this.Singer.HeaderText = "点播次数";
            this.Singer.Name = "Singer";
            this.Singer.ReadOnly = true;
            this.Singer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Singer.Width = 255;
            // 
            // FrmGoldRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 554);
            this.Controls.Add(this.dgvSonglist);
            this.Controls.Add(this.tsMusicPlay);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGoldRequest";
            this.Text = "金榜排行";
            this.Load += new System.EventHandler(this.FrmRequest_Load);
            this.tsMusicPlay.ResumeLayout(false);
            this.tsMusicPlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonglist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip tsMusicPlay;
        private System.Windows.Forms.ToolStripButton tsbtnMain;
        private System.Windows.Forms.ToolStripButton tsbtnWhile;
        private System.Windows.Forms.ToolStripButton tsbtnCutsong;
        private System.Windows.Forms.ToolStripButton tsbtnPlayed;
        private System.Windows.Forms.ToolStripButton tsbtnServer;
        private System.Windows.Forms.ToolStripButton tsbtnCancel;
        private System.Windows.Forms.DataGridView dgvSonglist;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Singer;
        
    }
}