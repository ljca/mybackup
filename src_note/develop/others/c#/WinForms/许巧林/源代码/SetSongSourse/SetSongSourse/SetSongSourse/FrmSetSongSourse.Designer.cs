namespace SetSongSourse
{
    partial class FrmSetsongSourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOldSourse = new System.Windows.Forms.TextBox();
            this.txtNewSourse = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.FbdSelectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "原歌曲路径";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "新路径";
            // 
            // txtOldSourse
            // 
            this.txtOldSourse.Location = new System.Drawing.Point(119, 22);
            this.txtOldSourse.Name = "txtOldSourse";
            this.txtOldSourse.Size = new System.Drawing.Size(496, 25);
            this.txtOldSourse.TabIndex = 2;
            // 
            // txtNewSourse
            // 
            this.txtNewSourse.Location = new System.Drawing.Point(119, 71);
            this.txtNewSourse.Name = "txtNewSourse";
            this.txtNewSourse.Size = new System.Drawing.Size(496, 25);
            this.txtNewSourse.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(119, 106);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(101, 31);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "浏览";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(397, 129);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 31);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(515, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 31);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmSetsongSourse
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 190);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtNewSourse);
            this.Controls.Add(this.txtOldSourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSetsongSourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置歌曲路径";
            this.Load += new System.EventHandler(this.FrmSetsongSourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOldSourse;
        private System.Windows.Forms.TextBox txtNewSourse;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.FolderBrowserDialog FbdSelectFolder;

    }
}

