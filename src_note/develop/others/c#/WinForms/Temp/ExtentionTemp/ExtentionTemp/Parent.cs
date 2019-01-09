using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionTemp
{

    /// <summary>
    /// 基类
    /// </summary>
    public class Parent
    {
        /// <summary>
        /// 问好
        /// </summary>
        public void Hi()
        {
            Console.WriteLine("*********************************");
 
        }

        /// <summary>
        /// 问好
        /// </summary>
        public void Hi(string name)
        {
            Console.WriteLine(name + "**************");
        }


    }
}
