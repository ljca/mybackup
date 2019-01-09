using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionTemp
{
    /// <summary>
    /// 子类
    /// </summary>
    public class Child:Parent
    {
        /// <summary>
        /// 问好
        /// </summary>
        public void Hi()
        {
            Console.WriteLine("******************Hi方法重写***************");

        }
    }
}
