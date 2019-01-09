using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Rss
{
    public partial class Form1 : CCSkinMain

    {
        private List<RssItem> currentList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //创建对象
            XmlDocument xml = new XmlDocument();
            //加载文档
            xml.Load("rss.xml");
            //获取根节点
            XmlNode root = xml.DocumentElement;
            //遍历并将数据添加到treeview上
            foreach (XmlNode site in root.ChildNodes)
            {//获取到site数据
                string siteName = site["name"].InnerText;
                //添加网站节点
                TreeNode siteNode = tvRssList.Nodes.Add(siteName);
                XmlNode rssList = site["list"];
                foreach (XmlNode rss in rssList.ChildNodes)
                {
                    string rssName = rss["name"].InnerText;
                    string rssUrl = rss["url"].InnerText;
                    TreeNode rssNode = siteNode.Nodes.Add(rssName);
                    //使用tag属性保存url数据
                    rssNode.Tag = rssUrl;
                }
            }
        }

        private void tvRssList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selected = tvRssList.SelectedNode;
            if (selected.Level == 1 && selected.Tag != null)
            {
                string url = selected.Tag.ToString();
                fetchRssNews(url);
            }
        }
        /// <summary>
        /// 解析rss新闻
        /// </summary>
        /// <param name="url"></param>
        private void fetchRssNews(string url)
        {
            try
            {
                //创建对象
                XmlDocument xml = new XmlDocument();
                //加载文档
                xml.Load(url);
                //获取根节点
                XmlNode root = xml.DocumentElement;
                List<RssItem> rssList = new List<RssItem>();
                //遍历并将数据添加到treeview上
                foreach (XmlNode item in root["channel"].ChildNodes)
                {
                    //判断该节点是否是item
                    if (item.Name.ToLower() == "item")
                    {//开始解析Rss新闻
                        RssItem rssItem = new RssItem();//实例化一个rss
                        rssItem.Title = item["title"].InnerText;
                        rssItem.Link = item["link"].InnerText;
                        rssItem.PubDate = item["pubDate"].InnerText;
                        rssItem.Description = item["description"].InnerText;
                        rssList.Add(rssItem);//将rss对象添加到集合
                    }
                }
                currentList = rssList;
                dgvNews.DataSource = new BindingList<RssItem>(rssList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载RSS内容失败:" + ex.Message);

            }
        }

        private void dgvNews_DoubleClick(object sender, EventArgs e)
        {
            int rowIndex = this.dgvNews.CurrentCell.RowIndex;
            new Reader(this.currentList[rowIndex]).ShowDialog();

        }


    }
}
