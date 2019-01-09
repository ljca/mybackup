namespace TreeViewDemo
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
            this.tvDemo = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tvDemo
            // 
            this.tvDemo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvDemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDemo.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tvDemo.Location = new System.Drawing.Point(0, 0);
            this.tvDemo.Name = "tvDemo";
            this.tvDemo.Size = new System.Drawing.Size(608, 439);
            this.tvDemo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 439);
            this.Controls.Add(this.tvDemo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvDemo;
    }
}

