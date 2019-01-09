using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MySchoolDAL
{
    public class DBService : DBHelper
    {

        protected List<T> GetListBySQL<T>(string sql)
        {
            DataTable dt = GetDataSetBySQL(sql).Tables["datalist"];
            List<T> list = new List<T>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                T t = Activator.CreateInstance<T>();
                PropertyInfo[] propertyInfo = t.GetType().GetProperties();
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    foreach (PropertyInfo info in propertyInfo)
                    {
                        if (dt.Columns[j].ColumnName.ToUpper().Equals(info.Name.ToUpper()))
                        {
                            if (dt.Rows[i][j] != DBNull.Value)
                            {
                                info.SetValue(t, dt.Rows[i][j], null);
                            }
                            else
                            {
                                info.SetValue(t, null, null);
                            }
                            break;
                        }
                    }
                }
                list.Add(t);
            }
            return list;
        }
    }
}
