<link href="../../css/style.css" rel="stylesheet" type="text/css" />


# xfce acpid 自定义电源事件

> install acpid

```Bash
pacman -S --neened openbsd-netcat
netcat -U /var/run/acpid.socket
journalctl -f
```


> 监听acpi按钮 `acpi_listen`，不同于Arch wiki acpid管理的SLPB和SBTN。或者使用openbsd-netcat软件包提供的netcat工具监听acpid套接字(acpid.socket)

+ button/power PBTN 00000080 00000000
+ button/power LNXPWRBN:00 00000080 00000005

屏幕背光调节 /etc/acpi/handler.sh，合上笔记本盖子时自动关闭显示器，锁屏，睡眠，打开笔记本盖子时自动点亮显示器

```Bash
case $(cat /proc/acpi/button/lid/LID0/state|awk '{print $2}') in
 closed) XAUTHORITY=$(ps -C xinit -f --no-header|sed -n 's/.*-auth //; s/ -[^ ].*//; p') xset -dispaly :0 dpms force off;;
 open) XAUTHORITY=$(ps -C xinit -f --no-header|sed -n 's/.*-auth //; s/ -[^ ].*//; p') xset -dispaly :0 dpms force on;;
 esac
```

连接电源时调高显示器亮度，否则就调低亮度 /etc/acpi/handler.sh，或者直接以根用户权限执行(不同的笔记本上intel_backlight目录值并不都相同):

```Bash
echo -n 80 > /sys/class/backlight/intel_backlight/brightness 
#
```
+ `/sys/class/backlight/intel_backlight/brightness` 允许被重定向以调节屏幕背光
+ `/sys/class/backlight/intel_backlight/actual_brightness` 保存了当前屏幕背光的亮度值
+ `/sys/class/backlight/intel_backlight/max_brightness` 保存了背光可以调节到的峰值

# 参考：

+ [xfce acpid 自定义电源事件][acpid]
+ [ACPI modules (简体中文) - ArchWiki][wiki]

[wiki]: https://wiki.archlinux.org/index.php/ACPI_modules_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[acpid]: https://wiki.archlinux.org/index.php/Acpid_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)

# FIQ 
## acpid_error

```log
ACPI:
[6.468204] ACPI Error: [\_SB_.PCI0.LPCB.H_EC.ECRD] Namespace lookup failure, AE_NOT_FOUND (20160930/psargs-359)
[6.470072] ACPI Error: Method parse/execution failed [\_TZ.TZ01._TMP] (Node ffff88015a0f1d98), AE_NOT_FOUND (20160930/psparse-543)

USB:
[7.636052] usb 1-5: string descriptor 0 read error: -22
```
