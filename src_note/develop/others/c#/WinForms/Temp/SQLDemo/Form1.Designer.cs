namespace SQLDemo
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
            this.txtLoginPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLoginPwd.Location = new System.Drawing.Point(103, 74);
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.Size = new System.Drawing.Size(259, 34);
            this.txtLoginPwd.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(41, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "密码";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.Location = new System.Drawing.Point(26, 130);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(336, 50);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "开 始 登 录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLoginId
            // 
            this.txtLoginId.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLoginId.Location = new System.Drawing.Point(103, 27);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(259, 34);
            this.txtLoginId.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "用户名";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserName.Location = new System.Drawing.Point(24, 203);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 27);
            this.lblUserName.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 279);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtLoginPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLoginId);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoginPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLoginId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;

    }
}

