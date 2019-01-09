namespace MyKTV.ManageForms
{
    partial class FrmSearchSinger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchSinger));
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSingerName = new System.Windows.Forms.TextBox();
            this.cboSingerType = new System.Windows.Forms.ComboBox();
            this.dgvSearchSinger = new System.Windows.Forms.DataGridView();
            this.SingerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsMusicsearch = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmsDel = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchSinger)).BeginInit();
            this.cmsMusicsearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(768, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "歌手姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "歌手类型";
            // 
            // txtSingerName
            // 
            this.txtSingerName.Location = new System.Drawing.Point(98, 19);
            this.txtSingerName.Name = "txtSingerName";
            this.txtSingerName.Size = new System.Drawing.Size(279, 25);
            this.txtSingerName.TabIndex = 5;
            // 
            // cboSingerType
            // 
            this.cboSingerType.FormattingEnabled = true;
            this.cboSingerType.Location = new System.Drawing.Point(470, 21);
            this.cboSingerType.Name = "cboSingerType";
            this.cboSingerType.Size = new System.Drawing.Size(267, 23);
            this.cboSingerType.TabIndex = 6;
            // 
            // dgvSearchSinger
            // 
            this.dgvSearchSinger.AllowUserToAddRows = false;
            this.dgvSearchSinger.AllowUserToDeleteRows = false;
            this.dgvSearchSinger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearchSinger.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSearchSinger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchSinger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SingerName,
            this.SingerType,
            this.SingerSex,
            this.SingerDescription});
            this.dgvSearchSinger.ContextMenuStrip = this.cmsMusicsearch;
            this.dgvSearchSinger.Location = new System.Drawing.Point(2, 70);
            this.dgvSearchSinger.Name = "dgvSearchSinger";
            this.dgvSearchSinger.ReadOnly = true;
            this.dgvSearchSinger.RowTemplate.Height = 27;
            this.dgvSearchSinger.Size = new System.Drawing.Size(871, 426);
            this.dgvSearchSinger.TabIndex = 16;
            // 
            // SingerName
            // 
            this.SingerName.DataPropertyName = "singer_name";
            this.SingerName.HeaderText = "歌手姓名";
            this.SingerName.Name = "SingerName";
            this.SingerName.ReadOnly = true;
            this.SingerName.Width = 200;
            // 
            // SingerType
            // 
            this.SingerType.DataPropertyName = "singertype_name";
            this.SingerType.HeaderText = "歌手类型";
            this.SingerType.Name = "SingerType";
            this.SingerType.ReadOnly = true;
            this.SingerType.Width = 200;
            // 
            // SingerSex
            // 
            this.SingerSex.DataPropertyName = "singer_sex";
            this.SingerSex.HeaderText = "歌手类别";
            this.SingerSex.Name = "SingerSex";
            this.SingerSex.ReadOnly = true;
            this.SingerSex.Width = 200;
            // 
            // SingerDescription
            // 
            this.SingerDescription.DataPropertyName = "singer_descripe";
            this.SingerDescription.HeaderText = "歌手描述";
            this.SingerDescription.Name = "SingerDescription";
            this.SingerDescription.ReadOnly = true;
            this.SingerDescription.Width = 200;
            // 
            // cmsMusicsearch
            // 
            this.cmsMusicsearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmsEdit,
            this.tsmsDel});
            this.cmsMusicsearch.Name = "cmsMusicsearch";
            this.cmsMusicsearch.Size = new System.Drawing.Size(153, 74);
            this.cmsMusicsearch.Text = "搜索";
            // 
            // tsmsEdit
            // 
            this.tsmsEdit.Name = "tsmsEdit";
            this.tsmsEdit.Size = new System.Drawing.Size(152, 24);
            this.tsmsEdit.Text = "修改";
            this.tsmsEdit.Click += new System.EventHandler(this.tsmsEdit_Click);
            // 
            // tsmsDel
            // 
            this.tsmsDel.Name = "tsmsDel";
            this.tsmsDel.Size = new System.Drawing.Size(152, 24);
            this.tsmsDel.Text = "删除";
            // 
            // FrmSearchSinger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 495);
            this.Controls.Add(this.dgvSearchSinger);
            this.Controls.Add(this.cboSingerType);
            this.Controls.Add(this.txtSingerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSearchSinger";
            this.Text = "搜索歌手信息";
            this.Load += new System.EventHandler(this.FrmSingerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchSinger)).EndInit();
            this.cmsMusicsearch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSingerName;
        private System.Windows.Forms.ComboBox cboSingerType;
        private System.Windows.Forms.DataGridView dgvSearchSinger;
        private System.Windows.Forms.ContextMenuStrip cmsMusicsearch;
        private System.Windows.Forms.ToolStripMenuItem tsmsEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmsDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerDescription;
    }
}