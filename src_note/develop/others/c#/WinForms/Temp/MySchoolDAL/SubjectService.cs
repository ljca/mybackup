using MySchoolModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchoolDAL
{
    public class SubjectService : DBService
    {
        public List<Subject> GetAll()
        {
            return GetListBySQL<Subject>("select * from subject");
        }

        public List<Subject> GetSubjectByName(string subName)
        {
            return GetListBySQL<Subject>(
                "select * from subject where subjectName like '%" + subName + "%'");
        }
    }
}
