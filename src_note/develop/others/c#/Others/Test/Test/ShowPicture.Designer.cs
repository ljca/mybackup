namespace Test
{
    partial class ShowPicture
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
            this.pbSinger = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.ofdShow = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbSinger)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSinger
            // 
            this.pbSinger.Location = new System.Drawing.Point(3, 25);
            this.pbSinger.Name = "pbSinger";
            this.pbSinger.Size = new System.Drawing.Size(290, 189);
            this.pbSinger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSinger.TabIndex = 0;
            this.pbSinger.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(12, 220);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 29);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "浏览";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // ofdShow
            // 
            this.ofdShow.FileName = "openFileDialog1";
            // 
            // ShowPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 259);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pbSinger);
            this.Name = "ShowPicture";
            this.Text = "显示图片";
            this.Load += new System.EventHandler(this.ShowPicture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSinger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSinger;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog ofdShow;
    }
}