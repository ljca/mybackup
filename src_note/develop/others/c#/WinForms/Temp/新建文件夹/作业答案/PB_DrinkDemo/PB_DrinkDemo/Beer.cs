using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PB_DrinkDemo
{
    /// <summary>
    /// 啤酒类
    /// </summary>
    public class Beer:Drink
    {
        // 实现饮用的方法
        public override void Drinking() 
        {
            Console.WriteLine("名称：" + this.Name + "\n口感：" + this.Taste + "\n冰镇饮用口感最好");
	    }
    }
}
