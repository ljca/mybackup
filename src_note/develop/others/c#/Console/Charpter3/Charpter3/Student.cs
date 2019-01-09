using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charpter3
{
    public class Student
    {
        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 问好，方法
        /// </summary>
        public void SayHi()
        {
            Console.WriteLine("大家好，我叫{0},年龄:{1}",Name,Age);
        }

    }
}
