using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MediaBLL
{
    public class MediaService
    {
        /// <summary>
        /// 保存流媒体路径的集合
        /// </summary>
        public List<string> pathlist = new List<string>();


        public TreeNode node1 = null;

        public TreeNode node2 = null;

        /// <summary>
        /// 寻找流媒体路径
        /// </summary>
        public void AddMedia()
        {
            XmlDocument xmltemp = new XmlDocument();
            xmltemp.Load(@".\..\..\temp.xml");
            XmlNode tempnode = xmltemp.DocumentElement;
            node1 = new TreeNode(tempnode.Attributes["Name"].Value);
            node2 = new TreeNode(tempnode.Attributes["SL"].Value);
            foreach (XmlNode item in tempnode.ChildNodes)
            {
                TreeNode nodes = new TreeNode(item.Attributes["Name"].Value);
                node2.Nodes.Add(nodes);
                foreach (XmlNode tmpnode in item.ChildNodes)
                {
                    nodes.Nodes.Add(tmpnode.InnerText);
                    pathlist.Add(tmpnode.Attributes["url"].Value);
                }
            }

        }
    }
}
