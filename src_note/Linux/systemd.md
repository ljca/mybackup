<link href="../css/style.css" rel="stylesheet" type="text/css" />

# systemd 笔记

> ***~~作为新一代 `Linux` 的 `init`，`systemd` 优化了 `Sys V` 以及 `Upstart` 在启动和管理系统时暴露的 lue shi 。另外，`systemd` 在设计时并不遵循 `Unix` 哲学。~~***

------------------------ 

> **涉及到系统权限时必须以根用户权限执行！**

## systemctl

+ *`systemctl status [unit-files]`*：查询系统或者某个单元状态

+ *`systemctl list-unit-files [--type]`*

+ *`systemctl daemon-reload`*：重载服务

+ *`systemctl cat <unit-files>`*：查看单元

+ *`systemctl start/stop/restart/kill <service>`*：启动/停止/重启/杀掉服务

+ *`systemctl disable/eanble <unit-files>`*：禁用/启用服务或者单元

+ *`systemctl mask/umask <unit-files>`*

+ *`systemctl reboot`*：重启系统

+ *`systemctl suspend`*：挂起系统/待机

+ ....
 
 --------------------------- 

## systemd-

+ `systemd-analyze`：统计信息
  + `systemd-analyze time`：统计系统启动时间

> Startup finished in 2.597s (firmware) + 1.510s (loader) + 3.478s (kernel) + 8.292s (userspace) = 15.878s 

+ ....

---------------------

## `systemd` `service` 定义

> *** 一个 `systemd` `service` 单元文件主要包含 `Unit`、`Service`、`Install` 三个区段。 大体结构如下：***

```config
[Unit]
Description=
man=
After/Before=
Wants=

[Service]
Type=forking/simple/oneshot/dbus..
ExecStart=
ExecStop=
ExecReload=
ExecStartPre/ExecStartPost=
KillMode=process

RemainAfterExit=

[Install]
Target=multi-user
Alias=
#...
```

>  详见 ：

+ [Systemd 入门教程：实战篇- 阮一峰的网络日志](http://www.ruanyifeng.com/blog/2016/03/systemd-tutorial-part-two.html)
+ Arch Wiki [systemd 条目（中文）][arch_wiki]
+ [从 openrc 到 systemd - 伪程序猿](http://rca.is-programmer.com/2013/7/17/from-openrc-to-systemd.40004.html)

[arch_wiki]: https://wiki.archlinux.org/index.php/systemd_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)+ 

