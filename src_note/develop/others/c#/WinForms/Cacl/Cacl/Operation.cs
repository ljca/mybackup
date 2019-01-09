using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cacl
{

    /// <summary>
    /// 父类
    /// </summary>
    public class Operation
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
}
