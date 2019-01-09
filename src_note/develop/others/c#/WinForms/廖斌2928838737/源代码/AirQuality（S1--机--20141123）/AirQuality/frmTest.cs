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
    public partial class frmTest : Form
    {
        string constr = @"Data Source=.;Initial Catalog=AirQualityDB;Integrated Security=True";
        public frmTest()
        {
            InitializeComponent();
        }
        //查询 ----  datagridView
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //创建连接对象
                SqlConnection con = new SqlConnection(constr);
                //创建操作对象
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("SELECT   AirQualityInfo.AirQualityID, AirQualityInfo.InputName, ");
                sb.AppendLine("         AirQualityInfo.StartDate, AirQualityInfo.EndDate, AirQualityInfo.PM, ");
                sb.AppendLine("         AirQualityInfo.[Level], AirQualityInfo.Notes, StationInfo.StationName");
                sb.AppendLine("FROM     AirQualityInfo ");
                sb.AppendLine("INNER JOIN StationInfo ON AirQualityInfo.StationID = StationInfo.StationID");
                SqlDataAdapter adp = new SqlDataAdapter(sb.ToString(), con);
                //打开链接(自动打开)
                //执行操作
                DataSet ds = new DataSet();
                adp.Fill(ds,"MyTable");
                //关闭连接(自动关闭)

                //显示到界面
                this.dataGridView1.DataSource = ds.Tables["MyTable"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //查询 ---- combox
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //创建连接对象
                SqlConnection con = new SqlConnection(constr);
                //创建操作对象
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("select StationID,StationName");
                sb.AppendLine("from StationInfo");
                SqlDataAdapter adp = new SqlDataAdapter(sb.ToString(), con);
                //打开链接(自动打开)
                //执行操作
                DataSet ds = new DataSet();
                adp.Fill(ds, "MyTable");
                //关闭连接(自动关闭)

                //显示到界面
                this.comboBox1.DisplayMember = "StationName";//显示列
                this.comboBox1.ValueMember = "StationID";//隐藏的数据列--业务中需要
                this.comboBox1.DataSource = ds.Tables["MyTable"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //查询 ---- ListView
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //创建连接对象
                SqlConnection con = new SqlConnection(constr);
                //创建操作对象
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("SELECT   AirQualityInfo.AirQualityID, AirQualityInfo.InputName, ");
                sb.AppendLine("         AirQualityInfo.StartDate, AirQualityInfo.EndDate, AirQualityInfo.PM, ");
                sb.AppendLine("         AirQualityInfo.[Level], AirQualityInfo.Notes, StationInfo.StationName");
                sb.AppendLine("FROM     AirQualityInfo ");
                sb.AppendLine("INNER JOIN StationInfo ON AirQualityInfo.StationID = StationInfo.StationID");
                SqlCommand cmd = new SqlCommand(sb.ToString(), con);
                //打开链接
                con.Open();
                //执行操作
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())//循环提取每一行数据
                {
                    //显示一行
                    //创建listViewItem对象
                    ListViewItem lvi = new ListViewItem(dr["AirQualityID"].ToString());//第一列
                    //各属性赋值
                    lvi.SubItems.Add(dr["InputName"].ToString());//第二列
                    lvi.SubItems.Add(dr["StartDate"].ToString());//第三列
                    lvi.SubItems.Add(dr["EndDate"].ToString());
                    lvi.SubItems.Add(dr["Notes"].ToString());
                    //加入到ListView控件
                    this.listView1.Items.Add(lvi);
                }
                dr.Close();
                //关闭连接
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //查询 ---- textBox
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //创建连接对象
                SqlConnection con = new SqlConnection(constr);
                //创建操作对象
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("SELECT   AirQualityInfo.AirQualityID, AirQualityInfo.InputName, ");
                sb.AppendLine("         AirQualityInfo.StartDate, AirQualityInfo.EndDate, AirQualityInfo.PM, ");
                sb.AppendLine("         AirQualityInfo.[Level], AirQualityInfo.Notes, StationInfo.StationName");
                sb.AppendLine("FROM     AirQualityInfo ");
                sb.AppendLine("INNER JOIN StationInfo ON AirQualityInfo.StationID = StationInfo.StationID");
                SqlCommand cmd = new SqlCommand(sb.ToString(), con);
                //打开链接
                con.Open();
                //执行操作
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())//只提取每一行数据
                {
                    //显示一行
                    this.textBox1.Text = dr["AirQualityID"].ToString();
                    this.textBox2.Text = dr["InputName"].ToString();
                    this.textBox3.Text = dr["StartDate"].ToString();
                    this.textBox4.Text = dr["EndDate"].ToString();
                    this.textBox5.Text = dr["PM"].ToString();
                    this.textBox6.Text = dr["Level"].ToString();
           
                }
                dr.Close();
                //关闭连接
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //combox选择改变时
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //显示值
            this.textBox7.Text = this.comboBox1.Text;
            //数据值
            this.textBox8.Text = this.comboBox1.SelectedValue.ToString();

        }
    }
}
