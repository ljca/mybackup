using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Temp
    {
        static int IC_;
        protected int a = 2;
    }

    class Program:Temp
    {
        static void Alter(int id, Student stu)
        {
            id = id++;
            stu.age++;
        }

        public void Tmp() 
        {
            base.a = 2;
        }

        static void Main(string[] args)
        {
            Student stu = new Student();
            Temp t = new Temp();
            Console.WriteLine();
            
            int id = 1;
            stu.age = 30;
            Alter(id, stu);
            Console.WriteLine("id={0},age={1}", id, stu.age);
            Console.ReadKey(true);
        }

    }
}