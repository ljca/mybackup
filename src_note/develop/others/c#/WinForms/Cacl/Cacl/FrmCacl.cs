using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cacl
{
    public partial class FrmCacl : Form
    {
        public FrmCacl()
        {
            InitializeComponent();
            this.cboOper.SelectedIndex = 0;
        }

        private void FrmCacl_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.lblResult_2.Text = null;
            this.txtNuberA.Focus();
        }



        private void btnCount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtNuberA.Text.Trim()))
            {
                MessageBox.Show("");
                txtNuberA.Focus();
                return;
            }

            if (string.IsNullOrEmpty(this.txtNuberB.Text.Trim()))
            {
                MessageBox.Show("");
                txtNuberB.Focus();
                return;
            }

            try
            {
                Operation op = new Operation();
                switch(this.cboOper.SelectedItem.ToString().Trim())
                {
                    case "+":
                        op = new OperationAdd();
                        break;
                    case "-":
                        op = new OperationSubctra();
                        break;
                    case "*":
                        op = new OperationMuli();
                        break;
                    case "/":
                        op = new OperationDiv();
                        break;
                    default:
                        break;
                }
                op.NumberA = double.Parse(this.txtNuberA.Text.Trim());
                op.NumberB = double.Parse(this.txtNuberB.Text.Trim());

                this.lblResult_2.Text = op.GetResult().ToString();
                lblResult_2.Visible = true;

            }
            catch (Exception)
            {
                throw;
            }

        }

       

    }
}
