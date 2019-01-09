namespace SMS
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pbAddUser = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAddUser
            // 
            this.pbAddUser.Image = ((System.Drawing.Image)(resources.GetObject("pbAddUser.Image")));
            this.pbAddUser.Location = new System.Drawing.Point(45, 26);
            this.pbAddUser.Name = "pbAddUser";
            this.pbAddUser.Size = new System.Drawing.Size(185, 174);
            this.pbAddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddUser.TabIndex = 0;
            this.pbAddUser.TabStop = false;
            this.pbAddUser.Click += new System.EventHandler(this.pbAddUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "添加用户";
            // 
            // pbSearch
            // 
            this.pbSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbSearch.Image")));
            this.pbSearch.Location = new System.Drawing.Point(347, 36);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(185, 174);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearch.TabIndex = 0;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "查询员工";
            // 
            // pbExit
            // 
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(45, 279);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(185, 174);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 0;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "退出程序";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 553);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.pbAddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "员工管理系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAddUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Label label3;
    }
}

