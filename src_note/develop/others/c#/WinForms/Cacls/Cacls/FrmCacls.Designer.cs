namespace Cacls
{
    partial class FrmCacls
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
            this.btnCacls = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cbc = new System.Windows.Forms.Label();
            this.lable3 = new System.Windows.Forms.Label();
            this.txt_Nuber1 = new System.Windows.Forms.TextBox();
            this.txt_Nuber2 = new System.Windows.Forms.TextBox();
            this.cbCacls = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_End = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCacls
            // 
            this.btnCacls.Location = new System.Drawing.Point(209, 197);
            this.btnCacls.Name = "btnCacls";
            this.btnCacls.Size = new System.Drawing.Size(85, 23);
            this.btnCacls.TabIndex = 0;
            this.btnCacls.Text = "计算";
            this.btnCacls.UseVisualStyleBackColor = true;
            this.btnCacls.Click += new System.EventHandler(this.btnCacls_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(332, 197);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(77, 23);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "退出";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "第一个数";
            // 
            // Cbc
            // 
            this.Cbc.AutoSize = true;
            this.Cbc.Location = new System.Drawing.Point(214, 56);
            this.Cbc.Name = "Cbc";
            this.Cbc.Size = new System.Drawing.Size(52, 15);
            this.Cbc.TabIndex = 4;
            this.Cbc.Text = "运算符";
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.Location = new System.Drawing.Point(329, 56);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(82, 15);
            this.lable3.TabIndex = 5;
            this.lable3.Text = "第二个数：";
            // 
            // txt_Nuber1
            // 
            this.txt_Nuber1.Location = new System.Drawing.Point(68, 92);
            this.txt_Nuber1.Name = "txt_Nuber1";
            this.txt_Nuber1.Size = new System.Drawing.Size(100, 25);
            this.txt_Nuber1.TabIndex = 6;
            // 
            // txt_Nuber2
            // 
            this.txt_Nuber2.Location = new System.Drawing.Point(321, 92);
            this.txt_Nuber2.Multiline = true;
            this.txt_Nuber2.Name = "txt_Nuber2";
            this.txt_Nuber2.Size = new System.Drawing.Size(100, 25);
            this.txt_Nuber2.TabIndex = 7;
            // 
            // cbCacls
            // 
            this.cbCacls.FormattingEnabled = true;
            this.cbCacls.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbCacls.Location = new System.Drawing.Point(217, 92);
            this.cbCacls.Name = "cbCacls";
            this.cbCacls.Size = new System.Drawing.Size(49, 23);
            this.cbCacls.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "运算结果:";
            // 
            // txt_End
            // 
            this.txt_End.Location = new System.Drawing.Point(135, 143);
            this.txt_End.Multiline = true;
            this.txt_End.Name = "txt_End";
            this.txt_End.Size = new System.Drawing.Size(286, 25);
            this.txt_End.TabIndex = 10;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(83, 197);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "清空";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FrmCacls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 261);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txt_End);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCacls);
            this.Controls.Add(this.txt_Nuber2);
            this.Controls.Add(this.txt_Nuber1);
            this.Controls.Add(this.lable3);
            this.Controls.Add(this.Cbc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btnCacls);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCacls";
            this.Text = "计算器";
            this.Load += new System.EventHandler(this.FrmCacls_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCacls;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Cbc;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.TextBox txt_Nuber1;
        private System.Windows.Forms.TextBox txt_Nuber2;
        private System.Windows.Forms.ComboBox cbCacls;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_End;
        private System.Windows.Forms.Button btnReset;
    }
}

