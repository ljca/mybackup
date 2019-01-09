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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SE[] seList = new SE[3];
        private void Form1_Load(object sender, EventArgs e)
        {
            seList[0] = new SE() { Name ="潘越",Age = 18,No = 1,Descript="未评价"};
            seList[1] = new SE() { Name = "小潘潘", Age = 16, No = 2, Descript = "未评价" };
            seList[2] = new SE() { Name = "小奇奇", Age = 17, No = 3, Descript = "未评价" };
            AddSeToListView();//调用方法添加数据
        }

        public void AddSeToListView()
        {
            lvSE.Items.Clear();
            //循环数组并将员工信息添加到ListView
            foreach (SE se in seList)
            {
                //向ListView添加项
                ListViewItem lvi = lvSE.Items.Add(se.Name);
                lvi.Tag = se;
                lvi.SubItems.Add(se.No.ToString());//工号
                lvi.SubItems.Add(se.Age.ToString());//年龄
                lvi.SubItems.Add(se.Descript);//评价
                lvi.SubItems.Add(se.Score.ToString());//得分
            }
        }

        private void lvSE_DoubleClick(object sender, EventArgs e)
        {
            if (lvSE.SelectedItems[0].Tag != null)
            {
                SE se = (SE)lvSE.SelectedItems[0].Tag;
                Form2 frm = new Form2();
                //将要显示的数据对象传递过去
                frm.se = se;
                frm.parent = this;
                frm.Show();
            }
        }
    }
}
