using MySchool.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySchool
{
    public partial class FrmMySchool : Form
    {
        public FrmMySchool()
        {
            InitializeComponent();
        }

        private void FrmMySchool_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            SearchGrade searchgrade = new SearchGrade();

        }
    }
}
