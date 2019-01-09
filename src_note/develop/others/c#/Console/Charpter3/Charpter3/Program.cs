using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Charpter3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList() 
            {
                new Student{Name = "A",Age = 18},
                new Student{Name = "B",Age = 19},
                new Student{Name = "C",Age = 20},
                new Student{Name = "D",Age = 21},
            };

            foreach (Object objec in list)
            {
                Student stus = (Student)objec;
                stus.SayHi();
            }
            Console.Read();

        }
    }
}
