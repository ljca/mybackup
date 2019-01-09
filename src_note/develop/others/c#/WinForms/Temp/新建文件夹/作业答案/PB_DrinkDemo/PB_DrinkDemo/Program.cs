using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PB_DrinkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 定义咖啡
		    Coffee pl = new Coffee();
		    pl.Name="曼特宁咖啡";
		    pl.Taste="醇厚偏苦";
		    pl.Drinking();
		    Console.WriteLine("----------------------------");
		    // 定义茶
		    Tea sp = new Tea("普洱茶","甜爽具佳");
		    sp.Drinking();
            Console.WriteLine("----------------------------");
		    // 定义啤酒
		    Beer br = new Beer();
		    br.Name="青岛啤酒";
		    br.Taste="平顺甘醇";
            br.Drinking();
        }
    }
}
