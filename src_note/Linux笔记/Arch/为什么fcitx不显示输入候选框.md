#  为什么fcitx不显示输入候选框
&nbsp;&nbsp;当我启动`fcitx`尝试输入中文时，很奇怪，中文输入候选并没有被显示出来。再切换`fcitx`中英文状态时，也无任何提示与动静。

```Bash
#先杀掉 fcitx，再杀掉与之相关的进程。最后重启 fcitx。或者由窗口管理器或者桌面环境启动它更好。
pkill fcitx
ps aux|grep -v grep|grep fcitx
kill ...
fcitx
```


```
fcitx
/usr/bin/dbus-daemon --fork --print-pid 4 --print-address 6 --config-file /usr/share/fcitx/dbus/daemon.conf
/usr/bin/fcitx-dbus-watcher unix:abstract=/tmp/dbus-XJ2UaZDEff,guid=76c012a9503a6d08e86385215a3bc192 13121
```

```Bash
sudo kill xxxx
rm -rf ~/.config/fcitx/{cached_layout,dbus}
```

```Bash
```


