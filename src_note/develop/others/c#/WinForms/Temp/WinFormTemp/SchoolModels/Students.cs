using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{

    /// <summary>
    /// 学生类
    /// </summary>
    public class Students
    {
        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 年级编号
        /// </summary>
        public int GradeId { get; set; }
        /// <summary>
        /// 年级
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// 学号
        /// </summary>
        public int Nuber { get; set; }
        public DateTime BornDate { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        public string LoginPwd { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string IdentityCard { get; set; }
    }

}
