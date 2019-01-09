#  Fedora Xfce 23 thunar 显不出文件缩略图却不知为那般？
&nbsp;&nbsp;在我的 Fedora[^fedora] Xfce 系统上，有一个问题让我让我觉得十分奇怪：Xfce 的 Thunar 文件管理器不显示出图片/视频/文档等文件的缩略图(我发现一开始好像不会这样，后来就变成了文件的缩略图上仅仅只有文件类型了)，图片浏览器 Ristretto 也是如此…… 哦，不知道是什么原因导致了这样的问题[^problem]。

## 重新编译安装 tumbler 

> &nbsp;&nbsp;为了能够让 thunar 显示文件缩略图，我们需要安装 tumbler 插件以及生成某类文件缩略图的工具，如果这没有用，**`那么我们很有可能需要重新编译 tumbler`[^option]** 以便让 Thunar 在启动时就能够加载 tumbler 发现某类文件的缩略图生成工具生成缩略图。这就需要在编译它的时候检测到（没有检测到恐怕默认是不会启用的）缩略图插件并启用它，因此，我们在编译 tumbler 之前，还得根据需要安装 `启用某类文件缩略图支持` 所需要的库才行[^config]。

[^config]: 请注意 ./configure 脚本的输出(这个地方是因为我不知道需要安装那些库和头文件，因此手动运行了 configure 脚本查看配置，安装这些库和头文件之后还要对刚才的 configure 脚本执行后生成的文件进行清理(一般是运行 make clean 或者 make distclean)然后重新运行 configure 脚本生成 Makefile.)可以看出要让 Thunar 支持，只需要使用 dnf 安装对应的库和头文件(库和头文件在 Fedora 系统上被分别打包成了一个软件包，库名能通过搜索得到，头文件一般是库加上 -devel 的形式出现)就行。

[^option]:  你可以尝试一下不重新编译 tumbler 而是仅仅安装那些 tumbler 生成缩略图所需要的工具和库。

### 1. 安装需要的库及头文件 ###
  + GdkPixbuf thumbnailer plugin: yes gdk-pixbuf2-devel
  + Cover thumbnailer plugin: no --> libcurl libcurl-devel
  + FreeType font thumbnailer plugin: yes --> freetype-devel 
  + JPEG thumbnailer plugin with EXIF support: no --> libexif libexif-devel libjpeg-turbo libjpeg-turbo-utils libjpeg-turbo-devel
  + Video thumbnailer plugin using ffmpegthumbnailer: no --> ffmpegthumbnailer ffmpegthumbnailer-devel
  + Video thumbnailer plugin using GStreamer: no --> gstreamer-devel gstreamer1-devel gstreamer1-plugins-base-devel
  + ODF thumbnailer plugin using libgsf: no --> libgsf libgsf-devel
  + PDF/PS thumbnailer plugin using poppler: no --> poppler-devel poppler-glib-devel
  + RAW thumbnailer plugin using libopenraw: no --> libopenraw libopenraw-devel libopenraw-gnome-devel libopenraw-pixbuf-loader libopenraw-gnome 
  + Freedesktop.org cache plugin: yes 

```Bash
alias dnfi='sudo dnf install -y'
dnfi tumbler-devel tumbler-extras libcurl-devel libexif-devel libjpeg-turbo-devel ffmpegthumbnailer-devel gstreamer-devel gstreamer1-devel libgsf-devel poppler-devel libopenraw-devel gdk-pixbuf2-devel dbus-glib-devel intltool poppler-glib-devel libopenraw-devel libopenraw-gnome-devel libopenraw-pixbuf-loader libopenraw-gnome poppler-glib-devel dbus-glib-devel
```

### 2. 编译 tumble

如果确定所需要支持的文件缩略图所对应的库及头文件都已装好，那么可以清理并尝试真正编译了。或者重新解开源码包，进入源码目录：

