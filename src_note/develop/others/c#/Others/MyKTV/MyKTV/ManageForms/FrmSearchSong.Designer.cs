namespace MyKTV.ManageForms
{
    partial class FrmSearchSong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchSong));
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.cboSongType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSearchSinger = new System.Windows.Forms.DataGridView();
            this.cmsMusicsearch = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmsDel = new System.Windows.Forms.ToolStripMenuItem();
            this.SongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Singer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerDescripe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchSinger)).BeginInit();
            this.cmsMusicsearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(738, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 28);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "歌曲名";
            // 
            // txtSongName
            // 
            this.txtSongName.Location = new System.Drawing.Point(85, 17);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(258, 25);
            this.txtSongName.TabIndex = 12;
            // 
            // cboSongType
            // 
            this.cboSongType.FormattingEnabled = true;
            this.cboSongType.Location = new System.Drawing.Point(437, 16);
            this.cboSongType.Name = "cboSongType";
            this.cboSongType.Size = new System.Drawing.Size(262, 23);
            this.cboSongType.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "歌曲类型";
            // 
            // dgvSearchSinger
            // 
            this.dgvSearchSinger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearchSinger.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSearchSinger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchSinger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SongName,
            this.SongType,
            this.Singer,
            this.SingerDescripe});
            this.dgvSearchSinger.Location = new System.Drawing.Point(2, 48);
            this.dgvSearchSinger.Name = "dgvSearchSinger";
            this.dgvSearchSinger.RowTemplate.Height = 27;
            this.dgvSearchSinger.Size = new System.Drawing.Size(874, 377);
            this.dgvSearchSinger.TabIndex = 15;
            // 
            // cmsMusicsearch
            // 
            this.cmsMusicsearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmsEdit,
            this.tsmsDel});
            this.cmsMusicsearch.Name = "cmsMusicsearch";
            this.cmsMusicsearch.Size = new System.Drawing.Size(109, 52);
            this.cmsMusicsearch.Text = "搜索";
            // 
            // tsmsEdit
            // 
            this.tsmsEdit.Name = "tsmsEdit";
            this.tsmsEdit.Size = new System.Drawing.Size(108, 24);
            this.tsmsEdit.Text = "修改";
            // 
            // tsmsDel
            // 
            this.tsmsDel.Name = "tsmsDel";
            this.tsmsDel.Size = new System.Drawing.Size(108, 24);
            this.tsmsDel.Text = "删除";
            // 
            // SongName
            // 
            this.SongName.DataPropertyName = "song_name";
            this.SongName.HeaderText = "歌曲名";
            this.SongName.Name = "SongName";
            this.SongName.Width = 200;
            // 
            // SongType
            // 
            this.SongType.DataPropertyName = "songtype_name";
            this.SongType.HeaderText = "歌曲类型";
            this.SongType.Name = "SongType";
            this.SongType.ReadOnly = true;
            this.SongType.Width = 200;
            // 
            // Singer
            // 
            this.Singer.DataPropertyName = "singer_name";
            this.Singer.HeaderText = "歌手";
            this.Singer.Name = "Singer";
            this.Singer.ReadOnly = true;
            this.Singer.Width = 200;
            // 
            // SingerDescripe
            // 
            this.SingerDescripe.HeaderText = "歌手描述";
            this.SingerDescripe.Name = "SingerDescripe";
            this.SingerDescripe.ReadOnly = true;
            this.SingerDescripe.Width = 200;
            // 
            // FrmSearchSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 454);
            this.Controls.Add(this.dgvSearchSinger);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboSongType);
            this.Controls.Add(this.txtSongName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSearchSong";
            this.Text = "搜索歌曲";
            this.Load += new System.EventHandler(this.FrmSearchSong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchSinger)).EndInit();
            this.cmsMusicsearch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.ComboBox cboSongType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSearchSinger;
        private System.Windows.Forms.ContextMenuStrip cmsMusicsearch;
        private System.Windows.Forms.ToolStripMenuItem tsmsEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmsDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Singer;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerDescripe;
    }
}