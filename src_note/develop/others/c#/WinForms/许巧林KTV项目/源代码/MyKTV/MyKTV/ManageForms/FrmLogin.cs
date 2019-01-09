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
namespace MyKTV.ManageForms
{
    public partial class FrmLogin : Form
    {
        //public static FrmAdmin admin = new MyKTV.ManageForms.FrmAdmin();
        public FrmLogin()
        {
            InitializeComponent();

        }

        /// <summary>
        /// 初始化窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            #region 初始化窗体
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.txtName.Focus();
            //this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = this.btnLogin;
            this.CancelButton = this.btnCancel;
            this.txtName.ForeColor = Color.Blue;
            this.txtPassword.ForeColor = Color.Blue;
            this.ForeColor = Color.Blue;
            this.txtPassword.PasswordChar = '*';
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            #endregion
        }


        #region 登录
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (!this.txtName.Text.Trim().Equals(string.Empty) && !this.txtPassword.Text.Trim().Equals(string.Empty) && LoginCheck())
            {
                FrmAdmin.admin = null;
                if (FrmAdmin.admin == null || FrmAdmin.admin.IsDisposed)
                {
                    this.Close();
                    //Application.Run(new FrmAdmin());

                    FrmAdmin.admin = new MyKTV.ManageForms.FrmAdmin();
                    FrmAdmin.admin.Show();
                }
               
            }
            else //if (LoginCheck())  //this.txtName.TextLength != 0 || this.txtPassword.TextLength != 0
            {
                MessageBox.Show("登录失败！\n\n请检查用户名或者密码是否存在！\n\n用户名或者密码可能为空！", "登录提示！");
                this.txtName.ResetText();
                this.txtPassword.ResetText();
                this.txtName.Focus();          
            }

        }
        #endregion

        #region 验证登录用户
        /// <summary>
        /// 验证登录用户
        /// </summary>
        /// <returns></returns>
        public bool LoginCheck()
        {
            DBHelper.sql = string.Format(@"select count(*) from admin_info where admin_name='{0}' and admin_pwd='{1}' ", txtName.Text.Trim(), txtPassword.Text.Trim());
            try
            {
                if(DBHelper.OpenCon())
                {
                    DBHelper.cm = new SqlCommand(DBHelper.sql,DBHelper.Cn);
                    if ((int)DBHelper.cm.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("登录成功！", "登录提示！");
                        return true;
                    }
                   
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("连接异常！" + ex.Message);
                return false;
            }
            finally
            {
                DBHelper.CloseCon();
            }
        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //FrmAdmin.admin.Dispose();
            this.Close();
        }
    }
}
