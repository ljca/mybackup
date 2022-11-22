<link href="../css/style.css" rel="stylesheet" type="text/css" />

# [coreutils：Linux 核心工具集][1]

- [[^test]：
- b2sum[^b2sum]：
- base32[^base32]：
- base64[^base64]：
- basename[^basename]：
- cat[^cat]：
- chcon[^chcon]：
- chgrp[^chgrp]：
- [chmod](coreutils/chmod.md)[^chmod]：文件/目录权限模式更改
- [chown](coreutils/chown.md)[^chown]：文件或者目录所有者更改，`chown [Options] [owner]:group file/Directory`
- chroot[^chroot]：根切换
- cksum[^cksum]：
- comm[^comm]：文件比较
- cp[^cp]：
- csplit[^csplit]：
- cut[^cut]：转换，输出[^cut]
- date[^date]：
- dd[^dd]：读取、转换、输入、输出
- dfm[^dfm]：
- dir[^dir]：
- dircolors[^dircolors]：
- dirname[^dirname]：
- du[^du]：
- echo[^echo]：
- env[^env]：
- expand[^expand]：制表符转换为空格
- expr[^expr]：
- factor[^factor]：
- false[^false]：
- fmt[^fmt]：
- fold[^fold]：
- head[^head]：
- hostid[^hostid]：
- id[^id]：
- install[^install]：
- join[^join]：
- link[^link]：
- ln[^ln]：
- logname[^logname]：
- [ls](coreutils/ls.md)[^ls]：在Unix及其变体终端窗口上显示文件或者子目录。
- md5sum[^md5sum]：
- mkdir[^mkdir]：
- mkfifo[^mkfifo]：
- mknod[^mknod]：
- mktemp[^mktemp]：
- mv[^mv]：
- nice[^nice]：
- nl[^nl]：
- nohup[^nohup]：
- nproc[^nproc]：
- numfmt[^numfmt]：
- od[^od]：
- paste[^paste]：
- pathchk[^pathchk]：
- pinky[^pinky]：
- [pr](coreutils/pr.md)[^pr]：
- printenv[^printenv]：
- printf[^printf]：
- ptx[^ptx]：
- pwd[^pwd]：
- readlink[^readlink]：链接路径读取，读取链接指向的文件的绝对路径
- realpath[^realpath]：
- rm[^rm]：
- rmdir[^rmdir]：递归移除目录/子目录和文件
- runcon[^runcon]：
- seq[^seq]：序列化一组有序数字
- sha1sum[^sha1sum]：
- sha224sum[^sha224sum]：
- sha256sum[^sha256sum]：
- sha384sum[^sha384sum]：
- sha512sum[^sha512sum]：
- shred[^shred]：移除文件并释放磁盘占用
- shuf[^shuf]：随机选取
- sleep[^sleep]：
- sort[^sort]：I/O 排序，输出
- split[^split]：
- stat[^stat]：
- stdbuf[^stdbuf]：
- [stty](coreutils/stty.md)[^stty]：对 tty 终端参数进行设置
- sum[^sum]：
- sync[^sync]：磁盘同步
- tac[^tac]：
- tail[^tail]：
- tee[^tee]：标准输出同步写入文件，`ls|tee ls.log`。一般与管道一起使用，用于在输出的同时将输出同步写入一个或者多个文件。
- test[^test]：
- timeout[^timeout]：
- touch[^touch]：文件/目录时间更新[^touch]，`touch file [format]` | `touch directory`
- tr[^tr]：转换
- true[^true]：
- truncate[^truncate]：
- tsort[^tsort]：
- tty[^tty]：
- uname[^uname]：
- unexpand[^unexpand]：
- uniq[^uniq]：
- unlink[^unlink]：
- users[^users]：
- vdir[^vdir]：
- wc[^wc]：
- who[^who]：
- whoami[^whoami]：
- yes[^yes]：

[1]: https://wiki.archlinux.org/index.php/Core_utilities_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)

> 参阅：

- 王垠 - 开源世界旅行手册

[^touch]: 如果不存在则创建一个新文件)文件或者目录访问或者修改时间；同样可以使用重定向等方式或者直接使用编辑器 vi/vim/nano 等创建文件
[^cut]: 此命令以行为单位，对命令输出或者文件流进行第二次处理。 不带任何参数的cut命令默认使用空格或者tab来作为分隔符。-d 使用自定义控制符过滤,这必须和-f选项一起使用  -f 指定域，也就是文件中的每行中的哪几部分，以数字计数。还可以使用-1，指定每行中哪几部分，如0-1,5这可以
[^test]: [ 是 test 的别名。
[^b2sum]: 
[^base32]: 
[^base64]: 
[^basename]: 
[^cat]: 
[^chcon]: 
[^chgrp]: 
[^chmod]: 文件/目录权限模式更改
[^chown]: 文件或者目录所有者更改，`chown [Options] [owner]:group file/Directory`
[^chroot]: 根切换
[^cksum]: 
[^comm]: 文件比较
[^cp]: 
[^csplit]: 
[^cut]: 转换，输出[^cut]
[^date]: 如果有网络，不推荐使用 date 设置系统和硬件时钟。在 init 为 systemd 的系统上，可以使用 `timedatectl set-ntp true`。
[^dd]: 读取、转换、输入、输出
[^dfm]: 
[^dir]: 
[^dircolors]: 
[^dirname]: 
[^du]: 
[^echo]: 
[^env]: 
[^expand]: expand options [file]|- -i -t|--tabs #制表符默认为8个空格，如果需要将制表符转换为更少的空格，使用-t参数。 -t|--tabs #指定制表符出现的位置，以逗号分隔
[^expr]: 
[^factor]: 
[^false]: 
[^fmt]: 
[^fold]: 
[^head]: 
[^hostid]: 
[^id]: 
[^install]: 
[^join]: 
[^link]: 
[^ln]: 
[^logname]: 
[^ls]: 在Unix及其变体终端窗口上显示文件或者子目录。
[^md5sum]: 
[^mkdir]: 
[^mkfifo]: 
[^mknod]: 
[^mktemp]: 
[^mv]: 
[^nice]: 
[^nl]: 
[^nohup]: 
[^nproc]: 
[^numfmt]: 
[^od]: 
[^paste]: 
[^pathchk]: 
[^pinky]: 
[^pr]: 
[^printenv]: 
[^printf]: 
[^ptx]: 
[^pwd]: 
[^readlink]: 链接路径读取，读取链接指向的文件的绝对路径
[^realpath]: 
[^rm]: 
[^rmdir]: 递归移除目录/子目录和文件
[^runcon]: 
[^seq]: 序列化一组有序数字
[^sha1sum]: 
[^sha224sum]: 
[^sha256sum]: 
[^sha384sum]: 
[^sha512sum]: 
[^shred]: 移除文件并释放磁盘占用
[^shuf]: 随机选取
[^sleep]: 
[^sort]: I/O 排序，输出。-n，让 sort 使用数值排序 -h，让 sort 使用可读的数值排序，du -sh /home/*|sort -hr -r，反转排序
[^split]: 
[^stat]: 
[^stdbuf]: 
[^stty]: 对 tty 终端参数进行设置
[^sum]: 
[^sync]: 磁盘同步
[^tac]: 
[^tail]: 
[^tee]: 标准输出同步写入文件，`ls|tee ls.log`。一般与管道一起使用，用于在输出的同时将输出同步写入一个或者多个文件。
[^timeout]: 
[^touch]: 文件/目录时间更新，`touch file [format]` | `touch directory`
[^tr]: 转换
[^true]: 
[^truncate]: 
[^tsort]: 
[^tty]: 
[^uname]: 
[^unexpand]: 
[^uniq]: 
[^unlink]: 
[^users]: 
[^vdir]: 
[^wc]: 
[^who]: 
[^whoami]: 
[^yes]: 看似无用的命令在回复某些交互式指令却用处极大。为了回复某些程序的交互式询问，需要手动输入 yes 或者 y 来进行确认，yes 指令可以直接回复确认。当然，一些交互式指令也提供了 -y 选项用于避免用户的每次确认。用法是在 yes 后接上管道然后传递给交互式指令：`yes | rm -iv tmp`。

