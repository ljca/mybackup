using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FightTheLandLord
{
    public class PokerGroups : List<PokerGroup>
    {
        public new void Add(PokerGroup PG)
        {
            if (DConsole.IsRules(PG))
            {
                if (PG.type == PokerGroupType.双王)
                {
                    DConsole.multiple *= 3;
                }
                if (PG.type == PokerGroupType.炸弹)
                {
                    DConsole.multiple *= 2;
                }
                base.Add(PG);
            }
            else
            {
                DConsole.Write("[系统消息]:有玩家作弊,重新启动游戏.");
            }
        }
    }
}
