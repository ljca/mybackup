using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCheck
{

    /// <summary>
    /// 体检检查项目类
    /// </summary>
    public class HeathCheckItem
    {
        /// <summary>
        /// 项目描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string ItemName { get; set; }
    }
}
