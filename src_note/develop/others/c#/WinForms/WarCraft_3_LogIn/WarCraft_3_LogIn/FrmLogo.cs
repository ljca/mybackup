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
    public partial class FrmLogo : Form
    {
        public FrmLogo()
        {
            InitializeComponent();
        }

        private void FrmLogo_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
        }

    }
}
