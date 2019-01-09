namespace MyKTV
{
    partial class FrmOrderBySinger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderBySinger));
            this.tsMusicPlay = new System.Windows.Forms.ToolStrip();
            this.tsbtnMain = new System.Windows.Forms.ToolStripButton();
            this.tsbtnWhile = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCutsong = new System.Windows.Forms.ToolStripButton();
            this.tsbtnPlayed = new System.Windows.Forms.ToolStripButton();
            this.tsbtnServer = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancel = new System.Windows.Forms.ToolStripButton();
            this.pbsingerRequest = new System.Windows.Forms.PictureBox();
            this.pbabRequest = new System.Windows.Forms.PictureBox();
            this.lbrf = new System.Windows.Forms.Label();
            this.lblMile = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbGame = new System.Windows.Forms.PictureBox();
            this.lblFMail = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tsMusicPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbsingerRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbabRequest)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).BeginInit();
            this.SuspendLayout();
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
            this.tsMusicPlay.Location = new System.Drawing.Point(0, 424);
            this.tsMusicPlay.Name = "tsMusicPlay";
            this.tsMusicPlay.Size = new System.Drawing.Size(747, 62);
            this.tsMusicPlay.TabIndex = 6;
            this.tsMusicPlay.Text = "歌曲播放";
            // 
            // tsbtnMain
            // 
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
            // pbsingerRequest
            // 
            this.pbsingerRequest.Image = global::MyKTV.Properties.Resources.lvzuhe;
            this.pbsingerRequest.Location = new System.Drawing.Point(113, 25);
            this.pbsingerRequest.Name = "pbsingerRequest";
            this.pbsingerRequest.Size = new System.Drawing.Size(127, 116);
            this.pbsingerRequest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbsingerRequest.TabIndex = 18;
            this.pbsingerRequest.TabStop = false;
            // 
            // pbabRequest
            // 
            this.pbabRequest.Image = global::MyKTV.Properties.Resources.lvMail;
            this.pbabRequest.Location = new System.Drawing.Point(360, 25);
            this.pbabRequest.Name = "pbabRequest";
            this.pbabRequest.Size = new System.Drawing.Size(130, 116);
            this.pbabRequest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbabRequest.TabIndex = 19;
            this.pbabRequest.TabStop = false;
            // 
            // lbrf
            // 
            this.lbrf.AutoSize = true;
            this.lbrf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbrf.Image = global::MyKTV.Properties.Resources.bg08;
            this.lbrf.Location = new System.Drawing.Point(154, 170);
            this.lbrf.Name = "lbrf";
            this.lbrf.Size = new System.Drawing.Size(37, 15);
            this.lbrf.TabIndex = 21;
            this.lbrf.Text = "组合";
            this.lbrf.Click += new System.EventHandler(this.lbrf_Click);
            // 
            // lblMile
            // 
            this.lblMile.AutoSize = true;
            this.lblMile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMile.Image = global::MyKTV.Properties.Resources.bg08;
            this.lblMile.Location = new System.Drawing.Point(391, 170);
            this.lblMile.Name = "lblMile";
            this.lblMile.Size = new System.Drawing.Size(52, 15);
            this.lblMile.TabIndex = 22;
            this.lblMile.Text = "男歌手";
            this.lblMile.Click += new System.EventHandler(this.lblMile_Click);
            this.lblMile.MouseHover += new System.EventHandler(this.lbOld_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pbGame);
            this.panel1.Controls.Add(this.lblFMail);
            this.panel1.Controls.Add(this.lblMile);
            this.panel1.Controls.Add(this.lbrf);
            this.panel1.Controls.Add(this.pbabRequest);
            this.panel1.Controls.Add(this.pbsingerRequest);
            this.panel1.Location = new System.Drawing.Point(1, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 378);
            this.panel1.TabIndex = 1;
            // 
            // pbGame
            // 
            this.pbGame.Image = global::MyKTV.Properties.Resources.lvFemail;
            this.pbGame.Location = new System.Drawing.Point(113, 214);
            this.pbGame.Name = "pbGame";
            this.pbGame.Size = new System.Drawing.Size(127, 116);
            this.pbGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGame.TabIndex = 27;
            this.pbGame.TabStop = false;
            // 
            // lblFMail
            // 
            this.lblFMail.AutoSize = true;
            this.lblFMail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFMail.Image = global::MyKTV.Properties.Resources.bg08;
            this.lblFMail.Location = new System.Drawing.Point(154, 350);
            this.lblFMail.Name = "lblFMail";
            this.lblFMail.Size = new System.Drawing.Size(52, 15);
            this.lblFMail.TabIndex = 24;
            this.lblFMail.Text = "女歌手";
            this.lblFMail.Click += new System.EventHandler(this.lblFMail_Click);
            this.lblFMail.MouseHover += new System.EventHandler(this.lbGame_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 29);
            this.panel2.TabIndex = 7;
            // 
            // FrmOrderBySinger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tsMusicPlay);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOrderBySinger";
            this.Text = "歌手点歌";
            this.Load += new System.EventHandler(this.FrmOrderBySinger_Load);
            this.tsMusicPlay.ResumeLayout(false);
            this.tsMusicPlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbsingerRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbabRequest)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMusicPlay;
        private System.Windows.Forms.ToolStripButton tsbtnWhile;
        private System.Windows.Forms.ToolStripButton tsbtnCutsong;
        private System.Windows.Forms.ToolStripButton tsbtnPlayed;
        private System.Windows.Forms.ToolStripButton tsbtnServer;
        private System.Windows.Forms.ToolStripButton tsbtnCancel;
        private System.Windows.Forms.ToolStripButton tsbtnMain;
        private System.Windows.Forms.PictureBox pbsingerRequest;
        private System.Windows.Forms.PictureBox pbabRequest;
        private System.Windows.Forms.Label lbrf;
        private System.Windows.Forms.Label lblMile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbGame;
        private System.Windows.Forms.Label lblFMail;
        private System.Windows.Forms.Panel panel2;
    }
}