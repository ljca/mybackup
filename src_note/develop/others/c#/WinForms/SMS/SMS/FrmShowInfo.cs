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
    public partial class FrmShowInfo : Form
    {
        public FrmShowInfo()
        {
            InitializeComponent();
        }

        SqlDataReader drear = null;



        private void FrmShowInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Seach();
        }


        /// <summary>
        /// 根据条件查询数据
        /// </summary>
        /// <returns></returns>
        private bool Seach()
        {
            if (lvShowDep.Items.Count > 0)
            {
                lvShowDep.Items.Clear();
            }
            
            FrmAdd.sql = string.Format(@"select a.StaffName,b.DepName,a.StaffLevel,a.JoinDate,a.[State] from Staff as a 
inner join Department as b on(b.DepId = a.DepId)
where StaffName like '%{0}%' ", txtName.Text);

            FrmAdd.cn = new SqlConnection(FrmAdd.constr);
            FrmAdd.cn.Open();

            string sx = "";
            try
            {
                FrmAdd.cmd = new SqlCommand(FrmAdd.sql, FrmAdd.cn);
                drear = FrmAdd.cmd.ExecuteReader();

                while (drear.Read())
                {
                    string sb = drear["StaffName"].ToString();
                    string sc = drear["DepName"].ToString();
                    string sd = drear["StaffLevel"].ToString();
                    string se = drear["JoinDate"].ToString();
                    string sf = drear["State"].ToString();
                    
                    ListViewItem item = new ListViewItem(sb);
                    item.SubItems.AddRange(new string[]{sc,sd,se,sf});
                    lvShowDep.Items.Add(item);
                     
                    sx += string.Format("姓名: {0}  部门: {1}  级别: {2}  入职日期: {3}  状态: {4}\n",sb,sc,sd,se,sf);
                }
                drear.Close();
                MessageBox.Show(sx, "查询结果！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, FrmAdd.CAPTION);
                return false;
                //throw;
            }
            finally
            {
                FrmAdd.cn.Close();
            }
            return false;
        }



    }
}