```Bash
# 在 configure 过程中，随时可以根据需要安装对应的插件库然后清理(假如 configure 脚本执行成功了的话，直接执行 make clean 或者 make distclean)重新 configure。
./configure --prefix=$HOME/.local && make && make install
```

**`一旦完成了 tumbler 的编译和安装，那么就可以注销系统重新登录看看效果了。`**

### Thunar 重新编译安装 （这是可选的）
（根据我的手动测试，即使覆盖安装系统中已存在的，可能仍不会有效），但重新编译它可以启用某些插件或者特性。它的编译过程有点类似于编译安装 tumbler，configure 直接使用默认参数即可。

以下是一些特性所对应的库：

 + X11库 --> libX11 libX11-devel
 + 缩略图支持 --> tumbler tumbler-devel tumbler-extras perl-Data-Tumbler
 + 面板通知支持 --> startup-notification-devel startup-notification libnotify libnotify-devel libgudev-devel libgudev
 + 面板回收站支持 --> xfce4-panel-devel
 + 会话支持 --> xfce4-session-devel

```Bash
dnfi libX11-devel libjpeg-turbo-utils libjpeg-turbo-devel  perl-Data-Tumbler intltool libxfce4ui-devel metadata-extractor2 exif poppler-utils  poppler-data  poppler zathura-pdf-poppler gstreamer-plugins-* gstreamer1-plugins-*  gstreamer-ffmpeg libxfce4ui-devel libxfce4util-devel xfce4-panel-devel xfce4-session-devel startup-notification-devel libnotify-devel libgudev-devel libexif-devel  xfce4-panel-devel xfce4-session-devel xfdesktop 
```

> thunar 插件 -->

 + gtkhash-thunar
 + thunar-vfs-devel
 + thunar-sendto-clamtk
 + thunarx-python
 + thunar-media-tags-plugin
 + thunar-vcs-plugin
 + thunar-vfs

```Bash
dnfi gtkhash-thunar thunar-vfs-devel thunar-sendto-clamtk thunarx-python thunar-media-tags-plugin thunar-vcs-plugin thunar-vfs thunar-volman thunar-media-tags-plugin thunar-archive-plugin
```

```Bash
dnfi --allowerasing exo-devel
```

### 编译和安装 Thunar：
```Bash
# 好叫你知道：手动编译安装 tumbler 后也许不会立即生效，需要重启 X 或者重启系统。尽管过程曲折而又多变，但不管怎样，总算可以让 Thunar 显示缩略图了。
cd Thunar-1.6.6;./configure --sysconfdir=/etc
make && sudo make install
```


