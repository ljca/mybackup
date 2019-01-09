using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWindows
{
    public class HealthCheckItem
    {
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// 属性
        /// </summary>
        public HealthCheckItem hk { get; set; }

    }
}
