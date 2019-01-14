# adb：Android调试桥

> adb 是 Android 调试桥(Android Debug Bridge)的简称，一般而言，adb 至少具有以下几个功能：

1. 调试 Android 程序
2. 安装、卸载、运行、停止设备上的 Android 应用
3. ...................................................

&nbsp;&nbsp;adb 默认并不会安装在操作系统上，在 Linux 上系统上已经有软件包(一些 Linux 发行已经包含在官方源中)直接提供,可以直接使用软件包管理器下载安装。而 windows 上需要自行下载 adb 并配置环境变量(如果有必要的话)

---------------------------------------------
> 在使用 adb 之前，需要先安装 google usb 驱动并打开Android智能手机的调试功能。如果确定 google usb 驱动已经配置完成，那么先要以根用户权限(windows 上是管理员权限)启动 adb server

```Bash
adb start-server
```

> 以下 adb 操作并没有硬性规定要以根用户权限执行：

- 使用完 adb 之后杀死 adb sever 释放 adb 占用资源

```Bash
adb kill-server
```
- 列出已经连接到 adb server 的 Android 设备

```Bash
adb devices
```
- 如果 Android 设备没有就绪，那就需要等待 Android 设备

```Bash
adb wait-for-devices
```

使用adb: 重新挂载远程(安卓设备上)的system分区为读写.

```Bash
adb remount
```

> `adb install` : 安装应用到设备

```Bash
# -s 安装到sd卡(如果有)
adb install [-l] [-r] [-s] apkfile
```

> adb uninstall：卸载 apk 

Note:

1. 卸载apk使用的是包名，如果应用安装到了data分区，可以直接到设备上的/data/data目录下查询，包名被作为文件夹.(google虽然提供了一个adb补全插件(以脚本的形式存在)，但这个插件只对bash(zsh,ksh,csh等shell没有效果)有效),使用apk文件名不再有效!
2. 安装到system/app下的apk通过重新挂载设备/system分区为读写后直接删除或重命名来卸载！
3. package是创建安卓工程时的-k参数名,还可以在Android工程下的AndroidMainfest.xml的mainfest节点下的package属性值
4. -k参数可以保留用户数据以便再次安装应用时可以很快恢复到应用未卸载前的样子.

```Bash
adb uninstall [-k] package_name
```

- 从计算机上上传文件到 Android 设备：
```Bash
adb push file/directory /sdcard
```
- 从 Android 设备上下载文件到本地计算上：
```Bash
adb pull /sdcard/tmp/test.txt /tmp
```

## adb shell：进入 adb shell 环境或者执行 adb shell 指令

&nbsp;&nbsp; shell 是 adb 中一个强大的指令，它不仅可以直接进入 Android 的  shell，还可以直接运行 Android Shell 里面的可执行程序。对于已经获取了 root 权限的 Android 设备来说，能进行的操作更多。它允许直接从 Android shell 中：

 * 启动/停止 Android 应用活动，服务
 * 卸载/安装 Android (系统)应用
 * 监视 Android 运行过程所产生的日志
............

---------------------------
&nbsp;&nbsp; adb shell 不仅可以直接执行位于 Android 系统中的本地可执行(包括 shell 脚本和本地可执行,大多数位于/system/bin;/system/xbin;/system/sbin下.少数位于 /sbin 等目录下)(adb shell 允许传递一个指令作为参数来直接执行一个位于 Android 设备上的本地可执行文件而不必每次都要先通过 adb shell 进入了 Android 的 shell 环境后再去执行某个指令。)

> adb shell : 进入设备的shell

```Bash
$ adb shell
```

使用adb: 使用adb shell直接运行一个shell指令:
$ adb shell busybox mount -o remount,rw /system

--------------------

### am：Android 应用、服务调试工具

&nbsp;&nbsp;Android shell 里不仅可以执行标准的 sh，还可以执行某些只适用于 Android 设备的指令，比如调试专用的 am 和 logcat

&nbsp;&nbsp;am 是一个位于 Android 设备上的本地可执行，主要功能是运行/停止 Android 设备上的一个 Android 应用，管理 Android 设备上的服务.....。它们都需要在 adb shell 中或者以 adb shell 的子命令形式使用。用法： 

```adb shell
am subcmd options或者adb shell am subcmd options
```

> options 包括:

 * -k 这个选项不是必须的
 * -n 用于指定 Android apk 包的包名及主活动(因为 Android 应用上层是使用了 Java 来实现)