> &nbsp;&nbsp;[Thunar Thumbnailers](http://goodies.xfce.org/projects/thunar-plugins/thunar-thumbnailers)  项目的目的是为其他缩略图忽略的媒体格式提供缩略图生成。下面这些是 thunar-thumbnailers 项目对其简单介绍和安装方法的谷歌翻译：

&nbsp;&nbsp;Thunar 使用外部实用程序（称为缩略图）来生成某些文件的预览。 Thunar 附带缩略图，以生成图像和字体文件的预览，并且可以自动使用可用的GNOME缩略图，如果它是支持 gconf 构建的。然而，即使这样，也有几种不存在缩略图的文件类型。 Thunar-thumbnailers 项目为 Thunar 提供了更多的缩略图，也覆盖了较少的常见文件格式。

> Thunth-thumnbnailers 生成以下格式的缩略图：

 + EPS
 + Postscript
 + PDF
 + DVI
 + OpenDocument Format
 + SVGZ (compressed SVG)
 + Fig (.fig)
 + LaTeX (requires tetex)
 + Raw Digital Camera Images (requires raw-thumbnailer and/or dcraw)
 + Grace (requires grace)
 + Video files (requires ffmpegthumbnailer)
 + XCF Images (The GIMP's native format)
 + Photoshop (PSD) images

在不久的将来，希望：

 + AVCHD video files (.MTS extension)
 + Audio files (audiothumbnailer)
 + RealMedia video files (in ffmpeg 0.5!!!)
 + OpenEXR
 + Abiword's supported files
 + Digital Comic (CBZ, CBR)
 + Gnuplot batch files (.gnuplot)

svn 貌似不可访问了，而使用了 git

```Bash
svn co http://svn.xfce.org/svn/goodies/thunar-thumbnailers/trunk/ thunar-thumbnailers
git clone git://git.xfce.org/apps/thunar-thumbnailers
```

进入目录使用 autogen.sh 进行自动 configure，如果成功执行的话就会创建 Makefile

```
cd thunar-thumbnailers;./autogen.sh
make
```

以根用户权限执行:

```Bash
make install
```

运行:

```Bash
/usr/libexec/thunar-vfs-update-thumbnailers-cache-1
```

注册新的文件缩略图给 Thunar。然后可以尝试搜索（二进制）文件来检查 Thunar 识别出哪些缩略图

```Bash
less ${HOME}/.cache/Thunar/thumbnailers.cache
```

依赖：

 + [ImageMagick](https://www.imagemagick.org)
 + [ImageMagick git 地址](https://github.com/ImageMagick/ImageMagick)

参考 [Arch Linux Thunar 条目][0]

[0]: https://wiki.archlinux.org/index.php/Thunar_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[Audio-thumbs]: https://github.com/bvbfan/Audio-thumbs
[thunar-thumbnailers]: git://git.xfce.org/apps/thunar-thumbnailers
[ImageMagick]: http://git.imagemagick.org/repos/ImageMagick.git

[^fedora]: Fedora 作为一种老牌 Linux 发行，基于 Redhat，其实是 Redhat 的内部测试版本。而 Fedora 默认发行的平台是 Workstation，使用的桌面环境是 Gnome，使用 Xfce 作为桌面环境的 Fedora 较之稍显轻量，似乎这并足以成为不使用 Gnome 桌面环境的理由。因为默认的 Gnome 桌面环境为了能照顾用户“开箱即用”，已经安装了用户可能会用到的大多数程序。得益于 Fedora 中文源的出现，一些像 windows 的应用(比如网易云音乐，福昕阅读器和 Adobe Reader 等)可以在 Fedora Linux 上也能见到，而不必再花更多的时间去安装配置 Wine。
-- 然而，即便如此，仍然有不少程序是根本用不上的或者因为布局及习惯等原因不是用户所喜欢的，虽然好像可以直接将它们移除掉让它们消失并归还占用的磁盘空间，但尴尬的是，Linux 上的程序因为捆绑和依赖等问题，能解决依赖关系的高级包管理工具会“聪明的”在卸载的时候将与之有依赖关系的程序一并卸载了，这其中有些甚至是桌面环境中很重要的组件（比如，假如我不喜欢 iubs 输入法并尝试直接卸载掉它，那么可能会出现系统控制中心也一起卸载了的尴尬问题）。
-- 或许 Xfce 桌面环境在处理这些事情上要表现的“宽容”一些，上面搭载的应用对内存的要求也没有那么高。所以，它的图形用户界面看起来似乎非常的朴素（那些貌似多余的动画效果都直接甩掉了）。

[^problem]: 后来在维基上发现了这个问题的解决方案，说是 Thunar 已经支持缩略图，只需要安装 tumbler 就行了。然而我很快发现，重新安装 tumbler 并没有什么用处，却不知是何故？ 也曾私下里有过各种猜测：是因为系统的安全策略问题？抑或是更多相关的库或者插件没装？还是需要重新编译安装 thunar 或者 thunar 插件？偶然发现 Ubuntu 的 xfce4 桌面环境的 thunar 也是这个样子的，而且连 panel 上的那个网络管理 applet 都没有了。 这个问题困扰了俺很久很久……灵光一闪尝试着手动编译安装了 Thunar 和 tumbler，没想到重新登录之后久违的文件缩略图又出现了。

ljca&copy;2017-?
