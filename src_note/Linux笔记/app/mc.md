#  mc
> mc 的一些功能键：

`<Ins>` 选中文件

`<Shift+Ins>` 取消选中

`<Tab>`：切换面板

`<C-u>`：交换面板

`<F5>`复制选中的文件到……

> ！！！Linux 的图形文件管理器一般支持直接连接到手机上启用的 FTP 服务器。

&nbsp;&nbsp;如果你智能手机的`USB`口存在问题以至于无法正常使用`USB调试功能`，但是你又希望在`PC`和智能手机上交换文件则可以尝试一下手机上的`FTP`功能。


> 以下是使用手机端 FTP 功能在 PC 和手机端交换文件的几个步骤：

```flow
s=>start: PC 和智能手机连接同一个 wifi
mop=>operation: 下载具有FTP功能的应用（比如ES浏览器或者MT管理器)安装到系统
mop2=>operation: 在网络功能中启用FTP服务
mcon=>condition: 启用成功？
pcop1=>operation:  Linux 打开 mc
pcop2=>operation: 按下<F9>，移动菜单选项到左/右 - 选择FTP链接
io=>inputoutput: 输入FTP地址和端口(比如192.168.1.108:3721)
con=>condition: 连接成功？
mck=>operation: 检查手机端wifi连接和ES浏览器FTP服务状态？
stop=>operation: 开始操作
//sub=>subroutine: 子结构
e=>end: 断开连接

s->mop->mop2->mcon
mcon(yes)->pcop1->pcop2->io->con
mcon(no)->mop2
con(yes)->stop->e
con(no)->mck->mop2

```
