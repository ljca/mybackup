<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# Android 笔记：
## [在 Linux 命令行上管理 Android 项目](android/android_apk.md)
## [adb：Android调试桥](android/android_tools.md)
## [编译 & 移植 Android](android/compier_android.md)

# 附
## Android 测试环境

`*#*#4636#*#*` 测试：可以用来切换SIM卡的2G/3G/……，以及查看电池和wifi信息（部分机型不支持）

`*#803#*`  wifi 测试……

`*#86#` 手机 IME 查询


### 仅华为

`*#*#2846579#*#*` 工程菜单
1. 后台设置
2. 单板信息查询
3. 网络信息查询
4. 软件升级
5. 恢复出厂设置
6. 补电

## FIQ：使用 Coolpad 8720L 出现的问题

据称，这是中国最早出现的一款`4G`移动智能手机……本人自使用 Coolpad 8720L 手机以来，遇到了层次不穷的问题，下面是我遇到的一些问题：

+ 我在 Coolpad 8720L 上设置了闹钟但是却不振动……


 前段时间，设置了闹钟，但闹钟的响铃有效可是却死活不振动。我还发现，不管是来电话还是短信以及设置了闹钟都只有铃声，振动一律不管用。

>   最初我认为可能是手机里面的振动器挂了，然而后来却无意发现是我不小心关掉了 Coolpad 8720L 手机里的触感反馈……
![](http://upload-images.jianshu.io/upload_images/6357881-8b17fc550799f71a.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240)

+ 我无法在 Coolpad 8720L 上调整闹铃铃声……
请你不要随意调整默认存储位置。当你需要调整闹钟铃声时，你需要将默认存储位置改为自动！

+ 我在 Coolpad 8720L 上安装 apk 时无法点击安装或者取消按钮……
请你在安装应用程序时不要打开云朵护眼一样的东西！

+ 我安装了一个应用程序，但是系统却提示应用程序未安装……
请你不要随意更换存储卡存储数据。如果出现了这种情况，那也许是原主人已经安装过了这个程序，假如你也要安装这个程序，那么你可以尝试： 
备份存储卡数据后清空应用数据和内置存储卡数据（恢复出厂设置倒是可以彻底解决这个问题，但谁会这么做呢）。当然，这也有可能是因为版本问题，你可以尝试安装一下这个应用的其它版本！

+ 我的 Coolpad 8720L 在接电话时提示无法连接网络……
请你不要随意将你的 Android 设备 root（你是要刷机还是用来看 wifi 密码我当然管不着，但你总需要打电话和接电话吧）假如已经出现了这种情况而你又迫切需要接电话，那么请移除`root`权限和从系统中卸载 root 授权工具！假如这并没有什么 N 用的话，你可能需要重置你的手机！

+ 为什么我的 Coolpad 8720L 没得开发者选项……
嘿嘿，因为 Coolpad 8720L 虽然是最先出来的 4G 手机，但也是与时俱进，一直在升级系统，现在已经升级到 Android 4.3 了，而 Android 4.3 以上的系统默认都没打开，如果你需要的话，可以自己去打开。方法是：点击关于手机里面的版本号 n 次！(n >= 3)

+ 为什么我的 Coolpad 8720L 默认将应用数据存储到内置的存储卡里面……
这……我也不知道为什么，假如你已经烦了的话，你可以去改一改系统的默认存储位置。当然了，别怪我没提醒你，这样做的话，闹钟铃声就只能用那个最原始的铃声而且无法更改……

# 参考：

+ [Android内核模块编译执行 - 水汐。2014 的专栏 - 博客频道 - CSDN.NET](http://blog.csdn.net/qq1084283172/article/details/56958136)
+ [Android内核模块编译执行 - 推酷](http://www.tuicool.com/articles/E3ARJzi)
+ [Android手机安装原版BT5 ARM_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2012-08/67591.htm)
+ [Android 手机上安装并运行 Ubuntu 12.04 第2页_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2013-05/84014p2.htm)
+ [Android中解析lrc歌词_Linux编程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2012-07/64755.htm)
+ [BusyBox构建根文件系统_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2015-08/121320.htm)
+ [Linux入门之定制Linux系统---Kernel+Busybox_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2014-04/99473.htm)
+ [Qt for Linux：环境搭建（CentOS 6.5 32位）——完全从零安装 - findumars - 博客园](http://www.cnblogs.com/findumars/p/5034623.html)
+ [安卓手机上安装运行Ubuntu系统的方法(图文)_刷机其它_刷机教程_手机学院_脚本之家](http://www.jb51.net/shuajijiaocheng/133097.html)
+ [让Ubuntu和Android同时运行（Ubuntu on Android）_Linux编程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2012-05/59599.htm)
+ [【_提醒】手机里的这些功能最好都关掉！不然......](http://www.360doc.com/content/16/0119/15/28041906_529100992.shtml)
+ [为Android加入busybox工具 - Easyman - 博客频道 - CSDN.NET](http://blog.csdn.net/liaoshengjiong/article/details/3957725)
+ [自己动手编译Android源码(超详细) - 简书](http://www.jianshu.com/p/367f0886e62b)
+ Android5.1开机LOGO与开机动画 - HelloBirthday的博客 - 博客频道 - CSDN.NET
+ android分区挂载fstab - HelloBirthday的博客 - 博客频道 - CSDN.NET
+ 天语K-TOUCH T619手机怎么进入recovery长按音量下键再按开机出现绿屏,找不到w开头的,也找不到recovery字眼,音量上一直是不变的三角形加叹号,那怎么办_百度作业帮
+ 天语 W619 (小黄蜂) 刷机包 官方卡刷包 - ROM基地安卓刷机最大最专业最齐全的安卓ROM刷机包资源下载站之家
+ 编译教程  半夏月
+ 《教程》_简单用超级终端提取机身recovery_img文件…自制刷机包很有用哦！ - Android安卓综合讨论与通用软件下载区 - 安卓智能手机论坛安卓论坛root刷机ROM下载 - dospy
+ 嵌入式linux驱动开发之点亮led（驱动编程思想之初体验） - heat nan - 博客园
+ Android系统移植(一) - HelloBirthday的博客 - 博客频道 - CSDN.NET
+ Android源码中编译自己的so库_Linux编程_Linux公社-Linux系统门户网站
+ Mono for Android 4.2之初体验-Android开发环境 -Android开发网
+ ubuntu12.04(64bit)编译android4.2.2源代码及SDK步骤 - oldmtn的专栏 - 博客频道 - CSDN.NET
+ 使用fastboot工具刷入recovery_img、boot_img、system_img等
+ 在Ubuntu-14.04.3配置并成功编译Android6_r1源码 - LeoLiang - 博客园
