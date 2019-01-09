using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmTestWinfoms
{
    public partial class FrmAddForms : Form
    {
        public FrmMain main = new FrmMain();

        public FrmAddForms()
        {
            InitializeComponent();
            //this.cboGerder.SelectedIndex = 0;
        }

        private void FrmAddForms_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            SE se = new SE();
            se.ID = txtId.Text.Trim();
            se.Name = txtName.Text.Trim();
            se.Age = Int32.Parse(txtAge.Text.Trim());
            se.Gerder = this.cboGerder.Text.ToString();
            main.selist.Add(se);
            main.BindGird(main.selist);
            this.Close();
        }


    }
}
