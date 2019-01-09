namespace LogIn_Forms
{
    partial class Admin_Forms
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
            this.txt_User = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(108, 96);
            this.txt_User.Multiline = true;
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(217, 79);
            this.txt_User.TabIndex = 0;
            this.txt_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Admin_Forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LogIn_Forms.Properties.Resources.aboug_bj;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(921, 595);
            this.Controls.Add(this.txt_User);
            this.Name = "Admin_Forms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员主界面";
            this.Load += new System.EventHandler(this.Admin_Forms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_User;
    }
}