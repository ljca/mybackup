#  adb
使用adb: 重新挂载远程(安卓设备上)的system分区为读写.
$ adb remount

使用adb: 安装应用到设备
$ adb install [-l] [-r] [-s] apkfile
-s 安装到sd卡(如果有)

Note:
1.卸载apk使用的是包名，如果应用安装到了data分区，可以直接到设备上的/data/data目录下查询，包名被作为文件夹.(google虽然提供了一个adb补全插件(以脚本的形式存在)，但这个插件只对bash(zsh,ksh,csh等shell没有效果)有效),使用apk文件名不再有效!

2.安装到system/app下的apk通过重新挂载设备/system分区为读写后直接删除或重命名来卸载！

3.package是创建安卓工程时的-k参数名,还可以在Android工程下的AndroidMainfest.xml的mainfest节点下的package属性值

4.-k参数可以保留用户数据以便再次安装应用时可以很快恢复到应用未卸载前的样子.
$ adb uninstall [-k] package_name

使用adb: 进入设备的shell
$ adb shell

使用adb: 使用adb shell直接运行一个shell指令:
$ adb shell busybox mount -o remount,rw /system


$ adb devices
List of devices attached 
???????????		no perssions

解决方案1:
以根用户权限杀死adb服务并启动adb
# adb kill-server
# adb start-server

然后就可以让普通用户使用adb: 列出设备,如果adb守护服务尚未启动，这个动作会同时启动adb-server
$ adb devices
List of devices attached 
0123456789ABCDEF	device

adb push文件到/system下出现
failed to copy 'led_mod.ko' to '/system/tmp/led_mod.ko': Read-only file system

解决方案一：
$ adb remount

解决方案二：
$ adb shell
# busybox mount -o remount,rw /system

adb install安装出现

# adb shell
# insmod led_test.ko
insmod: init_module 'led_mod.ko' failed (Exec format error)

# rmmod led_test
rmmod: delete_module 'led_mod' failed (errno 16)

? /home/external/back/tmp/android/led/jni/Android.mk:6: *** 遗漏分隔符
! Android.mk不能使用制表符作为分隔符,每行规则确保书写正确

? Unable to handle kernel paging request at virtual address 110002e0
! 只能访问经过映射为虚拟地址后的寄存器变量

shell@android:/data/local # rmmod ledtest                                      
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

? 动态库需要在系统引导时重新载入:

