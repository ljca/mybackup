using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace FightTheLandLord
{
    public class Player
    {
        private PokerGroup _pokers = new PokerGroup();
        private PokerGroup _bakPokers = new PokerGroup();
        private List<int> _selectPokers = new List<int>();
        private PokerGroup _leadPokers = new PokerGroup();
        private Color _backColor;
        private Graphics _g;
        private bool _areYouLandLord;
        private bool _isLandLord;
        private bool _haveOrder;
        private bool _isBiggest;

        public PokerGroup pokers
        {
            get
            {
                return this._pokers;
            }
            set
            {
                this._pokers = value;
            }
        }
        public bool areYouLandLord
        {
            get
            {
                return _areYouLandLord;
            }
            set
            {
                this._areYouLandLord = value;
            }
        }
        public bool isLandLord
        {
            get
            {
                return _isLandLord;
            }
            set
            {
                _isLandLord = value;
            }
        }
        public bool haveOrder
        {
            get
            {
                return _haveOrder;
            }
            set
            {
                _haveOrder = value;
            }
        }
        public Graphics g
        {
            get
            {
                return this._g;
            }
            set
            {
                this._g = value;
            }
        }
        public List<int> selectPokers
        {
            get
            {
                return this._selectPokers;
            }
            set
            {
                this._selectPokers = value;
            }
        }
        public Color backColor
        {
            get
            {
                return this._backColor;
            }
            set
            {
                this._backColor = value;
            }
        }
        public PokerGroup leadPokers
        {
            get
            {
                return this._leadPokers;
            }
            set
            {
                this._leadPokers = value;
            }
        }
        public PokerGroup bakPokers
        {
            get
            {
                return this._bakPokers;
            }
            set
            {
                this._bakPokers = value;
            }
        }


        //当自己的IsBiggest为true时,发送消息使其他玩家的IsBiggest为false,因为逻辑上IsBiggest只能有一个
        public bool isBiggest
        {
            get
            {
                return _isBiggest;
            }
            set
            {
                if (value)
                {
                    if (DConsole.client != null)
                    {
                        DConsole.client.SendDataForServer("IamIsBiggest");
                        _isBiggest = value;
                    }
                    if (DConsole.server != null)
                    {
                        DConsole.server.SendDataForClient("NoBiggest", 1);
                        DConsole.server.SendDataForClient("NoBiggest", 2);
                        _isBiggest = value;
                    }
                }
                else
                {
                    _isBiggest = value;
                }
            }
        }

        /// <summary>
        /// 把牌从大到小重新排序
        /// </summary>
        public void sort()  //排序玩家的牌
        {
            sort(this.pokers); //调用sort另一个版本
        }

        public static void sort(PokerGroup Pokers)  //从大到小排序算法
        {
            int i;
            int j;
            for (i = 0; i < Pokers.Count; i++)
            {
                for (j = i + 1; j < Pokers.Count; j++)
                {
                    if (Pokers[j] > Pokers[i])
                    {
                        Poker temp = Pokers[i];
                        Pokers[i] = Pokers[j];
                        Pokers[j] = temp;
                    }
                }
            }

        }
        public void BakPoker()
        {
            this.bakPokers.Clear();
            foreach (Poker poker in this.pokers)  //备份已经洗好的牌
            {
                this.bakPokers.Add(poker);
            }
        }

        /// <summary>
        /// 检测是否符合游戏规则,如果符合则出牌,否则返回flase
        /// </summary>
        public bool lead()
        {
            DConsole.leadPokers = leadPokers;
            this.leadPokers.Clear();
            foreach (int selectPoker in this.selectPokers)  //迭代循环把已选中的牌添加到leadPokers
            {
                this.leadPokers.Add(this.pokers[selectPoker]);
            }
            if (DConsole.IsRules(this.leadPokers))
            {
                if (DConsole.player1.isBiggest || DConsole.leadPokers > DConsole.leadedPokerGroups[DConsole.leadedPokerGroups.Count-1])
                {
                    if (DConsole.leadPokers.type == PokerGroupType.炸弹)
                    {
                        DConsole.multiple *= 2;
                    }
                    if (DConsole.leadPokers.type == PokerGroupType.双王)
                    {
                        DConsole.multiple *= 3;
                    }
                    DConsole.player1.isBiggest = true;
                    this.BakPoker();  //备份现有pokers,下次出牌时需要用到
                    foreach (int selectPoker in this.selectPokers)  //在pokers里移除已经出过的牌
                    {
                        this.pokers.Remove(this.bakPokers[selectPoker]);
                    }
                    this.selectPokers.Clear();  //清空已选牌
                    return true;
                }
                else
                {
                    this.leadPokers.Clear();
                    return false;
                }
            }
            else
            {
                this.leadPokers.Clear();
                return false;
            }
        }

        /// <summary>
        /// 把牌从左至右绘制到容器上
        /// </summary>
        public void Paint()
        {
            for (int i = 0; i < pokers.Count; i++)  //循环绘制所有的牌
            {
                int x = i * 40;
                if (this.IndexIsHave(i) == false)  //当当前的牌没有被选中时,绘制如下图案
                {
                    Rectangle rt = new Rectangle(x, 50, 50, 95); //没有选中的牌的X比选中的牌的X多50
                    g.FillRectangle(Brushes.White, rt);
                    g.DrawRectangle(Pens.Black, rt);
                    g.DrawString(this.pokers[i].ToString(), new Font("宋体", 12), Brushes.Black, x + 5, 55);
                }
                else  //当当前的牌已经被选中时,绘制如下图案
                {
                    Rectangle rt = new Rectangle(x, 0, 50, 95);
                    g.FillRectangle(Brushes.White, rt);
                    g.DrawRectangle(Pens.Black, rt);
                    g.DrawString(this.pokers[i].ToString(), new Font("宋体", 12), Brushes.Black, x + 5, 5);
                }
            }
        }
        /// <summary>
        /// 传入一个整型显示出牌的选中效果
        /// </summary>
        public void Paint(int index)  //牌的位置从左到右依次用0-16表示,对应this.pokers[0-16]
        {
            this.g.Clear(this.backColor);
            bool IndexIsHave = this.IndexIsHave(index); //返回一个值确定当前点击的牌是否已经被选中
            if (IndexIsHave) 
            {
                this.selectPokers.Remove(index);  //如果已经被选中则删除它
            }
            else
            {
                this.selectPokers.Add(index);  //如果没有被选中则添加它
            }
            this.Paint(); //绘制当前的牌
        }
        public void SelectLandLordEnd()
        {
            DConsole.PaintLandLord(true);
            if (this.isLandLord)
            {
                foreach (Poker poker in DConsole.LandLordPokers)
                {
                    this.pokers.Add(poker);
                }
                this.sort();
                this.Paint();
            }
        }

        public bool IndexIsHave(int index)  //判断选中的牌中是否有传入的值
        {
            bool indexIsHave = false;
            foreach (int selectPoker in this.selectPokers)
            {
                if (selectPoker == index)
                {
                    indexIsHave = true;
                    break;
                }
            }
            return indexIsHave;
        }
    }
}
