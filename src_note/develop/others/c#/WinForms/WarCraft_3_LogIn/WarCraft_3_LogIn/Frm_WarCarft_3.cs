using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarCraft_3_LogIn
{
    public partial class Frm_WarCarft_3 : Form
    {
        public Frm_WarCarft_3()
        {
            InitializeComponent();
        }

        private void Frm_WarCarft_3_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            MinimizeBox = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            txtEMail_Address.Text = "电子邮件地址........"; 
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtEMail_Address.ResetText();
        }

        private void plClose_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("确定要关闭该窗体吗？","消息提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (re == DialogResult.OK)
            {
                this.Close(); 
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmMain main = null;
            if (main == null || main.IsDisposed)
            {
                this.Hide();
                main = new FrmMain();
                main.Show();
            }

        }

        private void lklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogo logo = null;
            if (logo == null || logo.IsDisposed)
            {
                this.Hide();
                logo = new FrmLogo();
                logo.Show();
            }
        }



    }
}
