using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cacl
{

    /// <summary>
    /// 减法计算类
    /// </summary>
    public class OperationSubctra:Operation
    {
        public override double GetResult()
        {
            double result = NumberA - NumberB;
            return result;
        }
    }
}
