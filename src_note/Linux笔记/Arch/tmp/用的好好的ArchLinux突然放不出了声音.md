# 用的好好的Arch Linux突然放不出了声音
&nbsp;&nbsp;用的好好的 Arch Linux 不知怎么突然没声音了，检查了驱动和固件一切正常。结果发现竟然是我不知道什么时候 Mute audio output，真是尴尬。

&nbsp;&nbsp;解决方法也简单的很，在 xfce4 面板上的 pulseAduio 插件取消勾选 Mute audio output 就行了.(如果没有找到这个插件的话可能需要先用 pacman 安装 xfce4-gooies 软件包组下的 xfce4-pulseaudio-plugin,并将它添加到 xfce4 面板上)

&nbsp;&nbsp;顺便说一句，xfce4 面板上的很多插件是可以配置为同时管理笔记本的亮度，声音控制快捷键(单独配置全局快捷键也是可以的，但没这方便)，当然，这需要正确安装了驱动和正确配置了面板插件(如果需要的话),不借助这个方法也是可以的，但那要复杂的多。

&nbsp;&nbsp;在仅安装了 Xfce4  桌面环境的 Arch Linux 系统上，一开始是不能使用亮度/声音全局控制键的(比如宏碁笔记本用来调节亮度的Fn ←/Fn → 和调节声音的Fn ↓/Fn ↑)，不过物理功能控制键(Fn F7.....)是正常的。

> Note！！！

+ 属于`alsa-utils`的`speaker-test`可以用来测试喇叭是否工作正常。
