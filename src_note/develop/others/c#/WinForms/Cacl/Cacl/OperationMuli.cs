using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cacl
{

    /// <summary>
    /// 乘法计算类
    /// </summary>
    public class OperationMuli:Operation
    {
        public override double GetResult()
        {
            double result = NumberA * NumberB;
            return result;
        }
    }

}
