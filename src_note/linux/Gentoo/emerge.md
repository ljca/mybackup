<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# emerge[^emerge]

[^emerge]: Gentoo 软件包管理器

> `eselect profile list`

Current /etc/portage/make.profile symlink:
  default/linux/amd64/17.1
Available profile symlink targets:

+ [1]   default/linux/amd64/17.0 (stable)
+ [2]   default/linux/amd64/17.0/selinux (stable)
+ [3]   default/linux/amd64/17.0/hardened (stable)
+ [4]   default/linux/amd64/17.0/hardened/selinux (stable)
+ [5]   default/linux/amd64/17.0/desktop (stable)
+ [6]   default/linux/amd64/17.0/desktop/gnome (stable)
+ [7]   default/linux/amd64/17.0/desktop/gnome/systemd (stable)
+ [8]   default/linux/amd64/17.0/desktop/plasma (stable)
+ [9]   default/linux/amd64/17.0/desktop/plasma/systemd (stable)
+ [10]  default/linux/amd64/17.0/developer (stable)
+ [11]  default/linux/amd64/17.0/no-multilib (stable)
+ [12]  default/linux/amd64/17.0/no-multilib/hardened (stable)
+ [13]  default/linux/amd64/17.0/no-multilib/hardened/selinux (stable)
+ [14]  default/linux/amd64/17.0/systemd (stable)
+ [15]  default/linux/amd64/17.0/x32 (dev)
+ [16]  default/linux/amd64/17.1 (stable) *
+ [17]  default/linux/amd64/17.1/selinux (stable)
+ [18]  default/linux/amd64/17.1/hardened (stable)
+ [19]  default/linux/amd64/17.1/hardened/selinux (stable)
+ [20]  default/linux/amd64/17.1/desktop (stable)
+ [21]  default/linux/amd64/17.1/desktop/gnome (stable)
+ [22]  default/linux/amd64/17.1/desktop/gnome/systemd (stable)
+ [23]  default/linux/amd64/17.1/desktop/plasma (stable)
+ [24]  default/linux/amd64/17.1/desktop/plasma/systemd (stable)
+ [25]  default/linux/amd64/17.1/developer (stable)
+ [26]  default/linux/amd64/17.1/no-multilib (stable)
  .......

USE="acl acpi amd64 berkdb bzip2 cli ....." ....

```Bash

eselect profile set 20

```

Current /etc/portage/make.profile symlink:
  default/linux/amd64/17.1/desktop

USE="X a52 aac acl acpi alsa amd64 berkdb bluetooth brandin...." INPUT_DEVICES="" L10N="en-US zh-CN zh-TW" VIDEO_CARDS="i915 intel nvidia fbdev vesa" INPUT_DEVICES="keyboard libinput mouse evdev synaptics void"  ....

# FAQ
## --autounmask-write & dispatch-conf：合并 USE 标记，

## `USE="libav" emerge -pv media-video/ffmpeg`

[blocks B      ] media-video/ffmpeg:0 ("media-video/ffmpeg:0" is blocking media-video/libav-12.3)

> 被锁住的包： 根据 [Gentoo 维基](https://wiki.gentoo.org/wiki/Handbook:X86/Working/Portage#Blocked_packages)，这是由于二者之间存在冲突，因此要么移除掉其中的一个，要么不安装其中的一个。比如 libav 和 ffmpeg，i3 和 i3-gaps

## equery[^gentoolkit]

+ `equery uses <sr>` # \<sr\>：类名/软件包名，e.g. media-vedio/vlc
+ `equery list <sr>`
+ `equery files <sr>`

## genkernel

## Gentoo USE[^gentoo_use] 标记，参考 Gentoo [USE Flags](https://www.gentoo.org/support/use-flags/)

```log
下面是 WIKI 页 REQUIRED_USE的一个例子：
Example 	Description
REQUIRED_USE="foo? ( bar )" 	如果 foo 被设定, 必须设定bar 。
REQUIRED_USE="foo? ( !bar )" 	如果 foo 被设定， 必须设定 bar。
REQUIRED_USE="foo? ( || ( bar baz ) )" 	如果 foo被设定， 必须设定 bar 或baz 。
REQUIRED_USE="^^ ( foo bar baz )" 	foo bar 或baz 必须有一个被设定
REQUIRED_USE="|| ( foo bar baz )" 	至少 foo bar 或 baz 有一个被设定。
REQUIRED_USE="?? ( foo bar baz )" 	foo bar 或 baz中必须同时被设定多个
```
[^gentoo_use]: 来自 WIKI 的提醒：一些ebuild需要或禁止USE标志的某些组合才能正常工作。 这通过放置在 REQUIRED\_USE，用一组条件来表示。 此条件确保所有功能和依赖性都已完成，并且构建将成功并按预期执行。 如果任何一个不符合，emerge会提醒你，并要求你解决这个问题。

[^gentoolkit]: 
