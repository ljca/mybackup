using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MiniBook
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 判断当前文字是否改变
        /// </summary>
        bool isChanged = false;

        string selectedFIleName = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            string filePath = Application.StartupPath;
            DirectoryInfo directoryInfo = new DirectoryInfo(filePath);
            FileInfo[] fInfo = directoryInfo.GetFiles();
            foreach (FileInfo f in fInfo)
            {
                if (f.Extension == ".txt")
                {
                    TreeNode node = new TreeNode();
                    node.Tag = f.FullName;
                    node.Text = f.Name.Substring(0, f.Name.LastIndexOf("."));
                    this.tvList.Nodes.Add(node);
                }
            }
        }

        private void tvList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Index != 0)
            {
                //避免this.Text = selectedFIleName这行代码 触发TextChanged事件，导致关闭窗体时的提示
                this.txtNotepad.TextChanged -= new System.EventHandler(this.txtNotepad_TextChanged);
                string content = FileManager.OpenFile(e.Node.Tag.ToString());
                this.txtNotepad.Text = content;
                this.selectedFIleName = e.Node.Tag.ToString();
                this.Text = selectedFIleName;
                //重新进行事件绑定
                this.txtNotepad.TextChanged += new System.EventHandler(this.txtNotepad_TextChanged);
            }
        }



        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();

        }
        /// <summary>
        /// 弹出文件保存窗口进行保存。
        /// </summary>
        private void save()
        {
            //保存名称：年月日，时分秒
            string str = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss");
            bool retV = FileManager.SaveFile(Application.StartupPath+"\\"+str+".txt", this.txtNotepad.Text);
            if (!retV)
            {
                MessageBox.Show("文件保存失败！");
            }
            else
            {
                this.isChanged = false;
            }

        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.isChanged)
            {
                DialogResult dr =
                MessageBox.Show("文件内容已经改变，是否保存？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    if (selectedFIleName == "")
                    {
                        save();
                    }
                    else
                    {
                        FileManager.SaveFile(selectedFIleName, this.txtNotepad.Text);
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void txtNotepad_TextChanged(object sender, EventArgs e)
        {
            this.isChanged = true;
            this.Text = this.selectedFIleName + "*";
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedFIleName = "";
            this.txtNotepad.Text = "";
        }
    }
}
