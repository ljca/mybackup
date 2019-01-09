namespace S2MySchool
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLoginPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(39, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // txtLoginId
            // 
            this.txtLoginId.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLoginId.Location = new System.Drawing.Point(148, 48);
            this.txtLoginId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(344, 40);
            this.txtLoginId.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.Location = new System.Drawing.Point(45, 176);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(448, 62);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "开 始 登 录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLoginPwd.Location = new System.Drawing.Point(148, 106);
            this.txtLoginPwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.Size = new System.Drawing.Size(344, 40);
            this.txtLoginPwd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(65, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 279);
            this.Controls.Add(this.txtLoginPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLoginId);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoginId;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLoginPwd;
        private System.Windows.Forms.Label label2;
    }
}