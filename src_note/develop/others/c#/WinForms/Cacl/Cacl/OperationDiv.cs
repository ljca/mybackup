using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cacl
{

    /// <summary>
    /// 除法计算类
    /// </summary>
    public class OperationDiv:Operation
    {
        public override double GetResult()
        {
            double result = NumberA / NumberB;
            return result;
        }

    }
}
