namespace Notepad
{
    partial class FrmNotepad
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtauthor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(559, 429);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtauthor
            // 
            this.txtauthor.Location = new System.Drawing.Point(68, 20);
            this.txtauthor.Name = "txtauthor";
            this.txtauthor.Size = new System.Drawing.Size(217, 21);
            this.txtauthor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "作者:";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(400, 20);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(217, 21);
            this.txtBookName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "书名:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "内容:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(1, 89);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(783, 321);
            this.txtDescription.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(696, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "关闭";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmNotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 464);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtauthor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmNotepad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "读书日记";
            this.Load += new System.EventHandler(this.FrmNotepad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtauthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button button2;
    }
}

