using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FightTheLandLord
{
    public class PokerGroup:List<Poker>
    {
        /// <summary>
        /// 牌组的类型
        /// </summary>
        public PokerGroupType type;

        /// <summary>
        /// 序列化一个PokerGroup对象,返回一个byte数组
        /// </summary>
        /// <returns></returns>
        public byte[] GetBuffer()
        {
            byte[] bytePoker = new byte[this.Count * 2];
            int i = 0;
            foreach (Poker onepoker in this)
            {
                switch (onepoker.pokerColor)
                {
                    case PokerColor.黑桃:
                        switch(onepoker.pokerNum)
                        {
                            case PokerNum.P3:
                                bytePoker[i] = Convert.ToByte('3');
                                break;
                            case PokerNum.P4:
                                bytePoker[i] = Convert.ToByte('4');
                                break;
                            case PokerNum.P5:
                                bytePoker[i] = Convert.ToByte('5');
                                break;
                            case PokerNum.P6:
                                bytePoker[i] = Convert.ToByte('6');
                                break;
                            case PokerNum.P7:
                                bytePoker[i] = Convert.ToByte('7');
                                break;
                            case PokerNum.P8:
                                bytePoker[i] = Convert.ToByte('8');
                                break;
                            case PokerNum.P9:
                                bytePoker[i] = Convert.ToByte('9');
                                break;
                            case PokerNum.P10:
                                bytePoker[i] = Convert.ToByte('0');
                                break;
                            case PokerNum.J:
                                bytePoker[i] = Convert.ToByte('J');
                                break;
                            case PokerNum.Q:
                                bytePoker[i] = Convert.ToByte('Q');
                                break;
                            case PokerNum.K:
                                bytePoker[i] = Convert.ToByte('K');
                                break;
                            case PokerNum.A:
                                bytePoker[i] = Convert.ToByte('A');
                                break;
                            case PokerNum.P2:
                                bytePoker[i] = Convert.ToByte('2');
                                break;
                            case PokerNum.小王:
                                bytePoker[i] = Convert.ToByte('X');
                                break;
                            case PokerNum.大王:
                                bytePoker[i] = Convert.ToByte('D');
                                break;
                        }
                        bytePoker[i + 1] = Convert.ToByte('a');
                        break;
                    case PokerColor.红心:
                        switch (onepoker.pokerNum)
                        {
                            case PokerNum.P3:
                                bytePoker[i] = Convert.ToByte('3');
                                break;
                            case PokerNum.P4:
                                bytePoker[i] = Convert.ToByte('4');
                                break;
                            case PokerNum.P5:
                                bytePoker[i] = Convert.ToByte('5');
                                break;
                            case PokerNum.P6:
                                bytePoker[i] = Convert.ToByte('6');
                                break;
                            case PokerNum.P7:
                                bytePoker[i] = Convert.ToByte('7');
                                break;
                            case PokerNum.P8:
                                bytePoker[i] = Convert.ToByte('8');
                                break;
                            case PokerNum.P9:
                                bytePoker[i] = Convert.ToByte('9');
                                break;
                            case PokerNum.P10:
                                bytePoker[i] = Convert.ToByte('0');
                                break;
                            case PokerNum.J:
                                bytePoker[i] = Convert.ToByte('J');
                                break;
                            case PokerNum.Q:
                                bytePoker[i] = Convert.ToByte('Q');
                                break;
                            case PokerNum.K:
                                bytePoker[i] = Convert.ToByte('K');
                                break;
                            case PokerNum.A:
                                bytePoker[i] = Convert.ToByte('A');
                                break;
                            case PokerNum.P2:
                                bytePoker[i] = Convert.ToByte('2');
                                break;
                            case PokerNum.小王:
                                bytePoker[i] = Convert.ToByte('X');
                                break;
                            case PokerNum.大王:
                                bytePoker[i] = Convert.ToByte('D');
                                break;
                        }
                        bytePoker[i + 1] = Convert.ToByte('b');
                        break;
                    case PokerColor.梅花:
                        switch (onepoker.pokerNum)
                        {
                            case PokerNum.P3:
                                bytePoker[i] = Convert.ToByte('3');
                                break;
                            case PokerNum.P4:
                                bytePoker[i] = Convert.ToByte('4');
                                break;
                            case PokerNum.P5:
                                bytePoker[i] = Convert.ToByte('5');
                                break;
                            case PokerNum.P6:
                                bytePoker[i] = Convert.ToByte('6');
                                break;
                            case PokerNum.P7:
                                bytePoker[i] = Convert.ToByte('7');
                                break;
                            case PokerNum.P8:
                                bytePoker[i] = Convert.ToByte('8');
                                break;
                            case PokerNum.P9:
                                bytePoker[i] = Convert.ToByte('9');
                                break;
                            case PokerNum.P10:
                                bytePoker[i] = Convert.ToByte('0');
                                break;
                            case PokerNum.J:
                                bytePoker[i] = Convert.ToByte('J');
                                break;
                            case PokerNum.Q:
                                bytePoker[i] = Convert.ToByte('Q');
                                break;
                            case PokerNum.K:
                                bytePoker[i] = Convert.ToByte('K');
                                break;
                            case PokerNum.A:
                                bytePoker[i] = Convert.ToByte('A');
                                break;
                            case PokerNum.P2:
                                bytePoker[i] = Convert.ToByte('2');
                                break;
                            case PokerNum.小王:
                                bytePoker[i] = Convert.ToByte('X');
                                break;
                            case PokerNum.大王:
                                bytePoker[i] = Convert.ToByte('D');
                                break;
                        }
                        bytePoker[i + 1] = Convert.ToByte('c');
                        break;
                    case PokerColor.方块:
                        switch (onepoker.pokerNum)
                        {
                            case PokerNum.P3:
                                bytePoker[i] = Convert.ToByte('3');
                                break;
                            case PokerNum.P4:
                                bytePoker[i] = Convert.ToByte('4');
                                break;
                            case PokerNum.P5:
                                bytePoker[i] = Convert.ToByte('5');
                                break;
                            case PokerNum.P6:
                                bytePoker[i] = Convert.ToByte('6');
                                break;
                            case PokerNum.P7:
                                bytePoker[i] = Convert.ToByte('7');
                                break;
                            case PokerNum.P8:
                                bytePoker[i] = Convert.ToByte('8');
                                break;
                            case PokerNum.P9:
                                bytePoker[i] = Convert.ToByte('9');
                                break;
                            case PokerNum.P10:
                                bytePoker[i] = Convert.ToByte('0');
                                break;
                            case PokerNum.J:
                                bytePoker[i] = Convert.ToByte('J');
                                break;
                            case PokerNum.Q:
                                bytePoker[i] = Convert.ToByte('Q');
                                break;
                            case PokerNum.K:
                                bytePoker[i] = Convert.ToByte('K');
                                break;
                            case PokerNum.A:
                                bytePoker[i] = Convert.ToByte('A');
                                break;
                            case PokerNum.P2:
                                bytePoker[i] = Convert.ToByte('2');
                                break;
                            case PokerNum.小王:
                                bytePoker[i] = Convert.ToByte('X');
                                break;
                            case PokerNum.大王:
                                bytePoker[i] = Convert.ToByte('D');
                                break;
                        }
                        bytePoker[i + 1] = Convert.ToByte('d');
                        break;
                }
                i += 2;
            }
            return bytePoker;
        }

        public PokerGroup(byte[] bytePokers)
        {
            this.GetPokerGroup(bytePokers);
        }
        public PokerGroup()
        {
        }
        /// <summary>
        /// 通过一个byte[]反序列化为PokerGroup对象
        /// </summary>
        /// <param name="bytePokers"></param>
        public void GetPokerGroup(byte[] bytePokers)
        {
            for (int i = 0; i < bytePokers.Length - 1; i += 2)
            {
                switch(Convert.ToChar((bytePokers[i + 1])))
                {
                    case 'a':
                        switch (Convert.ToChar((bytePokers[i])))
                        {
                            case '3':
                                this.Add(new Poker(PokerNum.P3, PokerColor.黑桃));
                                break;
                            case '4':
                                this.Add(new Poker(PokerNum.P4, PokerColor.黑桃));
                                break;
                            case '5':
                                this.Add(new Poker(PokerNum.P5, PokerColor.黑桃));
                                break;
                            case '6':
                                this.Add(new Poker(PokerNum.P6, PokerColor.黑桃));
                                break;
                            case '7':
                                this.Add(new Poker(PokerNum.P7, PokerColor.黑桃));
                                break;
                            case '8':
                                this.Add(new Poker(PokerNum.P8, PokerColor.黑桃));
                                break;
                            case '9':
                                this.Add(new Poker(PokerNum.P9, PokerColor.黑桃));
                                break;
                            case '0':
                                this.Add(new Poker(PokerNum.P10, PokerColor.黑桃));
                                break;
                            case 'J':
                                this.Add(new Poker(PokerNum.J, PokerColor.黑桃));
                                break;
                            case 'Q':
                                this.Add(new Poker(PokerNum.Q, PokerColor.黑桃));
                                break;
                            case 'K':
                                this.Add(new Poker(PokerNum.K, PokerColor.黑桃));
                                break;
                            case 'A':
                                this.Add(new Poker(PokerNum.A, PokerColor.黑桃));
                                break;
                            case '2':
                                this.Add(new Poker(PokerNum.P2, PokerColor.黑桃));
                                break;
                            case 'X':
                                this.Add(new Poker(PokerNum.小王, PokerColor.黑桃));
                                break;
                            case 'D':
                                this.Add(new Poker(PokerNum.大王, PokerColor.黑桃));
                                break;
                        }
                        break;
                    case 'b':
                        switch (Convert.ToChar((bytePokers[i])))
                        {
                            case '3':
                                this.Add(new Poker(PokerNum.P3, PokerColor.红心));
                                break;
                            case '4':
                                this.Add(new Poker(PokerNum.P4, PokerColor.红心));
                                break;
                            case '5':
                                this.Add(new Poker(PokerNum.P5, PokerColor.红心));
                                break;
                            case '6':
                                this.Add(new Poker(PokerNum.P6, PokerColor.红心));
                                break;
                            case '7':
                                this.Add(new Poker(PokerNum.P7, PokerColor.红心));
                                break;
                            case '8':
                                this.Add(new Poker(PokerNum.P8, PokerColor.红心));
                                break;
                            case '9':
                                this.Add(new Poker(PokerNum.P9, PokerColor.红心));
                                break;
                            case '0':
                                this.Add(new Poker(PokerNum.P10, PokerColor.红心));
                                break;
                            case 'J':
                                this.Add(new Poker(PokerNum.J, PokerColor.红心));
                                break;
                            case 'Q':
                                this.Add(new Poker(PokerNum.Q, PokerColor.红心));
                                break;
                            case 'K':
                                this.Add(new Poker(PokerNum.K, PokerColor.红心));
                                break;
                            case 'A':
                                this.Add(new Poker(PokerNum.A, PokerColor.红心));
                                break;
                            case '2':
                                this.Add(new Poker(PokerNum.P2, PokerColor.红心));
                                break;
                            case 'X':
                                this.Add(new Poker(PokerNum.小王, PokerColor.红心));
                                break;
                            case 'D':
                                this.Add(new Poker(PokerNum.大王, PokerColor.红心));
                                break;
                        }
                        break;
                    case 'c':
                        switch (Convert.ToChar((bytePokers[i])))
                        {
                            case '3':
                                this.Add(new Poker(PokerNum.P3, PokerColor.梅花));
                                break;
                            case '4':
                                this.Add(new Poker(PokerNum.P4, PokerColor.梅花));
                                break;
                            case '5':
                                this.Add(new Poker(PokerNum.P5, PokerColor.梅花));
                                break;
                            case '6':
                                this.Add(new Poker(PokerNum.P6, PokerColor.梅花));
                                break;
                            case '7':
                                this.Add(new Poker(PokerNum.P7, PokerColor.梅花));
                                break;
                            case '8':
                                this.Add(new Poker(PokerNum.P8, PokerColor.梅花));
                                break;
                            case '9':
                                this.Add(new Poker(PokerNum.P9, PokerColor.梅花));
                                break;
                            case '0':
                                this.Add(new Poker(PokerNum.P10, PokerColor.梅花));
                                break;
                            case 'J':
                                this.Add(new Poker(PokerNum.J, PokerColor.梅花));
                                break;
                            case 'Q':
                                this.Add(new Poker(PokerNum.Q, PokerColor.梅花));
                                break;
                            case 'K':
                                this.Add(new Poker(PokerNum.K, PokerColor.梅花));
                                break;
                            case 'A':
                                this.Add(new Poker(PokerNum.A, PokerColor.梅花));
                                break;
                            case '2':
                                this.Add(new Poker(PokerNum.P2, PokerColor.梅花));
                                break;
                            case 'X':
                                this.Add(new Poker(PokerNum.小王, PokerColor.梅花));
                                break;
                            case 'D':
                                this.Add(new Poker(PokerNum.大王, PokerColor.梅花));
                                break;
                        }
                        break;
                    case 'd':
                        switch (Convert.ToChar((bytePokers[i])))
                        {
                            case '3':
                                this.Add(new Poker(PokerNum.P3, PokerColor.方块));
                                break;
                            case '4':
                                this.Add(new Poker(PokerNum.P4, PokerColor.方块));
                                break;
                            case '5':
                                this.Add(new Poker(PokerNum.P5, PokerColor.方块));
                                break;
                            case '6':
                                this.Add(new Poker(PokerNum.P6, PokerColor.方块));
                                break;
                            case '7':
                                this.Add(new Poker(PokerNum.P7, PokerColor.方块));
                                break;
                            case '8':
                                this.Add(new Poker(PokerNum.P8, PokerColor.方块));
                                break;
                            case '9':
                                this.Add(new Poker(PokerNum.P9, PokerColor.方块));
                                break;
                            case '0':
                                this.Add(new Poker(PokerNum.P10, PokerColor.方块));
                                break;
                            case 'J':
                                this.Add(new Poker(PokerNum.J, PokerColor.方块));
                                break;
                            case 'Q':
                                this.Add(new Poker(PokerNum.Q, PokerColor.方块));
                                break;
                            case 'K':
                                this.Add(new Poker(PokerNum.K, PokerColor.方块));
                                break;
                            case 'A':
                                this.Add(new Poker(PokerNum.A, PokerColor.方块));
                                break;
                            case '2':
                                this.Add(new Poker(PokerNum.P2, PokerColor.方块));
                                break;
                            case 'X':
                                this.Add(new Poker(PokerNum.小王, PokerColor.方块));
                                break;
                            case 'D':
                                this.Add(new Poker(PokerNum.大王, PokerColor.方块));
                                break;
                        }
                        break;
                }
            }
        }
        /// <summary>
        /// 重写"大于"运算符
        /// </summary>
        /// <param name="LP">左边的PokerGroup对象</param>
        /// <param name="RP">右边的PokerGroup对象</param>
        /// <returns></returns>
        public static bool operator >(PokerGroup LP, PokerGroup RP)
        {
            bool IsGreater = false;
            if (LP.type != RP.type && LP.type != PokerGroupType.炸弹 && LP.type != PokerGroupType.双王)
            {
                IsGreater = false;
            }
            else
            {
                if (LP.type == PokerGroupType.炸弹 && RP.type == PokerGroupType.炸弹) //LPRP都为炸弹
                {
                    if (LP[0] > RP[0]) //比较大小
                    {
                        IsGreater = true;
                    }
                    else
                    {
                        IsGreater = false;
                    }
                }
                else
                {
                    if (LP.type == PokerGroupType.炸弹) //只有LP为炸弹
                    {
                        IsGreater = true;
                    }
                    else
                    {
                        if (LP.type == PokerGroupType.双王) //LP为双王
                        {
                            IsGreater = true;
                        }
                        else
                        {
                            if (LP[0] > RP[0]) //LP为普通牌组
                            {
                                IsGreater = true;
                            }
                            else
                            {
                                IsGreater = false;
                            }
                        }
                    }
                }
            }
            return IsGreater;
          
        }
        public static bool operator <(PokerGroup LP, PokerGroup RP)
        {
            return (RP > LP);
        }
    }

}