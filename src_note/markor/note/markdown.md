<link href="../css/font-awesome.min.css" rel="stylesheet" type="text/css" />

<link href="../css/style.css" rel="stylesheet" type="text/css" />

<!--
<html>
<head>
<meta charset="utf-8">
-->

<a id="top"></a>

# Markdown 笔记

> Markdown 基础[^hm]可以参考阅读：

- [Markdown-Syntax-CN](md/Markdown-Syntax-CN.md)
- [LeaNote Markdown](http://leanote.leanote.com/post/Leanote-Markdown-Manual)
- [Cmder Markdown](https://www.zybuluo.com/mdeditor?url=https://www.zybuluo.com/static/editor/md-help.markdown)
- [StackEdit]
- [CSDN]。
- [……]

<div class="p">

<!--embed src="/storage/emulated/0/Music/纯音/红白巫女靈夢酱%20-%20CWTV中国气象频道%20-%20.国内城市逐6小时精细化天气预报.mp3" autostart="true" loop="true" controls></embed-->

</div>
<!--/head>

<body-->

### Markdown 字体样式对应的 HTML 标签

- <s>删除文本</s>｜<del>删除文本</del>
- <ins>插入文本</ins>｜<u>下划线文本</u>
- <b>加粗文字</b>｜<strong>强调文字</strong>
- <i>倾斜</i>｜<em>文本</em>
- <mark>mark</mark>
- 上标：H<sup>2</sup>O，下标：CO<sub>3</sub>
- <code>printf("stdout.\n");</code>
- 注音文字：<ruby>我<rt>wǒ</rt></ruby>

### 在 Markdown 文档中使用[图标字体：Font Awesome](http://www.fontawesome.com.cn/)

> Some Awesome Fonts——〉$ 

<i class="fa fa-book"></i>
<i class="fa fa-refresh"></i>
<i class="fa fa-code"></i>
<i class="fa fa-windows"></i>
<i class="fa fa-linux"></i>
<i class="fa fa-android"></i>
<i class="fa fa-weibo"></i>
<i class="fa fa-weixin"></i>
<i class="fa fa-car"></i>
<i class="fa fa-train"></i>
<i class="fa fa-bus"></i>
<i class="fa fa-search"></i>
<i class="fa fa-spinner"></i>
<i class="fa fa-star"></i>

<!--
<div class="p">

1.拷贝样式表到项目下（这是本地方式，如果路径位于网络，则不必如此）

2.如果调整了 fontawesome 目录结构，也需要跟着调整 font-awesome 字体位置，同时在样式表中也要调整字体路径（这不是必须的）。接着，导入样式表 `<link href="css/font-awesome.min.css" rel="stylesheet" type="text/css" />`，路径也可以是网络。

3.引用 `<i class="fa fa-book"></i>`

</div>
-->

> 更多参考：完整的矢量字体：[Font awesome](http://www.fontawesome.com.cn/cheatsheet/)，[大一点的](http://www.fontawesome.com.cn/icons-ui/) 以及 [设计师专用 3万多个](https://www.flaticon.com/packs)

<div STYLE="page-break-after: always;"></div>

> 音/视频<sub><span class="fzzy"><i class="fa fa-music"></i></sub>：夏婉安 - 暗夜精灵

<audio controls>
<source src="/storage/emulated/0/Music/流行/夏婉安%20-%20暗夜精灵.flac" type="audio/mpeg">
</audio>

```html
<video controls width="320" height="240">
<source src="/storage/emulated/0/Download/browser/「荣耀手环5」自定义手环教程%20自制表盘教程.mp4" type="video/mp4">
</video>
```

<div STYLE="page-break-after: always;"></div>

> HTML 阅读：

- [HTML 参考手册- (HTML5 标准)](https://www.runoob.com/tags/html-reference.html)
- [CSS 参考手册](https://www.runoob.com/cssref/css-reference.html)
- [简书：在 Markdown 注释](https://www.jianshu.com/p/c8a68f7d4832)。
- [rgb颜色对照表](http://tools.jb51.net/static/colorpicker/?ivk_sa=1021577i)
- [常用颜色表](http://www.ilikeseo.cn/wangzhanyingxiaozhishi_30.html)

> LaTax 阅读：

- [Markdown入门7-甘特图、标签分类、脚注、LaTeX 公式、加强的代码块](https://blog.csdn.net/cuishizun/article/details/80342072)
- [MarkDown 高级操作](https://blog.csdn.net/qq_39422642/article/details/78453376?utm_medium=distribute.wap_relevant.none-task-blog-BlogCommendFromBaidu-3.wap_blog_relevant_pic&depth_1-utm_source=distribute.wap_relevant.none-task-blog-BlogCommendFromBaidu-3.wap_blog_relevant_pic)
- [各种实体](https://blog.csdn.net/weixin_30873847/article/details/99598581?utm_medium=distribute.wap_relevant.none-task-blog-BlogCommendFromMachineLearnPai2-3.wap_blog_relevant_pic&depth_1-utm_source=distribute.wap_relevant.none-task-blog-BlogCommendFromMachineLearnPai2-3.wap_blog_relevant_pic)
- [非常详细的Markdown高级语法，最好用的文本编译！！！](https://blog.csdn.net/qq_44732742/article/details/106976312?utm_medium=distribute.wap_relevant.none-task-blog-BlogCommendFromBaidu-5.wap_blog_relevant_pic&depth_1-utm_source=distribute.wap_relevant.none-task-blog-BlogCommendFromBaidu-5.wap_blog_relevant_pic)
- 文字排版可以参考：[中文文案排版指北](https://github.com/mzlogin/chinese-copywriting-guidelines)

<div STYLE="page-break-after: always;"></div>

<div class="p">

PC 端有：[Typora](https://www.typora.io/)，[Tea](https://haocha.co/)，[VNote](https://github.com/vnotex/vnote)；Android 端有：[Markor](https://github.com/gsantner/markor)[^markor]，坚果云 Markdown[^坚果云]……。

</div>

<!--/body>
</html-->

> 注释

```markdown
[comment]: <> (这个最麻烦。)
[//]: # (不会显示的内容。)
[//]: <> (这个也是。)
[^_^]: # (这个最可爱。)
```

> 脚注分段：为了使脚注分段，脚注首段之后的每一个段落之前需要插入空行，并且在每个段落的首行之前需要插入4个空格符或者一个制表符。

```markdown
[^脚注]: 这是一段无意义的文字。

    第二段开始。
    ……

```

<div style="page-break-after: always;"></div>

分页：`<div style="page-break-after: always;"></div>`

<details>
<summary>
<span class="hwxk">23　孤独者要走的自我之路
</summary>

<div class="p">

<span class="hksnzt">迫使很多持不同看法的人改变他们的看法，因而他们对你不满。你接近他们，但是擦身而过，他们永远不会原谅你。

</div>

<i class="fa fa-quote-left fa-3x fa-pull-left fa-border" aria-hidden="true"></i><span class="wavy">你走在他们的前面，但你飞得越高，在忌妒的人眼里会变得越小，他们对在天空中翱翔的人深恶痛绝。

<div class="p">

<span class="pglh">“你们应该对我公平！”不，你应该说：“不招人妒是庸才，这些不公平待遇是因为我值得。” 

<span class="comment">他们给孤独者不公和侮辱，然而，我的兄弟，如果你想成为恒星，应该不计较地照耀他们！

<span class="jk">小心那些道德清道夫！他们想将那些自创道德标准的人钉在十字架上！</span><span class="translation">他们仇恨孤独者。

<span class="fzzy">也必须小心那些所谓的神圣者，在他们看来，凡是不单纯的都是邪恶的，此外，他们喜欢玩火，用此来处死异端。</span>
<span class="yy">小心防范那些爱你的人们！为你戴上打着爱的名义的镣铐。</span>

<!--a class="btn btn-danger" href="#top" aria-label="Delete"><i class="fa fa-long-arrow-up" aria-hidden="true" title="Delete this item?"></i></a-->

</div>
</details>

<details markdown='1'><summary>Admonition Extension</summary>

> Create block-styled side content.Use one of these qualifiers to select the icon and the block color: 

!!! warning 'Optional Title'
    abstract, summary, tldr, bug, danger, error, example, snippet, failure, fail, missing, question, help, faq, info, todo, note, seealso, quote, cite, success, check, done, tip, hint, important, warning, caution, attention.
Block-Styled Side Content with **Markdown support**

!!! info ''
    No-Heading Content

??? bug 'Collapsed by default'
    Collapsible Block-Styled Side Content

???+ example 'Open by default'
     Collapsible Block-Styled Side Content

[top](#top)

</details>

[^hm]: Markdown 兼容 HTML。迄今为止，大部分的 Markdown 解释器都会解释 Markdown 文档中嵌入的 HTML 标签。甚至一些版本较新的已经可以解析某些 HTML5 所增加的特性。但是 HTML 文档中的 Markdown 符号却是无效的。&copy;<a href="mailto:k_y_z_s@yeah.net">k_y_z_s@yeah.net</a>

[^markor]: 一个开源免费的 Android 端本地 Markdown 编辑、预览实现，在 F-Droid 或者它的 github 站点可以获取到它，不过写作此文时的版本（2.3.40）尚不支持云端、同步服务。
[^坚果云]: 支持云存储，但功能较少。
