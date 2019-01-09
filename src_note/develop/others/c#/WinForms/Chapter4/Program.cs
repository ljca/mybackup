using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("王");
            //实例化Student对象
            Student stu = new Student(teacher);

            SchoolMaster master = new SchoolMaster("蒋");

            stu.Hello(teacher);
            stu.Hello(master);

            
        }
    }
}
