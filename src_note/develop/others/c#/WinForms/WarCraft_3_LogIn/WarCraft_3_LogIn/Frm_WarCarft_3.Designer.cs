namespace WarCraft_3_LogIn
{
    partial class Frm_WarCarft_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_WarCarft_3));
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtEMail_Address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lklblLogin = new System.Windows.Forms.LinkLabel();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.plClose = new System.Windows.Forms.Panel();
            this.lblLog = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(28, 500);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(137, 42);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtEMail_Address
            // 
            this.txtEMail_Address.Location = new System.Drawing.Point(34, 271);
            this.txtEMail_Address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEMail_Address.Name = "txtEMail_Address";
            this.txtEMail_Address.Size = new System.Drawing.Size(988, 30);
            this.txtEMail_Address.TabIndex = 1;
            this.txtEMail_Address.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(30, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "电子邮件地址";
            // 
            // lklblLogin
            // 
            this.lklblLogin.AutoSize = true;
            this.lklblLogin.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lklblLogin.Location = new System.Drawing.Point(815, 544);
            this.lklblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lklblLogin.Name = "lklblLogin";
            this.lklblLogin.Size = new System.Drawing.Size(51, 20);
            this.lklblLogin.TabIndex = 3;
            this.lklblLogin.TabStop = true;
            this.lklblLogin.Text = "注册";
            this.lklblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblLogin_LinkClicked);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(28, 410);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(988, 30);
            this.txtPwd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(30, 363);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.plClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 188);
            this.panel1.TabIndex = 4;
            // 
            // plClose
            // 
            this.plClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plClose.BackgroundImage")));
            this.plClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plClose.Location = new System.Drawing.Point(941, 13);
            this.plClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plClose.Name = "plClose";
            this.plClose.Size = new System.Drawing.Size(60, 46);
            this.plClose.TabIndex = 5;
            this.plClose.Click += new System.EventHandler(this.plClose_Click);
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLog.Location = new System.Drawing.Point(581, 544);
            this.lblLog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(261, 20);
            this.lblLog.TabIndex = 5;
            this.lblLog.Text = "还没有账号？点这里注册！";
            // 
            // Frm_WarCarft_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(1035, 586);
            this.Controls.Add(this.lklblLogin);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtEMail_Address);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_WarCarft_3";
            this.Text = "战网登录";
            this.Load += new System.EventHandler(this.Frm_WarCarft_3_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtEMail_Address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lklblLogin;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel plClose;
        private System.Windows.Forms.Label lblLog;
    }
}

