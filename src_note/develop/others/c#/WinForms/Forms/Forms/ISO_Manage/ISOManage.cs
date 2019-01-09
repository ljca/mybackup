using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.ISO_Manage
{
    public partial class ISOManage : Form
    {
        public ISOManage()
        {
            InitializeComponent();
        }

        private void Open_File_Click(object sender, EventArgs e)
        {

        }

        private void Samll_Icon_Click(object sender, EventArgs e)
        {

            this.LvComputer.View = View.SmallIcon;

        }

        private void Detail_Click(object sender, EventArgs e)
        {

            this.LvComputer.View = View.Details;

        }

        private void Tile_Click(object sender, EventArgs e)
        {
            this.LvComputer.View = View.Tile;

        }

        private void List_Click(object sender, EventArgs e)
        {
            this.LvComputer.View = View.List;
        }

        private void Large_Ico_Click(object sender, EventArgs e)
        {
            this.LvComputer.View = View.LargeIcon;

        }




    }
}
