using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_work
{
    public partial class Form2 : Form
    {

        /// <summary>
        /// 要展示数据的员工对象
        /// </summary>
        public SE se;

        /// <summary>
        /// 要操作的父级对象
        /// </summary>
        public Form1 parent;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtName.Text = se.Name;
            txtDescript.Text = se.Descript;
            txtScore.Text = se.Score.ToString();
        }
        PM pm = new PM();

        private void button1_Click(object sender, EventArgs e)
        {
            //经理评分
            pm.Judge(se, txtDescript.Text, Convert.ToInt32(txtScore.Text));
            parent.AddSeToListView();
            this.Close();
        }
    }
}
