using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmTestWinfoms
{

   /// <summary>
   /// 打卡记录类
   /// </summary>
    public class Record
    {
        /// <summary>
        /// 签到时间
        /// </summary>
        public DateTime SignInTime { get; set; }

        /// <summary>
        /// 签退时间
        /// </summary>
        public DateTime SingnOutTime { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        public string Name { get; set; }


    }
}
