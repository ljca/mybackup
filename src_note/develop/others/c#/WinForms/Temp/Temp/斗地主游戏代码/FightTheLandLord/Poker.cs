using System;
using System.Collections.Generic;
using System.Text;

namespace FightTheLandLord
{
    public class Poker
    {
        /// <summary>
        /// 扑克牌的值
        /// </summary>
        private PokerNum _pokerNum;
        /// <summary>
        /// 扑克牌的花色
        /// </summary>
        private PokerColor _pokerColor;

        /// <summary>
        /// 扑克牌的值
        /// </summary>
        public PokerNum pokerNum
        {
            get
            {
                return this._pokerNum;
            }
            set
            {
                this._pokerNum = value;
            }
        }

        /// <summary>
        /// 扑克牌的花色
        /// </summary>
        public PokerColor pokerColor
        {
            get
            {
                return this._pokerColor;
            }
            set
            {
                this._pokerColor = value;
            }
        }

        public Poker(PokerNum pokerNum, PokerColor pokerColor)
        {
            this.pokerNum = pokerNum;
            this.pokerColor = pokerColor;
        }

        public static bool operator ==(Poker LP, Poker RP)
        {
            if ((object)LP != null && (object)RP != null)
            {
                if (LP.pokerNum == RP.pokerNum)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if ((object)LP == null && (object)RP != null)
                {
                    return false;
                }
                else
                {
                    if ((object)LP != null && (object)RP == null)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
        public static bool operator ==(Poker LP, PokerNum RP)
        {
            if ((object)LP != null)
            {
                if (LP.pokerNum == RP)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Poker LP, PokerNum RP)
        {
            return !(LP.pokerNum == RP);
        }
        public static bool operator !=(Poker LP, Poker RP)
        {
            return !(LP == RP);
        }
        public static bool operator >(Poker LP, Poker RP)
        {
            if ((object)LP != null && (object)RP != null)
            {
                if (LP.pokerNum > RP.pokerNum)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
        public static bool operator <(Poker LP, Poker RP)
        {
            if (RP > LP)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string Num = this.pokerNum.ToString().Replace("P", "");
            string Color; 
            switch (this.pokerColor.ToString())
            {
                case "黑桃":
                    Color = "♠";
                    break;
                case "方块":
                    Color = "♦";
                    break;
                case "红心":
                    Color = "♥";
                    break;
                case "梅花":
                    Color = "♣";
                    break;
                default:
                    Color = "";
                    break;
            }
            if ((int)(this.pokerNum) >= 16)
            {
                return Num;
            }
            else
            {
                return Color + Num;
            }
        }
    }
}
