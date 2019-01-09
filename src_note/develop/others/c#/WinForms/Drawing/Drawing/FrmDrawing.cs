using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class FrmDrawing : Form
    {
        public FrmDrawing()
        {
            InitializeComponent();
        }

        private void FrmDrawing_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {

        }



        private void pnlpic_Paint(object sender, PaintEventArgs e)
        {
            Graphics q = this.pnlpic.CreateGraphics();
            Pen p = new Pen(Color.Red, 3);
            Rectangle rec = new Rectangle(40, 46, 268, 257);
            q.DrawEllipse(p, rec);
            this.pnlpic.Invalidate();
        }


    }
}
