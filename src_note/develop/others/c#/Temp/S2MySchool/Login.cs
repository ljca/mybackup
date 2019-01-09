using MySchoolDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S2MySchool
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //1.
            AdminService admin = new AdminService();
            //2.
            try
            {
                if (admin.Login(txtLoginId.Text, txtLoginPwd.Text))
                {
                    MessageBox.Show("登录成功");
                    new Form1().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("登录失败");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
