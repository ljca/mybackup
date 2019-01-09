using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileTmp;

namespace FileTemp
{
    public partial class FrmFileTemp : Form
    {
        public FrmFileTemp()
        {
            InitializeComponent();
        }

        private void FrmFileTemp_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            FileTmp.FileTemp fis = new FileTmp.FileTemp();
            fis.GetFileAndDirectorys();
        }
    }
}
