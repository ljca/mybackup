#  rar一次解压多个密码相同的rar压缩包
我这里所讨论的仅是 winrar 的命令行实现 *rar* 的一点小技巧。如果你使用的是 Windows，那么可以在 winrar 选项中找到相同功能的选项。

以下这条指令适用于 Linux，windows 的命令提示符的 *for* 与此稍有出入。
```bash
# 使用密码 password 解压当前目录下所有的 rar 压缩包（我这里假设所有的 rar 压缩包使用的密码都是 password）到当前目录下后并删除原来的 rar 文件
for i in *.rar;do rar x -ppassword "$i" && rm -f "$i";done;
```
