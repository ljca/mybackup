using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class FrmNotepad : Form
    {
        public FrmNotepad()
        {
            InitializeComponent();
        }

        private void FrmNotepad_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //创建文件流
            FileStream filestream = new FileStream(@"D:\" + txtauthor.Text + ".txt",FileMode.Create);
            
            //创建写入器
            StreamWriter writer = new StreamWriter(filestream);
            try
            {
                writer.Write("作者：" + this.txtauthor.Text + "\t" 
                    + "书名：" + this.txtBookName.Text + "\t" 
                    + "内容：" + this.txtDescription.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            writer.Close(); //关闭写入器
            filestream.Close(); //关闭文件流
            MessageBox.Show("写入成功！");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
