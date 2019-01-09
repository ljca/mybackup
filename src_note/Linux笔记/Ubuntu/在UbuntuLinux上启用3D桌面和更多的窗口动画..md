#  在Ubuntu Linux上启用3D桌面和更多的窗口动画.
对于我而言，3D桌面是次要的，我真正需要的是对窗口动画和主题进行自定义……

> 如果你希望体验`3D`桌面[^0]以及对默认窗口动画进行自定义，那么你可能需要：

## 切换到闭源（官方）显卡驱动(闭源驱动可以在设置的软件源部分找到)是有必要的。

## 安装 compiz，ccsm(compizconfig-settings-manager)，compiz-plugins……以及 unity-tweak(ubuntu tweak tool)，Ubuntu 主题……

&nbsp;&nbsp;使用软件包管理器 apt (这个是基于命令行的工具)，图形化的叫软件中心，还有一个 aptitude 是一个基于 apt 的使用 ncurser 库的的伪图形界面，也要在终端使用。但不管使用命令行还是图形软件包管理器，都要安装好 ccsm 软件套件及其插件包才能正常设置 3D 桌面。 

> ！ 

+ 如果你不知道软件包名或者这里提供的软件包名称根本就是错误的，可以尝试提供一个关键字给`apt search`或者`apt-cache search`搜索完整的……
+ 另外，compiz 版本也许会不断变化……

```Bash
apt-get -y install unity-tweak compizconfig-settings-manager  compiz-plugins-extra compiz-plugins
```

## 配置 ccsm，可选配置 `unity-tweak`

&nbsp;&nbsp;接着，你需要运行 `ccsm` 进行配置，并打开其中的一些基本特效。基本的 3D 桌面只需要打开 ccsm 设置里的 3D Desktop，旋转立方体等基本特效，还要配置虚拟桌面个数（一般是 4 个）就可以了。至于什么下雪、焰火、养鱼等骚包的效果，别怪我没提醒你，如果你的计算机硬件配置不是很高，这些东西还是玩玩就好，别太认真去耍，如果硬件真的因此而出了问题，你不要哭泣。

&nbsp;&nbsp;不管怎样，如果一切顺利的话，可以在配置的过程中尝试同时按下 ctrl+alt，并且按住鼠标左键拖曳；也可以按下 ctrl+alt，再按下键盘上的←键或者→键，你就能见到神秘的 3D 桌面。而关于窗口动画及主题等的更改，你也许会在`unity`优化工具或者`ccsm`的`Animations`中找到。

假如在这些过程中出现了问题而导致图形界面崩溃或者系统重启后无法顺利进入图形界面，那么可以尝试：

在虚拟控制台登录，备份或者移除 ccsm 的配置文件（`~/.config/compiz* ~/.gconf/apps/compiz*`）
重置 unity （以根用户执行）：

```Bash
unity --reset
```

 接着尝试按下 ctrl+alt+F7，看看能否进入 Ubuntu 图形界面。

> 如果你希望见到更多更详细的`3D`特效介绍，请尝试访问这个[帖子](http://forum.ubuntu.org.cn/viewtopic.php?t=140531)……

[^0]:  无论是 3D 桌面还是窗口扭曲的动画特效，kde 桌面环境都已提供，假如你不喜欢折腾而又想尝试一下这些花哨的东西，那么不妨试一下 KDE 桌面环境。而这些在 unity 桌面环境是需要手动配置的。

