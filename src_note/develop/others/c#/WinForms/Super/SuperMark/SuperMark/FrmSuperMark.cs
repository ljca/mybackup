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


namespace SuperMark
{
    public partial class FrmSuperMannger : Form
    {
        public FrmSuperMannger()
        {
            InitializeComponent();
        }

        
        /// <summary>
        /// 连接数据库的字符串
        /// </summary>
        private const string STRCON = "Data Source=.;Initial Catalog=SuperMark;Integrated Security=True";

        public static string cs;
        /// <summary>
        /// 数据适配器对象
        /// </summary>
        private SqlDataAdapter db;
        /// <summary>
        /// 数据集对象
        /// </summary>
        private DataSet ds;

       private string sql = @"select [CustomerId],[CustomerType],[Score],[StatesName] from [UserInfo] as p,[States] as c
where c.[Id] = p.[StatesId]";
        /// <summary>
        /// 窗体加载时填充数据到DateGridView控件中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSuperMannger_Load(object sender, EventArgs e)
        {
            string sql_c = @"select * from [States]";
            this.ds = new DataSet("UserInfo");
            this.db = new SqlDataAdapter(sql, STRCON);
            SqlDataAdapter dc = new SqlDataAdapter(sql_c,STRCON);
            this.dgvSuper.AutoGenerateColumns = false;

            
            this.txtScore.Text = "500";
     
            this.rbGold.Select();

            
            if(this.ds.Tables["UserInfo"] != null)
            {
                this.ds.Tables["UserInfo"].Clear();
                //this.ds.Tables["States"].Clear();
            }


            dc.Fill(ds, "States");

            this.cboStates.ValueMember = "Id";
            this.cboStates.DisplayMember = "StatesName";
            
            this.cboStates.DataSource = ds.Tables["States"];
            
            //this.cboStates.SelectedIndex = 1;
            /*
            DataRow row = ds.Tables["States"].NewRow();
            row["Id"] = -1;
            row["StatesName"] = "全部";
            ds.Tables["States"].Rows.InsertAt(row, 0);
            */


            db.Fill(ds, "UserInfo");
            this.dgvSuper.DataSource = ds.Tables["UserInfo"];
        }

        /// <summary>
        /// 添加信息到数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Check方法的返回值为真则执行添加操作
             DialogResult result = MessageBox.Show("确定要添加吗？", "添加提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(Check())
            {
                if (result == DialogResult.OK)
                {
                    SqlCommandBuilder bu = new SqlCommandBuilder(db);
                    db.Update(ds, "UserInfo");
                }
 
        }

     
        }
        /// <summary>
        ///检查账户名和密码是否为空
        /// </summary>
        /// <returns>true 真，false 假</returns>
        private bool Check()
        {
            if (this.txtId.Text.Trim().Equals(string.Empty) || this.txtPassword.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("账户名或密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtId.Focus();
                return false;
            }
            else
            {
                return true;
            }
           }

        /// <summary>
        /// 退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出吗？", "退出提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsDel_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("确定要删除该项吗？删除后不可恢复","删除提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if(rs == DialogResult.Yes)
            {

            }


        }
    }
}
