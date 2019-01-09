using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace FightTheLandLord
{
    public static class DConsole
    {
        /// <summary>
        /// 记录自己最后一次出的牌组(已从大到小排序)
        /// </summary>
        public static PokerGroup leadPokers = new PokerGroup();
        public static PokerGroup LeftTempLeadedPoker;
        public static PokerGroup RightTempLeadedPoker;
        public static PokerGroup LandLordPokers;
        public static PokerGroup allPoker = new PokerGroup();
        public static int LandLordNum;
        public static System.Windows.Forms.TextBox tb;
        public static System.Windows.Forms.Label lblClient1Name;
        public static System.Windows.Forms.Label lblClient2Name;
        public static System.Windows.Forms.Label lblScore1;
        public static System.Windows.Forms.Label lblScore2;
        public static System.Windows.Forms.Label lblScore3;
        public static Color backColor;
        public static Graphics g1, g2, gPlayer1LeadPoker, gPlayer2LeadPoker, gPlayer3LeadPoker, gLandLordPoker;
        public static int leftCount;
        public static int rightCount;
        public static Server server;
        public static Client client;
        public static Player player1;
        public static int serverScore = 2000;
        public static int client1Score = 2000;
        public static int client2Score = 2000;
        public static int roundScore = 50;
        public static int multiple = 1;
        public static int _Winer = 0;
        public static int Winer  //计算分数
        {
            get
            {
                return _Winer;
            }
            set
            {
                if (value == 1)
                {
                    switch (LandLordNum)
                    {
                        case 1:
                            serverScore += roundScore * multiple * 2;
                            client1Score -= roundScore * multiple;
                            client2Score -= roundScore * multiple;
                            break;
                        case 2:
                            serverScore += roundScore * multiple;
                            client1Score -= roundScore * multiple * 2;
                            client2Score += roundScore * multiple;
                            break;
                        case 3:
                            serverScore += roundScore * multiple;
                            client1Score += roundScore * multiple;
                            client2Score -= roundScore * multiple * 2;
                            break;
                    }
                    _Winer = value;
                }
                if (value == 2)
                {
                    switch (LandLordNum)
                    {
                        case 1:
                            serverScore -= roundScore * multiple * 2;
                            client1Score += roundScore * multiple;
                            client2Score += roundScore * multiple;
                            break;
                        case 2:
                            serverScore -= roundScore * multiple;
                            client1Score += roundScore * multiple * 2;
                            client2Score -= roundScore * multiple;
                            break;
                        case 3:
                            serverScore += roundScore * multiple;
                            client1Score += roundScore * multiple;
                            client2Score -= roundScore * multiple * 2;
                            break;

                    }
                    _Winer = value;
                }

                if (value == 3)
                {
                    switch (LandLordNum)
                    {
                        case 1:
                            serverScore -= roundScore * multiple * 2;
                            client1Score += roundScore * multiple;
                            client2Score += roundScore * multiple;
                            break;
                        case 2:
                            serverScore += roundScore * multiple;
                            client1Score -= roundScore * multiple * 2;
                            client2Score += roundScore * multiple;
                            break;
                        case 3:
                            serverScore -= roundScore * multiple;
                            client1Score -= roundScore * multiple;
                            client2Score += roundScore * multiple * 2;
                            break;
                    }
                    _Winer = value;
                }
                server.SendDataForClient("ClientScore" + client2Score.ToString(), 1);
                server.SendDataForClient("ClientScore" + client1Score.ToString(), 2);
                server.SendDataForClient("YouScore" + client1Score.ToString(), 1);
                server.SendDataForClient("YouScore" + client2Score.ToString(), 2);
                server.SendDataForClient("ServerScore" + serverScore.ToString(), 1);
                server.SendDataForClient("ServerScore" + serverScore.ToString(), 2);
            }
        }
        /// <summary>
        /// 自己是否有出牌权限
        /// </summary>
        public static bool haveOrder;
        /// <summary>
        /// 是否已开始
        /// </summary>
        public static bool IsStart;
        /// <summary>
        /// 是否已经重新开始,用户判断是否显示准备按钮
        /// </summary>
        public static bool IsRestart;
        public static string OtherClientName
        {
            get
            {
                return lblClient2Name.Text;
            }
            set
            {
                lblClient2Name.Text = value;
            }
        }
        public static string ServerName
        {
            get
            {
                return lblClient1Name.Text;
            }
            set
            {
                lblClient1Name.Text = value;
            }
        }

        /// <summary>
        /// 记录其他玩家出的牌组
        /// </summary>
        public static PokerGroups leadedPokerGroups = new PokerGroups();
        /// <summary>
        /// 是否已选完地主
        /// </summary>
        public static bool SelectedLandLord = false;
        /// <summary>
        /// 洗牌
        /// </summary>
        public static void shuffle()
        {
            Poker lastPoker;
            for (int i = 0; i < 5000; i++)  //洗牌,六个随机数向下替换.
            {
                int num1 = new Random().Next(0, 27);
                lastPoker = allPoker[num1];
                int num2 = new Random().Next(28, 54);
                allPoker[num1] = allPoker[num2];
                int num3 = new Random().Next(0, 54);
                allPoker[num2] = allPoker[num3];
                int num4 = new Random().Next(0, 10);
                allPoker[num3] = allPoker[num4];
                int num5 = new Random().Next(34, 54);
                allPoker[num4] = allPoker[num5];
                int num6 = new Random().Next(45, 54);
                allPoker[num5] = allPoker[num6];
                allPoker[num6] = lastPoker;
            }
#if DEBUG
            Console.WriteLine("以下是洗过的牌");
            foreach (Poker onePoker in allPoker)
            {
                Console.WriteLine(onePoker.pokerColor.ToString() + onePoker.ToString());
            }
#endif
        }


        /// <summary>
        /// 发牌
        /// </summary>
        public static void deal()
        {
            PokerGroup player2Pokers = new PokerGroup();
            PokerGroup player3Pokers = new PokerGroup();
            player1.pokers.Clear();
            for (int i = 0; i < 17; i++)
            {
                player1.pokers.Add(allPoker[i]);
            }
            for (int i = 17; i < 34; i++)
            {
                player2Pokers.Add(allPoker[i]);
            }
            for (int i = 34; i < 51; i++)
            {
                player3Pokers.Add(allPoker[i]);
            }
            LandLordNum = new Random().Next(1, 4);
            PokerGroup landLordPokers = new PokerGroup();
            for (int i = 51; i < 54; i++)
            {
                landLordPokers.Add(allPoker[i]);
            }
            LandLordPokers = landLordPokers;
            player1.sort();
            if (server.SendDataForClient("StartPokers", player2Pokers, 1) && server.SendDataForClient("StartPokers", player3Pokers, 2))
            {
                DConsole.Write("[系统消息]发牌成功!");
                server.SendOrder(LandLordNum);
            }
            //if (server.SendDataForClient(player2.pokers, 1) && server.SendDataForClient(player3.pokers, 2))
            //{
            //    DConsole.Write("[系统消息]发牌成功!");
            //    server.SendOrder(DConsole.LandLordNum);
            //}
            else
            {
                DConsole.Write("[系统消息]发牌失败!");
            }

#if DEBUG //调试时在Console上显示的信息
            Console.WriteLine("玩家一的牌");
            foreach (Poker onePoker in player1.pokers)
            {
                Console.WriteLine(onePoker.pokerColor.ToString() + onePoker.ToString());
            }
#endif
        }

        /// <summary>
        /// 验证所出牌组是否符合游戏规则
        /// </summary>
        public static bool IsRules(PokerGroup leadPokers) //判断所出牌组类型以及其是否符合规则
        {
            bool isRule = false;
            Player.sort(leadPokers);
            switch (leadPokers.Count)
            {
                case 0:
                    isRule = false;
                    break;
                case 1:
                    isRule = true;
                    leadPokers.type = PokerGroupType.单张;
                    break;
                case 2:
                    if (IsSame(leadPokers,2))
                    {
                        isRule = true;
                        leadPokers.type = PokerGroupType.对子;
                    }
                    else
                    {
                        if (leadPokers[0] == PokerNum.大王 && leadPokers[1] == PokerNum.小王)
                        {
                            leadPokers.type = PokerGroupType.双王;
                            isRule = true;
                        }
                        else
                        {
                            isRule = false;
                        }
                    }
                    break;
                case 3:
                    if (IsSame(leadPokers,3))
                    {
                        leadPokers.type = PokerGroupType.三张相同;
                        isRule = true;
                    }
                    else
                    {
                        isRule = false;
                    }
                    break;
                case 4:
                    if (IsSame(leadPokers, 4))
                    {
                        leadPokers.type = PokerGroupType.炸弹;
                        isRule = true;
                    }
                    else
                    {
                        if (IsThreeLinkPokers(leadPokers))
                        {
                            leadPokers.type = PokerGroupType.三带一;
                            isRule = true;
                        }
                        else
                        {
                            isRule = false;
                        }
                    }
                    break;
                case 5:
                    if (IsStraight(leadPokers))
                    {
                        leadPokers.type = PokerGroupType.五张顺子;
                        isRule = true;
                    }
                    else
                    {
                        isRule = false;
                    }
                    break;
                case 6:
                    if (IsStraight(leadPokers))
                    {
                        leadPokers.type = PokerGroupType.六张顺子;
                        isRule = true;
                    }
                    else
                    {
                        if (IsLinkPair(leadPokers))
                        {
                            leadPokers.type = PokerGroupType.三连对;
                            isRule = true;
                        }
                        else
                        {
                            if (IsSame(leadPokers, 4))
                            {
                                leadPokers.type = PokerGroupType.四带二;
                                isRule = true;
                            }
                            else
                            {
                                if (IsThreeLinkPokers(leadPokers))
                                {
                                    leadPokers.type = PokerGroupType.二连飞机;
                                    isRule = true;
                                }
                                else
                                {
                                    isRule = false;
                                }
                            }
                        }
                    }
                    break;
                case 7:
                    if (IsStraight(leadPokers))
                    {
                        leadPokers.type = PokerGroupType.七张顺子;
                        isRule = true;
                    }
                    else
                    {
                        isRule = false;
                    }
                    break;
                case 8:
                    if (IsStraight(leadPokers))
                    {
                        leadPokers.type = PokerGroupType.八张顺子;
                        isRule = true;
                    }
                    else
                    {
                        if (IsLinkPair(leadPokers))
                        {
                            leadPokers.type = PokerGroupType.四连对;
                            isRule = true;
                        }
                        else
                        {
                            if (IsThreeLinkPokers(leadPokers))
                            {
                                leadPokers.type = PokerGroupType.飞机带翅膀;
                                isRule = true;
                            }
                            else
                            {
                                isRule = false;
                            }
                        }
                    }
                    break;
                case 9:
                    if (IsStraight(leadPokers))
                    {
                        leadPokers.type = PokerGroupType.九张顺子;
                        isRule = true;
                    }
                    else
                    {
                        if (IsThreeLinkPokers(leadPokers))
                        {
                            leadPokers.type = PokerGroupType.三连飞机;
                        }
                        else
                        {
                            isRule = false;
                        }
                    }
                    break;
                case 10:
                    if (IsStraight(leadPokers))
                    {
                        leadPokers.type = PokerGroupType.十张顺子;
                        isRule = true;
                    }
                    else
                    {
                        if (IsLinkPair(leadPokers))
                        {
                            leadPokers.type = PokerGroupType.五连对;
                            isRule = true;
                        }
                        else
                        {
                            isRule = false;
                        }
                    }
                    break;
                case 11:
                    if (IsStraight(leadPokers))
                    {
                        leadPokers.type = PokerGroupType.十一张顺子;
                        isRule = true;
                    }
                    else
                    {
                        isRule = false;
                    }
                    break;
                case 12:
                    if (IsStraight(leadPokers))
                    {
                        leadPokers.type = PokerGroupType.十二张顺子;
                        isRule = true;
                    }
                    else
                    {
                        if (IsLinkPair(leadPokers))
                        {
                            leadPokers.type = PokerGroupType.六连对;
                            isRule = true;
                        }
                        else
                        {
                            if (IsThreeLinkPokers(leadPokers))
                            {
                                //12有三连飞机带翅膀和四连飞机两种情况,所以在IsThreeLinkPokers中做了特殊处理,此处不用给type赋值.
                                isRule = true;
                            }
                            else
                            {
                                isRule = false;
                            }
                        }
                    }
                    break;
                case 13:
                    isRule = false;
                    break;
                case 14:
                    if (IsLinkPair(leadPokers))
                    {
                        leadPokers.type = PokerGroupType.七连对;
                        isRule = true;
                    }
                    else
                    {
                        isRule = false;
                    }
                    break;
                case 15:
                    if (IsThreeLinkPokers(leadPokers))
                    {
                        leadPokers.type = PokerGroupType.五连飞机;
                        isRule = true;
                    }
                    else
                    {
                        isRule = false;
                    }
                    break;
                case 16:
                    if (IsLinkPair(leadPokers))
                    {
                        leadPokers.type = PokerGroupType.八连对;
                        isRule = true;
                    }
                    else
                    {
                        if (IsThreeLinkPokers(leadPokers))
                        {
                            leadPokers.type = PokerGroupType.四连飞机带翅膀;
                            isRule = true;
                        }
                        else
                        {
                            isRule = false;
                        }
                    }
                    break;
                case 17:
                    isRule = false;
                    break;
                case 18:
                    if (IsLinkPair(leadPokers))
                    {
                        leadPokers.type = PokerGroupType.六连对;
                        isRule = true;
                    }
                    else
                    {
                        if (IsThreeLinkPokers(leadPokers))
                        {
                            leadPokers.type = PokerGroupType.六连飞机;
                            isRule = true;
                        }
                        else
                        {
                            isRule = false;
                        }
                    }
                    break;
                case 19:
                    isRule = false;
                    break;
                case 20:
                    if (IsLinkPair(leadPokers))
                    {
                        leadPokers.type = PokerGroupType.十连对;
                        isRule = true;
                    }
                    else
                    {
                        if (IsThreeLinkPokers(leadPokers))
                        {
                            leadPokers.type = PokerGroupType.五连飞机带翅膀;
                            isRule = true;
                        }
                        else
                        {
                            isRule = false;
                        }
                    }
                    break;
            }
#if DEBUG
            Console.WriteLine("玩家出的牌:");
            foreach (Poker Poker in leadPokers)
            {
                Write(Poker.pokerColor.ToString() + Poker.ToString());
            }
#endif
            return isRule;
        }

        public static void Write(string str)
        {
            tb.Text += str + "\r\n";
            tb.SelectionStart = tb.Text.Length;
            tb.ScrollToCaret();
        }
        public static void PaintServer(int PokerCount)
        {
            g1.Clear(backColor);
            int x = 0;
            leftCount = PokerCount;
            for (int y = 0; y < PokerCount * 18; y += 18)
            {
                g1.FillRectangle(Brushes.Gray, x, y, 100, 18);
                g1.DrawRectangle(Pens.Black, x, y, 100, 18);
            }
        }
        /// <summary>
        /// 客户端显示服务器玩家剩余牌数
        /// </summary>
        public static void PaintServer()
        {
            PaintServer(leftCount);
        }
        /// <summary>
        /// 客户端用,显示其他客户端玩家剩余牌数
        /// </summary>
        public static void PaintClient()
        {
            PaintClient(rightCount);
        }
        /// <summary>
        /// 服务器玩家显示两个客户端的剩余牌数
        /// </summary>
        /// <param name="temp">该参数仅为与另外一个重载区别开来,无实际意义,请随便传送一个bool值</param>
        public static void PaintClient(bool temp)
        {
            PaintClient(leftCount, 1);
            PaintClient(rightCount, 2);
        }
        /// <summary>
        /// 客户端用,用于显示另外一个客户端的剩余牌数
        /// </summary>
        /// <param name="PokerCount">剩余牌数</param>
        public static void PaintClient(int PokerCount)
        {
            System.Threading.Thread.Sleep(100);
            g2.Clear(backColor);
            int x = 0;
            rightCount = PokerCount;
            for (int y = 0; y < PokerCount * 18; y += 18)
            {
                g2.FillRectangle(Brushes.Gray, x, y, 100, 18);
                g2.DrawRectangle(Pens.Black, x, y, 100, 18);
            }
        }
        /// <summary>
        /// 服务器玩家显示两个客户端剩余牌数
        /// </summary>
        /// <param name="PokerCount">剩余牌的张数</param>
        /// <param name="ClientNum">客户端的代号,只能填1和2</param>
        public static void PaintClient(int PokerCount,int ClientNum)
        {
            int x = 0;
                if (ClientNum == 1)
                {
                    g1.Clear(backColor);
                    leftCount = PokerCount;
                    for (int y = 0; y < leftCount * 18; y += 18)
                    {
                        g1.FillRectangle(Brushes.Gray, x, y, 100, 18);
                        g1.DrawRectangle(Pens.Black, x, y, 100, 18);
                    }
                }
                if (ClientNum == 2)
                {
                    g2.Clear(backColor);
                    rightCount = PokerCount;
                    for (int y = 0; y < rightCount * 18; y += 18)
                    {
                        g2.FillRectangle(Brushes.Gray, x, y, 100, 18);
                        g2.DrawRectangle(Pens.Black, x, y, 100, 18);
                    }
                }
        }

        public static void PaintPlayer1LeadPoker()
        {
            gPlayer1LeadPoker.Clear(backColor);
            for (int i = 0; i < leadPokers.Count; i++)
            {
                int x = i * 30;
                Rectangle rt = new Rectangle(x, 0, 50, 95);
                gPlayer1LeadPoker.FillRectangle(Brushes.White, rt);
                gPlayer1LeadPoker.DrawRectangle(Pens.Black, rt);
                gPlayer1LeadPoker.DrawString(leadPokers[i].ToString(), new Font("宋体", 12), Brushes.Black, x + 5, 5);
            }
        }
        public static void PaintPlayer2LeadPoker()
        {
            if (LeftTempLeadedPoker != null)
            {
                PaintPlayer2LeadPoker(LeftTempLeadedPoker);
            }
        }
        public static void PaintPlayer3LeadPoker()
        {
            if (RightTempLeadedPoker != null)
            {
                PaintPlayer3LeadPoker(RightTempLeadedPoker);
            }
        }

        public static void PaintPlayer2LeadPoker(PokerGroup pg)
        {
            LeftTempLeadedPoker = pg;
            gPlayer2LeadPoker.Clear(backColor);
            for (int i = 0; i < pg.Count; i++)
            {
                int y = i * 20;
                Rectangle rt = new Rectangle(0, y, 95, 50);
                gPlayer2LeadPoker.FillRectangle(Brushes.White, rt);
                gPlayer2LeadPoker.DrawRectangle(Pens.Black, rt);
                gPlayer2LeadPoker.DrawString(pg[i].ToString(), new Font("宋体", 12), Brushes.Black, 40, y + 5);
            }
        }
        public static void PaintPlayer3LeadPoker(PokerGroup pg)
        {
            RightTempLeadedPoker = pg;
            gPlayer3LeadPoker.Clear(backColor);
            for (int i = 0; i < pg.Count; i++)
            {
                int y = i * 20;
                Rectangle rt = new Rectangle(0, y, 95, 50);
                gPlayer3LeadPoker.FillRectangle(Brushes.White, rt);
                gPlayer3LeadPoker.DrawRectangle(Pens.Black, rt);
                gPlayer3LeadPoker.DrawString(pg[i].ToString(), new Font("宋体", 12), Brushes.Black, 40, y + 5);
            }
        }

        public static void WriteLeadedPokers()
        {
            foreach (Poker poker in leadedPokerGroups[leadedPokerGroups.Count - 1])
            {
                Write(poker.pokerColor.ToString() + poker.ToString());
            }
        }
        /// <summary>
        /// 判断一个牌组指定数量相邻的牌是否两两相同
        /// </summary>
        /// <param name="PG">牌组对象</param>
        /// <param name="amount">指定数量的相邻牌组</param>
        /// <returns>指定数量的相邻牌是否两两相同</returns>
        public static bool IsSame(PokerGroup PG, int amount)
        {
            bool IsSame1 = false;
            bool IsSame2 = false;
            for (int i = 0; i < amount - 1; i++) //从大到小比较相邻牌是否相同
            {
                if (PG[i] == PG[i+1])
                {
                    IsSame1 = true;
                }
                else
                {
                    IsSame1 = false;
                    break;
                }
            }
            for (int i = PG.Count - 1; i > PG.Count - amount; i--)  //从小到大比较相邻牌是否相同
            {
                if (PG[i] == PG[i - 1])
                {
                    IsSame2 = true;
                }
                else
                {
                    IsSame2 = false;
                    break;
                }
            }
            if (IsSame1 || IsSame2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 判断牌组是否为顺子
        /// </summary>
        /// <param name="PG">牌组</param>
        /// <returns>是否为顺子</returns>
        public static bool IsStraight(PokerGroup PG)
        {
            bool IsStraight = false;
            foreach (Poker poker in PG)//不能包含2、小王、大王
            {
                if (poker == PokerNum.P2 || poker == PokerNum.小王 || poker == PokerNum.大王)
                {
                    IsStraight = false;
                    return IsStraight;
                }
            }
            for (int i = 0; i < PG.Count - 1; i++)
            {
                if (PG[i].pokerNum - 1 == PG[i + 1].pokerNum)
                {
                    IsStraight = true;
                }
                else
                {
                    IsStraight = false;
                    break;
                }
            }
            return IsStraight;
        }
        /// <summary>
        /// 判断牌组是否为连对
        /// </summary>
        /// <param name="PG">牌组</param>
        /// <returns>是否为连对</returns>
        public static bool IsLinkPair(PokerGroup PG)
        {
            bool IsLinkPair = false;
            foreach (Poker poker in PG) //不能包含2、小王、大王
            {
                if (poker == PokerNum.P2 || poker == PokerNum.小王 || poker == PokerNum.大王)
                {
                    IsLinkPair = false;
                    return IsLinkPair;
                }
            }
            for (int i = 0; i < PG.Count - 2; i += 2)  //首先比较是否都为对子，再比较第一个对子的点数-1是否等于第二个对子，最后检察最小的两个是否为对子（这里的for循环无法检测到最小的两个，所以需要拿出来单独检查）
            {
                if (PG[i] == PG[i + 1] && PG[i].pokerNum - 1 == PG[i + 2].pokerNum && PG[i + 2] == PG[i + 3])
                {
                    IsLinkPair = true;
                }
                else
                {
                    IsLinkPair = false;
                    break;
                }
            }
            return IsLinkPair;
        }
        /// <summary>
        /// 判断牌组是否为连续三张牌,飞机,飞机带翅膀
        /// </summary>
        /// <param name="PG">牌组</param>
        /// <returns>是否为连续三张牌</returns>
        public static bool IsThreeLinkPokers(PokerGroup PG) //判断三张牌方法为判断两两相邻的牌,如果两两相邻的牌相同,则count自加1.最后根据count的值判断牌的类型为多少个连续三张
        {
            bool IsThreeLinkPokers = false;
            int HowMuchLinkThree = 0;  //飞机的数量
            PG = SameThreeSort(PG); //排序,把飞机放在前面
            for (int i = 2; i < PG.Count; i++)  //得到牌组中有几个飞机
            {
                if (PG[i] == PG[i - 1] && PG[i] == PG[i - 2])
                {
                    HowMuchLinkThree++;
                }
            }
            if (HowMuchLinkThree > 0)  //当牌组里面有三个时
            {
                if (HowMuchLinkThree > 1)  //当牌组为飞机时
                {
                    for (int i = 0; i < HowMuchLinkThree * 3 - 3; i += 3) //判断飞机之间的点数是否相差1
                    {
                        if (PG[i] != PokerNum.P2 && PG[i].pokerNum - 1 == PG[i + 3].pokerNum) //2点不能当飞机出
                        {
                            IsThreeLinkPokers = true;
                        }
                        else
                        {
                            IsThreeLinkPokers = false; 
                            break;
                        }
                    }
                }
                else
                {
                    IsThreeLinkPokers = true; //牌组为普通三个,直接返回true
                }
            }
            else
            {
                IsThreeLinkPokers = false;
            }
            if (HowMuchLinkThree == 4)
            {
                PG.type = PokerGroupType.四连飞机;
            }
            if (HowMuchLinkThree == 3 && PG.Count == 12)
            {
                PG.type = PokerGroupType.三连飞机带翅膀;
            }
            return IsThreeLinkPokers;

        }
        /// <summary>
        /// 对飞机和飞机带翅膀进行排序,把飞机放在前面,翅膀放在后面.
        /// </summary>
        /// <param name="PG">牌组</param>
        /// <returns>是否为连续三张牌</returns>
        public static PokerGroup SameThreeSort(PokerGroup PG)
        {
            Poker FourPoker = null;  //如果把4张当三张出并且带4张的另外一张,就需要特殊处理,这里记录出现这种情况的牌的点数.
            bool FindedThree = false;  //已找到三张相同的牌
            PokerGroup tempPokerGroup = new PokerGroup();  //记录三张相同的牌
            int count = 0; //记录在连续三张牌前面的翅膀的张数
            int Four = 0; // 记录是否连续出现三三相同,如果出现这种情况则表明出现把4张牌(炸弹)当中的三张和其他牌配成飞机带翅膀,并且翅膀中有炸弹牌的点数.
            // 比如有如下牌组: 998887777666 玩家要出的牌实际上应该为 888777666带997,但是经过从大到小的排序后变成了998887777666 一不美观,二不容易比较.
            for (int i = 2; i < PG.Count; i++)  //直接从2开始循环,因为PG[0],PG[1]的引用已经存储在其他变量中,直接比较即可
            {
                if (PG[i] == PG[i - 2] && PG[i] == PG[i - 1])// 比较PG[i]与PG[i-1],PG[i]与PG[i-2]是否同时相等,如果相等则说明这是三张相同牌
                {
                    if (Four >= 1) //默认的Four为0,所以第一次运行时这里为false,直接执行else
                                   //一旦连续出现两个三三相等,就会执行这里的if
                    {
                        FourPoker = PG[i]; //当找到四张牌时,记录下4张牌的点数
                        Poker changePoker; 
                        for (int k = i; k > 0; k--) //把四张牌中的一张移动到最前面.
                        {
                            changePoker = PG[k];
                            PG[k] = PG[k - 1];
                            PG[k - 1] = changePoker;
                        }
                        count++; //由于此时已经找到三张牌,下面为count赋值的程序不会执行,所以这里要手动+1
                    }
                    else
                    {
                        Four++; //记录本次循环,因为本次循环找到了三三相等的牌,如果连续两次找到三三相等的牌则说明找到四张牌(炸弹)
                        tempPokerGroup.Add(PG[i]); //把本次循环的PG[i]记录下来,即记录下三张牌的点数
                    }
                    FindedThree = true; //标记已找到三张牌
                }
                else
                {
                    Four = 0; //没有找到时,连续找到三张牌的标志Four归零
                    if (!FindedThree) //只有没有找到三张牌时才让count增加.如果已经找到三张牌,则不再为count赋值.
                    {
                        count = i - 1;
                    }
                }
            }
            foreach (Poker tempPoker in tempPokerGroup)  //迭代所有的三张牌点数
            {
                Poker changePoker;  //临时交换Poker
                for (int i = 0; i < PG.Count; i++)  //把所有的三张牌往前移动
                {
                    if (PG[i] == tempPoker)  //当PG[i]等于三张牌的点数时
                    {
                        if (PG[i] == FourPoker) //由于上面已经把4张牌中的一张放到的最前面,这张牌也会与tempPoker相匹配所以这里进行处理
                                                // 当第一次遇到四张牌的点数时,把记录四张牌的FourPoker赋值为null,并中断本次循环.由于FourPoker已经为Null,所以下次再次遇到四张牌的点数时会按照正常情况执行.
                        {
                            FourPoker = null;
                            continue;
                        }
                        changePoker = PG[i - count];
                        PG[i - count] = PG[i];
                        PG[i] = changePoker;
                    }
                }
            }
            return PG;
        }

        public static void PaintLandLord(bool IsTurnOn)
        {
            SelectedLandLord = IsTurnOn;
            gLandLordPoker.Clear(backColor);
            if (IsStart)
            {
                if (IsTurnOn)
                {
                    for (int i = 0; i < LandLordPokers.Count; i++)
                    {
                        int x = i * 70;
                        Rectangle rt = new Rectangle(x, 0, 70, 95);
                        gLandLordPoker.FillRectangle(Brushes.White, rt);
                        gLandLordPoker.DrawRectangle(Pens.Black, rt);
                        gLandLordPoker.DrawString(LandLordPokers[i].ToString(), new Font("宋体", 12), Brushes.Black, x + 5, 5);
                    }
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        int x = i * 70;
                        Rectangle rt = new Rectangle(x, 0, 70, 95);
                        gLandLordPoker.FillRectangle(Brushes.White, rt);
                        gLandLordPoker.DrawRectangle(Pens.Black, rt);
                        gLandLordPoker.DrawString("牌", new Font("宋体", 15), Brushes.Black, x + 20, 33);
                    }
                }
            }
        }
        public static void PaintLandLord()
        {
            gLandLordPoker.Clear(backColor);
            if (IsStart)
            {
                if (SelectedLandLord)
                {
                    for (int i = 0; i < LandLordPokers.Count; i++)
                    {
                        int x = i * 70;
                        Rectangle rt = new Rectangle(x, 0, 70, 95);
                        gLandLordPoker.FillRectangle(Brushes.White, rt);
                        gLandLordPoker.DrawRectangle(Pens.Black, rt);
                        gLandLordPoker.DrawString(LandLordPokers[i].ToString(), new Font("宋体", 12), Brushes.Black, x + 5, 5);
                    }
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        int x = i * 70;
                        Rectangle rt = new Rectangle(x, 0, 70, 95);
                        gLandLordPoker.FillRectangle(Brushes.White, rt);
                        gLandLordPoker.DrawRectangle(Pens.Black, rt);
                        gLandLordPoker.DrawString("牌", new Font("宋体", 15), Brushes.Black, x + 20, 33);
                    }
                }
            }
        }

        public static void Restart()
        {
            leadPokers.Clear();
            leadedPokerGroups.Clear();
            player1.pokers.Clear();
            LandLordPokers.Clear();
            DConsole.allPoker.Clear();
            player1.isLandLord = false;
            player1.isBiggest = false;
            player1.haveOrder = false;
            player1.areYouLandLord = false;
            DConsole.lblClient1Name.Text = DConsole.lblClient1Name.Text.Replace("(地主)", "");
            DConsole.lblClient2Name.Text = DConsole.lblClient2Name.Text.Replace("(地主)", "");
            DConsole.lblClient1Name.ForeColor = Color.Black;
            DConsole.lblClient2Name.ForeColor = Color.Black;
            IsRestart = true;
            server.SendDataForClient("ReStart", 1);
            System.Threading.Thread.Sleep(200);
            server.SendDataForClient("ReStart", 2);
            System.Threading.Thread.Sleep(200);
        }

        public static void ChangePlace()
        {
            Graphics tempG = g1;
            g1 = g2;
            g2 = tempG;
            tempG = gPlayer2LeadPoker;
            gPlayer2LeadPoker = gPlayer3LeadPoker;
            gPlayer3LeadPoker = tempG;
            //System.Windows.Forms.Label lblTemp = lblClient1Name;
            //lblClient1Name = lblClient2Name;
            //lblClient2Name = lblTemp;
        }
    }
}
