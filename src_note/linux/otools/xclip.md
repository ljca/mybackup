<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# xsel & xclip：Linux X 下的命令行剪贴板工具

 `primary` `clipboard` `second` `-sel`

`xclip -o > tmp.md`

`xclip -i < /etc/fstab`#  xsel&xclip，Linux命令行下的剪贴板管理器
Linux 下的剪贴板

其中`fcitx`也提供了一个剪贴板插件，用来保存更多的剪贴板操作记录到一个文件（方便随时使用）中，默认为５条，如果你在`fcitx`配置工具中启用了这个`fcitx`插件，那么你随时可以在用`fcitx`输入时用`C-;`（默认）调出来。`fcitx`默认是会保存剪贴板历史记录到`~/.config/fcitx/clipboard/history.dat`文件中的。这些，都可以使用`fcitx`配置工具`fcitx-configtool`或者修改`fcitx`配置文件组(`~/.config/fcitx/conf/`)进行修改和调整。

为了方便，Linux 提供了命令行下（当然，为了使用剪贴板，你可能需要运行`X`）管理剪贴板（在运行了`X`上的终端里可以使用`xsel`或者`xclip`进行管理）的工具……

```bash
# 查看剪贴板内容
xsel -o 

xclip -o

# 清空剪贴板
xsel -c

```

