using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MySchoo
{
    public partial class UpdeateForms : Form
    {
        public UpdeateForms()
        {
            InitializeComponent();
        }





        public const string cn = "Data Source=.;Initial Catalog=MySchool;Integrated Security=True";

        SqlConnection CN = new SqlConnection(cn);


        /// <summary>
        /// 打开数据库连接
        /// </summary>
        public void OpenConnection()
        {
            if (CN.State == ConnectionState.Closed)
            {
                CN.Open();
            }
            else if (CN.State == ConnectionState.Broken)
            {
                CN.Close();
                CN.Open();
            }
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public void CloseConnection()
        {
            if (CN.State == ConnectionState.Broken || CN.State == ConnectionState.Open)
            {
                CN.Close();
            }
        }
        /// <summary>
        /// 向ListViwe控件中填充数据
        /// </summary>
       public void FillListViwe()
        {
           if(LvShow.Items.Count > 0)
           {
               LvShow.Items.Clear();
           }

           //StringBuilder sql = new StringBuilder();
           string sql = "select * from [Student]";
           //DBHelper dbhelper = new DBHelper();
           try
           {
               OpenConnection();
               SqlCommand cm = new SqlCommand(sql,CN);
             
               SqlDataReader reader = cm.ExecuteReader();
               //
               if (!reader.HasRows)
               {
                   MessageBox.Show("没有要查找的记录！", "查询结果");
               }
               else
               {
                   while(reader.Read())
                   {
                       string ID = reader["0"].ToString();
                       string Name = reader["Name"].ToString();
                       string Sexy = reader["Sexy"].ToString();
                       string Age = reader["Age"].ToString();
                       string E_Mail = reader["E_Mail"].ToString();
                       string Adress = reader["Adress"].ToString();
                       ListViewItem item = new ListViewItem(ID);
                       item.SubItems.Add(Name);
                       item.SubItems.Add(Sexy);
                       item.SubItems.Add(Age);
                       item.SubItems.Add(E_Mail);
                       item.SubItems.Add(Adress);
                       LvShow.Items.Add(item);
                   
                   }
                   reader.Close();
               }
           }
           catch (Exception)
           {

               MessageBox.Show("系统出现错误！","查询结果");
           }

           finally 
           {
               CloseConnection();
           }

        }

       private void btn_Seach_Click(object sender, EventArgs e)
       {
           FillListViwe();
       }




    }
}
