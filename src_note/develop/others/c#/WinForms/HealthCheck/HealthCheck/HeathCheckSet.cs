using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCheck
{
    /// <summary>
    /// 体检套餐类
    /// </summary>
    public class HeathCheckSet
    {
        /// <summary>
        /// 体检检查项目集合
        /// </summary>
        public List<HeathCheckItem> Items { get; set; }

        /// <summary>
        /// 套餐价格
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// 套餐名称
        /// </summary>
        public string Name { get; set; }





    }
}
