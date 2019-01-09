namespace Chapter8
{
    partial class TreeViewDemo
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
            this.tvDemo = new System.Windows.Forms.TreeView();
            this.txtNodeName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvDemo
            // 
            this.tvDemo.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tvDemo.Location = new System.Drawing.Point(3, 3);
            this.tvDemo.Name = "tvDemo";
            this.tvDemo.Size = new System.Drawing.Size(309, 444);
            this.tvDemo.TabIndex = 0;
            // 
            // txtNodeName
            // 
            this.txtNodeName.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNodeName.Location = new System.Drawing.Point(318, 3);
            this.txtNodeName.Name = "txtNodeName";
            this.txtNodeName.Size = new System.Drawing.Size(274, 35);
            this.txtNodeName.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(480, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "添加节点";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(334, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "添加根节点";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(480, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 39);
            this.button3.TabIndex = 5;
            this.button3.Text = "删除节点";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(334, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 39);
            this.button4.TabIndex = 6;
            this.button4.Text = "清空所有节点";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TreeViewDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtNodeName);
            this.Controls.Add(this.tvDemo);
            this.Name = "TreeViewDemo";
            this.Text = "TreeViewDemo";
            this.Load += new System.EventHandler(this.TreeViewDemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvDemo;
        private System.Windows.Forms.TextBox txtNodeName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}