........

> [adb shell] am {subcmd} 包括：start|kill|service...，如果已经进入了 adb shell，可以直接使用 am，否则就要在它的前端加上 adb shell。

 1. `start`子命令用于启动应用。启动一个包名为 package,主活动为 Activity 的应用。关于 Android 应用包名，主活动信息都可以直接通过 PC 上由 Android sdk 提供的的 aapt 工具来获取。

```sh
am start options
am start -n package_name/package_name.Activity  # -n 参数后需要给出两次包名，并且是相同的。比如```
am start -n test.test/test.test.Test
#......
```

2. `kill`子命令用于停止应用，kill 子命令允许直接从 Android shell 停掉一个 Android 应用活动或者服务

3. `service`子命令用于管理 Android 设备上正在运行的服务，service 子命令允许对 Android 系统上的服务进行管理。

```sh
am service subcmd   //subcmd 可以是 list(列出)
```

-----------------------------

# aapt：Android apk 分析工具
&nbsp;&nbsp;Android apk 分析工具(Android Assiant Packging Tool)，不仅可以用来分析得到一些 apk 概况(比如列出 apk 包内的文件和列出 apk 权限)还可以用来更改 apk 包(添加或者删除 apk 包中的某个文件,甚至可以用来重新打包 apk)

&nbsp;&nbsp;这个工具是在编译 Android 系统镜像时交叉编译(为主机而编译)然后输出到安卓 sdk 源码下的`/out/host/linux-x86/bin`这个目录下的。这个工具不需要以根用户权限来执行，下面是它的几个基本使用方法：

+ 列出 apk 包中包含的文件：`aapt l[ist] [-v] [-a] apk_file_name`
 
 + list 表示列出文件,方括号和方括号中的字符表示这是可选输入的
 + -v 选项能以更详细的表格形式列出 apk 包中包含的文件信息
 + -a 选项能以更详细的输出显示 Android apk 包的资源表(Resources Table)

```Bash
#以表格详情列出 Test.apk 包中包含的文件
aapt list -v Test.apk
```

Test.apk

|Length|Method|Size|Ratio|Offset|Date/Time|CRC-32|Name|
|:-:|:-:|:-:|:-:|:-:|:-:|:-:|:-:|
|文件长度|使用的方法|未知|大小|偏移|时间|校验和|文件或者目录名称|
|.......|


+ 列出 apk 包详情 aapt d[ump]  //转存
 
```Bash
aapt dump badging Test.apk
```

> 输出类似于以下结果:

&nbsp;&nbsp;包名被提供给 adb 工具的 uninstall 参数时会卸载 Android 应用,系统应用不再此列，Android sdk tools 命令行创建项目时也需要指定包名，Android 的 am 工具运行 Android 应用时需要使用包名参数

```log
package: name='led.test' versionCode='1' versionName='1.0'
Sdk 版本,API Levl
sdkVersion:'17'
Sdk target
targetSdkVersion:'17'
应用程序标签
application-label:'ledtest'
应用程序图标大小,运行时的图标及标签
application-icon-160:'res/drawable-hdpi/ic_launcher.png'
application-icon-240:'res/drawable-hdpi/ic_launcher.png'
application: label='ledtest' icon='res/drawable-hdpi/ic_launcher.png'
应用程序运行时加载的包和主活动
launchable-activity: name='led.test.Led'  label='ledtest' icon=''
uses-feature:'android.hardware.touchscreen'
uses-implied-feature:'android.hardware.touchscreen','assumed you require a touch screen unless explicitly made optional'
main
支持的 LCD 屏幕大小,分辨率大小
supports-screens: 'small' 'normal' 'large' 'xlarge'
supports-any-density: 'true'
locales: '--_--'
densities: '160' '240'
```

+ 列出 GoogleTTS.apk 权限
 
```Bash
aapt dump permissions GoogleTTS.apk
```

> package: com.google.android.tts //包名

+ uses-permission: android.permission.INTERNET //允许应用联网
+ uses-permission: android.permission.ACCESS_NETWORK_STATE //允许查看,访问网络状态
+ uses-permission: android.permission.WRITE_EXTERNAL_STORAGE //允许写入数据到外部 sd 卡
+ uses-permission: com.google.android.providers.gsf.permission.READ_GSERVICES

-----------------------------

# logcat：Android 日志分析器


--------------------

# FIQ

？普通用户执行adb devices: `adb devices`

```log
List of devices attached 
???????????		no perssions
```

！以根用户权限杀死adb服务并启动adb `adb kill-server` `adb start-server`

然后就可以让普通用户使用adb: 列出设备,如果adb守护服务尚未启动，这个动作会同时启动adb-server

```Bash
$ adb devices
```

```log
List of devices attached 
0123456789ABCDEF	device
```

！也许应该给adb设置setuid以便让普通用户在运行adb时也有root权限 来正常访问连接到的设备.

```Bash
chmod u+s `which adb`
```

！adb连接的设备可能因为某些问题而存在延时问题,可以尝试重启一下udev服务 ` ervice udev restart`


> 添加google推荐的udev规则到 /etc/udev/rules.d/,然后重启udev服务（`service udev restart`），google android设备udev规则

======== vim /etc/udev/rules.d/50-android.rules ============

```config
SUBSYSTEM=="andorid" ATTR{},ATTR{},
```

删除 ~/.android/adbkey* 不是必须的，`rm -fr ~/.android`


？adb push文件到/system下出现

```log
failed to copy 'led_mod.ko' to '/system/tmp/led_mod.ko': Read-only file system
```

！解决方案一： $ adb remount

解决方案二：

```Bash
adb shell
busybox mount -o remount,rw /system
```

？adb install安装出现

```Bash
adb shell
insmod led_test.ko
rmmod led_test
```

```log
insmod: init_module 'led_mod.ko' failed (Exec format error)
rmmod: delete_module 'led_mod' failed (errno 16)
```

? /home/external/back/tmp/android/led/jni/Android.mk:6: *** 遗漏分隔符
! Android.mk不能使用制表符作为分隔符,每行规则确保书写正确

? Unable to handle kernel paging request at virtual address 110002e0
! 只能访问经过映射为虚拟地址后的寄存器变量

```adb shell
shell@android:/data/local # rmmod ledtest                                      
```

```log
[  383.270000] led_class removed
shell@android:/data/local # [  384.020000] Unable to handle kernel paging request at virtual address bf0002e0
[  384.020000] pgd = db914000
[  384.020000] [bf0002e0] *pgd=5bbe1811, *pte=00000000, *ppte=00000000
[  384.020000] Internal error: Oops: 7 [#1] PREEMPT SMP ARM
[  384.020000] Modules linked in: [last unloaded: ledtest]
[  384.020000] CPU: 0    Tainted: G           O  (3.5.0-FriendlyARM #6)
[  384.020000] PC is at misc_open+0x4c/0x194
[  384.020000] LR is at misc_open+0x20/0x194
[  384.020000] pc : [<c0231084>]    lr : [<c0231058>]    psr: 80000013
[  384.020000] sp : dbb59dc8  ip : c19b56b0  fp : dc54b360
[  384.020000] r10: bf0002e0  r9 : c00f2e80  r8 : c08942e0
[  384.020000] r7 : dc3287f8  r6 : dbebe180  r5 : 00000032  r4 : c08942f8
[  384.020000] r3 : bf0002ec  r2 : dbb59dc0  r1 : 00000000  r0 : c08942e0
[  384.020000] Flags: Nzcv  IRQs on  FIQs on  Mode SVC_32  ISA ARM  Segment user
[  384.020000] Control: 10c5387d  Table: 5b91404a  DAC: 00000015
[  384.020000] 
[  384.020000] PC: 0xc0231004:
[  384.020000] 1004  e0655006 ebffffcc e0641005 ebfef871 e2844eff e284400f e0844001 e3c40eff
[  384.020000] 1024  e3c0000f e8bd8070 e30402e0 e34c0089 ea0dd763 e92d45f8 e59f8180 e590502c
[  384.020000] 1044  e1a04008 e1a07000 e1a00008 e1a06001 eb0dd7d5 e5b43018 e3c554ff e1530004
[  384.020000] 1064  e3c5560f e243a00c 1a000004 ea000032 e59a300c e1530004 e243a00c 0a00002e
[  384.020000] 1084  e513300c e1530005 1afffff8 e59a3008 e3530000 0a000028 e5930000 ebf92499
[  384.020000] 10a4  e3500000 0a000024 e59a3008 e3530000 0a000021 e5964010 e5863010 e593502c
[  384.020000] 10c4  e3550000 0a000014 e586a080 e593302c e1a00007 e1a01006 e12fff33 e2505000
```

? 动态库需要在系统引导时重新载入:
