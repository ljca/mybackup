using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rss
{
    public partial class Reader : CCSkinMain

    {
        RssItem readRss = null;
        public Reader(RssItem rss)
        {
            InitializeComponent();
            this.readRss = rss;
        }
        private void Reader_Load(object sender, EventArgs e)
        {
            if (this.readRss != null)
            {
                this.lblTitle.Text = this.readRss.Title;
                this.txtDesciption.Text = this.readRss.Description;
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.readRss != null)
            {
                Process.Start(this.readRss.Link);
            }

        }


    }
}
