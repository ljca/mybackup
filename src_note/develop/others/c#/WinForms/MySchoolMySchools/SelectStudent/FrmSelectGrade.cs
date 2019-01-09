using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectStudent
{
    public partial class FrmSelectGrade : Form
    {
        public FrmSelectGrade()
        {
            InitializeComponent();
        }

        private void FrmSelectGrade_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;

        }


        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        private void cboGrade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}
