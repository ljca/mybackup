using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class ShowPicture : Form
    {
        public ShowPicture()
        {
            InitializeComponent();
        }

        private void ShowPicture_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;
            this.ShowIcon = false;
            this.ofdShow.FileName = null;
            this.ofdShow.InitialDirectory = "D:\\";
            this.ofdShow.Filter = @"图片文件(*.jpg,*.png,*.jpge)|*.jpg;*.png;*.jpeg";

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
           
            if(this.ofdShow.ShowDialog() == DialogResult.OK)
            {
                this.pbSinger.Image = Image.FromFile(this.ofdShow.FileName);
                //this.pbSinger.ImageLocation = this.ofdShow.FileName;
            }
        }
    }
}
