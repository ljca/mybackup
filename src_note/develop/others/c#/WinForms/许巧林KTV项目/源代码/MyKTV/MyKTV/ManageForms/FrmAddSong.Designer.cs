namespace MyKTV.ManageForms
{
    partial class FrmAddSong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddSong));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSongN = new System.Windows.Forms.TextBox();
            this.txtSongab = new System.Windows.Forms.TextBox();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboSongType = new System.Windows.Forms.ComboBox();
            this.ofdBrowse = new System.Windows.Forms.OpenFileDialog();
            this.txtSinger = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "歌曲名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "拼音缩写";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "歌曲类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "歌手";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "歌曲文件名";
            // 
            // txtSongN
            // 
            this.txtSongN.Location = new System.Drawing.Point(85, 6);
            this.txtSongN.Name = "txtSongN";
            this.txtSongN.Size = new System.Drawing.Size(613, 25);
            this.txtSongN.TabIndex = 5;
            // 
            // txtSongab
            // 
            this.txtSongab.Location = new System.Drawing.Point(85, 46);
            this.txtSongab.Name = "txtSongab";
            this.txtSongab.Size = new System.Drawing.Size(613, 25);
            this.txtSongab.TabIndex = 6;
            // 
            // txtSongName
            // 
            this.txtSongName.Location = new System.Drawing.Point(12, 222);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(686, 25);
            this.txtSongName.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(604, 134);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 26);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(15, 253);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(94, 26);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "浏览";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(488, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 26);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(604, 331);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 26);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboSongType
            // 
            this.cboSongType.FormattingEnabled = true;
            this.cboSongType.Location = new System.Drawing.Point(85, 91);
            this.cboSongType.Name = "cboSongType";
            this.cboSongType.Size = new System.Drawing.Size(613, 23);
            this.cboSongType.TabIndex = 13;
            // 
            // ofdBrowse
            // 
            this.ofdBrowse.FileName = "openFileDialog1";
            // 
            // txtSinger
            // 
            this.txtSinger.Location = new System.Drawing.Point(85, 134);
            this.txtSinger.Name = "txtSinger";
            this.txtSinger.Size = new System.Drawing.Size(497, 25);
            this.txtSinger.TabIndex = 8;
            // 
            // FrmAddSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 398);
            this.Controls.Add(this.cboSongType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSinger);
            this.Controls.Add(this.txtSongName);
            this.Controls.Add(this.txtSongab);
            this.Controls.Add(this.txtSongN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddSong";
            this.Text = "添加歌曲";
            this.Load += new System.EventHandler(this.FrmAddSong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSongN;
        private System.Windows.Forms.TextBox txtSongab;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboSongType;
        private System.Windows.Forms.OpenFileDialog ofdBrowse;
        private System.Windows.Forms.TextBox txtSinger;
    }
}