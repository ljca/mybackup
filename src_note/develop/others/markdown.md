# Markdown 笔记
据我所知，支持 Markdown 的在线编辑器有：

- [StackEdit](https://stackedit.io/editor)
- [markable.in](https://markable.in/editor/)
- [简书](https://www.jianshu.com)
- [CSDN-博客](https://blog.csdn.net)
- [开源中国博客](https://www.oschina.net/blog)
- [蚂蚁笔记](https://www.leanote.com)
- Cmd Markdown 作业部落
- ..........


> 客户端有：

- [VNote](https://github.com/tamlok/vnote)
- 蚂蚁笔记
- Cmd Markdown 作业部落
- 为知笔记
- 有道云笔记
- 印象笔记
- ........

&nbsp;&nbsp;在线编辑器功能支持最多并且免费的仅 CSDN 博客了。客户端中大多数都是跨平台的。蚂蚁笔记除了提供所有笔记功能，还独创了博客功能，仅仅新用户能试用一段时间。另外，一些扩展功能也是收费的。虽然作业部落的功能最多最完善。不过，它不是免费的产品。作业部落 Markdown 手册可以去 [这里](https://www.zybuluo.com/mdeditor?) 看看。免费产品中当以 VNote 功能支持最多。


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


其次则是 Leanote，Leanote Markdown 语法手册在[这里](http://www.leanote.com/blog/post/531b263bdfeb2c0ea9000002)。

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
