using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn_Forms
{
    public partial class LogInForms : Form
    {
        public const string ADMIN = "管理员";
        public LogInForms()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if(CheckInput())
            {
            if(this.cbo_Type.Text.Equals(ADMIN))
            {
            Admin_Forms forms = new Admin_Forms();
            forms.UserName = txt_User.Text.Trim();
            forms.Show();

            }
            this.Hide();
        }

        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool CheckInput()
        {





            return true;
        
        
        
        }




    }
}
