namespace MainSearch
{
    partial class MainSearch
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgvShowInfo = new System.Windows.Forms.DataGridView();
            this.cmsShow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsiRevise = new System.Windows.Forms.ToolStripMenuItem();
            this.song_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songtype_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.song_ab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.song_url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowInfo)).BeginInit();
            this.cmsShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(657, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入歌曲名：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(341, 25);
            this.txtName.TabIndex = 2;
            // 
            // dgvShowInfo
            // 
            this.dgvShowInfo.AllowUserToAddRows = false;
            this.dgvShowInfo.AllowUserToDeleteRows = false;
            this.dgvShowInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowInfo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvShowInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.song_name,
            this.singer_name,
            this.songtype_name,
            this.song_ab,
            this.song_url});
            this.dgvShowInfo.ContextMenuStrip = this.cmsShow;
            this.dgvShowInfo.Location = new System.Drawing.Point(2, 47);
            this.dgvShowInfo.Name = "dgvShowInfo";
            this.dgvShowInfo.ReadOnly = true;
            this.dgvShowInfo.RowTemplate.Height = 27;
            this.dgvShowInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowInfo.Size = new System.Drawing.Size(1187, 588);
            this.dgvShowInfo.TabIndex = 3;
            // 
            // cmsShow
            // 
            this.cmsShow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsiRevise});
            this.cmsShow.Name = "cmsShow";
            this.cmsShow.Size = new System.Drawing.Size(109, 28);
            // 
            // cmsiRevise
            // 
            this.cmsiRevise.Name = "cmsiRevise";
            this.cmsiRevise.Size = new System.Drawing.Size(152, 24);
            this.cmsiRevise.Text = "修改";
            this.cmsiRevise.Click += new System.EventHandler(this.cmsiRevise_Click);
            // 
            // song_name
            // 
            this.song_name.DataPropertyName = "song_name";
            this.song_name.HeaderText = "歌曲名";
            this.song_name.Name = "song_name";
            this.song_name.ReadOnly = true;
            this.song_name.Width = 200;
            // 
            // singer_name
            // 
            this.singer_name.DataPropertyName = "singer_name";
            this.singer_name.HeaderText = "歌手";
            this.singer_name.Name = "singer_name";
            this.singer_name.ReadOnly = true;
            this.singer_name.Width = 200;
            // 
            // songtype_name
            // 
            this.songtype_name.DataPropertyName = "songtype_name";
            this.songtype_name.HeaderText = "歌曲类型";
            this.songtype_name.Name = "songtype_name";
            this.songtype_name.ReadOnly = true;
            this.songtype_name.Width = 200;
            // 
            // song_ab
            // 
            this.song_ab.DataPropertyName = "song_ab";
            this.song_ab.HeaderText = "歌曲拼音";
            this.song_ab.Name = "song_ab";
            this.song_ab.ReadOnly = true;
            this.song_ab.Width = 200;
            // 
            // song_url
            // 
            this.song_url.DataPropertyName = "song_url";
            this.song_url.HeaderText = "歌曲路径";
            this.song_url.Name = "song_url";
            this.song_url.ReadOnly = true;
            this.song_url.Width = 200;
            // 
            // MainSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 638);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvShowInfo);
            this.Name = "MainSearch";
            this.Text = "查询数据";
            this.Load += new System.EventHandler(this.MainSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowInfo)).EndInit();
            this.cmsShow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgvShowInfo;
        private System.Windows.Forms.ContextMenuStrip cmsShow;
        private System.Windows.Forms.ToolStripMenuItem cmsiRevise;
        private System.Windows.Forms.DataGridViewTextBoxColumn song_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn singer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn songtype_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn song_ab;
        private System.Windows.Forms.DataGridViewTextBoxColumn song_url;
    }
}

