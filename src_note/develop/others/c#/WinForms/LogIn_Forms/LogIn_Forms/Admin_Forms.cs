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
    public partial class Admin_Forms : Form
    {
        public Admin_Forms()
        {
            InitializeComponent();
        }
        public string UserName = string.Empty;

        private void Admin_Forms_Load(object sender, EventArgs e)
        {
            this.txt_User.Text = UserName;
        }



    }
}
