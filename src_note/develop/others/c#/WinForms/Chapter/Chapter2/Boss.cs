using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    public class Boss
    {
        public void AddMoney(SE se)
        {
            //在原有工资上翻倍
            se.money *= 2 ;
        }
        public void AddMoney1(StructSE se)
        {
            //在原有工资上翻倍
            se.money *= 2;
        }
    }
}
