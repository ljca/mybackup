/*
 * 由SharpDevelop创建。
 * 用户： 子非鱼
 * 日期: 2015/8/1 星期六
 * 时间: 13:57
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace Temp
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.LinkLabel linkLabel1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// linkLabel1
			// 
			this.linkLabel1.Location = new System.Drawing.Point(235, 107);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(151, 35);
			this.linkLabel1.TabIndex = 0;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "没有账号？点这里注册";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(947, 519);
			this.Controls.Add(this.linkLabel1);
			this.Name = "MainForm";
			this.Text = "Temp";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);

		}
	}
}
