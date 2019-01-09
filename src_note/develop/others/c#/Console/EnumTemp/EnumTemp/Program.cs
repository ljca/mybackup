using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            char x ='男';
            if (x!= (char)Sex.FMaile)
            {
                Console.WriteLine((char)Sex.Male);
            }
            Console.ReadKey();
        }
    }
}
