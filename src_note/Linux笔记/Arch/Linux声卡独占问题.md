# Linux声卡独占问题
&nbsp;&nbsp;对`Linux`上这种奇葩的声卡独占问题[^1]一直很奇怪也没有找到解决方案，各种折腾后竟然在`ALSA`配置文件中用`pulseaudio`解决了这个问题（其实维基里面有这方面的提醒和注意）……

&nbsp;&nbsp;我听说以前的`OSS`声音驱动是可以直接启用软件混音的，然而现代的`ALSA`要启用软件混音……

&nbsp;&nbsp;如果你和我一样用的是较新的`Linux 发行`版本并且希望使用混音（就是那种多个应用程序同时使用声卡的情况）而且你的声卡有可能不支持硬件混音，可以尝试启用软件混音（详见 Arch Linux Wiki）[ALSA](https://wiki.archlinux.org/index.php/Advanced_Linux_Sound_Architecture) 部分。另一种方式则是尝试使用 pulseaudio（这种方式貌似不适合 mpd）……

&nbsp;&nbsp;如果你希望使用`ALSA`+`pulseaudio`，你也许需要先检查你的系统中是否已经安装了pulseaudio，假如没有的话你可能需要先拿起你的软件包管理器安装它，接着尝试让 ALSA 使用 pulseaudio 接管声卡：

> 配置文件(/etc/asound.conf or ~/.asoundrc)其实是在更新系统时（不知道是由`ALSA`还是`pulseaudio`创建的）是这样写的：

```
# Use PulseAudio by default
pcm.!default {
  type pulse
  fallback "sysdefault"
  hint {
    show on
    description "Default ALSA Output (currently PulseAudio Sound Server)"
  }
}

ctl.!default {
  type pulse
  fallback "sysdefault"
}

```

而我原本的`ALSA`配置文件是这样的：

```
defaults.pcm.card 1
defaults.pcm.device 0
defaults.ctl.card 1
```

&nbsp;&nbsp;接下来，我先用 vlc 播放了一个 MV，又用 smplayer 播放了一个视频，同时又打开了 mocp 和　RhythmCat 播放音乐，当我同时听到了它们放出的美妙声音时，心里其实挺激动的（这种东西貌似在`Windows`上根本不需要配置就可以直接使用的）。遗憾的是，至今仍未找到方法在 Firefox 浏览器播放在线音乐或者视频时的同时在本地播放多媒体（或者相反。据称，这可能是由于 firefox 浏览器是直接使用的 pluseaudio 来解析在线媒体流），虽然一般不会有人这样子搞……

![奇妙的混音啊](../../images/混音啊_1543755226_1711254746.png)

> 参考：

+ [Linux问题解决_arch系统安装完没有声音 - FaceYe](http://www.faceye.net/search/98807.html)
+ [Advanced Linux Sound Architecture (简体中文) - ArchWiki][alsa]

[alsa]: https://wiki.archlinux.org/index.php/Advanced_Linux_Sound_Architecture_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)#.E7.94.A8.E6.88.B7.E6.9D.83.E9.99.90

[^1]: 虽然我由此而接触到了混音的概念，但遗憾的是：我并没有因此而学到更多（至少，混音叫做什么仍未弄清……），因为我以前是用的`Windows`，而在`Windows`上似乎不会去思考声卡独占这种`Windows`用户可能认为很奇葩的而在`Linux`上（哦，不对，一些现代 Linux 已经正确配置了声卡并启用了混音。）确实又存在的系统问题……
