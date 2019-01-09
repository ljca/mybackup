using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMDBLL;

namespace WindowsFormsApplication1
{
    /// <summary>
    /// 临时类
    /// </summary>
    public class Temp:CmdCall
    {
        public int Tempd { get; set; }

        /// <summary>
        /// 调用系统命令行
        /// </summary>
        public void Temps()
        {
            Ls();
        }

    }
}
