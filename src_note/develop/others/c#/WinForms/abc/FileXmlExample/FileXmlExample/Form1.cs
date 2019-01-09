using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileXmlExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FileStream
            //StreamReader:ReadToEnd,ReadLine
            //StreamWriter:Write,WriteLine
            
            string note = txtNote.Text;//获得文本框内容
            //获取文件流
            FileStream fs = new FileStream("D:/abc/a.txt", FileMode.Create);
            //
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(note);//写入文件
            //关闭流
            sw.Close();
            fs.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("D:/abc/a.txt"))
            {
                //
                FileStream fs = new FileStream("D:/abc/a.txt", FileMode.Open);
                ///
                StreamReader sr = new StreamReader(fs);
                txtNote.Text = sr.ReadToEnd();
                //
                sr.Close();
                fs.Close();
            }
        }
    }
}
