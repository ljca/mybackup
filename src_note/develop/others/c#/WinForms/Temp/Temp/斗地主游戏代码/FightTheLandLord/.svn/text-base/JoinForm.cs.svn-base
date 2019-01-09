using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace FightTheLandLord
{
    public partial class JoinForm : Form
    {
        public JoinForm()
        {
            InitializeComponent();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Any;
            if (IPAddress.TryParse(this.textBoxIP.Text, out ip))
            {
                Properties.Settings.Default.Host = this.textBoxIP.Text;
            }
            else
            {
                MessageBox.Show("请输入一个正确的IP", "错误");
            }
            string name = this.textBoxName.Text.Trim();
            if (name == "")
            {
                MessageBox.Show("请输入一个名字", "火拼斗地主");
            }
            else
            {
                Properties.Settings.Default.Name = name;
            }
            if (Properties.Settings.Default.Name != "" && Properties.Settings.Default.Host != "")
            {
                this.Close();
            }
        }
    }
}
