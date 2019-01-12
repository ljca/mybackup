# fedora_install_lovewallpapers
1. install 必须依赖 python-pyside ：`dnf install python-pyside`
如果没有安装这个软件包,会提示载入模块Pyside.QtCore失败
安装好lovewallpaper的依赖软件包之后,直接使用LoveWallpaper提供给Fedora的rpm包 `rpm -ivh LoveWallpaper4LinuxFedora.rpm`

.tar.gz包安装: `tar -xf LoveWallpaper4Linux.tar.gz`

修改安装脚本 INSTALL.sh和data/LoveWallpaper.desktop文件为正确的路径,并以根用户权限执行安装脚本.

为了方便安装和卸载,将安装脚本修改为makefile,然后使用make来直接安装或者卸载 ：`mv INSTALL.sh makefile && make install`
