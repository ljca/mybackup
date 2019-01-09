using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chearcs
{
    public partial class FormsAdmi : Form
    {
        public FormsAdmi()
        {
            InitializeComponent();
        }

       

        private void tM_1_Click(object sender, EventArgs e)
        {
            this.lvC.View = View.LargeIcon;

        }

        private void tM_2_Click(object sender, EventArgs e)
        {
            this.lvC.View = View.SmallIcon;
        }

        private void tM_3_Click(object sender, EventArgs e)
        {
            this.lvC.View = View.Tile;
        }

        private void tM_4_Click(object sender, EventArgs e)
        {
            this.lvC.View = View.Details;
        }

        private void tM_5_Click(object sender, EventArgs e)
        {
            this.lvC.View = View.List;
        }

        private void FormsAdmi_Load(object sender, EventArgs e)
        {

            ListViewItem itemC = new ListViewItem("X盘",1);
          
            itemC.SubItems.Add("200M");
            itemC.SubItems.Add("X");
            itemC.SubItems.Add("system.img");
            itemC.SubItems.Add("*.bat");
            itemC.SubItems.Add("1.8G");
          
            lvC.Items.Add(itemC);

        }




    }
}
