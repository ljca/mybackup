using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmTestWinfoms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 保存SE对象
        /// </summary>
        public List<SE> selist = new List<SE>();

        private void FrmTestWinForms_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            dgvTest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgvTest.AutoGenerateColumns = false;
            TempList ls = new TempList();
            ls.AddSe();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }


        private void tsbtnSelect_Click(object sender, EventArgs e)
        {
            FrmAddForms addse = null;
            if (addse == null || addse.IsDisposed)
            {
                addse = new FrmAddForms();
                addse.ShowDialog();
            }

        }


        /// <summary>
        /// 绑定数据
        /// </summary>
        /// <param name="templist"></param>
        public void BindGird(List<SE> templist)
        {
            this.dgvTest.DataSource = new BindingList<SE>(templist);
        }

    }
}
