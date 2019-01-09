namespace MyKTV.ManageForms
{
    partial class FrmPhotoPath
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhotoPath));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNewSource = new System.Windows.Forms.TextBox();
            this.txtOldSource = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fdbPicture = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(544, 147);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 34);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(414, 147);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 34);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNewSource
            // 
            this.txtNewSource.Location = new System.Drawing.Point(96, 68);
            this.txtNewSource.Name = "txtNewSource";
            this.txtNewSource.Size = new System.Drawing.Size(543, 25);
            this.txtNewSource.TabIndex = 14;
            // 
            // txtOldSource
            // 
            this.txtOldSource.Location = new System.Drawing.Point(96, 12);
            this.txtOldSource.Name = "txtOldSource";
            this.txtOldSource.Size = new System.Drawing.Size(543, 25);
            this.txtOldSource.TabIndex = 13;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(96, 99);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(95, 34);
            this.btnBrowse.TabIndex = 12;
            this.btnBrowse.Text = "浏览";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "新路径";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "初始路径";
            // 
            // FrmPhotoPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 187);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNewSource);
            this.Controls.Add(this.txtOldSource);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPhotoPath";
            this.Text = "设置歌手照片路径";
            this.Load += new System.EventHandler(this.FrmPhotoPath_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNewSource;
        private System.Windows.Forms.TextBox txtOldSource;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog fdbPicture;

    }
}