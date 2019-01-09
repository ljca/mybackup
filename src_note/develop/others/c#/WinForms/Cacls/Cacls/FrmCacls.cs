using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cacls
{
    public partial class FrmCacls : Form
    {
        public FrmCacls()
        {
            InitializeComponent();
        }

        private const string Mess = "运算结果！";
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///   对输入的对象进行运算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCacls_Click(object sender, EventArgs e)
        {
            if (Check()) //&& this.txt_End.Equals(string.Empty))
            {
                //第一个运算数
                double a = (Double.Parse(this.txt_Nuber1.Text.ToString()));
                //第二个运算数
                double b = (Double.Parse(this.txt_Nuber2.Text.ToString()));
                //运算结果
                string c = this.txt_End.Text;
                //运算符
                char s = Char.Parse(this.cbCacls.Text);
                switch (s)
                {
                    case '+':
                        this.txt_End.Text = (a + b).ToString();
                        MessageBox.Show(txt_End.Text, Mess, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        break;
                    case '-':
                        this.txt_End.Text = (a - b).ToString();
                        MessageBox.Show(txt_End.Text, Mess, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                       break;

                    case '*':
                       this.txt_End.Text = (a * b).ToString();
                       MessageBox.Show(txt_End.Text.ToString(), Mess, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                    case '/':
                        this.txt_End.Text = (a / b).ToString();
                        MessageBox.Show(txt_End.Text.ToString(), Mess, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    default:
                        c = "";
                        MessageBox.Show(txt_End.Text.ToString(), Mess, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }

            }

        }



        /// <summary>
        /// 检查输入是否为空
        /// </summary>
        /// <returns>true 真，false 假</returns>

        public bool Check()
        {

            if (this.txt_Nuber1.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入数字！", Mess, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_Nuber1.Focus();
                return false;
            }
            else if (this.txt_Nuber2.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入数字！", Mess, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_Nuber2.Focus();
                return false;
            }
            else if (this.cbCacls.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入运算符！");
                this.cbCacls.Focus();
                return false;
            }
            else
            {
                return true;
            }

        }

        private void FrmCacls_Load(object sender, EventArgs e)
        {
            this.cbCacls.SelectedIndex = 1;
            this.txt_End.ReadOnly = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txt_Nuber1.ResetText();
            txt_Nuber2.ResetText();
            txt_End.ResetText();
            cbCacls.SelectedIndex = 0;
        }


    }
}
