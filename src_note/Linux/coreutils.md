# [coreutils：Linux 核心工具集][1]

## [：
## b2sum：
## base32：
## base64：
## basename：
## cat：
## chcon：
## chgrp：
## [chmod](coreutils/chmod.md)：文件/目录权限模式更改

## [chown](coreutils/chown.md)：文件或者目录所有者更改

```
chown [Options] [owner]:group file/Directory
```

## chroot：根切换
## cksum：
## comm：文件比较
## cp：
## csplit：
## cut：转换，输出
&nbsp;&nbsp;此命令以行为单位，对命令输出或者文件流进行第二次处理。 不带任何参数的cut命令默认使用空格或者tab来作为分隔符。

+ -d 使用自定义控制符过滤,这必须和-f选项一起使用

+ -f 指定域，也就是文件中的每行中的哪几部分，以数字计数。还可以使用-1，指定每行中哪几部分，如0-1,5这可以

## date：
## dd：读取、转换、输入、输出
## dfm
## dir：
## dircolors：
## dirname：
## du：
## echo：
## env：
## expand：制表符转换为空格

```bash
expand options [file]|-
options:
-i
-t|--tabs #制表符默认为8个空格，如果需要将制表符转换为更少的空格，使用-t参数。
-t|--tabs #指定制表符出现的位置，以逗号分隔
```
## expr：
## factor：
## false：
## fmt：
## fold：
## head：
## hostid：
## id：
## install：
## join：
## link：
## ln：
## logname：
## [ls](coreutils/ls.md)：在Unix及其变体终端窗口上显示文件或者子目录。
## md5sum：
## mkdir：
## mkfifo：
## mknod：
## mktemp：
## mv：
## nice：
## nl：
## nohup：
## nproc：
## numfmt：
## od：
## paste：
## pathchk：
## pinky：
## [pr](coreutils/pr.md)：
## printenv：
## printf：
## ptx：
## pwd：
## readlink：链接路径读取
-f 读取链接指向的文件的绝对路径
## realpath：
## rm：
## rmdir：递归移除目录/子目录和文件
## runcon：
## seq：序列化一组有序数字
## sha1sum：
## sha224sum：
## sha256sum：
## sha384sum：
## sha512sum：
## shred：移除文件并释放磁盘占用
## shuf：随机选取
## sleep：
## [sort]：I/O 排序，输出
## split：
## stat：
## stdbuf：
## [stty](coreutils/stty.md)：对 tty 终端参数进行设置
## sum：
## sync：磁盘同步
## tac：
## tail：
## tee：标准输出同步写入文件
一般与管道一起使用，用于在输出的同时将输出同步写入一个或者多个文件。

```bash
ls|tee ls.log
```
## test：
## timeout：
## touch：文件/目录时间更新
> 如果不存在则创建一个新文件)文件或者目录访问或者修改时间；同样可以使用重定向等方式或者直接使用编辑器 vi/vim/nano 等创建文件

```Bash
touch file [format]
touch directory
```

## tr：转换
## true：
## truncate：
## tsort：
## tty：
## uname：
## unexpand：
## uniq：
## unlink：
## users：
## vdir：
## wc：
## who：
## whoami：
## yes：

[1]: https://wiki.archlinux.org/index.php/Core_utilities_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)

> 参阅：

+ 王垠 - 开源世界旅行手册
