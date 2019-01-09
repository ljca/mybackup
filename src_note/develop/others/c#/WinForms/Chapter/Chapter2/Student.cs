using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    /// <summary>
    /// 学生数据类型
    /// </summary>
    public struct Student
    {
        /// <summary>
        ///编号
        /// </summary>
        public int Id;
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name;
        /// <summary>
        /// 学生信息
        /// </summary>
        public void Show()
        {
            Console.WriteLine("这是一个学生:" + Name);
        }
    }
}
