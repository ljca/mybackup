using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySchoo
{
    public partial class AdminForms : Form
    {
        UpdeateForms seach = new UpdeateForms();
        public AdminForms()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        public const string cs = "";
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tBtnAdd_ButtonClick(object sender, EventArgs e)
        {

            AddForms forms = new AddForms();
            forms.MdiParent = this;
            forms.Show();

        }

        private void tBtnSelect_ButtonClick(object sender, EventArgs e)
        {
            UpdeateForms up = new UpdeateForms();
            //seach.MdiParent = this;
            seach.FillListViwe();
            seach.ShowDialog();
        }

        private void tmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

  


    }
}
