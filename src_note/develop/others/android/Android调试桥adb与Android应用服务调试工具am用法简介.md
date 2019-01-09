#  Android调试桥adb与Android应用服务调试工具am用法简介
adb 是 Android 调试桥(Android Debug Bridge)的简称，一般而言，adb 至少具有以下几个功能：
  1. 调试 Android 程序
  2. 安装、卸载、运行、停止设备上的 Android 应用
  3. ...................................................

>   adb 默认并不会安装在操作系统上，在 Linux 上系统上已经有软件包(一些 Linux 发行已经包含在官方源中)直接提供,可以直接使用软件包管理器下载安装。而 windows 上需要自行下载 adb 并配置环境变量(如果有必要的话)

---------------------------------------------
>   在使用 adb 之前，需要先安装 google usb 驱动并打开Android智能手机的调试功能

---------------------------
>   如果确定 google usb 驱动已经配置完成，那么先要以根用户权限(windows 上是管理员权限)启动 adb server
```Bash
adb start-server
```

以下 adb 操作并没有硬性规定要以根用户权限执行：
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

- 从计算机上上传文件到 Android 设备：
```Bash
adb push file/directory /sdcard
```
- 从 Android 设备上下载文件到本地计算上：
```Bash
adb pull /sdcard/tmp/test.txt /tmp
```

>   shell 是 adb 中一个强大的指令，它不仅可以直接进入 Android 的  shell，还可以直接运行 Android Shell 里面的可执行程序。对于已经获取了 root 权限的 Android 设备来说，能进行的操作更多。它允许直接从 Android shell 中：
 * 启动/停止 Android 应用活动，服务
 * 卸载/安装 Android (系统)应用
 * 监视 Android 运行过程所产生的日志
............

---------------------------
>   adb shell 不仅可以直接执行位于 Android 系统中的本地可执行(包括 shell 脚本和本地可执行,大多数位于/system/bin;/system/xbin;/system/sbin下.少数位于 /sbin 等目录下)(adb shell 允许传递一个指令作为参数来直接执行一个位于 Android 设备上的本地可执行文件而不必每次都要先通过 adb shell 进入了 Android 的 shell 环境后再去执行某个指令。)

--------------------
>   Android shell 里不仅可以执行标准的 sh，还可以执行某些只适用于 Android 设备的指令，比如调试专用的 am 和 logcat
am 是一个位于 Android 设备上的本地可执行，主要功能是运行/停止 Android 设备上的一个 Android 应用，管理 Android 设备上的服务.....。它们都需要在 adb shell 中或者以 adb shell 的子命令形式使用。用法： 
```adb shell
am subcmd options```或者```adb shell am subcmd options```
options 包括:
 * -k 这个选项不是必须的
 * -n 用于指定 Android apk 包的包名及主活动(因为 Android 应用上层是使用了 Java 来实现)
........

--------------------
> + am {subcmd} 包括：start|kill|service...
 1. `start`子命令用于启动应用。
启动一个包名为 package,主活动为 Activity 的应用。关于 Android 应用包名，主活动信息都可以直接通过 PC 上由 Android sdk 提供的的 aapt 工具来获取。
> ```sh
am start options
```
```am start -n package_name/package_name.Activity  # -n 参数后需要给出两次包名，并且是相同的。比如```
```Bash
am start -n test.test/test.test.Test
......
```
 2. `kill`子命令用于停止应用
kill 子命令允许直接从 Android shell 停掉一个 Android 应用活动或者服务
 3. `service`子命令用于管理 Android 设备上正在运行的服务
service 子命令允许对 Android 系统上的服务进行管理。用法：
```sh
am service subcmd   //subcmd 可以是 list(列出)
```
