using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            Child te = new Child();
            te.Hi();
            te.Hi("Word");
            Console.ReadKey();
        }
    }
}
