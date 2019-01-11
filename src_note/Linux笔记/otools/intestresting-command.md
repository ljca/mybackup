# 我见过的一些终端下很有意思的命令和脚本 

+  *sl* 终端上一辆从未来穿行到过去的火车
曾见过有人在 terminal 中跑火车，如果错误的将 ls 敲成了sl(这个命令由软件包 sl 提供，它并没有默认安装在系统中)，就会一辆火车从终端上快速穿行而过，这个时候除了可以用 Ctrl S 暂停，Ctrl Z 恢复或者关闭窗口之外。除非故意键入了-c 选项，不然 Ctrl c 这辆穿行而过的火车是不会中途消失的。这个时候也不能使用终端执行指令，得等火车完全通行之后终端窗口才会恢复正常。如果故意敲成了sl --help，那么出来的火车或许跟没有这个选项时出来的样子不太一样
  

+ `cowsay` 在终端上打印出 ascii 图形
Arch Linux 默认出来的是一个小牛，还可以是

```Bash
echo | cowsay -f $(\ls /usr/share/cows|shuf -n1)
for i in $(\ls /usr/share/cows);do echo $i|cut -d. -f1|cowsay $i;done
```

+  `notify-send` 将一条或者一组命令执行的结果以系统通知框的形式呈现 
notify-send 指令可以将一组指令(需要使用命令替换)然后执行出来的结果使用一个消息框呈现出来。下面这个别名定义来源与 Ubuntu，用于将用户的最后一条历史记录以系统通知的形式呈现出来。
```Bash
alias alert='notify-send --urgency=low -i "$([ $? = 0 ] && echo terminal || echo error)" "$(history|tail -n1|sed -e '\''s/^\s*[0-9]\+\s*//;s/[;&|]\s*alert$//'\'')"'
```
```Bash
Usage:  
notify-send [OPTION...] <SUMMARY> [BODY] - create a notification
Help Options:  
-?, --help Show help options
Application Options:  
-u, --urgency=LEVEL Specifies the urgency level (low, normal, critical).  
-t, --expire-time=TIME Specifies the timeout in milliseconds at which to expire the notification.  
-a, --app-name=APP_NAME Specifies the app name for the icon  
-i, --icon=ICON[,ICON...] Specifies an icon filename or stock icon to display.  
-c, --category=TYPE[,TYPE...] Specifies the notification category.  
-h, --hint=TYPE:NAME:VALUE Specifies basic extra data to pass. Valid types are int, double, string and byte.  
-v, --version Version of the package.
-i 选项用来给弹出消息框一个指定一个图标
尖括号部分代表必选项，可以是单纯的算数运算，也可以是一组命令，但命令需要使用命令替换还应该要包含在双引号中，否则依然无效
```

+  *pv* 在终端像打字机一样慢慢打印命令输出 

+  *lolcat* 让文本能像彩虹一样显示在终端上的 ruby 脚本 

+ *flglet* 让文字看起来像广告字体一样 

> 参考：

+ [lolcat：一个在Linux终端中输出彩虹特效的命令行工具 - 51CTO](http://os.51cto.com/art/201507/483977.htm)
+ [终端中的乐趣：6个有趣的Linux命令行工具-桌面应用_Linux](https://linux.cn/article-4128-1.html)
+ [输错密码？这个 sudo 会“嘲讽”你_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2016-04/130255.htm)
+ [彩色的命令行 —— 使用 ANSI 色彩代码 - Linx时代 - ChinaUnix](http://linux.chinaunix.net/doc/2004-10-05/7.shtml#335lfindex3)
+ [格式_ echo -e '_033字背景颜色;字体颜色字符串' - 水滴石穿 - 博客频道 - CSDN](http://blog.csdn.net/panpan639944806/article/details/23930553)
