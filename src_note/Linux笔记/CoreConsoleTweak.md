
> 禁止Arch Linux启动时清除启动信息： 创建目录 `/etc/systemd/system/getty@tty1.service.d`，And Then,Touch file: `noclear.conf`, Add: 

```cfg
[Service]
TTYVTDisallocate=no
```

&nbsp;&nbsp;在systemd上,禁止tmp分区自动挂载为tmpfs：`systemctl mask tmp.mount`，这会在/etc/systemd/system下创建一个指向/dev/null的符号链接tmp.mount

&nbsp;&nbsp;核心控制台滚动缓冲区大小设置，传递内核参数：fbcon:scrollback=Nk,默认为32K

&nbsp;&nbsp;临时启用 SysRq：`su -c 'echo 1 > /proc/sys/kernel/sysrq'`，if init=systemd: touch the file:`/etc/sysctl.d/N-xx.conf`, And then add：`kernel.sysrq=1`


> 参考：

+ [stty linux 命令 在线中文手册](http://linux.51yip.com/search/stty)

+ [linux_unix命令行终端的光标及字符控制快捷键 - 技术文档 - 系统管理 Linux时代 - 开源、自由、共享 - 中国最大的Linux技术社区](http://linux.chinaunix.net/techdoc/system/2007/11/23/973027.shtml)
+ [让Linux开机进入字符界面的方法及设置FrameBuffer分辨率的方法_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2015-04/116075.htm)