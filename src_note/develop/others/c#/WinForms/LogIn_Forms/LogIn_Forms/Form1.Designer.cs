namespace LogIn_Forms
{
    partial class LogInForms
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
            this.lb_User = new System.Windows.Forms.Label();
            this.lb_pwd = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_Pwd = new System.Windows.Forms.TextBox();
            this.cbo_Type = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.Location = new System.Drawing.Point(276, 322);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(60, 15);
            this.lb_User.TabIndex = 0;
            this.lb_User.Text = "用户名:";
            // 
            // lb_pwd
            // 
            this.lb_pwd.AutoSize = true;
            this.lb_pwd.Location = new System.Drawing.Point(276, 375);
            this.lb_pwd.Name = "lb_pwd";
            this.lb_pwd.Size = new System.Drawing.Size(75, 15);
            this.lb_pwd.TabIndex = 1;
            this.lb_pwd.Text = "登录密码:";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(276, 446);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(75, 15);
            this.lbType.TabIndex = 2;
            this.lbType.Text = "登录类型:";
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(434, 504);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(101, 33);
            this.btnLog.TabIndex = 3;
            this.btnLog.Text = "登录";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(586, 504);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 33);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(357, 319);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(153, 25);
            this.txt_User.TabIndex = 5;
            // 
            // txt_Pwd
            // 
            this.txt_Pwd.Location = new System.Drawing.Point(357, 372);
            this.txt_Pwd.Name = "txt_Pwd";
            this.txt_Pwd.Size = new System.Drawing.Size(153, 25);
            this.txt_Pwd.TabIndex = 6;
            // 
            // cbo_Type
            // 
            this.cbo_Type.FormattingEnabled = true;
            this.cbo_Type.Items.AddRange(new object[] {
            "管理员",
            "学生用户",
            "来宾"});
            this.cbo_Type.Location = new System.Drawing.Point(357, 438);
            this.cbo_Type.Name = "cbo_Type";
            this.cbo_Type.Size = new System.Drawing.Size(153, 23);
            this.cbo_Type.TabIndex = 7;
            // 
            // LogInForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LogIn_Forms.Properties.Resources.login_bj;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 604);
            this.Controls.Add(this.cbo_Type);
            this.Controls.Add(this.txt_Pwd);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lb_pwd);
            this.Controls.Add(this.lb_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogInForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录界面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.Label lb_pwd;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_Pwd;
        private System.Windows.Forms.ComboBox cbo_Type;
    }
}

