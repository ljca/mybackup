using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XiTi
{

    /// <summary>
    /// 
    /// </summary>
    class Info
    {

       public void Show()
        {
            Reder sc = new Reder();
            Console.WriteLine("请输入选择：");
            Console.ReadLine();
            switch (Console.ReadLine())
            {
                case "1":
                    sc.ShowInfo();
                    break;

                case "2":
                    break;

                case "3":
                    break;

                case "4":
                    break;

                case "5":
                    break;

                case "0":
                    break;

                default:
                    break;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void ShowMenu()
        {
            Console.WriteLine("*******欢迎使用低碳生活信息管理系统*******");
            Console.WriteLine("*******请选择菜单项*******");
            Console.WriteLine("1、显示碳消耗列表");
            Console.WriteLine("2、显示碳消耗类别");
            Console.WriteLine("3、更新碳消耗量");
            Console.WriteLine("4、添加碳消耗记录");
            
            Console.WriteLine("5、删除碳消耗记录");
            Console.WriteLine("0、退出");
            Console.WriteLine("**************************************");
            //Console.ReadLine();
        }

        /// <summary>
        /// 
        /// </summary>
       
    }
}






