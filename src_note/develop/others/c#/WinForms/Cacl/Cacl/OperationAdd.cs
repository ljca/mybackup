using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cacl
{

    /// <summary>
    /// 加法计算类
    /// </summary>
    public class OperationAdd:Operation
    {
        public override double GetResult()
        {
            double result = NumberA + NumberB;
            return result;
        }

    }
}
