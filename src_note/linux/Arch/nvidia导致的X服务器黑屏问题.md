<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# nvidia 导致的 X 服务器黑屏问题
﻿在 Arch Linux 系统上，如果你选择安装 `nvidia` 的闭源驱动并尝试加入 `initramfs` 则可能会导致 X 服务器在启动时黑屏：

=========== /etc/mkinitcpio.conf ============

```Bash

MODULES="nvidia"
#MODULES=""
BINARIES=""

FILES=""

#    usr, fsck and shutdown hooks.
HOOKS="base udev autodetect modconf block filesystems keyboard fsck"

COMPRESSION="xz"

```

```Bash
mkinitcpio -p linux
# 即便你没有将 nvidia 的闭源驱动模块加入 initramfs 中，但在重启之后，你可能仍会发现：X 服务器黑屏。你可能在 X.log.0 中发现没有 EE，只有 UnloadModule。
```

幸运的是：这个问题可以通过安装和启用 `bumblebee` 来解决。`bbswitch` 是可选的…才怪。

```Bash
community/bbswitch 0.8-77 [已安装]
    Kernel module allowing to switch dedicated graphics card on Optimus laptops
community/bumblebee 3.2.1-15 [已安装]
    NVIDIA Optimus support for Linux through VirtualGL

```

> 启用 community/bumblebee 服务：

```Bash
# 
usermod -G bumblebee,users,wheel $USER
systemctl enable bumblebee.service

```
> 参考：

+ [NVIDIA (简体中文) - ArchWiki][nvidia]
+ [Bumblebee (简体中文) - ArchWiki][bumble]

[nvidia]: https://wiki.archlinux.org/index.php/NVIDIA_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[bumble]: https://wiki.archlinux.org/index.php/Bumblebee_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)#.E4.B8.BA_Intel.2FNVIDIA_.E5.AE.89.E8.A3.85_Bumblebee
