using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temos;

namespace CMDBLL
{
    /// <summary>
    /// 逻辑层调用Temos层
    /// </summary>
    public class CmdCall
    {
        /// <summary>
        /// 清屏
        /// </summary>
        public static void Ls()
        {
            Tsos.Cmd();
        }
    }
}
