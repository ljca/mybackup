<link href="../css/style.css" rel="stylesheet" type="text/css" />


# grub 笔记

## GRUB 2 Themes
如果你希望调整`Grub`默认主题并且没兴趣了解、讨论`Grub`主题配置文件细节，你可以尝试直接从 Gnome Themes 的 [Grub Themes][grub_themes] 节获取您喜欢的主题后放到合适的位置然后根据需要调整……而下面这些仅仅适合我和那些“希望了解`Grub`主题包细节和对`Grub`主题进行微小调整的人群”……

如果您希望在`Grub`引导菜单项中能见到您喜欢的`OS`图标，您可以自己收集您喜欢的`OS`图标文件(尺寸：`24x24/32x32/64x64/72x72/88x88/128x128……`，格式：`8 bit 的 png`)重命名(os\_dist\_type.png)后存放到固定位置处（`Grub`主题目录下的`icons`目录中）。

当然，除了可选的`OS`图标，`Grub`主题还包含一些其它的东西(主题定义文件)、资源文件(这些东西需要你自己动手搜集[^1]，如果你对自定义充满了兴趣并表示不反对的话)。

>  一个`Grub`主题包结构类似：

======== dir:/boot/.../grub/themes/books/ =========

```log
├── books.png # Grub 背景图片
├── theme.txt # Grub 主题定义文件，
├── icons  # 一组 OS 图标（可以仅收集已安装系统的）
│   ├── arch.png
│   ├── bsd.png
│   ├── centos.png
│   ├── fedora.png
│   ├── gentoo.png
│   ├── lfs.png
│   ├── linux.png
│   ├── windows.png
# 可选，样式资源组（这里的文件名需要在主题定义文件被正确引用）：
# 一组用于引导菜单的样式
├── boot_menu_c.png 
├── ......
├── COPYING.CC-BY-SA-3.0
# 一组用于引导菜单项被选中时的样式
├── select_c.png 
├── ............
# 一组用于有滚动条时的样式
├── slider_c.png 
├── ......
# 一组用于 Grub 命令解释器的样式
├── terminal_box_c.png 
├──......
# 用于其它对象的样式资源组
└── .......
```

 如果你希望自定义`Grub`主题，一个格式是纯文本的文件（文件名倒是可以随意，但引用时必须一致）是必须的，它被用来定义`Grub`主题样式。

> ![](images/tips/conf.png)[themes.txt](config/themes.txt)

如果你在第一次更改`Grub`主题文件后已经更新过了`Grub`配置文件，那么之后如果仅仅是对`Grub`主题文件作了修改就不再需要更新`Grub`配置文件…… 然后更新`Grub`配置文件应用`Grub`主题： `/etc/default/grub`,`/etc/grub.d/40-custom`....还可以是其它的[^2]。


> ![](images/tips/conf.png)/etc/default/grub 

```config
# ……
GRUB_GFXMODE=1024x768x32,auto
GRUB_THEME="/boot/efi/EFI/boot/grub/themes/books/theme.txt" # 这里，请务必调整为你的 Grub 主题文件正确的路径。
# ……
```

> 最后，你还需要更新`Grub`配置……

```Bash
# 以根用户权限运行 Grub 配置生成脚本 grub-mkconfig ，最后的输出路径务必自行调整……
grub-mkconfig -o /boot/efi/EFI/boot/grub/grub.cfg
```

> 如果您觉得`grub-mkconfig`脚本更新`Grub`配置太慢(查找其它的`OS`)尝试直接编辑`Grub`最终生成的`grub.cfg`，用于设置主题的指令类似：

```config
insmod gfxmenu
insmod png
set theme=(hd0,1)/EFI/boot/grub/themes/books/theme.txt 
export theme
```

在更新`Grub`和重新引导系统之前，不要忘了备份旧的`Grub`配置文件和使用`grub-script-check`来检查`grub.cfg`是否存在问题。


## 附
### 加密 GRUB 2 命令行

