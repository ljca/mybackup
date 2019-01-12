# Linux平台下的中国象棋游戏gmchess
gmchess 是一款 Linux 下的中国象棋游戏。

作者信息：

Main developer:
lerosua@gmail.com
xihes@gmail.com

patch developer:
aginobili@gmail.com
gbreed@gmail.com

&nbsp;&nbsp;GMChess program is write by gtkmm and c++，以及开源程序象棋巫师的源码。不幸的是，作者提供的预编译版本只有 Debian 系的才可以直接下载安装)，其它的 Linux 发行想要安装这个游戏可能需要自行获取源码并编译安装到系统中。

&nbsp;&nbsp;当然，在 Arch Linux 系统上，官方源里面找不到的很多软件都可以在 aur 上面发现。即使如此，aur 上的 gmchess 的构建脚本因为源码包地址是错误(aur 上提交这个包的作者还暂时没有修正这个错误)可能导致构建不成功，所以如果需要的话，可能需要对构建脚本 PKGBUILD 的源码地址的 url 部分进行修改以便使构建工具能正常获取源码包.

&nbsp;&nbsp;如果系统已经安装了 yaourt(fr 和 cn 源中都包含了),那么可以直接以普通用户自动构建并安装 gmchess:

```Bash
yaourt -S gmchess
```

&nbsp;&nbsp;否则的话应该手动构建（yaourt 在构建时会将构建脚本下载到 /tmp 下的一个以 yaourt-用户名开始的目录中），所以下载 gmchess 构建脚本可以通过yaourt 来做。

&nbsp;&nbsp;手动构建方式类似于`cd /tmp/yaourt-..tmp;makepkg -sr`如果没有传递 -i 给 makepkg，那么构建好时默认不会安装。安装本地包只需要将 -S 选项改成 -U 选项,而其它的一样。卸载也和使用`pacman -S`安装的一样。手动编译安装 gmchess 的方式，编译安装都采用了默认的选项：


```Bash
# 大多数 configure 脚本会创建 Makefile 文件指导 make 继续下一阶段的工作，Makefile 里面大多都包含了编译/安装/卸载等规则。

# tar -xf gmchess-0.29.6.tar.bz2

# configure 脚本配置选项：默认。 程序最终的安装路径也是默认的：/usr/local

cd gmchess-0.29.6;./configure

# 编译和安装方式：默认

make -j3 && sudo make install
```

&nbsp;&nbsp;configure 脚本执行成功会创建 Makefile 和 config.log(里面有 configure 脚本配置和 make 指令的执行结果,源码编译成功后可以保留前几行然后再删除源码。)

&nbsp;&nbsp;如果没有意外的话，gmchess 就安装到了系统中。可以直接在终端模拟器中后台运行。

&nbsp;&nbsp;手动编译安装方式的卸载(如果已经删除了源码，那就还要执行一遍 configure)：

```Bash
cd gmchess-0.29.6;sudo make uninstall
```

