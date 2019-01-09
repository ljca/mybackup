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

namespace MyKTV.ManageForms
{
    public partial class FrmSearchSinger : Form
    {
        public FrmSearchSinger()
        {
            InitializeComponent();
        }

        string sql = @"select singer_name,singer_sex,singertype_name from singer_info as b,singer_type as a
where a.singertype_id = b.singertype_id";
        
        /// <summary>
        /// 窗体初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSingerList_Load(object sender, EventArgs e)
        {
            #region 
            //FrmAdmin.admin.Init();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AcceptButton = this.btnSearch;
            this.MdiParent = MyKTV.ManageForms.FrmAdmin.admin;
            this.ShowInTaskbar = false;
            this.ForeColor = Color.Blue;
            this.cboSingerType.ForeColor = Color.Blue;
            this.dgvSearchSinger.ForeColor = Color.Blue;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.dgvSearchSinger.AutoGenerateColumns = false;
            this.dgvSearchSinger.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            #endregion
            //SearchSinger();
            FillData();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!this.txtSingerName.Text.Trim().Equals(string.Empty))
            {
                string sql = string.Format(@"select singer_name,singertype_name,singer_sex
from singer_info as a 
inner join singer_type as b on b.singertype_id = a.singertype_id
where singer_name like '%{0}%' and singertype_name = '{1}' ",this.txtSingerName.Text.Trim(),this.cboSingerType.Text.ToString());
                SearchSinger(sql);
                if(!SearchSinger(sql))
                {
                    MessageBox.Show("未搜索到该歌手！");
                }
            }
            else
            {
                MessageBox.Show("歌手名为空！");
                SearchSinger(this.sql);
            }
        }

        #region　其他方法

        /// <summary>
        /// 填充数据
        /// </summary>
        public bool FillData()
        {
            string sql = "select * from [singer_type]";
            try
            {
                DBHelper.ds = new DataSet("singer_type");
                DBHelper.da = new System.Data.SqlClient.SqlDataAdapter(sql, DBHelper.constr);
                DBHelper.da.Fill(DBHelper.ds, "singer_type");
                this.cboSingerType.ValueMember = "singertype_id";
                this.cboSingerType.DisplayMember = "singertype_name";
                this.cboSingerType.DataSource = DBHelper.ds.Tables["singer_type"];
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        /// <summary>
        /// 搜索歌手
        /// </summary>
        public bool SearchSinger(string strsql)
        {
            try
            {
                DBHelper.ds = new DataSet("singer_info");
                DBHelper.da = new SqlDataAdapter(strsql, DBHelper.constr);
                if (DBHelper.ds.Tables["singer_info"] != null)
                {
                    DBHelper.ds.Tables["singer_info"].Clear();
                }

                DBHelper.da.Fill(DBHelper.ds, "singer_info");
                this.dgvSearchSinger.DataSource = DBHelper.ds.Tables["singer_info"];
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        #endregion

        private void tsmsEdit_Click(object sender, EventArgs e)
        {
            if(SingerInfo())
            {
                KTVUtil.AddSingerOfWindows();
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// 传递歌手信息！
        /// </summary>
        /// <returns></returns>
        private bool SingerInfo()
        {
            if(dgvSearchSinger.SelectedRows.Count == 1)
            {
                FrmAddSinger singer = new FrmAddSinger();
              FrmAddSinger.SingerName = this.dgvSearchSinger.SelectedRows[0].Cells["SingerName"].Value.ToString();
               FrmAddSinger.SingerSex = this.dgvSearchSinger.SelectedRows[0].Cells["SingerSex"].Value.ToString();
                
                FrmAddSinger.SingerType = this.dgvSearchSinger.SelectedRows[0].Cells["SingerType"].Value.ToString();
                return true;
            }
            else
            {
                MessageBox.Show("不允许同时修改多行数据！","系统提示！");
                return false;
            }
        }
    }
}
