# pacman：Arch Linux 的软件包管理器

> 安装：-S

+ -y, -yy：刷新软件源
+ -u: -yyu, 滚动升级系统。-yyuu：[降级系统](arch.md)。
+ -s: 搜索软件包
+ -l：列出软件仓库的软件包
+ -g：列出软件包组
+ -i：获取软件仓库中的某个软件包信息

> 软件包查询：-Q

+ -o: 查询本地指定的文件或者指令属于哪个软件包。 `pacman -Qo $(which ls)`
+ -c: 检查已安装的软件包完整性。
+ -i: 查询已安装的某个软件包信息。`pacman -Qi $(which ls)`, -ii 显示所有
+ -n：查询不在系统仓库中的软件包
+ -m：查询位于软件仓库中的软件包
+ -d
+ -t
+ -q：简略格式

> 卸载/移除：-R

+ -d: 忽略依赖，-dd 忽略所有
+ -n: 移除配置文件
+ -c: 级联移除

> 指令查询：-F

+ -s：根据 `pacman -Fyy` 生成的数据库查询某个指令/文件（可以是系统中未安装的软件包）位于哪个软件包中，`pacman -Fs sl`。这需要先执行 `pacman -Fyy`。效果等同 pkgfile。

> 更新：-U，直接安装本地或者网络的软件包。`pacman -U xx.pkg.tar.xz`

+ 帮助：-H

# 附

+ yaourt | pacaur: 从 aur 搜索，安装。
+ pkgfile
+ pactree
+ /etc/pacman.conf
+ /etc/pacman.d/mirrorlist
+ pacman-key --init & 

> **参考：**

+ [Pacman (简体中文) - ArchWiki][pacman]
+ [package_and_database_signature_checking](https://www.archlinux.org/pacman/pacman.conf.5.html#_package_and_database_signature_checking)
+ [pacman_Package signing (简体中文) - ArchWiki][pkg_sig]
+ [PacmanTips and tricks (简体中文) - ArchWiki][pacman_tricks]
+ [ArchLinux 的 pacman 命令详解 - 开源中国社区](http://www.oschina.net/question/54100_29072)

[pacman]: https://wiki.archlinux.org/index.php/Pacman_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)#.E5.88.A0.E9.99.A4.E8.BD.AF.E4.BB.B6.E5.8C.85
[pkg_sig]: https://wiki.archlinux.org/index.php/Pacman/Package_signing_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)#.E9.85.8D.E7.BD.AE_pacman
[pacman_tricks]: https://wiki.archlinux.org/index.php/Pacman/Tips_and_tricks_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
