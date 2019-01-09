#  让显示管理器在其它的tty启动
ll 掉了 X 服务器(后台运行 startx 似乎没有什么用)，tty1 才会重新显示出 shell 的提示符(如果确定 X 服务配置没有问题而又不希望看到那些日志信息的话，可以尝试将输出和错误信息重定向到位桶(/dev/null)，这样重新回到字符界面的时候控制台看起来也许会显得“干净”一点)。而有的时候出于需要，不想让 tty1 直接被 X 服务器占用。除了尝试传递参数给 X 服务器之外。

&nbsp;&nbsp;还可以通过编辑显示管理器的服务和配置文件（假如 `init` 使用的是 `systemd` 的话。不过，init 使用的是 `System V` 的 `openRC` 的话 也可以尝试使用类似的方法配置）来让显示管理器和 X 服务器明白自己“应该”在哪一个 tty 上启动自己做到“永久性配置”。假如桌面环境显示管理器或者说是登录管理器使用的是 lxdm（其它的似乎也没有多少不同），它的 systemd 服务单元文件在不同的 Linux 发行上位置可能不同，不过实际上
`/etc/systemd/system/display-manager.service` 只是一个指向显示管理器服务的符号链接，一般是在显示服务器的服务被允许开机启动或者多用户环境目标被设为图形用户时自动创建。

假如要让显示管理器 lxdm 在系统引导时自动启动（如果系统已经直接将多用户目标配置为图形用户，那么根本不需要这样做），以根用户权限运行：

```Bash
systemctl enable lxdm
```

而如果想要让 systemd 在其它的 tty(比如个人计算机上很少使用的 tty12)启动显示管理器，那么就可能需要适当的编辑显示管理器 systemd 服务文件：

```Bash
sudoe $(readlink /etc/systemd/system/display-manager.service)  #sudoe是sudo -E vim的别名，目的是为了在以其它用户启动vim时仍然使用现在用户的环境比如仍然读取当前用户的vimrc。
```

```
Conflicts=getty@tty12.service plymouth-quit.service
After=systemd-user-sessions.service getty@tty12.service plymouth-quit.service
```

以及显示管理器（我使用的 lxdm，很遗憾，我还没有找到配置 gdm 的方法）的配置文件：

============== /etc/lxdm/lxdm.conf ===============
```
[server]
## arg used to start xserver, not fully function

arg=/usr/bin/X -background vt12 # 这会让显示管理器在第 12 个 tty 上启动 X 服务器和自身
```

 假如重启之后成功引导了系统，可以通过切换控制台或者直接用 ps 指令检查结果。

```Bash
ps aux|grep -v grep|grep X
```

```Bash
root       790  1.7  3.0 616836 120248 tty12   Ssl+ 17:20   0:41 /usr/lib/xorg-server/Xorg -background none :0 vt12 -nolisten tcp -novtswitch -auth /var/run/lxdm/lxdm-:0.auth
```

&nbsp;&nbsp;另一个问题是：在我的个人计算机上似乎并不需要这么多的 tty 在按下终端切换组合键时启动 getty 和 login（虽然在每一个 tty 上登录然后尝试在上面执行一些不同的任务或者启动多个不同的桌面环境听起来似乎比 windows 要酷多了，但实际上，这样做的也许仅仅是极少数。）

如果不想启动太多 tty 的话，可以尝试控制启动的 tty 的个数:

&nbsp;&nbsp;`Arch Linux` 维基上说，在以 `systemd` 作为 `init` 的系统上，可以编辑 `/etc/systemd/logind.conf` 配置文件的 `Login` 段，其中 `NAutoVTs` 的值就是用来控制默认的 `getty` 个数，默认有 6 个，但都是在用户按下 Ctrl+Alt Fn(1-6)时才会触发 getty 并启动一个 login。

如果将它设为 11，则会在所有 tty 上启动 getty 并将 tty1 的消息转发到 tty12。

============= /etc/systemd/logind.conf =============
```
[Login]

NAutoVTs=1 # 只在 tty1 上启动了 getty，不过奇怪的是这样的配置对 tty6 似乎并没有什么用处。
……
```

