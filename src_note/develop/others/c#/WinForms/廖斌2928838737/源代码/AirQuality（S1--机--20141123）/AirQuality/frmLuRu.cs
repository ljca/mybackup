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
    public partial class frmLuRu : Form
    {
        string constring = "server=.;database=AirQualityDB;uid=sa;pwd=power;";
        public frmLuRu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //清空所有
        private void btnQingKong_Click(object sender, EventArgs e)
        {
            //方式一：逐一清空
            this.txtEndDate.Clear();
            this.txtInputName.Text = "";
            this.txtLevel.Text = "";
            this.txtNotes.Text = "";
            this.txtPM.Text = "";
            this.txtStartDate.Text = "";
            //方式二：使用循环遍历
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    //完成清空操作
                    item.Text = "";
                    //((TextBox)item).Clear();
                }
            }

        }
        //关闭
        private void btnGuanBi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //提交
        private void btnTiJiao_Click(object sender, EventArgs e)
        {
            //校验用户录入数据是否完整
            if (this.cboStationID.Text == "" ||
                this.txtEndDate.Text.Length == 0 ||
                this.txtInputName.Text.Length < 1 ||
                string.IsNullOrEmpty(this.txtLevel.Text)||
                this.txtNotes.Text == string.Empty ||
                this.txtPM.Text == "" ||
                this.txtStartDate.Text == "" )
            {
                MessageBox.Show("所有信息均不能为空！请完善!");
                return;
            }
            //再提交到数据库
            try
            {
                //创建数据库连接对象
                SqlConnection con = new SqlConnection(constring);
                //创建操作对象
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("UPDATE  AirQualityInfo");
                sb.AppendFormat("SET     StationID = '{0}',",this.cboStationID.SelectedValue);
                sb.AppendFormat("		InputName = N'{0}', ",this.txtInputName.Text);
                sb.AppendFormat("		StartDate = '{0}', ",this.txtStartDate.Text);
                sb.AppendFormat("		EndDate = '{0}', ",this.txtEndDate.Text);
                sb.AppendFormat("		PM = '{0}', ",this.txtPM.Text);
                sb.AppendFormat("		[Level] = '{0}', ",this.txtLevel.Text);
                sb.AppendFormat("		Notes = N'{0}'",this.txtNotes.Text);
                sb.AppendFormat("where AirQualityID = {0}", this.AirQualityID);
                SqlCommand cmd = new SqlCommand(sb.ToString(), con);
                //打开链接
                con.Open();
                //执行
                cmd.ExecuteNonQuery();
                //关闭连接
                con.Close();

                //提示
                MessageBox.Show("数据已经成功保存！","操作提示");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("数据库操作失败！");
            }

        }
        //查询，所有的检测站信息
        private void frmLuRu_Load(object sender, EventArgs e)
        {
            //从数据库中，提前站点信息，并绑定combox
            this.LoadStationInfo();

            //直接显示，传入数据
            this.txtEndDate.Text = this.EndDate;
            this.txtInputName.Text = this.InputName;
            this.txtLevel.Text = this.Level;
            this.txtNotes.Text = this.Notes;
            this.txtPM.Text = this.PM;
            this.txtStartDate.Text = this.StartDate;
            //给combox赋值的两种方式：
            this.cboStationID.Text = this.StationName;
           // this.cboStationID.SelectedValue = this.StationID;
        }

        private void LoadStationInfo()
        {
            try
            {
                //创建连接对象
                SqlConnection con = new SqlConnection(constring);
                //创建操作对象
                SqlDataAdapter adp = 
                    new SqlDataAdapter("select StationID,StationName  from StationInfo", con);
                //打开链接
                //执行
                DataTable dt = new DataTable();
                adp.Fill(dt);
                //关闭连接

                //绑定到界面
                this.cboStationID.DisplayMember = "StationName";
                this.cboStationID.ValueMember = "StationID";
                this.cboStationID.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        public string StationName { get; set; }

        public string InputName { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public string PM { get; set; }

        public string Level { get; set; }

        public string Notes { get; set; }

        public string AirQualityID { get; set; }  //传入的主键

        public string StationID { get; set; }

        
    }
}
