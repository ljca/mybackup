namespace Rss
{
    partial class Reader
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
            this.lblTitle = new CCWin.SkinControl.SkinLabel();
            this.txtDesciption = new CCWin.SkinControl.SkinTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.BorderColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(12, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(571, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "标题";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDesciption
            // 
            this.txtDesciption.BackColor = System.Drawing.Color.Transparent;
            this.txtDesciption.DownBack = null;
            this.txtDesciption.Icon = null;
            this.txtDesciption.IconIsButton = false;
            this.txtDesciption.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtDesciption.IsPasswordChat = '\0';
            this.txtDesciption.IsSystemPasswordChar = false;
            this.txtDesciption.Lines = new string[] {
        "内容"};
            this.txtDesciption.Location = new System.Drawing.Point(9, 47);
            this.txtDesciption.Margin = new System.Windows.Forms.Padding(0);
            this.txtDesciption.MaxLength = 32767;
            this.txtDesciption.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtDesciption.MouseBack = null;
            this.txtDesciption.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtDesciption.Multiline = true;
            this.txtDesciption.Name = "txtDesciption";
            this.txtDesciption.NormlBack = null;
            this.txtDesciption.Padding = new System.Windows.Forms.Padding(5);
            this.txtDesciption.ReadOnly = false;
            this.txtDesciption.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDesciption.Size = new System.Drawing.Size(574, 330);
            // 
            // 
            // 
            this.txtDesciption.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesciption.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDesciption.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDesciption.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtDesciption.SkinTxt.Multiline = true;
            this.txtDesciption.SkinTxt.Name = "BaseText";
            this.txtDesciption.SkinTxt.Size = new System.Drawing.Size(564, 320);
            this.txtDesciption.SkinTxt.TabIndex = 0;
            this.txtDesciption.SkinTxt.Text = "内容";
            this.txtDesciption.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDesciption.SkinTxt.WaterText = "";
            this.txtDesciption.TabIndex = 1;
            this.txtDesciption.Text = "内容";
            this.txtDesciption.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDesciption.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDesciption.WaterText = "";
            this.txtDesciption.WordWrap = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.Location = new System.Drawing.Point(492, 382);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(88, 26);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "阅读新闻";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 413);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtDesciption);
            this.Controls.Add(this.lblTitle);
            this.Name = "Reader";
            this.Text = "Reader";
            this.Load += new System.EventHandler(this.Reader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel lblTitle;
        private CCWin.SkinControl.SkinTextBox txtDesciption;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}