grub 2 现在使用的加密工具是 `grub-mkpasswd-pbkdf2`，要加密 grub 的命令行和编辑功能，我们需要先使用它生成密码并根据需要将它加入 grub.d 下的配置文件中 `grub-mkpasswd-pbkdf2 >> /etc/grub.d/00_header`（只有放在所有 menuentry 和所有 submenu 项之前，才能对它们进行应用密码）并用 grub-mkconfig 重新生成 `grub.cfg` 或者仅仅添加变化的部分到`grub.cfg`（这样就无需对 /etc/grub.d/ 下的脚本做任何修改，也无需调用 grub-mkconfig）。

======= ![](images/tips/conf.png) /etc/grub.d/00_header =======

```cfg
# ....
# 根据维基的解释和以及个人的测试，只能使用`cat << EOF`这种方式。否则会提示`password_pbkdf2`命令无法找到。
cat << EOF 
set superusers=''
password_pbkdf2 user "这里填写 grub-mkpasswd-pbkdf2 工具生成的密码"
EOF
```

### GRUB2 启动 ISO：从 ISO 直接安装

GRUB 2 支持读取 iso（然而，一些 Linux 发行的 Live CD 并不支持从 NTFS 分区读取 ISO 文件)并尝试启动。你只需要在 [`/etc/grub.d/40-custom`](config/40_custom) 脚本[^others]中添加自定义菜单项然后使用 `grub-mkconfig` 脚本更新 grub 配置文件就行了。

[^others]: 当然，你可以自定义脚本，只要你能保证 `grub-mkconfig` 脚本可以调用到。但实在没有什么理由要这样做，不是吗？或者，干脆直接编辑这个脚本生成的最终配置文件 `grub.cfg` 好了。甚至都不用修改配置文件，在 Grub 的命令行下就可以读取并启动 iso，但这是一次性的。

### 从 GRUB 2 命令行手动引导 OS

```
# Arch Linux
grub> set root=(hd0,gpt3)
grub> linux /boot/vmlinuz-linux root=LABEL=Arch rw
grub> initrd /boot/initramfs-linux.img
grub> boot

# Windows，链式加载 
grub> set root=(hd0,gpt1)
grub> search --label --set=root ESP
grub> chainloader /efi/win/Boot/bootmgfw.efi
grub> boot
```

### Security Shell，见参考。

[grub_themes]: https://www.gnome-look.org/browse/cat/109/ord/latest/

> 参考：

+ [GRUB (简体中文) - ArchWiki][grub]
+ [【Linux 翻译】GRUB 2 使用全手册。](https://www.douban.com/group/topic/35734437/?author=1#sep)
+ [GNU GRUB Manual 2](http://www.gnu.org/software/grub/manual/grub.html#chainloader)
+ [GRUB 2_zh-cn - FedoraProject](https://fedoraproject.org/wiki/GRUB_2/zh-cn)
+ [GRUB2官方文档翻译项目2-06 - 查看主题 • Ubuntu中文论坛](http://forum.ubuntu.org.cn/viewtopic.php?t=470163)
+ [GRUB2英文文档的部分翻译 - ini_always - 博客园](http://www.cnblogs.com/ini_always/archive/2011/04/08/2009654.html)
+ [详细图解美化Grub2原创 - 查看主题 • Ubuntu中文论坛](http://forum.ubuntu.org.cn/viewtopic.php?t=257189)
+ [GRUB2中文指南第二版上 - Ubuntu 正體中文 Wiki][grub_]
+ [用GRUB启动ISO镜像_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2015-01/111838.htm)

[grub_]: http://wiki.ubuntu-tw.org/index.php?title=GRUB2%E4%B8%AD%E6%96%87%E6%8C%87%E5%8D%97%E7%AC%AC%E4%BA%8C%E7%89%88(%E4%B8%8A%EF%BC%89)

[grub]: https://wiki.archlinux.org/index.php/GRUB_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)#x86_64

[^1]: 你可以尝试在`Gnome Themes`的 [Grub Themes] [grub] 节找到很多直接可用的`Grub-themes`。

[^2]: 如果你自定义，那就要让它是一个可执行的`Grub`脚本，还要保证更新`Grub`配置的脚本`grub-mkconfig`能调用到它。

