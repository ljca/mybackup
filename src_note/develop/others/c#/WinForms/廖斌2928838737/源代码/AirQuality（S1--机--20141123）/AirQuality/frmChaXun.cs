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

namespace AirQuality
{
    public partial class frmChaXun : Form
    {
        //用于暂存数据
        DataTable _dt = null;
        string _constring = @"server=.;database=AirQualityDB;uid=sa;pwd=power;";
        public frmChaXun()
        {
            InitializeComponent();
        }
       
        //查询所有的检测记录
        private void frmChaXun_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            try
            {
                //显示所有的
                //创建连接对象
                SqlConnection con = new SqlConnection(_constring);
                //创建操作对象
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("select AirQualityInfo.* ,StationInfo.StationName");
                sb.AppendLine("from AirQualityInfo,StationInfo");
                sb.AppendLine("where AirQualityInfo.StationID = StationInfo.StationID");
                SqlDataAdapter adp = new SqlDataAdapter(sb.ToString(), con);
                //打开链接(自动打开)
                //执行
                _dt = new DataTable();
                adp.Fill(_dt);
                //关闭连接（自动关闭）

                //显示到界面
                this.dgvData.DataSource = _dt.DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //模糊查找
        private void btnChaZhao_Click(object sender, EventArgs e)
        {
            try
            {
               //条件过来
                _dt.DefaultView.RowFilter = string.Format("InputName like '%{0}%'",this.txtInputNameSelect.Text);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        //关闭
        private void btnGuanBi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //修改
        private void tsmiXiuGai_Click(object sender, EventArgs e)
        {
            //创建修改窗口
            frmLuRu frmobj = new frmLuRu();
            //将dgv中当前选中数据，传递给修改窗口
            frmobj.StationName = this.dgvData.SelectedRows[0].Cells["StationName"].Value.ToString();
            frmobj.InputName = this.dgvData.SelectedRows[0].Cells["InputName"].Value.ToString();
            frmobj.StartDate = this.dgvData.SelectedRows[0].Cells["StartDate"].Value.ToString();
            frmobj.EndDate = this.dgvData.SelectedRows[0].Cells["EndDate"].Value.ToString();
            frmobj.PM = this.dgvData.SelectedRows[0].Cells["PM"].Value.ToString();
            frmobj.Level = this.dgvData.SelectedRows[0].Cells["Level"].Value.ToString();
            frmobj.Notes = this.dgvData.SelectedRows[0].Cells["Notes"].Value.ToString();
            frmobj.AirQualityID = this.dgvData.SelectedRows[0].Cells["AirQualityID"].Value.ToString();
            frmobj.StationID = this.dgvData.SelectedRows[0].Cells["StationID"].Value.ToString();

            frmobj.ShowDialog();
            //后续操作（刷新）----上面必须showdialog（）

            this.GetData();//调用创建加载时的代码，重新从数据库提取数据

        }
        //删除
        private void tsmiShanChu_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("您确定要删除吗？",
                                    "提示",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question,
                                    MessageBoxDefaultButton.Button2);
            if (result ==  System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    //创建连接对象
                    SqlConnection con = new SqlConnection(_constring);
                    //创建操作对象
                    string id = this.dgvData.SelectedRows[0].Cells["AirQualityID"].Value.ToString();//获取删除主键（当前被dgv隐藏）
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("delete from AirQualityInfo");
                    sb.AppendFormat("where AirQualityID = {0}", id);
                    SqlCommand cmd = new SqlCommand(sb.ToString(), con);
                    //打开链接
                    con.Open();
                    //执行
                    cmd.ExecuteNonQuery();
                    //关闭连接
                    con.Close();

                    //数据刷新
                    MessageBox.Show("数据删除成功！");
                    this.GetData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
    }
}
