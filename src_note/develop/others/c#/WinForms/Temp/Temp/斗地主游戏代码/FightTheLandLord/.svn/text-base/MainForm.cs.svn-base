using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Microsoft.VisualBasic;


namespace FightTheLandLord
{
    public partial class MainForm : Form
    {
        private Player player1 = new Player();
        private Player player2;
        private Player player3;
        public Server server;
        public Client client;
        private bool SendedName;
        private Thread acceptConn;
        private Thread AcceptClient1Data;
        private Thread AcceptClient2Data;
        private Thread AcceptServerData;
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            DConsole.IsStart = true;
            if (this.server != null)
            {
                for (int i = 3; i < 18; i++)  //嵌套for循环初始化54张牌
                {
                    for (int j = 1; j < 5; j++)
                    {
                        if (i <= 15)
                        {
                            DConsole.allPoker.Add(new Poker((PokerNum)i, (PokerColor)j));
                        }
                    }
                    if (i >= 16)
                    {
                        DConsole.allPoker.Add(new Poker((PokerNum)i, PokerColor.黑桃));
                    }
                }                           //嵌套for循环初始化54张牌

#if DEBUG
                Console.WriteLine(DConsole.allPoker.Count);
                foreach (Poker onePoker in DConsole.allPoker)
                {
                    Console.WriteLine(onePoker.pokerColor.ToString() + onePoker.ToString());
                }
#endif
                if (!DConsole.IsRestart)
                {
                    server.SendDataForClient("YouAreClient1", 1);
                }
                DConsole.shuffle(); //洗牌
                DConsole.deal(); //发牌
                this.player1.sort(); //把牌从大到小排序
                this.player1.g = this.panelPlayer1.CreateGraphics(); //把panelPlayer1的Graphics传递给player1
                this.player1.Paint(); //在panelPlayer1中画出player1的牌
                this.player2.sort();
                this.player3.sort();
                server.SendDataForClient("SPokerCount" + "17", 1);
                Thread.Sleep(200);
                server.SendDataForClient("SPokerCount" + "17", 2);
                Thread.Sleep(200);
                server.SendDataForClient("PokerCount" + "17", 1);
                Thread.Sleep(200);
                server.SendDataForClient("PokerCount" + "17", 2);
                Thread.Sleep(200);
                DConsole.PaintClient(17, 1);
                DConsole.PaintClient(17, 2);
                DConsole.PaintLandLord(false);
                //this.panelPlayer1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelPlayer1_MouseClick); //给panelPlayer1添加一个点击事件
                this.btnStart.Enabled = false;
                this.btnStart.Visible = false;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DConsole.tb = this.tbState;
            DConsole.g1 = this.panelPlayer2.CreateGraphics();
            DConsole.g2 = this.panelPlayer3.CreateGraphics();
            DConsole.gPlayer1LeadPoker = this.panelPlayer1LeadPoker.CreateGraphics();
            DConsole.gPlayer2LeadPoker = this.panelPlayer2LeadPoker.CreateGraphics();
            DConsole.gPlayer3LeadPoker = this.panelPlayer3LeadPoker.CreateGraphics();
            DConsole.gLandLordPoker = this.panelLandLordPokers.CreateGraphics();
            DConsole.backColor = this.BackColor;
            DConsole.lblClient1Name = this.lblClient1Name;
            DConsole.lblClient2Name = this.lblClient2Name;
            DConsole.lblScore1 = this.lblScore1;
            DConsole.lblScore2 = this.lblScore2;
            DConsole.lblScore3 = this.lblScore3;
            player1.g = panelPlayer1.CreateGraphics();

        }

        private void panelPlayer1_Paint(object sender, PaintEventArgs e)
        {
            this.player1.Paint();
        }

        private void panelPlayer1_MouseClick(object sender, MouseEventArgs e)  //鼠标点击事件,处理选中牌的效果
        {
            int index;
            this.player1.backColor = this.panelPlayer1.BackColor;
            if ((int)(e.X / 40) < player1.pokers.Count)
            {
                index = (int)(e.X / 40);
                this.player1.Paint(index);
            }
        }

