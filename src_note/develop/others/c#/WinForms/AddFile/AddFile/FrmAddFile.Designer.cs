namespace AddFile
{
    partial class FrmAddFile
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
            this.lstFile = new System.Windows.Forms.ListBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.splfile = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // lstFile
            // 
            this.lstFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstFile.ForeColor = System.Drawing.Color.Blue;
            this.lstFile.FormattingEnabled = true;
            this.lstFile.ItemHeight = 15;
            this.lstFile.Location = new System.Drawing.Point(0, 0);
            this.lstFile.Name = "lstFile";
            this.lstFile.Size = new System.Drawing.Size(274, 557);
            this.lstFile.TabIndex = 0;
            this.lstFile.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstFile_MouseDoubleClick);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("创艺简行楷", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFile.ForeColor = System.Drawing.Color.Blue;
            this.lblFile.Location = new System.Drawing.Point(277, 13);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(66, 21);
            this.lblFile.TabIndex = 2;
            this.lblFile.Text = "label1";
            // 
            // splfile
            // 
            this.splfile.Location = new System.Drawing.Point(0, 0);
            this.splfile.Name = "splfile";
            this.splfile.Size = new System.Drawing.Size(987, 550);
            this.splfile.TabIndex = 4;
            this.splfile.TabStop = false;
            // 
            // FrmAddFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 550);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.lstFile);
            this.Controls.Add(this.splfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAddFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加文件";
            this.Load += new System.EventHandler(this.FrmAddFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Splitter splfile;
    }
}

