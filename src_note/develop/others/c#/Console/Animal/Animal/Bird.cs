using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Bird:Animal
    {
        public override void Run()
        {
            Console.WriteLine("鸟在天上飞！");
        }
    }
}
