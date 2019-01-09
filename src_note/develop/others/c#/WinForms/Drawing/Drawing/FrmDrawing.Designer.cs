namespace Drawing
{
    partial class FrmDrawing
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlpic = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rboRect = new System.Windows.Forms.RadioButton();
            this.rboCircle = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rboBlue = new System.Windows.Forms.RadioButton();
            this.rboYellow = new System.Windows.Forms.RadioButton();
            this.rboRed = new System.Windows.Forms.RadioButton();
            this.btnDraw = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlpic
            // 
            this.pnlpic.Location = new System.Drawing.Point(40, 46);
            this.pnlpic.Name = "pnlpic";
            this.pnlpic.Size = new System.Drawing.Size(268, 257);
            this.pnlpic.TabIndex = 0;
            this.pnlpic.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlpic_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rboRect);
            this.groupBox1.Controls.Add(this.rboCircle);
            this.groupBox1.Location = new System.Drawing.Point(458, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图形";
            // 
            // rboRect
            // 
            this.rboRect.AutoSize = true;
            this.rboRect.Location = new System.Drawing.Point(21, 59);
            this.rboRect.Name = "rboRect";
            this.rboRect.Size = new System.Drawing.Size(58, 19);
            this.rboRect.TabIndex = 1;
            this.rboRect.TabStop = true;
            this.rboRect.Text = "矩形";
            this.rboRect.UseVisualStyleBackColor = true;
            // 
            // rboCircle
            // 
            this.rboCircle.AutoSize = true;
            this.rboCircle.Location = new System.Drawing.Point(21, 24);
            this.rboCircle.Name = "rboCircle";
            this.rboCircle.Size = new System.Drawing.Size(58, 19);
            this.rboCircle.TabIndex = 1;
            this.rboCircle.TabStop = true;
            this.rboCircle.Text = "圆形";
            this.rboCircle.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rboBlue);
            this.groupBox2.Controls.Add(this.rboYellow);
            this.groupBox2.Controls.Add(this.rboRed);
            this.groupBox2.Location = new System.Drawing.Point(458, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 144);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "颜色";
            // 
            // rboBlue
            // 
            this.rboBlue.AutoSize = true;
            this.rboBlue.Location = new System.Drawing.Point(21, 99);
            this.rboBlue.Name = "rboBlue";
            this.rboBlue.Size = new System.Drawing.Size(58, 19);
            this.rboBlue.TabIndex = 1;
            this.rboBlue.TabStop = true;
            this.rboBlue.Text = "蓝色";
            this.rboBlue.UseVisualStyleBackColor = true;
            // 
            // rboYellow
            // 
            this.rboYellow.AutoSize = true;
            this.rboYellow.Location = new System.Drawing.Point(21, 59);
            this.rboYellow.Name = "rboYellow";
            this.rboYellow.Size = new System.Drawing.Size(58, 19);
            this.rboYellow.TabIndex = 1;
            this.rboYellow.TabStop = true;
            this.rboYellow.Text = "黄色";
            this.rboYellow.UseVisualStyleBackColor = true;
            // 
            // rboRed
            // 
            this.rboRed.AutoSize = true;
            this.rboRed.Location = new System.Drawing.Point(21, 24);
            this.rboRed.Name = "rboRed";
            this.rboRed.Size = new System.Drawing.Size(58, 19);
            this.rboRed.TabIndex = 1;
            this.rboRed.TabStop = true;
            this.rboRed.Text = "红色";
            this.rboRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rboRed.UseVisualStyleBackColor = true;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(561, 339);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(97, 39);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "绘制";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // FrmDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 397);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlpic);
            this.Name = "FrmDrawing";
            this.Text = "绘图板";
            this.Load += new System.EventHandler(this.FrmDrawing_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlpic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rboRect;
        private System.Windows.Forms.RadioButton rboCircle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.RadioButton rboBlue;
        private System.Windows.Forms.RadioButton rboYellow;
        private System.Windows.Forms.RadioButton rboRed;
    }
}

