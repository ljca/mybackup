# Arch Linux上编译安装Apache-httpd-2.4.0笔记  

> 必须的编译环境  

+ gcc  
+ make  
+ texinfo  
+ autoconf  
+ ....  

&nbsp;&nbsp;软件包组 base-devel 包含了大多数的开发环境软件包。 查询软件包组 base-devel 中包含的的软件包：  `pacman -Qg base-deve`。apache-httpd以及其依赖  httpd 对其依赖有版本检查。过低的软件版本会让 configure 脚本调用失败。这些依赖包可以单独分开编译或者直接放到 httpd 展开后的目录下的 srclib 目录下让 httpd 在编译时自动调用。也就说，在编译 `Apache-httpd` 之前，下面这些版本的软件包[^httpd]必须先被安装到系统中。

[^httpd]:  在它的官网上有更详细的安装指导。

+ apr  
+ apr-util  
+ pcre-8.10+

httpd configure 选项很多很多，但是一般只需要其中的少许选项，编译安装成功之后，还可以在配置文件中手动启用和禁用某些模块。  

```Bash
./configure --prefix= --with-apr= --with-apr-util= --with-pcre= --sysconfdir=
\  
\--enable-cgi --enable-ssl --enable-deflate --enable-rewrite --enable-so \  
\--enable-mpm-shared= --with-mpm=event|worker|proworker.... --enable-
modules=most|all...
```
  
> `configure` 选项[^config]，更多选项可见 `configure --help`

+ \--prefix= -- 用于将软件安装到不同位置，如果安装目录不存在则在 `make install` 阶段会自动被创建，如果不指定，则会默认安装到/usr/local目录下;  
+ \--sysconfdir= -- 配置文件安装目录
+ \--with-apr  
+ \--with-apr-util  
+ \--with-pcre  
+ \--enable-cgi  
+ \--enable-ssl  
+ \--enable-deflate  
+ \--enable-rewrite  
+ \--enable-so  
+ \--enable-mpm= -- apache-httpd-2.4.0以上版本支持特性

[^config]: &nbsp;&nbsp;如果 `./configure` 被成功执行，那么则会生成一个 `MakeFile` 文件。`make` 会根据 `MakeFile` 中的指令顺序编译。否则应该检查调用 `configure` 脚本时产生的 `configure` 产生的 warning 和 error。那些未通过的软件版本和依赖检查可能会导致调用 `configure` 脚本或者是 `make` 失败。
  
&nbsp;&nbsp;`make [-j num]` -j 选项指定编译时是否使用多线程来编译，多线程编译或许会提高编译速度，但是一些软件包可能会编译失败。  -j 选项后跟一个正整数，这个数字取决于系统中的逻辑 CPU 数量(可以通过 `cat /proc/cpuinfo|grep` 来查看)，它的最优数字等于系统的逻辑 cpu 总数+1；如果 make 执行成功了，但是 make install 执行失败了，那么可能需要重新 make 或者重新以更高权限执行 `make install`；重新 make 务必执行 `make distclean || make clean` 命令，这会清除掉 make 过程中产生的临时编译文件  

&nbsp;&nbsp;`make distclean` 可以清除 `./configure` 和 `make` 过程产生的所有临时文件。`make clean` 不会清除 make 过程产生的可执行以及库文件；更多 `make` 选项可见 `make --help`。

&nbsp;&nbsp;如果在调用 configure 脚本时指定了将配置文件安装到 /etc 目录下，那么需要以根用户的权限运行 make install 命令:  `sudo make install`

> apache-httpd安装完的配置:  

&nbsp;&nbsp;除非在调用 `configure` 脚本时手动指定配置文件路径,即选项 `--sysconfdir`  否则，应该到它的安装目录的下的conf目录中查找 `apache-httpd` 主配置文件 `httpd.conf`
  