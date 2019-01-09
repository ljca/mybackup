using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temos
{
    /// <summary>
    /// 命令行辅助类
    /// </summary>
    public class Tsos:CallCmd
    {
        /// <summary>
        /// 命令行路径
        /// </summary>
        public string cmdpath { get; set; }

        /// <summary>
        /// 命令行调用
        /// </summary>
        public static void Cmd()
        {
            Cls();
        }
    }
}
