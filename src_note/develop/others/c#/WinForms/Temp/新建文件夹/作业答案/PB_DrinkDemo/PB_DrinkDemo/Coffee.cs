using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PB_DrinkDemo
{
    /// <summary>
    /// 咖啡类
    /// </summary>
    public class Coffee:Drink
    {
        // 实现饮用的方法
        public override void Drinking() 
        {
            Console.WriteLine("名称：" + this.Name + "\n口感：" + this.Taste + "\n饮用时可以加奶和糖");
	    }
    }
}
