using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Models
{
    /// <summary>
    ///学生实体类
    /// </summary>
    public class Student
    {
        /// <summary>
        /// 学生编号
        /// </summary>
        public int StudentNo { get; set; }

        /// <summary>
        /// 登录密码
        /// </summary>
        public string LoginPwd { get; set; }

        /// <summary>
        /// 学生姓名
        /// </summary>
        public string StudentName { get; set; }

        /// <summary>
        /// 学生性别
        /// </summary>
        public char Sex{ get; set; }

        /// <summary>
        /// 年级编号
        /// </summary>
        public int GradeId { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime BornDate { get; set; }

        /// <summary>
        /// 邮箱地址
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string IdentityCard { get; set; }

    }
}
