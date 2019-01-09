using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MainSearch
{
    public partial class MainSearch : Form
    {
        public MainSearch()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 用于连接数据库MyKTV的连接字符串！
        /// </summary>
        public static string strcon = @"Data Source=YLHHGG\MYSQL;Initial Catalog=MyKTV;Integrated Security=True";

        /// <summary>
        /// 数据适配器对象！
        /// </summary>
        SqlDataAdapter da = null;

        /// <summary>
        /// 数据集对象！
        /// </summary>
        DataSet ds = null;

        /// <summary>
        /// 数据视图对象！
        /// </summary>
        DataView dv = null;

        /// <summary>
        /// 数据表对象！
        /// </summary>
        DataTable dt = null;

        private void MainSearch_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            this.ForeColor = Color.Blue;
            //IsMdiContainer = true;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                string sql = string.Format(@"select a.song_name,b.singer_name,c.songtype_name,a.song_ab,a.song_url 
from song_info as a 
inner join singer_info as b on(b.singer_id = a.singer_id)
inner join song_type as c on(c.songtype_id = a.songtype_id)
where a.song_name like '%{0}%' ",txtName.Text);

                Search(sql);
            }

            else
            {
                MessageBox.Show("条件不能为空！","系统提示！");
            }
        }

       /// <summary>
       /// 根据条件查询数据！
       /// </summary>
       /// <param name="sql"></param>
       /// <returns></returns>
        
        public bool Search(string sql)
        {
            try
            {
                dt = new DataTable("song_info");
                da = new SqlDataAdapter(sql, strcon);
                
               // dt.DefaultView.RowFilter = string.Format(@"a.song_name like '%{0}%' ", txtName.Text);
                if(dt != null)
                {
                    dt.Clear();
                }

                da.Fill(dt);
                this.dgvShowInfo.DataSource = dt;
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                //throw;
            }

        }

        private void cmsiRevise_Click(object sender, EventArgs e)
        {
            FrmShowM show = null;
            if(show == null || show.IsDisposed)
            {
               Showb();
                show = new FrmShowM();
                //show.MdiParent = this;
                show.ShowDialog(this);
                
            }
        }


        /// <summary>
        /// 传值操作！
        /// </summary>
        /// <returns></returns>
        private bool Showb()
        {
            //如果选中了一行则执行传值操作！
            if (dgvShowInfo.SelectedRows.Count == 1)
            {
                FrmShowM.SongName = dgvShowInfo.SelectedRows[0].Cells["song_name"].Value.ToString();
                FrmShowM.SingerName = dgvShowInfo.SelectedRows[0].Cells["singer_name"].Value.ToString();
                FrmShowM.SongType = dgvShowInfo.SelectedRows[0].Cells["songtype_name"].Value.ToString();
                FrmShowM.SongAb = dgvShowInfo.SelectedRows[0].Cells["song_ab"].Value.ToString();
                FrmShowM.SongUrl = dgvShowInfo.SelectedRows[0].Cells["song_url"].Value.ToString();
                return true;

            }
            return false;
        }

  }
}

