# 让Arch Linux“滚回”到以前的版本
﻿&nbsp;&nbsp;也许`Arch Linux`滚动式发行的特点能让系统一下子就更新到最新状态，但不幸的是：并非所有的旧硬件(比如我的)都能适应这种变化。经过升级的软件包释出的一些新特性也许并不兼容`PC`机上的旧硬件。或者在使用之前至少需要对某其中的一项做出微小调整后才能正常工作。因此，此时的你也许对新版本的软件包并不感冒，而希望将它降级后使用。

&nbsp;&nbsp;如果你的`Arch Linux`中的某个软件包因为一些问题需要降级，可以从存档库中下载历史版本然后手动降级[^1]。

&nbsp;&nbsp;然而，当我尝试从 Arch Linux 回滚机[^archive]上降级`Arch Linux`时，遇到了下面的一些问题[^problem]。


```
# shell
sudo pacman -Syy
```

> output::
 
```
:: 正在同步软件包数据库...
错误：无法从 archive.archlinux.org : SSL certificate problem: certificate is not yet valid 获取文件 'core.db'
错误：无法升级 core (下载函数库出错)
错误：无法从 archive.archlinux.org : SSL certificate problem: certificate is not yet valid 获取文件 'extra.db'
错误：无法升级 extra (下载函数库出错)
错误：无法从 archive.archlinux.org : SSL certificate problem: certificate is not yet valid 获取文件 'community.db'
错误：无法升级 community (下载函数库出错)
错误：无法同步任何数据库
错误：无法初始化事务处理 (下载函数库出错)
```

```
pacman -S sl
```

```
正在解决依赖关系...
正在查找软件包冲突...

软件包 (1)  新版本  净变化  下载大小
community/sl  5.02-4  0.01 MiB  0.01 MiB
下载大小:   0.01 MiB
全部安装大小：  0.01 MiB
:: 进行安装吗？ [Y/n] 
:: 正在获取软件包......
错误：无法从 archive.archlinux.org : SSL certificate problem: certificate is not yet valid 获取文件 'sl-5.02-4-x86_64.pkg.tar.xz'
警告：无法获取某些文件
错误：无法提交处理 (下载函数库出错)
发生错误，没有软件包被更新。
```

```
error setting certificate verify locations:
```

&nbsp;&nbsp;当然，如果你并不介意这些问题，那么则可以直接将源的地址写死到回滚机的某个时间点，然后尝试降级系统。


=============== /etc/pacman.d/mirrorlist =================

```
# gcc 5.3
Server = https://archive.archlinux.org/repos/2016/05/01/$repo/os/$arch
```

```Bash
# 以根用户权限执行降级系统命令。为了顺利执行，可能需要先清除系统缓存
pacman -Scc
# 启用降级
pacman -Syyuu
```

&nbsp;&nbsp;遗憾的是：这样出问题的机率并不小。如果你希望回到以前而又不介意重装系统，则可以尝试进入`Arch Linux`的`Live CD`环境，将软件源设为回滚机的某一个时间点，重建缓存后开始基本系统的安装和配置工作。

```Bash
pacman -Scc

pacman -Syy

# 确认软件版本，如果能返回预期的结果，则可以开始：
pacman -Ss gcc

# Install and configure base system……
mount /dev/disk/by-label/Arch /mnt
pacstrap -i /mnt base base-devel net-tools wpa_supplicant dhcpcd
# ...
```

[^1]: 手动降级某个软件包时，pacman并不会顺带解决依赖问题。所以在降级时可以需要连其依赖一起降级。不过，AUR上提供了一个用来降级软件包的工具downgrade和downgrader。它们都可以根据需要降级指定的软件包并尝试解决依赖问题，而使用它们降级软件包时也只需要提供一个要降级的软件包名，然后从多个历史版本中选择一个版本就能降级这个软件包到某个历史版本。除了下载速度有些慢之外。如果你希望了解更多，请参考 Arch Linux 存档库维基。


[^archive]: 回滚机可以把系统“回滚”到以前的某种“状态”。不过，也许只有滚动式发行的才有，Arch Linux 的在[这里](https://archive.archlinux.org)。不幸的是：这同时也会降低系统的安全性。

[^problem]: 如果你的系统时钟是错误的，可能会无法正常访问网络……

