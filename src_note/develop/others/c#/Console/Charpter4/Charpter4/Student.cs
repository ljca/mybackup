using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charpter4
{

    /// <summary>
    /// 学生类
    /// </summary>
    public class Student
    {
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get; set; }

        public Student()
        {

        }
        
        public Student(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }

        /// <summary>
        /// 问好，方法
        /// </summary>
        public void SayHi()
        {
            Console.WriteLine("我叫{0},年龄{1}岁",Name,Age);
            Console.Read();
        }


    }
}
