namespace MyKTV.ManageForms
{
    partial class FrmEditSinger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditSinger));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbdescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescribe = new System.Windows.Forms.TextBox();
            this.cboSingerType = new System.Windows.Forms.ComboBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnAddsinger = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbSingerPic = new System.Windows.Forms.PictureBox();
            this.ofdPicture = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSingerPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "性别";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "歌手类型";
            // 
            // lbdescription
            // 
            this.lbdescription.AutoSize = true;
            this.lbdescription.Location = new System.Drawing.Point(32, 264);
            this.lbdescription.Name = "lbdescription";
            this.lbdescription.Size = new System.Drawing.Size(67, 15);
            this.lbdescription.TabIndex = 3;
            this.lbdescription.Text = "歌手描述";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(65, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 42);
            this.panel1.TabIndex = 4;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(216, 11);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 19);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "组合";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(154, 11);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(43, 19);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "女";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(75, 11);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 19);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "男";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(123, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(258, 25);
            this.txtName.TabIndex = 5;
            // 
            // txtDescribe
            // 
            this.txtDescribe.Location = new System.Drawing.Point(123, 261);
            this.txtDescribe.Multiline = true;
            this.txtDescribe.Name = "txtDescribe";
            this.txtDescribe.Size = new System.Drawing.Size(435, 110);
            this.txtDescribe.TabIndex = 6;
            // 
            // cboSingerType
            // 
            this.cboSingerType.FormattingEnabled = true;
            this.cboSingerType.Location = new System.Drawing.Point(123, 184);
            this.cboSingerType.Name = "cboSingerType";
            this.cboSingerType.Size = new System.Drawing.Size(322, 23);
            this.cboSingerType.TabIndex = 7;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(464, 183);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(94, 26);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "浏览";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnAddsinger
            // 
            this.btnAddsinger.Location = new System.Drawing.Point(351, 387);
            this.btnAddsinger.Name = "btnAddsinger";
            this.btnAddsinger.Size = new System.Drawing.Size(94, 26);
            this.btnAddsinger.TabIndex = 9;
            this.btnAddsinger.Text = "添加";
            this.btnAddsinger.UseVisualStyleBackColor = true;
            this.btnAddsinger.Click += new System.EventHandler(this.btnAddsinger_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(465, 387);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 26);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbSingerPic
            // 
            this.pbSingerPic.Location = new System.Drawing.Point(406, 22);
            this.pbSingerPic.Name = "pbSingerPic";
            this.pbSingerPic.Size = new System.Drawing.Size(134, 140);
            this.pbSingerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSingerPic.TabIndex = 11;
            this.pbSingerPic.TabStop = false;
            // 
            // ofdPicture
            // 
            this.ofdPicture.FileName = "openFileDialog1";
            // 
            // FrmEditSinger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 430);
            this.Controls.Add(this.pbSingerPic);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddsinger);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.cboSingerType);
            this.Controls.Add(this.txtDescribe);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbdescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditSinger";
            this.Text = "编辑歌手信息";
            this.Load += new System.EventHandler(this.FrmEditSinger_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSingerPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbdescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescribe;
        private System.Windows.Forms.ComboBox cboSingerType;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnAddsinger;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbSingerPic;
        private System.Windows.Forms.OpenFileDialog ofdPicture;
    }
}