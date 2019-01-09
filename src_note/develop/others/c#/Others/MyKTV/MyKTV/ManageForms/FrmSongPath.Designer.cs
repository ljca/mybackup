namespace MyKTV.ManageForms
{
    partial class FrmSongPath
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtOldSource = new System.Windows.Forms.TextBox();
            this.txtNewSource = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.fbdSongSource = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "初始路径";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "新路径";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(91, 120);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(95, 34);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "浏览";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtOldSource
            // 
            this.txtOldSource.Location = new System.Drawing.Point(91, 26);
            this.txtOldSource.Name = "txtOldSource";
            this.txtOldSource.Size = new System.Drawing.Size(543, 25);
            this.txtOldSource.TabIndex = 6;
            // 
            // txtNewSource
            // 
            this.txtNewSource.Location = new System.Drawing.Point(91, 89);
            this.txtNewSource.Name = "txtNewSource";
            this.txtNewSource.Size = new System.Drawing.Size(543, 25);
            this.txtNewSource.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(409, 168);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 34);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(539, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 34);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmSongPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 212);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNewSource);
            this.Controls.Add(this.txtOldSource);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSongPath";
            this.Text = "设置歌曲路径";
            this.Load += new System.EventHandler(this.FrmSongPath_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtOldSource;
        private System.Windows.Forms.TextBox txtNewSource;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.FolderBrowserDialog fbdSongSource;
    }
}