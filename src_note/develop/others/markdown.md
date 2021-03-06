# Markdown 笔记
据我所知，支持 Markdown 的在线编辑器有：

- [StackEdit](https://stackedit.io/editor)
- [markable.in](https://markable.in/editor/)
- [简书](https://www.jianshu.com)
- [CSDN-博客](https://blog.csdn.net)
- [cnblog](https://www.cnblog.com)
- [开源中国博客](https://www.oschina.net/blog)
- [蚂蚁笔记](https://www.leanote.com)
- [Cmd Markdown 作业部落](https://www.zybuluo.com)
- ..........


> 跨平台（同时支持 Linux 和 Windows）的客户端有：

- [VNote](https://github.com/tamlok/vnote)[^vnote]
- 蚂蚁笔记
- [Cmd Markdown 作业部落](https://www.zybuluo.com/)
- 为知笔记
- 有道云笔记
- 印象笔记
- ........

&nbsp;&nbsp;在线编辑器功能支持最多并且免费的仅 CSDN 博客了。渲染效果似乎都还不错。客户端中大多数都是跨平台的。蚂蚁笔记除了提供所有笔记功能，还独创了博客功能，仅仅新用户能试用一段时间。另外，一些扩展功能也是收费的。虽然作业部落的功能最多最完善。不过，它不是免费的产品。作业部落 Markdown 手册可以去 [这里](https://www.zybuluo.com/mdeditor?) 看看。免费产品中当以 VNote 功能支持最多。

+ 它的 Markdown 编辑器支持：

 - [x] 标题
 - [x] 有序列表
 - [x] 无序列表
 - [x] 表格
 - [x] 块、引用
 - [x] 代码
 - [x] 链接
 - [x] 图片
 - [x] 脚注[^1]
 - [x] Todo List[^2]
 - [x] 流程图&时序图[^3]
 - [x] 数学公式

## Todo List[^1] 写法
```
 - [x] 1
 - [ ] 2
```

## Markdown 脚注[^2] 写法：
```
脚注定义[^var]
[^var]: 脚注释义
```

## Markdown 时序图/流程图[^3] 写法：

### 流程图

```
s=>start: 开始
op=>operation: 操作
con=>condition: 条件？
io=>inputoutput: 输入/输出？
op2=>operation: 操作2

e=>end: 结束

s->op->io->con
con(yes)->op2->e
con(no)->op

```

> 将生成下面的流程图：

```flow
s=>start: 开始
op=>operation: 操作
con=>condition: 条件？
io=>inputoutput: 输入/输出？
op2=>operation: 操作2

e=>end: 结束

s->op->io->con
con(yes)->op2->e
con(no)->op
```


### 时序图

## 表格：

```
|t1|title2|title3|
|:--:|:--:|:--:| # 对齐方式使用冒号
|des1|desc2|desc3|
```

|title1|title2|title3|
|:--:|:--:|:--:|
|des1|desc2|desc3|

Leanote 也不错。Leanote Markdown 语法手册在[这里](http://www.leanote.com/blog/post/531b263bdfeb2c0ea9000002)。

> Leanote 参阅： 

+ [如何开发Leanote桌面端插件 · Issue _110 · leanote_desktop-app · GitHub](https://github.com/leanote/desktop-app/issues/110)
+ [如何开发Leanote桌面端主题 · Issue _109 · leanote_desktop-app · GitHub](https://github.com/leanote/desktop-app/issues/109)

[^1]: 什么是[脚注][]？脚注就是对某个生僻词汇或者句子的详细解释…
[^2]: [Todo List][] 很像表单里的复选框……
[^3]: [时序图/流程图][4]
[^4]: [TOC][5]

[1]: https://
[2]: https://
[3]: https://
[4]: https://
[5]: https://
[脚注]: https://
[Todo List]: https://

参考：

+ <a href="https://zh.wikipedia.org/wiki/Markdown" target="_blank"> 维基百科

[1]: http://math.stackexchange.com/
[2]: https://github.com/jmcmanus/pagedown-extra "Pagedown Extra"
[3]: http://meta.math.stackexchange.com/questions/5020/mathjax-basic-tutorial-and-quick-reference
[4]: http://bramp.github.io/js-sequence-diagrams/
[5]: http://adrai.github.io/flowchart.js/
[6]: https://github.com/benweet/stackedit

访问 [MathJax](http://meta.math.stackexchange.com/questions/5020/mathjax-basic-tutorial-and-quick-reference) 参考更多使用方法

> - [时序图语法](http://bramp.github.io/js-sequence-diagrams/)
> - [流程图语法](http://adrai.github.io/flowchart.js)
> - [Sublime Text 2](http://www.sublimetext.com/2) + [MarkdownEditing](http://ttscoff.github.com/MarkdownEditing/) / [教程](http://lucifr.com/2012/07/12/markdownediting-for-sublime-text-2/)

[^vnote]: VNote 使用 QT 实现，是我用过之后就没有再换的 Markdown 编辑器。
