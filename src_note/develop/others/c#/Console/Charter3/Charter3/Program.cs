using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Charter3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stus = new List<Student>();
            Student bob = new Student(){Name = "bob",Age = 14};
            stus.Add(bob);
            Student.SayHi(bob.Name,bob.Age);
        }
    }
}
