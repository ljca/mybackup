using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace FightTheLandLord
{
    public class Client
    {
        /// <summary>
        /// 客户端的名称
        /// </summary>
        public string Name;
        public TcpClient client;
        /// <summary>
        /// 所有用户是否已准备
        /// </summary>
        public bool everyIsOk = false;
        /// <summary>
        /// 每次发送数据延迟时间(毫秒)
        /// </summary>
        public int sleep = 100;

        /// <summary>
        /// 构造函数
        /// </summary>
        public Client()
        {
            client = new TcpClient();
        }

        /// <summary>
        /// 向服务器发送连接请求
        /// </summary>
        public bool Connection()
        {
            try
            {
                client.Connect(IPAddress.Parse(Properties.Settings.Default.Host), Properties.Settings.Default.Port);
            }
            catch
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 接收服务器发送的数据
        /// </summary>
        public void AcceptServerData() 
        {
            NetworkStream Ns = client.GetStream();
            string str = "";
            while (true)
            {
                byte[] bytes = new byte[108];
                Ns.Read(bytes, 0, 108);
                str = Encoding.Default.GetString(bytes);
                if (str.StartsWith("StartPokers"))
                {
                    DConsole.IsStart = true;
                    str = str.Replace("StartPokers", "");
                    str.Trim();
                    byte[] bytePokers = Encoding.Default.GetBytes(str);
                    PokerGroup pokers = new PokerGroup(bytePokers);
                    if (pokers.Count == 17)
                    {
                        DConsole.player1.pokers.Clear();
                        DConsole.player1.pokers = pokers;
                        DConsole.player1.sort();
                        DConsole.player1.Paint();
                    }
                    DConsole.PaintLandLord();
                    continue;
                }
                if (str.StartsWith("CName"))
                {
                    str = str.Replace("CName", "");
                    DConsole.OtherClientName = str;
                    continue;
                }
                if (str.StartsWith("SPokerCount"))
                {
                    str = str.Replace("SPokerCount","");
                    int pokerCount = Convert.ToInt32(str);
                    DConsole.PaintServer(pokerCount);
                    continue;
                }
                if (str.StartsWith("PokerCount"))
                {
                    str = str.Replace("PokerCount","");
                    int pokerCount = Convert.ToInt32(str);
                    DConsole.PaintClient(pokerCount);
                    continue;
                }
                if (str.StartsWith("YouAreClient1"))
                {
                    DConsole.ChangePlace();
                    continue;
                }
                if (str.StartsWith("EveryOneIsOk"))
                {
                    this.everyIsOk = true;
                    continue;
                }
                if (str.StartsWith("server"))
                {
                    PokerGroup pokers = new PokerGroup();
                    str = str.Replace("server", "");
                    byte[] bytePg = Encoding.Default.GetBytes(str);
                    pokers.GetPokerGroup(bytePg);
                    DConsole.leadedPokerGroups.Add(pokers);
                    DConsole.WriteLeadedPokers();
                    DConsole.PaintPlayer2LeadPoker(pokers);
                    continue;
                }
                if (str.StartsWith("client"))
                {
                    PokerGroup pokers = new PokerGroup();
                    str = str.Replace("client", "");
                    byte[] bytePg = Encoding.Default.GetBytes(str);
                    pokers.GetPokerGroup(bytePg);
                    DConsole.leadedPokerGroups.Add(pokers);
                    DConsole.WriteLeadedPokers();
                    DConsole.PaintPlayer3LeadPoker(pokers);
                    continue;
                }
                if (str.StartsWith("Order"))
                {
                    DConsole.player1.haveOrder = true;
                    continue;
                }
                if (str.StartsWith("ClientPass"))
                {
                    DConsole.gPlayer3LeadPoker.Clear(DConsole.backColor);
                    DConsole.gPlayer3LeadPoker.DrawString("不要", new System.Drawing.Font("宋体", 20), System.Drawing.Brushes.Red, 5, 5);
                    continue;
                }
                if (str.StartsWith("ServerPass"))
                {
                    DConsole.gPlayer2LeadPoker.Clear(DConsole.backColor);
                    DConsole.gPlayer2LeadPoker.DrawString("不要", new System.Drawing.Font("宋体", 20), System.Drawing.Brushes.Red, 5, 5);
                    continue;
                }
                if (str.StartsWith("IsBiggest"))
                {
                    DConsole.player1.isBiggest = true;
                    continue;
                }
                if (str.StartsWith("NoBiggest"))
                {
                    DConsole.player1.isBiggest = false;
                    continue;
                }
                if (str.StartsWith("AreYouLandLord"))
                {
                    DConsole.player1.areYouLandLord = true;
                    continue;
                }
                if (str.StartsWith("LandLordPokers"))
                {
                    PokerGroup pokers = new PokerGroup();
                    str = str.Replace("LandLordPokers", "");
                    byte[] bytePg = Encoding.Default.GetBytes(str);
                    pokers.GetPokerGroup(bytePg);
                    DConsole.LandLordPokers = pokers;
                    DConsole.player1.SelectLandLordEnd();
                    continue;
                }
                if (str.StartsWith("ClientIsLandLord"))
                {
                    DConsole.lblClient2Name.Text += "(地主)";
                    DConsole.lblClient2Name.ForeColor = System.Drawing.Color.Red;
                    DConsole.PaintClient(20);
                    continue;
                }
                if (str.StartsWith("ServerIsLandLord"))
                {
                    DConsole.lblClient1Name.Text += "(地主)";
                    DConsole.lblClient1Name.ForeColor = System.Drawing.Color.Red;
                    DConsole.PaintServer(20);
                    continue;
                }
                if (str.StartsWith("ReStart"))
                {
                    DConsole.leadedPokerGroups.Clear();
                    DConsole.leadPokers.Clear();
                    DConsole.player1.pokers.Clear();
                    DConsole.player1.areYouLandLord = false;
                    DConsole.player1.isBiggest = false;
                    DConsole.player1.isLandLord = false;
                    DConsole.player1.haveOrder = false;
                    DConsole.lblClient1Name.Text = DConsole.lblClient1Name.Text.Replace("(地主)", "");
                    DConsole.lblClient2Name.Text = DConsole.lblClient2Name.Text.Replace("(地主)", "");
                    DConsole.lblClient1Name.ForeColor = System.Drawing.Color.Black;
                    DConsole.lblClient2Name.ForeColor = System.Drawing.Color.Black;
                    DConsole.PaintLandLord(false);
                    DConsole.IsRestart = true;
                    continue;
                }
                if (str.StartsWith("YouScore"))
                {
                    str = str.Replace("YouScore","");
                    DConsole.serverScore = Convert.ToInt32(str);
                    continue;
                }
                if (str.StartsWith("ClientScore"))
                {
                    str = str.Replace("ClientScore", "");
                    DConsole.client2Score = Convert.ToInt32(str);
                    continue;
                }
                if (str.StartsWith("ServerScore"))
                {
                    str = str.Replace("ServerScore", "");
                    DConsole.client1Score = Convert.ToInt32(str);
                    continue;
                }
            }
        }

        /// <summary>
        /// 向服务器发送准备请求
        /// </summary>
        public bool SendOk() //给服务器发送准备指令
        {
            this.SendDataForServer("OK");
            return true;
        }

        /// <summary>
        /// 向服务器发送出牌请求
        /// </summary>
        public bool SendDataForServer(string str)
        {
            NetworkStream Ns = this.client.GetStream();
            byte[] bytes = Encoding.Default.GetBytes(str);
            Ns.Write(bytes, 0, bytes.Length);
            Thread.Sleep(sleep);
            return true;
        }
        public bool SendDataForServer(PokerGroup pg)
        {
            NetworkStream Ns = this.client.GetStream();
            byte[] bytes = pg.GetBuffer();
            Ns.Write(bytes, 0, bytes.Length);
            Thread.Sleep(sleep);
            return true;
        }
        public bool SendDataForServer(string head,PokerGroup pg)
        {
            NetworkStream Ns = client.GetStream();
            byte[] bytePg = pg.GetBuffer();  //通过2个 MemoryStream对象获取代表2组牌的 比特流对象
            string strPg = Encoding.Default.GetString(bytePg);
            string strSender = head + strPg;  //组合两个字符串
            byte[] byteSender = Encoding.Default.GetBytes(strSender);  //把要发送的数据转换为byte[]
            Ns.Write(byteSender, 0, byteSender.Length);  //把2个比特流对象写入server与client的连接管道中
            Thread.Sleep(sleep);
            return true;
        }
    }
}