        private void btnLead_Click(object sender, EventArgs e) //出牌按钮的事件处理程序
        {
            if (player1.lead())
            {
                this.btnLead.Visible = false;
                this.btnPass.Visible = false;
                if (this.server != null)
                {
                    server.SendDataForClient("SPokerCount" + Convert.ToString(this.player1.pokers.Count), 1);
                    Thread.Sleep(100);
                    server.SendDataForClient("SPokerCount" + Convert.ToString(this.player1.pokers.Count), 2);
                    Thread.Sleep(100);
                    server.SendDataForClient("server", DConsole.leadPokers, 1);
                    Thread.Sleep(100);
                    server.SendDataForClient("server", DConsole.leadPokers, 2);
                    Thread.Sleep(100);
                    if (this.player1.pokers.Count == 0 && DConsole.IsStart)
                    {
                        DConsole.Winer = 1;
                        DConsole.Restart();
                    }
                    else
                    {
                        server.SendDataForClient("Order", 2); //当server端的牌出完了后,就不再传递出牌权限.
                    }
                    DConsole.player1.haveOrder = false;
                    
                }
                if (this.client != null)
                {
                    client.SendDataForServer("PokerCount" + Convert.ToString(this.player1.pokers.Count));
                    Thread.Sleep(500);
                    client.SendDataForServer("client", DConsole.leadPokers);
                    Thread.Sleep(100);
                    this.player1.haveOrder = false;
                }
                player1.g.Clear(this.BackColor);
                player1.Paint();
                DConsole.PaintPlayer1LeadPoker();
            }
            else
            {
                DConsole.Write("[系统消息]:您出的牌不符合规则!");
            }
        }

        private void 创建游戏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.server = new Server();  //创建服务器
            DConsole.server = this.server;
            DConsole.player1 = this.player1;
            this.server.listener.Start();  //开始监听
            this.player2 = new Player();
            this.player3 = new Player();
            this.acceptConn = new Thread(new ThreadStart(this.server.Connection)); //新建一个线程用于接受请求连接
            this.acceptConn.IsBackground = true;
            this.acceptConn.Name = "检测客户端的连接并接受的线程";
            this.acceptConn.Start(); //开始线程
            DConsole.Write("[系统消息]:创建游戏成功,等待其他人链接");
            this.timerServer.Enabled = true;
            ToolStripMenuItem tsmi = (ToolStripMenuItem)(this.menuStrip1.Items["游戏ToolStripMenuItem"]);
            tsmi.DropDownItems["创建游戏ToolStripMenuItem"].Enabled = false;
            tsmi.DropDownItems["自定义分数ToolStripMenuItem"].Enabled = false;
            tsmi.DropDownItems["加入游戏ToolStripMenuItem"].Enabled = false;  //禁用相关菜单
        }

