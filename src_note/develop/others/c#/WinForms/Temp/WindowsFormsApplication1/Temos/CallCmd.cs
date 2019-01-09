using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temos
{
    /// <summary>
    /// 所有自定义类的父类：命令行
    /// 此类位于Temos层
    /// </summary>
    public class CallCmd
    {
        /// <summary>
        /// 清屏
        /// </summary>
        protected static void Cls()
        {
            Console.WriteLine("你好，我们正在配置你的PC...........");
            Console.ReadKey();
        }
    }
}
