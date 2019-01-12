# adb_tmp
普通用户执行adb devices:
$ adb devices
List of devices attached 
???????????		no perssions
也许应该给adb设置setuid以便让普通用户在运行adb时也有root权限 来正常访问连接到的设备.
# chmod u+s `which adb`

adb连接的设备可能因为某些问题而存在延时问题,可以尝试重启一下udev服务
# service udev restart

添加google推荐的udev规则到 /etc/udev/rules.d/,然后重启udev服务
google android设备udev规则
# vim /etc/udev/rules.d/50-android.rules
# SUBSYSTEM=="andorid" ATTR{},ATTR{},
# service udev restart

以下步骤不是必须的:
删除 ~/.android/adbkey*
$ rm -fr ~/.android
