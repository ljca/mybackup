namespace Cacl
{
    partial class FrmCacl
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
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCount = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboOper = new System.Windows.Forms.ComboBox();
            this.txtNuberB = new System.Windows.Forms.TextBox();
            this.txtNuberA = new System.Windows.Forms.TextBox();
            this.lblResult_2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(156, 185);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(75, 15);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "计算结果:";
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(403, 45);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(95, 25);
            this.btnCount.TabIndex = 1;
            this.btnCount.Text = "计算";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboOper);
            this.groupBox1.Controls.Add(this.btnCount);
            this.groupBox1.Controls.Add(this.txtNuberB);
            this.groupBox1.Controls.Add(this.txtNuberA);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 89);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "计算";
            // 
            // cboOper
            // 
            this.cboOper.FormattingEnabled = true;
            this.cboOper.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cboOper.Location = new System.Drawing.Point(159, 45);
            this.cboOper.Name = "cboOper";
            this.cboOper.Size = new System.Drawing.Size(75, 23);
            this.cboOper.TabIndex = 1;
            // 
            // txtNuberB
            // 
            this.txtNuberB.Location = new System.Drawing.Point(281, 43);
            this.txtNuberB.Name = "txtNuberB";
            this.txtNuberB.Size = new System.Drawing.Size(66, 25);
            this.txtNuberB.TabIndex = 0;
            // 
            // txtNuberA
            // 
            this.txtNuberA.Location = new System.Drawing.Point(34, 45);
            this.txtNuberA.Name = "txtNuberA";
            this.txtNuberA.Size = new System.Drawing.Size(66, 25);
            this.txtNuberA.TabIndex = 0;
            // 
            // lblResult_2
            // 
            this.lblResult_2.AutoSize = true;
            this.lblResult_2.Location = new System.Drawing.Point(232, 185);
            this.lblResult_2.Name = "lblResult_2";
            this.lblResult_2.Size = new System.Drawing.Size(55, 15);
            this.lblResult_2.TabIndex = 0;
            this.lblResult_2.Text = "label1";
            // 
            // FrmCacl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 238);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResult_2);
            this.Controls.Add(this.lblResult);
            this.Name = "FrmCacl";
            this.Text = "计算器";
            this.Load += new System.EventHandler(this.FrmCacl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboOper;
        private System.Windows.Forms.TextBox txtNuberA;
        private System.Windows.Forms.Label lblResult_2;
        private System.Windows.Forms.TextBox txtNuberB;
    }
}

