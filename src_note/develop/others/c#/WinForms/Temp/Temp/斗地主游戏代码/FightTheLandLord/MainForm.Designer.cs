namespace FightTheLandLord
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.panelPlayer1 = new System.Windows.Forms.Panel();
            this.btnLead = new System.Windows.Forms.Button();
            this.lblIsRule = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.游戏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.创建游戏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加入游戏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自定义分数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于作者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerServer = new System.Windows.Forms.Timer(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.timerClient = new System.Windows.Forms.Timer(this.components);
            this.tbState = new System.Windows.Forms.TextBox();
            this.panelPlayer2 = new System.Windows.Forms.Panel();
            this.panelPlayer3 = new System.Windows.Forms.Panel();
            this.panelPlayer1LeadPoker = new System.Windows.Forms.Panel();
            this.panelPlayer2LeadPoker = new System.Windows.Forms.Panel();
            this.panelPlayer3LeadPoker = new System.Windows.Forms.Panel();
            this.lblClient1Name = new System.Windows.Forms.Label();
            this.lblClient2Name = new System.Windows.Forms.Label();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnNeedLandLord = new System.Windows.Forms.Button();
            this.btnNotLandLord = new System.Windows.Forms.Button();
            this.panelLandLordPokers = new System.Windows.Forms.Panel();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblScore3 = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(395, 382);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(50, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panelPlayer1
            // 
            this.panelPlayer1.Location = new System.Drawing.Point(10, 411);
            this.panelPlayer1.Name = "panelPlayer1";
            this.panelPlayer1.Size = new System.Drawing.Size(800, 150);
            this.panelPlayer1.TabIndex = 1;
            this.panelPlayer1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPlayer1_Paint);
            this.panelPlayer1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelPlayer1_MouseClick);
            // 
            // btnLead
            // 
            this.btnLead.Enabled = false;
            this.btnLead.Location = new System.Drawing.Point(315, 382);
            this.btnLead.Name = "btnLead";
            this.btnLead.Size = new System.Drawing.Size(37, 23);
            this.btnLead.TabIndex = 2;
            this.btnLead.Text = "出牌";
            this.btnLead.UseVisualStyleBackColor = true;
            this.btnLead.Visible = false;
            this.btnLead.Click += new System.EventHandler(this.btnLead_Click);
            // 
            // lblIsRule
            // 
            this.lblIsRule.AutoSize = true;
            this.lblIsRule.ForeColor = System.Drawing.Color.Red;
            this.lblIsRule.Location = new System.Drawing.Point(10, 392);
            this.lblIsRule.Name = "lblIsRule";
            this.lblIsRule.Size = new System.Drawing.Size(0, 12);
            this.lblIsRule.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.游戏ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 游戏ToolStripMenuItem
            // 
            this.游戏ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.创建游戏ToolStripMenuItem,
            this.加入游戏ToolStripMenuItem,
            this.自定义分数ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.游戏ToolStripMenuItem.Name = "游戏ToolStripMenuItem";
            this.游戏ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.游戏ToolStripMenuItem.Text = "游戏";
            // 
            // 创建游戏ToolStripMenuItem
            // 
            this.创建游戏ToolStripMenuItem.Name = "创建游戏ToolStripMenuItem";
            this.创建游戏ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.创建游戏ToolStripMenuItem.Text = "创建游戏";
            this.创建游戏ToolStripMenuItem.Click += new System.EventHandler(this.创建游戏ToolStripMenuItem_Click);
            // 
            // 加入游戏ToolStripMenuItem
            // 
            this.加入游戏ToolStripMenuItem.Name = "加入游戏ToolStripMenuItem";
            this.加入游戏ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.加入游戏ToolStripMenuItem.Text = "加入游戏";
            this.加入游戏ToolStripMenuItem.Click += new System.EventHandler(this.加入游戏ToolStripMenuItem_Click);
            // 
            // 自定义分数ToolStripMenuItem
            // 
            this.自定义分数ToolStripMenuItem.Name = "自定义分数ToolStripMenuItem";
            this.自定义分数ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.自定义分数ToolStripMenuItem.Text = "自定义分数";
            this.自定义分数ToolStripMenuItem.Click += new System.EventHandler(this.自定义分数ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于作者ToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 关于作者ToolStripMenuItem
            // 
            this.关于作者ToolStripMenuItem.Name = "关于作者ToolStripMenuItem";
            this.关于作者ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.关于作者ToolStripMenuItem.Text = "关于作者";
            this.关于作者ToolStripMenuItem.Click += new System.EventHandler(this.关于作者ToolStripMenuItem_Click);
            // 
            // timerServer
            // 
            this.timerServer.Interval = 500;
            this.timerServer.Tick += new System.EventHandler(this.timerServer_Tick);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(358, 382);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(48, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "准备";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // timerClient
            // 
            this.timerClient.Interval = 500;
            this.timerClient.Tick += new System.EventHandler(this.timerClient_Tick);
            // 
            // tbState
            // 
            this.tbState.ForeColor = System.Drawing.Color.Red;
            this.tbState.Location = new System.Drawing.Point(222, 27);
            this.tbState.Multiline = true;
            this.tbState.Name = "tbState";
            this.tbState.ReadOnly = true;
            this.tbState.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbState.Size = new System.Drawing.Size(376, 56);
            this.tbState.TabIndex = 6;
            // 
            // panelPlayer2
            // 
            this.panelPlayer2.Location = new System.Drawing.Point(10, 27);
            this.panelPlayer2.Name = "panelPlayer2";
            this.panelPlayer2.Size = new System.Drawing.Size(100, 378);
            this.panelPlayer2.TabIndex = 7;
            this.panelPlayer2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPlayer2_Paint);
            // 
            // panelPlayer3
            // 
            this.panelPlayer3.Location = new System.Drawing.Point(710, 27);
            this.panelPlayer3.Name = "panelPlayer3";
            this.panelPlayer3.Size = new System.Drawing.Size(100, 378);
            this.panelPlayer3.TabIndex = 8;
            this.panelPlayer3.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPlayer3_Paint);
            // 
            // panelPlayer1LeadPoker
            // 
            this.panelPlayer1LeadPoker.Location = new System.Drawing.Point(222, 275);
            this.panelPlayer1LeadPoker.Name = "panelPlayer1LeadPoker";
            this.panelPlayer1LeadPoker.Size = new System.Drawing.Size(376, 100);
            this.panelPlayer1LeadPoker.TabIndex = 9;
            this.panelPlayer1LeadPoker.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPlayer1LeadPoker_Paint);
            // 
            // panelPlayer2LeadPoker
            // 
            this.panelPlayer2LeadPoker.Location = new System.Drawing.Point(116, 57);
            this.panelPlayer2LeadPoker.Name = "panelPlayer2LeadPoker";
            this.panelPlayer2LeadPoker.Size = new System.Drawing.Size(100, 348);
            this.panelPlayer2LeadPoker.TabIndex = 10;
            this.panelPlayer2LeadPoker.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPlayer2LeadPoker_Paint);
            // 
            // panelPlayer3LeadPoker
            // 
            this.panelPlayer3LeadPoker.Location = new System.Drawing.Point(604, 56);
            this.panelPlayer3LeadPoker.Name = "panelPlayer3LeadPoker";
            this.panelPlayer3LeadPoker.Size = new System.Drawing.Size(100, 348);
            this.panelPlayer3LeadPoker.TabIndex = 11;
            this.panelPlayer3LeadPoker.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPlayer3LeadPoker_Paint);
            // 
            // lblClient1Name
            // 
            this.lblClient1Name.AutoSize = true;
            this.lblClient1Name.Location = new System.Drawing.Point(116, 30);
            this.lblClient1Name.Name = "lblClient1Name";
            this.lblClient1Name.Size = new System.Drawing.Size(0, 12);
            this.lblClient1Name.TabIndex = 12;
            // 
            // lblClient2Name
            // 
            this.lblClient2Name.AutoSize = true;
            this.lblClient2Name.Location = new System.Drawing.Point(638, 30);
            this.lblClient2Name.Name = "lblClient2Name";
            this.lblClient2Name.Size = new System.Drawing.Size(0, 12);
            this.lblClient2Name.TabIndex = 13;
            // 
            // btnPass
            // 
            this.btnPass.Location = new System.Drawing.Point(451, 382);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(39, 23);
            this.btnPass.TabIndex = 14;
            this.btnPass.Text = "不要";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Visible = false;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnNeedLandLord
            // 
            this.btnNeedLandLord.Location = new System.Drawing.Point(284, 382);
            this.btnNeedLandLord.Name = "btnNeedLandLord";
            this.btnNeedLandLord.Size = new System.Drawing.Size(56, 23);
            this.btnNeedLandLord.TabIndex = 15;
            this.btnNeedLandLord.Text = "叫地主";
            this.btnNeedLandLord.UseVisualStyleBackColor = true;
            this.btnNeedLandLord.Visible = false;
            this.btnNeedLandLord.Click += new System.EventHandler(this.btnNeedLandLord_Click);
            // 
            // btnNotLandLord
            // 
            this.btnNotLandLord.Location = new System.Drawing.Point(470, 382);
            this.btnNotLandLord.Name = "btnNotLandLord";
            this.btnNotLandLord.Size = new System.Drawing.Size(57, 23);
            this.btnNotLandLord.TabIndex = 16;
            this.btnNotLandLord.Text = "不叫";
            this.btnNotLandLord.UseVisualStyleBackColor = true;
            this.btnNotLandLord.Visible = false;
            this.btnNotLandLord.Click += new System.EventHandler(this.btnNotLandLord_Click);
            // 
            // panelLandLordPokers
            // 
            this.panelLandLordPokers.Location = new System.Drawing.Point(304, 102);
            this.panelLandLordPokers.Name = "panelLandLordPokers";
            this.panelLandLordPokers.Size = new System.Drawing.Size(211, 100);
            this.panelLandLordPokers.TabIndex = 18;
            this.panelLandLordPokers.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLandLordPokers_Paint);
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.Location = new System.Drawing.Point(116, 42);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(0, 12);
            this.lblScore2.TabIndex = 19;
            // 
            // lblScore3
            // 
            this.lblScore3.AutoSize = true;
            this.lblScore3.Location = new System.Drawing.Point(638, 41);
            this.lblScore3.Name = "lblScore3";
            this.lblScore3.Size = new System.Drawing.Size(0, 12);
            this.lblScore3.TabIndex = 20;
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.Location = new System.Drawing.Point(222, 387);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(0, 12);
            this.lblScore1.TabIndex = 21;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 566);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.lblScore3);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.panelLandLordPokers);
            this.Controls.Add(this.btnNotLandLord);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.btnNeedLandLord);
            this.Controls.Add(this.lblClient2Name);
            this.Controls.Add(this.lblClient1Name);
            this.Controls.Add(this.panelPlayer3LeadPoker);
            this.Controls.Add(this.panelPlayer2LeadPoker);
            this.Controls.Add(this.panelPlayer1LeadPoker);
            this.Controls.Add(this.panelPlayer3);
            this.Controls.Add(this.panelPlayer2);
            this.Controls.Add(this.tbState);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblIsRule);
            this.Controls.Add(this.btnLead);
            this.Controls.Add(this.panelPlayer1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(830, 600);
            this.MinimumSize = new System.Drawing.Size(830, 600);
            this.Name = "MainForm";
            this.Text = "火拼斗地主";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panelPlayer1;
        private System.Windows.Forms.Button btnLead;
        private System.Windows.Forms.Label lblIsRule;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 游戏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 创建游戏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加入游戏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于作者ToolStripMenuItem;
        private System.Windows.Forms.Timer timerServer;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Timer timerClient;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.Panel panelPlayer2;
        private System.Windows.Forms.Panel panelPlayer3;
        private System.Windows.Forms.Panel panelPlayer1LeadPoker;
        private System.Windows.Forms.Panel panelPlayer2LeadPoker;
        private System.Windows.Forms.Panel panelPlayer3LeadPoker;
        private System.Windows.Forms.Label lblClient1Name;
        private System.Windows.Forms.Label lblClient2Name;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnNeedLandLord;
        private System.Windows.Forms.Button btnNotLandLord;
        private System.Windows.Forms.Panel panelLandLordPokers;
        private System.Windows.Forms.ToolStripMenuItem 自定义分数ToolStripMenuItem;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label lblScore3;
        private System.Windows.Forms.Label lblScore1;
    }
}

