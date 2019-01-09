using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKTV.ManageForms
{
    public partial class FrmAddSinger : Form
    {
        public FrmAddSinger()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 歌手姓名！
        /// </summary>
        public static string SingerName = "";
        /// <summary>
        /// 歌手性别！
        /// </summary>
        public static string SingerSex = "";
        /// <summary>
        /// 歌手类别！
        /// </summary>
        public static string SingerType = "";
        /// <summary>
        /// 歌手描述！
        /// </summary>
        public static string Discribe = "";
        /// <summary>
        /// 窗体初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAddSinger_Load(object sender, EventArgs e)
        {
            #region
            //FrmAdmin.admin.Init();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MdiParent = MyKTV.ManageForms.FrmAdmin.admin;
            this.ShowInTaskbar = false;
            this.ForeColor = Color.Blue;
            this.txtDescribe.ForeColor = Color.Blue;
            this.txtName.ForeColor = Color.Blue;
            this.cboSingerType.ForeColor = Color.Blue;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            #endregion
            #region 
            this.txtName.Text = SingerName;
            this.cboSingerType.Text = SingerType;
            #endregion
            FillData();
            CheckValue(SingerSex);
        }

        #region 按钮事件
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SelectPicture();
        }

        private void btnAddsinger_Click(object sender, EventArgs e)
        {
            if (InsertSinger() == 1)
            {
                MessageBox.Show("Success!");
                this.Close();
            }
        }


        /// <summary>
        /// 关闭窗体
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region 其他方法！


        /// <summary>
        /// 填充数据
        /// </summary>
        public void FillData()
        {
            string sql = "select * from [singer_type]";
            DBHelper.ds = new DataSet("singer_type");
            DBHelper.da = DBHelper.GetDa(sql);
            DBHelper.da.Fill(DBHelper.ds, "singer_type");
            this.cboSingerType.DataSource = DBHelper.ds.Tables["singer_type"];
            this.cboSingerType.ValueMember = "singertype_id";
            this.cboSingerType.DisplayMember = "singertype_name";
        }


        /// <summary>
        /// 选择图片！
        /// </summary>
        private string SelectPicture()
        {
                this.ofdPicture.FileName = null;
                this.ofdPicture.Title = "请选择图片：";
                this.ofdPicture.InitialDirectory = "E:\\";
                this.ofdPicture.Filter = "图片文件(*.jpg;*.png;*.jpge;*.bmp)|*.jpg;*.png;*.jpge;*.bmp|其他文件(*.ico)|*.ico";
                this.ofdPicture.FilterIndex = 1;
                this.ofdPicture.Multiselect = false;
                if (ofdPicture.ShowDialog() == DialogResult.OK)
                {
                    this.pbSingerPic.Image = Image.FromFile(ofdPicture.FileName);
                    return ofdPicture.FileName;
                }
            
            return null;

        }

        #region 非空验证！

        /// <summary>
        /// 非空验证！
        /// </summary>
        /// <returns></returns>
        private bool CheckNotNull()
        {
            if (!this.txtDescribe.Text.Trim().Equals(string.Empty)
                && !this.txtName.Text.Trim().Equals(string.Empty))
            {
                return true;
            }
            else if (this.txtDescribe.Text.Trim().Equals(string.Empty)
                || this.txtName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("添加失败！\n歌手姓名或者描述可能为空！", "添加提示！");
                this.txtName.ResetText();
                this.txtDescribe.ResetText();
                this.txtName.Focus();
                return false;
            }
            //else if (this.pbSingerPic.CanSelect)
            //{
            //    MessageBox.Show("歌手图片可能尚未选择！\n\n请选择图片！");
            //    SelectPicture();
            //    return false;
            //}
            return false;
        }

        #endregion

        #region 添加歌手数据
        /// <summary>
        /// 插入数据！
        /// </summary>
        /// <returns>成功返回true </returns>
        public int InsertSinger()
        {
            if (CheckNotNull())
            {
                DBHelper.sql = string.Format(@"insert into [singer_info](singer_name,singer_sex,singer_photo_url,singertype_id)
values('{0}','{1}','{2}',{3})", this.txtName.Text, SelectRbo(),
 SelectPicture(),cboIndex());
                try
                {
                    DBHelper.OpenCon();
                    DBHelper.cm = new System.Data.SqlClient.SqlCommand(DBHelper.sql, DBHelper.Cn);
                    if (DBHelper.cm.ExecuteNonQuery() != 0)
                    {
                        return DBHelper.cm.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return -1;
                    throw;
                }
                finally
                {
                    DBHelper.CloseCon();
                }
            }
            return 0;
        }
        #endregion

        #region 获取选中单选按钮上的值
        /// <summary>
        /// 获取选中单选按钮上的值
        /// </summary>
        /// <returns>返回选中单选按钮上的值</returns>
        public string SelectRbo()
        {
            if(this.rboMail.Checked)
            {
                return this.rboMail.Text.ToString();
            }
            else if(this.rboFMail.Checked)
            {
                return this.rboFMail.Text.ToString();
            }
            else if(this.rboCompose.Checked)
            {
                return this.rboCompose.Text.ToString();
            }
            return null;
        }

        #endregion

        #region 获取下拉列表上索引
        /// <summary>
        /// 获取下拉列表项的索引！
        /// </summary>
        /// <returns>索引！</returns>
        
        public int cboIndex()
        {
            if(this.cboSingerType.Text == "大陆")
            {
                return 1;
            }
            else if(this.cboSingerType.Text == "欧美")
            {
                return 2;
            }
            else if (this.cboSingerType.Text == "日韩")
            {
                return 3;
            }
            else if (this.cboSingerType.Text == "港台")
            {
                return 4;
            }
            return 0;
        }

        #endregion

        /// <summary>
        /// 传递选中状态！
        /// </summary>
        /// <param name="SingerSex"></param>
        public void CheckValue(string SingerSex)
        {
            if(SingerType == "男")
            {
                this.rboMail.Select();
            }
            else if (SingerType == "女")
            {
                this.rboFMail.Select();
            }
            else if (SingerType == "组合")
            {
                this.rboCompose.Select();
            }
           
        }

        #endregion
    }
}
