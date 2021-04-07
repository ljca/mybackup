<link href="../../css/style.css" rel="stylesheet" type="text/css" />


# centos7配置vsftpd服务器

在 Linux 上，FTP 服务器的实现，真的有很多。比如：`tftp-server`。但是 vsftpd 是轻量级的，安全的。

## Install

##  Configure ![](../images/1543757688_489799211.png)

![](../images/1543758336_1061117187.png)/etc/vsftpd/vsftpd.conf
![](../images/1543758336_1061117187.png)/etc/vsftpd/user_list
![](../images/1543758336_1061117187.png)/etc/vsftpd/chroot_list

### 虚拟用户

>  ftp 客户端，CLI: `ftp`、`lftp`，GUI: `filezilla` 


# 附 

## Arch Linux 配置 vsftpd ![](../images/1543758336_1061117187.png)[vsftpd.conf](config/vsftpd.conf)

![](../images/k_tip_5_Bulb_32px.png)虚拟用户不必在系统中存在，但是必须在 vsftpd 的用户列表中存在。[](config/vsftpd/.passwd)。如果给虚拟用户使用 openssl (`openssl passwd -1 >> .passwd`) 或者 apache 提供的 httpasswd（） 设置了密码，那就要使用 pam 认证模块进行认证。但是 Arch Linux 已经不再使用 libpwd，而是使用其它的。一个轻量级的用户 pam 认证模块：`libpam_pwdfile`。pam 认证模块必须和 vsftpd.conf 中定义的一致：![](../images/1543758336_1061117187.png)[/etc/pam.d/vsftpd](config/vsftpd/vsftpd) 
> ![](../images/achtung_alert_warning_32px.png)虚拟用户的配置需要单独进行。

+ [user1](config/vsftpd/vconf/iso)
+ [user2](config/vsftpd/vconf/others)
