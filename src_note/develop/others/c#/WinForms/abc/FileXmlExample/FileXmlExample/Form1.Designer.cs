namespace FileXmlExample
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
            this.btnText = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(12, 11);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(75, 23);
            this.btnText.TabIndex = 0;
            this.btnText.Text = "button1";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(12, 40);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(508, 345);
            this.txtNote.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 397);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.btnText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.TextBox txtNote;
    }
}

