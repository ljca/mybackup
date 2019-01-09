#  xfce_acpid
acpi自定义电源事件
安装acpid

监听acpi按钮
# acpi_listen
不同于Arch wiki acpid管理的SLPB和SBTN。
button/power PBTN 00000080 00000000
button/power LNXPWRBN:00 00000080 00000005
或者使用openbsd-netcat软件包提供的netcat工具监听acpid套接字(acpid.socket)
# pacman -S --neened openbsd-netcat
# netcat -U /var/run/acpid.socket

# journalctl -f

屏幕背光调节

/etc/acpi/handler.sh
合上笔记本盖子时自动关闭显示器，锁屏，睡眠

打开笔记本盖子时自动点亮显示器
case $(cat /proc/acpi/button/lid/LID0/state|awk '{print $2}') in
 closed) XAUTHORITY=$(ps -C xinit -f --no-header|sed -n 's/.*-auth //; s/ -[^ ].*//; p') xset -dispaly :0 dpms force off;;
 open) XAUTHORITY=$(ps -C xinit -f --no-header|sed -n 's/.*-auth //; s/ -[^ ].*//; p') xset -dispaly :0 dpms force on;;
 esac

连接电源时调高显示器亮度，否则就调低亮度
/etc/acpi/handler.sh

或者直接以根用户权限执行(不同的笔记本上intel_backlight目录值并不都相同):
# echo -n 80 > /sys/class/backlight/intel_backlight/brightness 
#
/sys/class/backlight/intel_backlight/brightness文件允许被重定向以调节屏幕背光
/sys/class/backlight/intel_backlight/actual_brightness保存了当前屏幕背光的亮度值
/sys/class/backlight/intel_backlight/max_brightness文件则保存了背光可以调节到的峰值

[acpid]: https://wiki.archlinux.org/index.php/Acpid_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
+ [ACPI modules (简体中文) - ArchWiki]: https://wiki.archlinux.org/index.php/ACPI_modules_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
