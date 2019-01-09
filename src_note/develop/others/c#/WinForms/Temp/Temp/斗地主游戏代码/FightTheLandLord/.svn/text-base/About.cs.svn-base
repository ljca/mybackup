using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FightTheLandLord
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.CreateNoWindow = false;
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.FileName = "iexplore";
            p.StartInfo.Arguments = "http://www.chuiniudi.cn";
            p.Start();
            p.Dispose();
        }
    }
}
