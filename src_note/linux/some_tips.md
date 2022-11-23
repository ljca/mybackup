<link href="../css/style.css" rel="stylesheet" type="text/css" />

> Tips：

- 顺序批量重命名文件： `a=1;for i in *.jpg;do mv -v "$i" "$((a++)).jpg";done`。本条技巧来自博客：[Bash批量重命名文件](https://www.codenong.com/39133172/)
- 重命名扩展：`rename` 即可完成。
- 清除或者替换文件名中的特殊字符：sed 和 for 即可完成。

-----------

- rar 一次解压多个密码相同[^rar]的rar压缩包。`for i in *.rar;do rar x -ppassword "$i" && rm -f "$i";done;`
- 浏览器能以只读的形式直接访问本地磁盘上那些允许访问的目录和文件（就像是在访问`ftp`服务器）。
- 如果将那些包含网页文件的目录添加到浏览器书签，就可以随时访问保存到本地的网页（如果是那种以单个网页格式`mht`保存的，在其它的浏览器上直接访问可能还需要安装支持这种格式的插件）。这样一来，就不需要到本地磁盘上去寻找并花费不短的时间等待浏览器慢慢打开它……
- 侧边栏可能会让顶级目录导航更快。
 
[^rar]: 我这里所讨论的仅是 winrar 的命令行实现 *rar* 的一点小技巧。如果你使用的是 Windows，那么可以在 winrar 选项中找到相同功能的选项。使用密码 password 解压当前目录下所有的 rar 压缩包（我这里假设所有的 rar 压缩包使用的密码都是 password）到当前目录下后并删除原来的 rar 文件；本次在 Linux 测试完成，windows 的命令提示符的 *for* 与此稍有出入。

