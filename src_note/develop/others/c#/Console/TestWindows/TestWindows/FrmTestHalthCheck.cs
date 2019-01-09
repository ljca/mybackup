using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindows
{
    public partial class FrmTestHalthCheck : Form
    {
        public FrmTestHalthCheck()
        {
            InitializeComponent();
        }

        private void FrmTestHalthCheck_Load(object sender, EventArgs e)
        {
            HealthCheckItem hi = new HealthCheckItem();
            Dictionary<string, HealthCheckItem> dh = new Dictionary<string, HealthCheckItem>();
            dh[hi.Name].Name = "X";
            hi.hk = new HealthCheckItem();

            dh.Add(hi.Name, hi.hk);
            Console.WriteLine(hi.Name);

        }
    }
}
