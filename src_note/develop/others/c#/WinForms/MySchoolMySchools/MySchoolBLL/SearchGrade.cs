using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using MySchool.DAL;
using MySchool.Models;

namespace MySchool.BLL
{

   public class SearchGrade
    {

       /// <summary>
       /// 查询年级记录
       /// </summary>
       public void SearchGrade()
       {
           GredeService.GetGradeId(1);
       }

    }
}
