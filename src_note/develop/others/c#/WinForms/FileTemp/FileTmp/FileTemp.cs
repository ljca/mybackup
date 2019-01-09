using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace FileTmp
{
    public class FileTemp
    {

        DirectoryInfo dir = null;
        /// <summary>
        /// 目录
        /// </summary>
        DirectoryInfo[] dirs = null;
        FileInfo file = null;
        /// <summary>
        /// 文件
        /// </summary>
        FileInfo[] files = null;

        FileSystemInfo[] filesanddir = null;

        /// <summary>
        /// 文件和目录的集合
        /// </summary>
        List<FileSystemInfo> filesanddirs = null;

        /// <summary>
        /// 获取文件和目录
        /// </summary>
        /// <returns></returns>
        public List<FileSystemInfo> GetFileAndDirectorys()
        {
            dir = new DirectoryInfo("I:\\");
            filesanddir = dir.GetFileSystemInfos();
            TreeNode rootnode = new TreeNode(@"I:\");
            rootnode.Nodes.Add(rootnode);
            foreach (FileSystemInfo item in filesanddir)
            {
                TreeNode node = rootnode.Nodes.Add(item.Name);
                filesanddirs = new List<FileSystemInfo>();
                filesanddirs.Add(item);
            }
            return filesanddirs;
        }


    }
}
