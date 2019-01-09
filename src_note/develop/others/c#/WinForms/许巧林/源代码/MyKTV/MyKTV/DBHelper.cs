using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace MyKTV
{
    /// <summary>
    /// 数据库连接辅助类
    /// </summary>
   public class DBHelper
   {
       #region 数据库的一些字段
       public static string sql = null;
       private static SqlConnection cn;

       /// <summary>
       /// 数据库连接对象
       /// </summary>
       public static SqlConnection Cn
       {
           get
           {
               if (cn == null)
               {
                   cn = new SqlConnection(constr);
               }
               return cn;
           }
       }

       /// <summary>
       /// 执行对象
       /// </summary>
       public static SqlCommand cm = null;
       //public static SqlCommand Cm
       //{
       //    get
       //    {
       //        if (cm == null)
       //        {
       //            cm = new SqlCommand(sql, Cn);
       //        }
       //        return cm;
       //    }
       //}
       /// <summary>
       /// 数据集对象
       /// </summary>
       public static DataSet ds = null;
       /// <summary>
       /// 适配器对象
       /// </summary>
       public static SqlDataAdapter da = null;
       /// <summary>
       /// 数据库操作对象
       /// </summary>
       public static SqlCommandBuilder builder = null;

       /// <summary>
       /// 视图对象
       /// </summary>
       public static DataView dv = null;
      
       /// <summary>
      /// 读取对象
      /// </summary>
       public static SqlDataReader dreader = null;
       //public static SqlDataReader Dreader
       //{
       //    get
       //    {
       //        if(dreader == null)
       //        {
       //            dreader = Cm.ExecuteReader();
       //        }
       //        return dreader;
       //    }
       //}
       /// <summary>
       /// 连接字符串
       /// </summary>
       public static string constr = @"Data Source=YLHHGG\MYSQL;Initial Catalog=MyKTV;Integrated Security=True";//Data Source=.;Initial Catalog=MyKTV;Integrated Security=True";
      

       #endregion
       /// <summary>
       /// 检查连接状态，如果关闭则打开连接
       /// </summary>
       public static bool OpenCon()
       {
           if (Cn.State == ConnectionState.Closed)
           {
               Cn.Open();
           }
           return true;
       }

       /// <summary>
       /// 检查连接状态，如果打开则关闭连接
       /// </summary>
       public static void CloseCon()
       {
         if(Cn.State == ConnectionState.Open || Cn.State == ConnectionState.Broken)
           {
               Cn.Close();
           }
       }

    }
}
