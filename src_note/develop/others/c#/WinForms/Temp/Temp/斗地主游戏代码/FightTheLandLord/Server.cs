using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace FightTheLandLord
{
    public class Server
    {
        /// <summary>
        /// 监听对象
        /// </summary>
        public TcpListener listener = new TcpListener(IPAddress.Any ,Properties.Settings.Default.Port);
        /// <summary>
        /// 客户端1
        /// </summary>
        public TcpClient client1;
        /// <summary>
        /// 客户端2
        /// </summary>
        public TcpClient client2;
        /// <summary>
        /// 客户端1的名字
        /// </summary>
        public string client1Name;
        /// <summary>
        /// 客户端2的名字
        /// </summary>
        public string client2Name;
        /// <summary>
        /// 所有用户是否已准备
        /// </summary>
        public bool everyOneIsOk = false;
        public bool client1IsOk = false;
        public bool client2IsOk = false;

        public int sleep = 100;

        /// <summary>
        /// 寻远接收客户端的连接请求，当连接2个客户端后关闭端口监听。
        /// </summary>
        public void Connection() //循环检测是否有连接请求,接受最先请求的两个连接,得到两个TcpClient,然后拒绝其他的所有连接
        {
            while (true)
            {
                if (client1 == null)
                {
                    client1 = listener.AcceptTcpClient();   //得到一个客户端
                }
                if (client2 == null)
                {
                    client2 = listener.AcceptTcpClient();  //得到另一个客户端
                }
                if (client1 != null && client2 != null)   //如果已有两个客户端,关闭监听,终端循环.
                {
                    listener.Stop();
                    break;
                }
            }
        }

        /// <summary>
        /// 循环接收客户端1的请求数据
        /// </summary>
        public void AccpetClient1Data()
        {
            NetworkStream Ns1 = client1.GetStream();
            string str1 = "";
            while (true)
            {
                PokerGroup pg = new PokerGroup();
                byte[] bytes1 = new byte[108];
                Ns1.Read(bytes1, 0, 108);
                str1 = Encoding.Default.GetString(bytes1);
                if (str1.StartsWith("Name"))
                {
                    str1 = str1.Replace("Name", "");
                    this.client1Name = str1;
                    this.SendDataForClient("CName" + str1, 2);
                    continue;
                }
                if (str1.StartsWith("OK"))
                {
                    this.client1IsOk = true;
                    continue;
                }
                if (str1.StartsWith("PokerCount"))
                {
                    Thread.Sleep(sleep);
                    SendDataForClient(str1, 2);
                    str1 = str1.Replace("PokerCount", "");
                    int PokerCount = Convert.ToInt32(str1);
                    if (PokerCount == 0 && DConsole.IsStart)
                    {
                        DConsole.Winer = 2;
                        DConsole.Restart();
                    }
                    DConsole.PaintClient(PokerCount, 1);
                    continue;
                }
                if (str1.StartsWith("client"))
                {
                    SendDataForClient(str1, 2);
                    Thread.Sleep(sleep);
                    str1 = str1.Replace("client", "");
                    pg.GetPokerGroup(Encoding.Default.GetBytes(str1));
                    DConsole.leadedPokerGroups.Add(pg);
                    DConsole.PaintPlayer2LeadPoker(pg);
                    DConsole.WriteLeadedPokers();
                    if (!DConsole.IsRestart)
                    {
                        DConsole.player1.haveOrder = true;  //client1出牌后归server出牌,前提是没有Restart,Restart后出牌权限消失
                    }
                    else
                    {
                        DConsole.IsRestart = false;
                    }
                    continue;
                }
                //Client放弃出牌,权限交给服务器
                if (str1.StartsWith("Pass"))
                {
                    DConsole.gPlayer2LeadPoker.Clear(DConsole.backColor);
                    DConsole.gPlayer2LeadPoker.DrawString("不要", new System.Drawing.Font("宋体", 20), System.Drawing.Brushes.Red,5,5);
                    DConsole.player1.haveOrder = true;
                    SendDataForClient("ClientPass", 2);
                    continue;
                }
                if (str1.StartsWith("IamIsBiggest"))
                {
                    DConsole.player1.isBiggest = false;
                    this.SendDataForClient("NoBiggest", 2);
                    continue;
                }
                if (str1.StartsWith("AreYouLandLord"))
                {
                    if (DConsole.LandLordNum == 1)
                    {
                        DConsole.Restart();
                        continue;
                    }
                    DConsole.player1.areYouLandLord = true;
                    continue;
                }
                if (str1.StartsWith("IamLandLord"))
                {
                    DConsole.lblClient1Name.Text += "(地主)";
                    DConsole.lblClient1Name.ForeColor = System.Drawing.Color.Red;
                    SendDataForClient("ClientIsLandLord", 2);
                    Thread.Sleep(sleep);
                    DConsole.PaintClient(20, 1);
                    SendDataForClient("LandLordPokers", DConsole.LandLordPokers, 1);
                    Thread.Sleep(sleep);
                    SendDataForClient("LandLordPokers", DConsole.LandLordPokers, 2);
                    DConsole.player1.SelectLandLordEnd();
                    continue;
                }
            }
        }
        /// <summary>
        /// 循环接收客户端2的请求数据
        /// </summary>
        public void AccpetClient2Data()
        {
            NetworkStream Ns2 = client2.GetStream();
            string str1 = "";
            while (true)
            {
                PokerGroup pg = new PokerGroup();
                byte[] bytes2 = new byte[108];
                Ns2.Read(bytes2, 0, 108);
                str1 = Encoding.Default.GetString(bytes2);
                if (str1.StartsWith("Name"))
                {
                    str1 = str1.Replace("Name", "");
                    this.client2Name = str1;
                    this.SendDataForClient("CName" + str1, 1);
                    continue;
                }
                if (str1.StartsWith("OK"))
                {
                    this.client2IsOk = true;
                    continue;
                }
                if (str1.StartsWith("PokerCount"))
                {
                    Thread.Sleep(sleep);
                    SendDataForClient(str1, 1);
                    str1 = str1.Replace("PokerCount", "");
                    int PokerCount = Convert.ToInt32(str1);
                    if (PokerCount == 0 && DConsole.IsStart)
                    {
                        DConsole.Winer = 3;
                        DConsole.Restart();
                    }
                    DConsole.PaintClient(PokerCount, 2);
                    continue;
                }
                if (str1.StartsWith("client"))
                {
                    SendDataForClient(str1, 1);
                    Thread.Sleep(sleep);
                    str1 = str1.Replace("client", "");
                    pg.GetPokerGroup(Encoding.Default.GetBytes(str1));
                    DConsole.leadedPokerGroups.Add(pg);
                    DConsole.PaintPlayer3LeadPoker(pg);
                    DConsole.WriteLeadedPokers();
                    if (!DConsole.IsRestart)
                    {
                        SendDataForClient("Order", 1);  //权限交给client1 前提是没有Restart
                    }
                    else
                    {
                        DConsole.IsRestart = false; //当检测到已经Restart时,复位Restart使它还原为false供下次使用
                    }
                    System.Threading.Thread.Sleep(sleep);
                    continue;
                }
                //Client2放弃出牌,权限交给Client1
                if (str1.StartsWith("Pass"))
                {
                    DConsole.gPlayer3LeadPoker.Clear(DConsole.backColor);
                    DConsole.gPlayer3LeadPoker.DrawString("不要", new System.Drawing.Font("宋体", 20), System.Drawing.Brushes.Red, 5, 5);
                    SendDataForClient("ClientPass", 1);
                    Thread.Sleep(500);
                    SendDataForClient("Order", 1);
                    continue;
                }
                if (str1.StartsWith("IamIsBiggest"))
                {
                    DConsole.player1.isBiggest = false;
                    this.SendDataForClient("NoBiggest", 1);
                    continue;
                }
                if (str1.StartsWith("AreYouLandLord"))
                {
                    if (DConsole.LandLordNum == 2)
                    {
                        DConsole.Restart();
                        continue;
                    }
                    SendDataForClient("AreYouLandLord", 1);
                    continue;
                }
                if (str1.StartsWith("IamLandLord"))
                {
                    DConsole.lblClient2Name.Text += "(地主)";
                    DConsole.lblClient2Name.ForeColor = System.Drawing.Color.Red;
                    SendDataForClient("LandLordPokers", DConsole.LandLordPokers, 1);
                    SendDataForClient("LandLordPokers", DConsole.LandLordPokers, 2);
                    SendDataForClient("ClientIsLandLord", 1);
                    DConsole.PaintClient(20, 2);
                    DConsole.player1.SelectLandLordEnd();
                    continue;
                }
            }
        }
        /// <summary>
        /// 发送牌组给客户端
        /// </summary>
        /// <param name="pg">牌组</param>
        /// <param name="client">客户端的编号,只能是1,2</param>
        /// <returns>是否发送成功</returns>
        public bool SendDataForClient(PokerGroup pg, int client)
        {

            NetworkStream Ns = null;
            if (client == 1)
            {
                Ns = this.client1.GetStream();
            }
            if (client == 2)
            {
                Ns = this.client2.GetStream();//得到客户端的网络流对象
            }
            if (client != 1 && client != 2)
            {
                return false;
            }
            byte[] bytePg = pg.GetBuffer();  //通过2个 MemoryStream对象获取代表2组牌的 比特流对象
            Ns.Write(bytePg, 0, bytePg.Length);  //把2个比特流对象写入server与client的连接管道中
            Thread.Sleep(sleep);
            return true;
        }
        /// <summary>
        /// 发送指定牌组和头信息给客户端
        /// </summary>
        /// <param name="head">头信息</param>
        /// <param name="pg">牌组</param>
        /// <param name="client">客户端编号,只能是1,2</param>
        /// <returns>是否发送成功</returns>
        public bool SendDataForClient(string head, PokerGroup pg, int client)
        {

            NetworkStream Ns = null;
            if (client == 1)
            {
                Ns = this.client1.GetStream();
            }
            if (client == 2)
            {
                Ns = this.client2.GetStream();//得到客户端的网络流对象
            }
            if (client != 1 && client != 2)
            {
                return false;
            }
            byte[] bytePg = pg.GetBuffer();  //通过2个 MemoryStream对象获取代表2组牌的 比特流对象
            string strPg = Encoding.Default.GetString(bytePg);
            string strSender = head + strPg;  //组合两个字符串
            byte[] byteSender = Encoding.Default.GetBytes(strSender);  //把要发送的数据转换为byte[]
            Ns.Write(byteSender, 0, byteSender.Length);  //把2个比特流对象写入server与client的连接管道中
            Thread.Sleep(sleep);
            return true;
        }
        /// <summary>
        /// 发送字符串给客户端
        /// </summary>
        /// <param name="str">要发送的字符串</param>
        /// <param name="client">客户端编号,只能是1,2</param>
        /// <returns>是否发送成功</returns>
        public bool SendDataForClient(string str, int client)
        {

            NetworkStream Ns = null;
            if (client == 1)
            {
                Ns = this.client1.GetStream();
            }
            if (client == 2)
            {
                Ns = this.client2.GetStream();//得到客户端的网络流对象
            }
            if (client != 1 && client != 2)
            {
                return false;
            }
            byte[] byteStr = Encoding.Default.GetBytes(str); 
            Ns.Write(byteStr, 0, byteStr.Length);  //把2个比特流对象写入server与client的连接管道中
            Thread.Sleep(sleep);
            return true;
        }
        /// <summary>
        /// 通知客户端选出的地主
        /// </summary>
        public void SendOrder(int Num)
        {
            switch (Num)
            {
                case 1:
                    DConsole.player1.areYouLandLord = true;
                    break;
                case 2:
                    this.SendDataForClient("AreYouLandLord", 1);
                    break;
                case 3:
                    this.SendDataForClient("AreYouLandLord", 2);
                    break;
            }
        }
    }
}
