using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PB_DrinkDemo
{
    /// <summary>
    /// 茶类
    /// </summary>
    public class Tea:Drink
    {
        public Tea()
        {
        }
        public Tea(string name, string taste):base(name,taste)
        {
        }
        // 实现饮用的方法
        public override void Drinking() 
        {
            Console.WriteLine("名称：" + this.Name + "\n口感：" + this.Taste + "\n热饮口感最好");
	}
    }
}
