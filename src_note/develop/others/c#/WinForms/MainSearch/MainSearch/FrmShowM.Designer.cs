namespace MainSearch
{
    partial class FrmShowM
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
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSingerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSongType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSongAb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSongUrl = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // txtSongName
            // 
            this.txtSongName.Location = new System.Drawing.Point(114, 34);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(767, 25);
            this.txtSongName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "label1";
            // 
            // txtSingerName
            // 
            this.txtSingerName.Location = new System.Drawing.Point(114, 116);
            this.txtSingerName.Name = "txtSingerName";
            this.txtSingerName.Size = new System.Drawing.Size(767, 25);
            this.txtSingerName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "label1";
            // 
            // txtSongType
            // 
            this.txtSongType.Location = new System.Drawing.Point(114, 187);
            this.txtSongType.Name = "txtSongType";
            this.txtSongType.Size = new System.Drawing.Size(767, 25);
            this.txtSongType.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "label1";
            // 
            // txtSongAb
            // 
            this.txtSongAb.Location = new System.Drawing.Point(114, 269);
            this.txtSongAb.Name = "txtSongAb";
            this.txtSongAb.Size = new System.Drawing.Size(767, 25);
            this.txtSongAb.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "label1";
            // 
            // txtSongUrl
            // 
            this.txtSongUrl.Location = new System.Drawing.Point(114, 343);
            this.txtSongUrl.Name = "txtSongUrl";
            this.txtSongUrl.Size = new System.Drawing.Size(767, 25);
            this.txtSongUrl.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(237, 452);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 42);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelet
            // 
            this.btnDelet.Location = new System.Drawing.Point(434, 452);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(119, 42);
            this.btnDelet.TabIndex = 3;
            this.btnDelet.Text = "删除";
            this.btnDelet.UseVisualStyleBackColor = true;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // FrmShowM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 585);
            this.Controls.Add(this.btnDelet);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSongAb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSongUrl);
            this.Controls.Add(this.txtSingerName);
            this.Controls.Add(this.txtSongType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSongName);
            this.Controls.Add(this.label1);
            this.Name = "FrmShowM";
            this.Text = "显示传递数据！";
            this.Load += new System.EventHandler(this.FrmShowM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSingerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSongType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSongAb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSongUrl;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelet;
    }
}