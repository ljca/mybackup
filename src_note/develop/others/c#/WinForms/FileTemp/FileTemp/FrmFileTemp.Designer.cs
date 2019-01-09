namespace FileTemp
{
    partial class FrmFileTemp
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvFileTemp = new System.Windows.Forms.TreeView();
            this.lvFileTemp = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvFileTemp);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvFileTemp);
            this.splitContainer1.Size = new System.Drawing.Size(864, 509);
            this.splitContainer1.SplitterDistance = 287;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvFileTemp
            // 
            this.tvFileTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFileTemp.Location = new System.Drawing.Point(0, 0);
            this.tvFileTemp.Name = "tvFileTemp";
            this.tvFileTemp.Size = new System.Drawing.Size(287, 509);
            this.tvFileTemp.TabIndex = 0;
            // 
            // lvFileTemp
            // 
            this.lvFileTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFileTemp.Location = new System.Drawing.Point(0, 0);
            this.lvFileTemp.Name = "lvFileTemp";
            this.lvFileTemp.Size = new System.Drawing.Size(573, 509);
            this.lvFileTemp.TabIndex = 1;
            this.lvFileTemp.UseCompatibleStateImageBehavior = false;
            // 
            // FrmFileTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 509);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmFileTemp";
            this.Text = "临时文件清理";
            this.Load += new System.EventHandler(this.FrmFileTemp_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvFileTemp;
        private System.Windows.Forms.ListView lvFileTemp;
    }
}

