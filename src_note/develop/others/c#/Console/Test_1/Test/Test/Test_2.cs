using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Test
{
    class Test_2
    {
        private const string strCon = "";
        private const string Errr = "";
        SqlConnection cn = new SqlConnection(strCon);
        StringBuilder str = new StringBuilder();
           
        
        public void Co()
        {
            cn.Open();
             str.AppendLine("")
                .AppendLine("")
                .AppendLine("")
                .AppendLine("")
            .AppendLine("")
            .AppendLine("");
            string str_1 = str.ToString();
            cn.Close();
        }


            public void Show()
            {
                cn.Open();
                SqlCommand cm = new SqlCommand(str.ToString(),cn);


            }
        

    }
}
