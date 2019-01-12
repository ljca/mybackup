# 为什么在我的Linux核心控制台上，Alt Gr键不能被用作Meta键？
&nbsp;&nbsp;Meta 键是一个元键，一般对应于 PC 机键盘上的左 Alt，如果图形界面的伪终端也正确配置了 Alt 键，右边的 Alt 也可以作为 Meta 键使用。
在没有 Alt 键的时代，是使用 Esc 键来代替 Meta 键的。

> ！假如 Alt Gr 键在虚拟控制台上不能作为 Meta 键使用，那也许是因为键盘映射不对。

大多数的 key 在 Linux 核心控制台上已经正确配置，不过极少数的键还是需要手动进行配置并进行载入后才可以正常使用，以下指令在核心控制台上可能需要用到（在伪终端上无效）：

+ showkey 可以用来显示按键对应的映射码
+ loadkeys 可以用来从一个文件或者标准输入载入键盘映射码
+ dumpkeys 导出按键映射码

临时让 Alt Gr 映射到 Alt 上：
```bash
su -c 'echo -e "$(dumpkeys|grep keymaps)\nkeycode 100 = Alt" | loadkeys'
```

========== dir: /usr/share/kbd/keymaps/ ========== 
```bash
echo -e "$(dumpkeys|grep keymaps)\nkeycode 100 = Alt" > alt.map
gzip alt.map
# 以根用户执行
mkdir /usr/share/kbd/keymaps/my
mv alt.map.gz /usr/share/kbd/keymaps/my
```

然后在 Linux 核心终端或者已经运行了 tmux 的终端上以根用户权限执行：
```bash
loadkeys alt
```

参考：

 + [loadkeys]() & [dumpkeys]()
 + [在虚拟终端下面使用 Emacs 不能使用右边的 Alt 键问题的解决](http://lifegoo.pluskid.org/wiki/EnableLeftCtrlInConsole.html)
 + [Linux & Unix](https://unix.stackexchange.com/questions/44453/how-to-define-a-compose-key-in-terminal-no-desktop-environment?answertab=votes)
 + [Arch Linux Wiki](https://wiki.archlinux.org/index.php/Keyboard_shortcuts)
