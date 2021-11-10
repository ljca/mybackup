<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# 我见过的一些终端下很有意思的命令和脚本 

+  *sl* 终端上一辆从未来穿行到过去的火车

曾见过有人在 terminal 中跑火车，如果错误的将 ls 敲成了sl(这个命令由软件包 sl 提供，它并没有默认安装在系统中)，就会一辆火车从终端上快速穿行而过，这个时候除了可以用 Ctrl S 暂停，Ctrl Z 恢复或者关闭窗口之外。除非故意键入了-c 选项，不然 Ctrl c 这辆穿行而过的火车是不会中途消失的。这个时候也不能使用终端执行指令，得等火车完全通行之后终端窗口才会恢复正常。如果故意敲成了sl --help，那么出来的火车或许跟没有这个选项时出来的样子不太一样
  
+ `cowsay` 在终端上打印出 ascii 图形，Arch Linux 默认出来的是一个小牛，还可以是

```Bash
echo | cowsay -f $(\ls /usr/share/cows|shuf -n1)
for i in $(\ls /usr/share/cows);do echo $i|cut -d. -f1|cowsay $i;done
```

+  `notify-send` 将一条或者一组命令执行的结果以系统通知框的形式呈现 

notify-send 指令可以将一组指令(需要使用命令替换)然后执行出来的结果使用一个消息框呈现出来。尖括号部分代表必选项，可以是单纯的算数运算，也可以是一组命令，但命令需要使用命令替换还应该要包含在双引号中，否则依然无效。-i 选项用来给弹出消息框一个指定一个图标

```Bash
# 这是一个定义在 Ubuntu 上的别名，用于将用户命令历史记录最后一条以系统通知的形式呈现出来。
alias alert='notify-send --urgency=low -i "$([ $? = 0 ] && echo terminal || echo error)" "$(history|tail -n1|sed -e '\''s/^\s*[0-9]\+\s*//;s/[;&|]\s*alert$//'\'')"'
```

+  *pv* 在终端像打字机一样慢慢打印命令输出 
+  *lolcat* 让文字像彩虹一样显示在终端上的 ruby 脚本 
+ *flglet* 让文字看起来像广告字体一样 

> 参考：

+ [lolcat：一个在Linux终端中输出彩虹特效的命令行工具 - 51CTO](http://os.51cto.com/art/201507/483977.htm)
+ [终端中的乐趣：6个有趣的Linux命令行工具-桌面应用_Linux](https://linux.cn/article-4128-1.html)
+ [输错密码？这个 sudo 会“嘲讽”你_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2016-04/130255.htm)
+ [彩色的命令行 —— 使用 ANSI 色彩代码 - Linx时代 - ChinaUnix](http://linux.chinaunix.net/doc/2004-10-05/7.shtml#335lfindex3)
+ [格式_ echo -e '_033字背景颜色;字体颜色字符串' - 水滴石穿 - 博客频道 - CSDN](http://blog.csdn.net/panpan639944806/article/details/23930553)
+ [Linux最佳选择：总有一款桌面发行版适合你_Linux新闻_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2016-03/129545.htm)
+ [linux终端播放音乐歌词同步显示 - 开源中国社区](http://www.oschina.net/code/snippet_2298475_49747)
+ [LXDE和Enlightenment - 抗衡Win Linux全凭这些桌面环境(上篇)_Linux新闻_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2012-01/52278p3.htm)
+ [Unity和Xfce - 抗衡Win Linux全凭这些桌面环境(上篇)_Linux新闻_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2012-01/52278p2.htm)
+ [五大Linux歌词插件火拼Windows - 开源资讯 - LUPA开源社区](http://www.lupaworld.com/portal.php?mod=view&aid=214699&page=all)
+ [基于Debian的Linux发行版安装深度音乐及其插件_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2016-04/130713.htm)
+ [很轻很强大：轻量级桌面环境比较 · LinuxTOY](https://linuxtoy.org/archives/lightweight-desktop-compare.html)
+ [Shell 游戏：贪吃蛇-Shell-ChinaUnix](http://bbs.chinaunix.net/thread-3574908-1-1.html)