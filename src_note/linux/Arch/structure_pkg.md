<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# 怎样在 Arch Linux 构建一个简单的软件包？

 最初，我使用`Deepin`的图标集，但我很快发现并不是很习惯其设计，而 Arch Linux 所带的几套图标主题尽管简洁但我不是很喜欢。想了很久，发现还是很喜欢最开始使用的那套 Humman 图标集，遗憾的是：搜遍源和`AUR`，也没有发现提供给`Arch Linux`的。不过我很快在网络上找到了它，发现只有提供给`Ubuntu`和`Fedora`的。

最初我用了一个 shell 脚本(包括获取 rpm 以及解包 rpm，安装，卸载等工作)希望可以一劳永逸让以后的安装与卸载仅仅需要一条指令，后来还是厌烦了这样做[^1][^2]。

`Arch Linux`赋予了更多的自由给使用者，它还允许使用者去自己构建和构建自己的软件包。于是按照 Wiki 创建了一个临时构建目录，并创建一个最基础的 PKGBUILD (示例文件可以从 /usr/share/pacman/ 下找到)，它是一个 shell 脚本，在 Bash 上能保证运行的很好。随时可以运行 makepkg 测试创建的 PKGBUILD 是否工作正常。

> Note：makepkg 要求下面的几个变量和一个 package 函数是必须在 PKGBUILD 脚本中定义的:

+ pkgdir (代表 pkg )和 srcdir (代表 src )这两个变量不需要定义，它们会在构建之前被自动创建，因此可以直接在函数中引用它们。
 
+ makepkg 会自动检测构建过程中需要用到的基础包格式并尝试在进入 fakeroot 时使用 bsdtar 自动解包它们(源码包可能是在 build 函数中手动解包并配置的)；因此，某些工作实际上并不需要手动完成(比如切换到 src 路径与解包构建所依赖的基础包，这些工作实际上就是在进入`fakeroot`环境时完成的)。
 
+ build 函数只有在有需要编译的代码时才会有意义，这个函数定义在 package 函数之前。

+ package 这个函数是 makepkg 工具唯一要求必须在 PKGBUILD 脚本中定义的。
一旦 PKGBUILD 脚本创建成功并确定没有问题，就可以选择将它提交到 AUR 上或者放在本地供个人使用。
构建环境是在一个 fakeroot 环境，一旦构建成功，那么`makepkg`会在构建目录下创建一个可以供`pacman`直接安装(-U)的软件包(格式类似于:`${pkgname}-${pkgver}-${pkgrel}-${arch}.tar.xz)`


======== PKGBUILD =========

```cfg
# Maintainer: kyzs <k_y_z_s@yeah.net>  PKGBUILD 主要提供者邮箱
pkgname=humanity-icon-theme  # 定义软件包名
pkgver=0.6.10 # 定义软件包版本
pkgrel=1 #
epoch=
arch=('any') # 定义软件包架构,可选值有 i686,x86_64,如果没有架构，应该是 any。如果软件包允许在多个架构上构建，但最终只能运行在一种架构上,可以将多个值使用单引号引起来，然后使用空格隔开
pkgdesc="Ubuntu humanty icon themes." # 软件包描述信息
#'https://launchpad.net/ubuntu/+archive/primary/+files/humanity-icon-theme_0.6.13.dsc'
url="" 
license=('GPL') # 软件包使用的协议
depends=() # 软件包的必须依赖
#makedepends=('rpmextract') # 软件包仅在构建时需要的依赖，构建前自动安装，如果有-s选项的话
install=
# 软件包校验和是很重要的，可以用来验证软件包在作者提供之后是否有被修改的痕迹，除了 md5 之外还有 sha 等方式。如果不知道，可以在下载完成后使用 makepkg -g 自动生成并追加到 PKGBUILD 或者从下载页查询获得。
source=("http://dl.fedoraproject.org/pub/fedora/linux/updates/23/x86_64/h/$pkgname-$pkgver-$pkgrel.fc23.noarch.rpm") # 用于指定构建软件包过程中需要的基础包路径，可以是本地也可以来源于网络。可以是一个因特网上的路径，也可以是本地上(这时可以引用 pkgname 和 pkgvar 变量)的源码包，它是一个数组，可以像像架构一样指定多个值并使用空格分隔。
noextract=()
md5sums=('ec5ac76908f6ad40c1a8ce1ff0a64e53') 
validpgpkeys=()  # 是否具有 gpg 签名
# package 函数是 PKGBUILD 脚本中要有的，里面包含了构建过程中需要明确执行的指令
package() {
  #cd $srcdir
  #rpm2cpio $pkgname-$pkgver-$pkgrel.fc23.noarch.rpm|bsdtar -xf -
  [ ! -d ${pkgdir}/usr ] && install -d ${pkgdir}/usr/local
  cp -rf usr/* ${pkgdir}/usr/local
}
```

如果已经确定写好的 PKGBUILD 没有问题，那么尝试运行 `makepkg -srCci` 开始构建并安装软件包。

> 参考：

+ [makepkg (简体中文) - ArchWiki][makepkg]
+ [Creating packages (简体中文) - ArchWiki][cre_pkg]
+ [PKGBUILD (简体中文) - ArchWiki][pkgbuild]

[makepkg]: https://wiki.archlinux.org/index.php/Makepkg_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[pkgbuild]: https://wiki.archlinux.org/index.php/PKGBUILD_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)#pkgbase
[cre_pkg]: https://wiki.archlinux.org/index.php/Creating_packages_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)

[^1]: 不过这难不倒我，在我看来，图标文件应该是与架构平台等无关的，格式也应该是兼容的，不管什么`Linux`发行上的图标，在 Arch Linux 上应该也是可以正常使用的才怪。

[^2]: 因为`Ubuntu`使用的软件包格式略微比`Fedora`(`rpm`)的格式复杂，因此我直接使用了`Fedora`预编译好的。

