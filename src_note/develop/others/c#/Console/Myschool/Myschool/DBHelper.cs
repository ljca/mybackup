using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Myschool
{
    /// <summary>
    /// 提供操作数据的工具类
    /// 
    /// </summary>
    class DBHelper
    {
        private const string connection_string = "Data Source=.;Initial Catalog=QQ;User ID=sa;Password=123";
        private SqlConnection connection = new SqlConnection(connection_string);

        public SqlConnection Connection
        {
            get { return connection; }

        }
        public void Open()
        {
            connection.Open();

        }
        public void Close()
        {
            connection.Close();

        }

    }
}