        private void 加入游戏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JoinForm joinForm = new JoinForm();
            joinForm.ShowDialog();
            if (Properties.Settings.Default.Host != "" && Properties.Settings.Default.Name != "")
            {
                this.client = new Client();
                DConsole.client = this.client;
                DConsole.player1 = this.player1;
                if (this.client.Connection())
                {
                    MessageBox.Show("连接成功", "消息");
                    client.Name = Properties.Settings.Default.Name;
                    this.lblClient1Name.Text = "server";
                    btnOK.Enabled = true;
                    btnOK.Visible = true;   //启用"准备"按钮
                    ToolStripMenuItem tsmi = (ToolStripMenuItem)(this.menuStrip1.Items["游戏ToolStripMenuItem"]);
                    tsmi.DropDownItems["创建游戏ToolStripMenuItem"].Enabled = false;
                    tsmi.DropDownItems["自定义分数ToolStripMenuItem"].Enabled = false;
                    tsmi.DropDownItems["加入游戏ToolStripMenuItem"].Enabled = false;  //禁用相关菜单
                }
                else
                {
                    MessageBox.Show("连接失败", "消息");
                }
            }
        }

        private void timerServer_Tick(object sender, EventArgs e)
        {
            if (this.server.client1 != null && this.server.client2 != null)
            {
                if (this.tbState.Text.IndexOf("连接建立成功,等待其他人准备", 0, this.tbState.Text.Length) < 0) //防止向用户重复发送此消息
                {
                    DConsole.Write("[系统消息]:连接建立成功,等待其他人准备");
                }
                if (this.lblClient1Name.Text == "" && this.lblClient2Name.Text == "")
                {
                    this.lblClient1Name.Text = server.client1Name;
                    this.lblClient2Name.Text = server.client2Name;
                }
                if (this.AcceptClient1Data == null)  //如果线程没有初始化则先初始化
                {
                    this.AcceptClient1Data = new Thread(new ThreadStart(server.AccpetClient1Data));
                    this.AcceptClient1Data.IsBackground = true;
                    this.AcceptClient1Data.Name = "服务器检测客户端1是否发送准备消息";
                }
                if (this.AcceptClient1Data.ThreadState == (ThreadState.Background | ThreadState.Unstarted))  //如果线程没有启动则先启动,由于之前把线程的IsBackGround设置为true,所以这里要这样写
                {
                    this.AcceptClient1Data.Start();
                }
                if (this.AcceptClient2Data == null)  //如果线程没有初始化则先初始化
                {
                    this.AcceptClient2Data = new Thread(new ThreadStart(server.AccpetClient2Data));
                    this.AcceptClient2Data.IsBackground = true;
                    this.AcceptClient2Data.Name = "服务器检测客户端2是否发送准备消息";
                }
                if (this.AcceptClient2Data.ThreadState == (ThreadState.Background | ThreadState.Unstarted))  //如果线程没有启动则先启动,由于之前把线程的IsBackGround设置为true,所以这里要这样写
                {
                    this.AcceptClient2Data.Start();
                }
                if (this.server.client1IsOk && this.server.client2IsOk)
                {
                    this.server.client1IsOk = false;
                    this.server.client2IsOk = false;
                    this.server.SendDataForClient("EveryOneIsOk", 1);
                    this.server.SendDataForClient("EveryOneIsOk", 2);
                    this.server.everyOneIsOk = true;
                }
                if (this.server.everyOneIsOk) //启动线程后,服务器循环获取客户端的NetworkStream,然后判断客户端是否发送"OK"信息,如果发送,则把everyOneIsOk设置为True.
                {
                    this.server.everyOneIsOk = false; //为下一局做准备
                    DConsole.Write("[系统消息]:所有人已准备,可以开始游戏");
                    this.btnStart.Enabled = true;
                    this.btnStart.Visible = true;
                }
                if (DConsole.player1.haveOrder)
                {
                    this.btnLead.Enabled = true;
                    this.btnLead.Visible = true;
                    if (!DConsole.player1.isBiggest)
                    {
                        this.btnPass.Visible = true;
                    }
                }
                else
                {
                    this.btnLead.Visible = false;
                    this.btnPass.Visible = false;
                }
                if (DConsole.player1.isBiggest)
                {
                    this.btnPass.Visible = false;
                }
                if (DConsole.player1.areYouLandLord)
                {
                    btnNeedLandLord.Visible = true;
                    btnNotLandLord.Visible = true;
                }
                lblScore1.Text = "分数:" + DConsole.serverScore.ToString();
                lblScore2.Text = "分数:" + DConsole.client1Score.ToString();
                lblScore3.Text = "分数:" + DConsole.client2Score.ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.client.SendOk())
            {
                btnOK.Enabled = false;
                btnOK.Visible = false;
                this.timerClient.Enabled = true; 
                if (this.AcceptServerData == null)
                {
                    this.AcceptServerData = new Thread(new ThreadStart(client.AcceptServerData));
                    this.AcceptServerData.IsBackground = true;
                    this.AcceptServerData.Name = "接收服务器数据";
                }
                if (this.AcceptServerData.ThreadState == (ThreadState.Background | ThreadState.Unstarted))
                {
                    this.AcceptServerData.Start();
                }
                DConsole.Write("[系统消息]:已向服务器发送准备消息,正在等待响应...");
            }
            else
            {
                MessageBox.Show("准备失败,请检查网络连接", "火拼斗地主");
            }
        }

        private void timerClient_Tick(object sender, EventArgs e)
        {
            if (this.client.everyIsOk)
            {
                if (!this.SendedName)
                {
                    client.SendDataForServer("Name" + client.Name);
                    this.SendedName = true;
                }
                //if (this.player1.pokers.Count == 0)
                //{
                //    if (this.client.Pokers != null)
                //    {
                //        DConsole.Write("[系统消息]:接收到服务器分配的牌组.");
                //        this.player1.pokers = this.client.Pokers;
                //        this.player1.sort(); //把牌从大到小排序
                //        this.player1.g = this.panelPlayer1.CreateGraphics(); //把panelPlayer1的Graphics传递给player1
                //        this.player1.Paint(); //在panelPlayer1中画出player1的牌
                //        this.panelPlayer1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelPlayer1_MouseClick); //给panelPlayer1添加一个点击事件
                //    }
                //}
            }
            if (DConsole.player1.haveOrder)
            {
                this.btnLead.Enabled = true;
                this.btnLead.Visible = true;
                if (!DConsole.player1.isBiggest)
                {
                    this.btnPass.Visible = true;
                }
            }
            else
            {
                btnLead.Visible = false;
                btnPass.Visible = false;
            }
            if (DConsole.player1.isBiggest)
            {
                this.btnPass.Visible = false;
            }
            if (player1.areYouLandLord)
            {
                this.btnNeedLandLord.Visible = true;
                this.btnNotLandLord.Visible = true;
            }
            if (DConsole.IsRestart)
            {
                DConsole.IsRestart = false;
                btnOK.Enabled = true;
                btnOK.Visible = true;
            }
            lblScore2.Text = "分数:" + DConsole.serverScore.ToString();
            lblScore1.Text = "分数:" + DConsole.client1Score.ToString();
            lblScore3.Text = "分数:" + DConsole.client2Score.ToString();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 关于作者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void panelPlayer2_Paint(object sender, PaintEventArgs e)
        {
            if (this.server != null)
            {
                DConsole.PaintClient(true);
            }
            if (this.client != null)
            {
                DConsole.PaintServer();
            }
        }

        private void panelPlayer3_Paint(object sender, PaintEventArgs e)
        {
            if (this.server != null)
            {
                DConsole.PaintClient(true);
                DConsole.PaintClient(true);
            }
            if (this.client != null)
            {
                DConsole.PaintClient();
                DConsole.PaintServer();
            }
        }

        private void panelPlayer2LeadPoker_Paint(object sender, PaintEventArgs e)
        {
            DConsole.PaintPlayer2LeadPoker();
        }

        private void panelPlayer3LeadPoker_Paint(object sender, PaintEventArgs e)
        {
            DConsole.PaintPlayer3LeadPoker();
        }

        private void panelPlayer1LeadPoker_Paint(object sender, PaintEventArgs e)
        {
            DConsole.PaintPlayer1LeadPoker();
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            this.btnLead.Visible = false;
            this.btnPass.Visible = false;
            DConsole.player1.haveOrder = false;
            if (player1.pokers.Count != 0) //当牌出完后,出牌权限消失,不允许再次传递
            {
                if (this.server != null)
                {
                    this.server.SendDataForClient("ServerPass", 1);
                    this.server.SendDataForClient("ServerPass", 2);
                    Thread.Sleep(500);
                    this.server.SendDataForClient("Order", 2);
                }
                if (this.client != null)
                {
                    this.client.SendDataForServer("Pass");
                }
            }
        }

        private void btnNeedLandLord_Click(object sender, EventArgs e)
        {
            this.player1.isLandLord = true;
            this.player1.haveOrder = true;
            this.player1.isBiggest = true;
            this.player1.areYouLandLord = false;
            this.btnNeedLandLord.Visible = false;
            this.btnNotLandLord.Visible = false;
            DConsole.player1.Paint();
            if (this.server != null)
            {
                this.player1.SelectLandLordEnd();
                this.server.SendDataForClient("LandLordPokers", DConsole.LandLordPokers, 1);
                Thread.Sleep(100);
                this.server.SendDataForClient("LandLordPokers", DConsole.LandLordPokers, 2);
                Thread.Sleep(100);
                this.server.SendDataForClient("ServerIsLandLord", 1);
                Thread.Sleep(100);
                this.server.SendDataForClient("ServerIsLandLord", 2);
                Thread.Sleep(100);
            }
            if (this.client != null)
            {
                this.client.SendDataForServer("IamLandLord");
                Thread.Sleep(300);
            }
        }

        private void btnNotLandLord_Click(object sender, EventArgs e)
        {
            this.player1.areYouLandLord = false;
            this.player1.isLandLord = false;
            this.btnNeedLandLord.Visible = false;
            this.btnNotLandLord.Visible = false;
            if (this.server != null)
            {
                if (DConsole.LandLordNum == 3)
                {
                    DConsole.Restart();
                    return;
                }
                this.server.SendDataForClient("AreYouLandLord", 2);
            }
            if (this.client != null)
            {
                this.client.SendDataForServer("AreYouLandLord");
            }
        }

        private void panelLandLordPokers_Paint(object sender, PaintEventArgs e)
        {
            DConsole.PaintLandLord();
        }

        private void 自定义分数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomScore fromCustomScore = new CustomScore();
            fromCustomScore.ShowDialog();

        }
    }
}
