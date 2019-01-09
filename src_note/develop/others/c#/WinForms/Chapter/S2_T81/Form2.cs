using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S2_T81
{
    public partial class Form2 : Form
    {
        public Form1 f1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblMainName.Text = f1.userName;
            
        }
    }
}
