<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# pandoc 使用笔记

<div class="p">

从 [博客页](https://blog.csdn.net/xzy565143480/article/details/115108874?utm_medium=distribute.pc_aggpage_search_result.none-task-blog-2~aggregatepage~first_rank_v2~rank_aggregation-2-115108874.pc_agg_rank_aggregation&utm_term=pandoc%E6%95%99%E7%A8%8B&spm=1000.2123.3001.4430) 了解到，pandoc[^pandoc] 原生支持脚注，不必另行转换配置过滤器[^过滤器]。pandoc 支持调用多种工具转换文件到 pdf，但这些工具必须先行安装到系统中。

以下使用 wkhtmltopdf[^wkhtmltopdf] 将 markdown 转换成 pdf：`pandoc -f markdown -t pdf --pdf-engine=wkhtmltopdf --metadata title="Grub 笔记"  -N --toc -o ~/grub.pdf grub.md`

</div>

<div class="p">

为了将多个文件合并转换，可以在命令行中使用正则表达式指定多个输入文件。合并转换多个 html 到 pdf： `pandoc --toc -N --pdf-engine=wkhtmltopdf -f html -t pdf  -o ../tmp.pdf  *.html`

</div>

[^wkhtmltopdf]: 这个工具需要自行准备然后将它放到合适的位置并添加安装路径到系统 PATH 环境变量，当然，也可以安装系统软件源里的，这多少会缺少一些功能。
[^过滤器]: 一些稍微高级点的功能可能需要用到。
[^pandoc]: pandoc 支持多种文档格式互相转换。类似的转换工具还有 gitbook，功能少些。图形界面的 calibre 支持阅读、转换 epub 等格式的其它转换选项。
[^_^]: 我们可以直接使用 wkhtmltopdf 将 html 转换到 pdf。但是，这需要将 markdown 文档先行转换成 html 文档。很明显，pandoc 功能更多更完善。

## 附：

+ [Pandoc   a universal document converter](https://pandoc.org/)
+ [关于用 pandoc 制作带弹出式注释的 EPUB 和 MOBI 电子书](http://fromwiz.com/share/s/2yNneO1LOQap2-bdmA21_AH12-kyXg1YMABU2rGeUT14mwnz)。
+ [Pandoc：一个超级强大的文档格式转换工具](https://tonydong.blog.csdn.net/article/details/108536784?utm_term=pandoc%E6%95%99%E7%A8%8B&utm_medium=distribute.pc_aggpage_search_result.none-task-blog-2~all~sobaiduweb~default-1-108536784&spm=3001.4430)
+ [使用 Pandoc 将你的书转换成网页和电子书](https://linux.cn/article-10287-1.html?utm_source=weixin)
+ [Turn your book into a website and an ePub using Pandoc](https://opensource.com/article/18/10/book-to-website-epub-using-pandoc)
+ [在命令行使用 Pandoc 进行文件转换](https://linux.cn/article-10228-1-rel.html)

