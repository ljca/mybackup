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


namespace SMS
{
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 连接字符串！
        /// </summary>
        public static string constr = @"Data Source=.;Initial Catalog=SMS;Integrated Security=True";
        //Data Source=.;Initial Catalog=SMS;Integrated Security=True";

        public const string CAPTION = "系统提示！";

       /// <summary>
       /// 适配器对象！
       /// </summary>
        public static SqlDataAdapter da = null;

        /// <summary>
        /// 数据集对象！
        /// </summary>
        public static DataSet ds = null;

        /// <summary>
        /// 连接对象！
        /// </summary>
        public static SqlConnection cn = null;

        /// <summary>
        /// command对象！
        /// </summary>
        public static SqlCommand cmd = null;

        /// <summary>
        /// sql
        /// </summary>
        public static string sql = "";

        private void FrmAdd_Load(object sender, EventArgs e)
        {
            SelectDepName();
            CheckState();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("确定要保存吗？\n数据库可能会受到影响！","数据库提示！");
            if (ds == DialogResult.OK)
            {
                if (Save() != 0)
                {
                    MessageBox.Show("保存成功！",CAPTION);
                }
                else
                {
                    MessageBox.Show("保存失败！",CAPTION);
                } 
            }
        }


        /// <summary>
        /// 关闭窗体！
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //关闭窗体！
            this.Close();
        }


        /// <summary>
        /// 非空验证！
        /// </summary>
        /// <returns></returns>
        private bool CheckNull()
        {
            if (txtName.Text != ""
                || txtStafName.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("项不能为空！",CAPTION);
                return false; 
            } 
        }


        /// <summary>
        /// 查询部门并填充！
        /// </summary>
        private void SelectDepName()
        {
            sql = @"select DepId,DepName
from Department";
            da = new SqlDataAdapter(sql, constr);
           /*
            ds = new DataSet();
            if (ds.Tables["Department"] != null)
            {
                ds.Tables["Department"].Clear();   
            }
            */
            DataTable dt = new DataTable("Department");
            da.Fill(dt);//ds, "Department");
            this.cboDepName.DataSource = dt;
            this.cboDepName.ValueMember = "DepId";
            this.cboDepName.DisplayMember = "DepName";
        }


        /// <summary>
        /// 查询员工状态并填充！
        /// </summary>
        private void CheckState()
        {
            sql = @"select StaffId,[State]
from Staff";
            da = new SqlDataAdapter(sql, constr);
            DataTable dt = new DataTable("Staff");
            da.Fill(dt);//ds, "Staff");
            this.cboState.DataSource = dt;//ds.Tables["Staff"];
            this.cboState.ValueMember = "StaffId";
            this.cboState.DisplayMember = "State";
        }


       /// <summary>
       /// 保存数据！
       /// </summary>
       /// <returns></returns>
        private int Save()
        {
            if (CheckNull())
            {
                sql = string.Format(@"");
                cn = new SqlConnection(constr);
                cn.Open();
                try
                {
                    cmd = new SqlCommand(sql, cn);
                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        return cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return 0;
                }
                finally
                {
                    cn.Close();
                }
            }

            return 0;
        }


    }
}
