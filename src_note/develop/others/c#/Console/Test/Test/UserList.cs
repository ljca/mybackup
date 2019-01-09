using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Test
{

    /// <summary>
    /// 
    /// </summary>
    class UserList
    {
        string username,password;
        /// <summary>
        /// 
        /// </summary>
        public void CheckInfo()
        {
            Console.WriteLine("");
            username  = Console.ReadLine();

            Console.WriteLine("");
            password = Console.ReadLine();

            if(username == "school" && password == "123")
            {
                Console.WriteLine("");
                ShowList();
            }
            else
            {
                CheckInfo();
            }
            Console.WriteLine("");
                
        }



        /// <summary>
        /// 
        /// </summary>
        public void ShowList()
        {
            string str = "Data Source=.;Initial Catalog=MySchool;Integrated Security=True";
            SqlConnection cn = new SqlConnection(str);

            string sql = "select count(*) from [Students]";
            cn.Open();
            SqlCommand cm = new SqlCommand(sql,cn);
            int ia = (int)cm.ExecuteScalar();
            Console.WriteLine(ia);
            cn.Close();
            Console.ReadLine();
            //SqlDataReader reader = cm.ExecuteReader();

            StringBuilder str_1 = new StringBuilder();
            str_1.AppendLine("")
                .AppendLine("")
                .AppendLine("")
                .AppendLine("")
                .AppendLine("");

            /*
            while(reader.Read())
            {
             * 
                

            }

            */
        }

    }
}
