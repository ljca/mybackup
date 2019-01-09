
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


namespace MySchool
{
    public partial class Seach_Forms : Form
    {
        private SqlDataAdapter data;
        private DataSet ds;

        public Seach_Forms()
        {
            InitializeComponent();
        }

        string cnString = "Data Source=.;Initial Catalog=MySchool;Integrated Security=True";

        private void btn_Seach_Click(object sender, EventArgs e)
        {
            string sql = "select * from [Student] where Grede = 'S1'";
            //StringBuilder sql = new StringBuilder("select * from [Student]    where Grede = 'S1'");
            this.data = new SqlDataAdapter(sql, cnString);
            this.ds = new DataSet();
            if(ds.Tables["Student"] != null)
            {
                ds.Tables["Student"].Clear();
            }
            data.Fill(ds, "Student");
            this.dgv_Student.DataSource = ds.Tables["Student"];
            
            this.dgv_Student.AutoGenerateColumns = false;
        }

        
            
        private void Seach_Forms_Load(object sender, EventArgs e)
        {
            
            string sql = "select * from [Student]";
            this.data = new SqlDataAdapter(sql,cnString);
            this.ds = new DataSet();
            data.Fill(ds, "Student");
            this.cbo_Seach.DataSource = ds.Tables["Student"];
            this.cbo_Seach.ValueMember = "ID";
            this.cbo_Seach.DisplayMember = "Grede";      

        }





    }
}
