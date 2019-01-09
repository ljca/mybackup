using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_work
{
    public class PM
    {
        /// <summary>
        /// 项目经理评分
        /// </summary>
        /// <param name="se"></param>
        public void Judge(SE se, String descript, int score)
        {
            se.Descript = descript;
            se.Score = score;
        }
    }
}
