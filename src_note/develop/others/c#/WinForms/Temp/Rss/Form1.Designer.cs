namespace Rss
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.tvRssList = new CCWin.SkinControl.SkinTreeView();
            this.dgvNews = new CCWin.SkinControl.SkinDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).BeginInit();
            this.skinSplitContainer1.Panel1.SuspendLayout();
            this.skinSplitContainer1.Panel2.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNews)).BeginInit();
            this.SuspendLayout();
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.Controls.Add(this.tvRssList);
            // 
            // skinSplitContainer1.Panel2
            // 
            this.skinSplitContainer1.Panel2.Controls.Add(this.dgvNews);
            this.skinSplitContainer1.Size = new System.Drawing.Size(859, 413);
            this.skinSplitContainer1.SplitterDistance = 286;
            this.skinSplitContainer1.TabIndex = 0;
            // 
            // tvRssList
            // 
            this.tvRssList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvRssList.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tvRssList.Location = new System.Drawing.Point(0, 0);
            this.tvRssList.Name = "tvRssList";
            this.tvRssList.Size = new System.Drawing.Size(286, 413);
            this.tvRssList.TabIndex = 0;
            this.tvRssList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvRssList_AfterSelect);
            // 
            // dgvNews
            // 
            this.dgvNews.AllowUserToAddRows = false;
            this.dgvNews.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgvNews.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNews.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNews.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNews.ColumnFont = null;
            this.dgvNews.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNews.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvNews.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNews.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNews.EnableHeadersVisualStyles = false;
            this.dgvNews.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvNews.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvNews.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvNews.Location = new System.Drawing.Point(0, 0);
            this.dgvNews.Name = "dgvNews";
            this.dgvNews.ReadOnly = true;
            this.dgvNews.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNews.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvNews.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNews.RowTemplate.Height = 23;
            this.dgvNews.Size = new System.Drawing.Size(569, 413);
            this.dgvNews.TabIndex = 0;
            this.dgvNews.TitleBack = null;
            this.dgvNews.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgvNews.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.dgvNews.DoubleClick += new System.EventHandler(this.dgvNews_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Title";
            this.Column1.HeaderText = "标题";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PubDate";
            this.Column2.HeaderText = "发布日期";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 413);
            this.Controls.Add(this.skinSplitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.skinSplitContainer1.Panel1.ResumeLayout(false);
            this.skinSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).EndInit();
            this.skinSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNews)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer1;
        private CCWin.SkinControl.SkinTreeView tvRssList;
        private CCWin.SkinControl.SkinDataGridView dgvNews;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

