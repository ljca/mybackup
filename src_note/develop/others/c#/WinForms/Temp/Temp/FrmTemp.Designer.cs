namespace Temp
{
    partial class FrmTemp
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
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.btnTemp = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnTemp);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtTemp);
            this.splitContainer1.Size = new System.Drawing.Size(891, 525);
            this.splitContainer1.SplitterDistance = 297;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(3, 0);
            this.txtTemp.Multiline = true;
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(590, 525);
            this.txtTemp.TabIndex = 0;
            // 
            // btnTemp
            // 
            this.btnTemp.Location = new System.Drawing.Point(72, 56);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(101, 28);
            this.btnTemp.TabIndex = 1;
            this.btnTemp.Text = "temp";
            this.btnTemp.UseVisualStyleBackColor = true;
            this.btnTemp.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // FrmTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 525);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmTemp";
            this.Text = "临时窗口";
            this.Load += new System.EventHandler(this.FrmTemp_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnTemp;
        private System.Windows.Forms.TextBox txtTemp;

    }
}

