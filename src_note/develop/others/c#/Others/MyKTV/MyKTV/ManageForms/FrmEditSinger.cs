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
    public partial class FrmEditSinger : Form
    {
        public FrmEditSinger()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEditSinger_Load(object sender, EventArgs e)
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
            FillData();
        }

        #region 按钮事件
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SelectPicture();

        }

        private void btnAddsinger_Click(object sender, EventArgs e)
        {
            if (Update())
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
            DBHelper.da = new System.Data.SqlClient.SqlDataAdapter(sql, DBHelper.constr);
            DBHelper.da.Fill(DBHelper.ds, "singer_type");
            this.cboSingerType.ValueMember = "singertype_id";
            this.cboSingerType.DisplayMember = "singertype_name";
            this.cboSingerType.DataSource = DBHelper.ds.Tables["singer_type"];
        }


        /// <summary>
        /// 选择图片！
        /// </summary>
        private Image SelectPicture()
        {
            if (this.pbSingerPic != null)
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
                    return Image.FromFile(ofdPicture.FileName);
                }
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
                && !this.txtName.Text.Trim().Equals(string.Empty)
                && !this.pbSingerPic.CanSelect)
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
            else if (this.pbSingerPic.CanSelect)
            {
                MessageBox.Show("歌手图片可能尚未选择！\n\n请选择图片！");
                SelectPicture();
                return false;
            }
            return false;
        }

        #endregion


        /// <summary>
        /// 更新数据！
        /// </summary>
        /// <returns>成功返回true </returns>
        public bool Update()
        {
            if(CheckNotNull())
            {
                string sql = "select * from [singer_info]";
                DBHelper.ds = new DataSet("singer_info");
                DBHelper.da = new System.Data.SqlClient.SqlDataAdapter(sql, DBHelper.constr);
                DBHelper.builder = new System.Data.SqlClient.SqlCommandBuilder(DBHelper.da);

                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
