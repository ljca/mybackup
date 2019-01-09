using MySchoolModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchoolDAL
{
    public class GradeService : DBService
    {
        /// <summary>
        /// 获取所有的年级信息
        /// </summary>
        /// <returns></returns>
        public List<Grade> GetAllGrade()
        {
            return GetListBySQL<Grade>("select * from Grade");
        }
    }
}
