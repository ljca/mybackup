<link href="../css/style.css" rel="stylesheet" type="text/css" />


# windows控制台命令[^desc]笔记 :) :(

[^desc]: windows下的命令也被称之为dos命令或者控制台命令还可以指powershell命令；dos命令由windows命令解释器cmd或者command负责解释，与命令行脚本不同的是，它们必须输入一条、执行一条指令。而脚本程序则是按照文件中指定的位置顺序执行，直到遇到错误或者exit命令才会终止命令的执行。如果将这一条一条的命令存入一个文件中，并以特殊扩展作为扩展名(！如果要让自定义扩展也可以直接被命令解释器解释执行，则必须确保已经在PATHEXT环境变量中正确添加了自定义扩展)。

## *内部命令*

+ attrib[^attrib]: 更改文件或目录属性： `attrib [+/-a] [+/-s] [+/-h] [+/-r] [/s] [/d] 目录或者文件名`
+ dir[^dir]: 显示驱动器或者目录下的文件或者子目录。 `dir [路径][/a] [/a[:]x] [/s] [/t] [/w] [/t] [/o[:]x] [/q] [/p] `

[^attrib]: 命令来查看、修改文件或者目录属性：`attrib +s +h +r +a dir|file` 。windows7以上版本的系统已经不推荐使用cacls,转而使用icacls来对文件或者目录设置访问权限

[^dir]: 如果在路径中包含特殊字符，如空格....则应该用双引号将路径引起来。选项：/a: 显示所有文件或者子目录，如果不指定这个选项，则dir无法显示具有隐藏和系统属性的文件和目录；/a: r|h|a|s]:根据文件或者目录属性来查看文件或者目录,可以是隐藏的(h),只读的(r),存档的(a),系统的(s)； /q: 显示文件所有者列； /o: G|E|-..]: 根据选项将输出排序。G目录在所有文件之前。E根据文件扩展名排序

+ cd:更改路径。可选项[/D] : `cd /D 路径`[^cd]

[^cd]: 如果要显示当前所在路径，键入不带任何参数和路径的cd；/D 如果只是想要更改到某个驱动器下，应该直接键入驱动器盘符；如果想要更改到另一个驱动器下的某个目录，使用/D选项

+ mkdir | md: 创建目录：` md|mkdir [路径]目录名`
+ `ren | rename`: 重命名目录或者文件，支持通配符：`ren 源目录或者文件名 目标文件|目录`
+ `del`: 删除文件。 `del [/f][/s][/q][/p] 文件名`(支持通配符?和*)

[^del]: /f 强制删除只读文件,没有提示。[/s] 删除子目录下的文件；/q 跳过删除每一个文件之前确认提示。[/p] 以询问用户的方式删除文件

+ `rd | rmdir`[^rd]:删除目录。`rd|rmdir [/s] [/q] [/f] [/p] 目录或者文件名`

[^rd]: 如果指定了/s参数，会递归删除该目录及子目录下所有文件及目录

+ copy:复制命令，也可用此命令创建文件
+ move:移动,重命名文件或者目录，不支持有系统属性的目录或者文件。`move 源文件|目录 目标文件|目录 [/y|/-y]`
+ xcopy:复制目录及其下的文件。支持复制具有系统属性的文件或者目录，`xcopy 源路径 目标路径 选项`，

[^xcopy]: ` + `/e`： + `/s`： + `/h`： + `/k`： + `/y|/-y`:

+ type:显示文本文件内容。 `type filename`
+ tree:以树形结构显示文件或者目录 `tree 路径`
+ cacls[^cacls]：更改文件或者目录的ACL。 `cacls 文件名或者目录名 [/T][/C][/G username:权限]|[/D username:权限][/P username:权限][/R username:权限] [/E]`

[^cacls]: username:用户名。权限 R：可读、W：可写、F:完全控制、C：写入 + /T：递归处理子目录及文件。/G：为指定用户赋予文件或者目录访问权限。/P：替换指定用户访问文件或者目录的权限。 + /D：拒绝指定用户对指定文件或者目录的访问权限。/R：撤销指定用户对文件或者目录的访问权限，与/E一起使用合法。 

+ icacls[^icacls]

[^icacls]: Options:  /setowner:设置文件/目录所有者，这并不会强行更改文件的所有者。  /grant[:r] sid perimission[:r] 允许指定用户访问指定文件。如果使用了:r选项，则会将权限追加给用户  /demand 拒绝指定用户的访问权限。

+ takeown:强行更改文件/目录所有者 /F:只能为管理员组，如果没有指定，则将所有者更改为当前用户。
+ where[^where]：根据指定的路径搜索文件 `where [/R] PATH 字符串 [/F]`

[^where]: /R 指定搜索路径  /F将搜索到文件使用双引号引起来

+ find
+ ftype

## *磁盘*

+ format:格式化磁盘  ` format 驱动器(卷标、盘符) [options]`

[^format]: options-list:  /FS[:filesystem]:指定格式化驱动器所使用的文件系统，可选文件系统:Fat/Fat32,NTFS,EXFat,Refs,VDF  /V:lable:指定格式化驱动器后使用的卷标  /X:强制卸载卷  /C:对驱动器中的文件进行压缩，此项仅适合NTFS文件系统  /Q:执行快速格式化，如果同时指定了/p选项，则/p选项不生效  /P:和/q选项一起使用不生效  /A:  /T:

+ diskpart:windows磁盘管理工具

`DISKPART-> command`

+ ACTIVE - 将选中的分区标记为活动的分区。
+ ADD - 将镜像添加到一个简单卷。
+ ASSIGN - 给所选卷分配一个驱动器号或装载点。
+ ATTRIBUTES - 操纵卷或磁盘属性。
+ ATTACH - 连接虚拟磁盘文件。
+ AUTOMOUNT - 启用和禁用基本卷的自动装载。
+ BREAK - 中断镜像集。
+ CLEAN - 从磁盘清除配置信息或所有信息。
+ COMPACT - 尝试减少文件的物理大小。
+ CONVERT - 在不同的磁盘格式之间转换。
+ CREATE - 创建卷、分区或虚拟磁盘。
+ DELETE - 删除对象。
+ DETAIL - 提供对象详细信息。
+ DETACH - 分离虚拟磁盘文件。
+ EXIT - 退出 DiskPart。
+ EXTEND - 扩展卷。
+ EXPAND - 扩展虚拟磁盘上可用的最大大小。
+ FILESYSTEMS - 显示卷上当前和支持的文件系统
+ FORMAT - 格式化卷或分区
+ GPT - 给选择的 GPT 分区分配属性。
+ HELP - 显示命令列表。
+ IMPORT - 导入磁盘组。
+ INACTIVE - 将所选分区标为不活动。
+ LIST - 显示对象列表。
+ MERGE - 将子磁盘与其父磁盘合并。
+ ONLINE - 使当前标为脱机的对象联机。
+ OFFLINE - 使当前标记为联机的对象脱机。
+ RECOVER - 刷新所选包中所有磁盘的状态。

尝试恢复无效包中的磁盘，并重新同步具有过时丛或奇偶校验数据的镜像卷和 RAID5 卷。

+ REM - 不起任何作用。用来注释脚本。
+ REMOVE - 删除驱动器号或装载点分配。
+ REPAIR - 用失败的成员修复一个 RAID-5 卷。
+ RESCAN - 重新扫描计算机，查找磁盘和卷。
+ RETAIN - 在一个简单卷下放置一个保留分区。
+ SAN - 显示或设置当前启动的操作系统的 SAN 策略。
+ SELECT - 将焦点移动到对象。
+ SETID - 更改分区类型。
+ SHRINK - 减小选定卷。
+ UNIQUEID - 显示或设置磁盘的 GUID 分区表(GPT)标识符或主启动记录(MBR)签名。

-------------------------------------------------------------

+ chkdsk[^chkdsk]: 检查驱动器错误并尝试修复。 `chkdsk 驱动器(可使用卷标或者盘符) [options]`

[^chkdsk]: options-list:  /F:检查并尝试修复文件系统  /X:强制卸载驱动器  /I:对索引进行较小强度的检查,只对NTFS文件系统有效  /C

+ convert:将fat32文件系统转换为NTFS文件系统。 ` convert 驱动器(可使用盘符或者卷标) /FS:文件系统 [/X]`
+ mountvol:映射(挂载)EFI系统分区(驱动器/卷)到驱动器 `mountvol 驱动器号(盘符) /S`

[^mountvol]: 如果没有在windows系统安装其它操作系统的文件系统的驱动程序，即使已经被映射，windows也无法识别这些文件系统；系统引导分区也只能被映射为一个驱动器号，而不能显示在资源管理器

+ label:在windows系统上修改驱动器卷标 ` label 驱动器(可使用卷标或者盘符) 新卷标 `
+ vol:显示驱动器卷标和序列号 `vol 驱动器盘符`

> 网络

+ ping
+ ftp
+ telnet
+ netstat
+ nbtstat
+ tracert
+ netsh
  + wlan:
  + http：
  + p2p:
  + nslookup
  + arp

--------------------------------

+ ipconfig:显示或设置IP

> 其它

+ date[^date]
+ time：显示或者更改系统时间和日期,语法:  `date [/T] & time [/T]`

[^date]: /T:此选项可以让系统只显示不修改，不带选项的命令默认修改如果只是要需要查看时间或者日期，则可以通过显示系统中的DATA，TIME变量的方式，命令： ` echo %Date% %Time%`

+ color[^color]: 临时更改命令行解释器背景和前景 `color FG`

[^color]: F:背景颜色,G:字体颜色值，为十六进制数

+ prompt: 临时更改[^prompt]命令提示符,默认为$P$G 命令语法： ` prompt 提示符字符串$p$s$$`

[^prompt]: 如果想要永久更改，可以使用setx创建一个系统级环境变量，并为它赋值。

+ at
+ doskey (F7查看命令历史记录)
+ if-else 可以对程序运行结果进行判断；通过查看系统变量errorlevel的值，可以判断上个程序的运行结果是否返回错误 + `%ERRORLEVEL%` 可以对字符串的值进行判断 + `exists` 可以对文件/目录进行判断

> 使用语法:

```batch
:: 如果在不同行上调用,则else必须与if子句的右括号位于同一行；else子句的左括号必须与else位于同一行
if exist %0 ( command1 ) else ( command2 ) 
```

> eg:

```Batch
if (
) else (
)
```

+ for[^for]

```batch
for /r path %i in (*.txt) do @echo %i
```

```batch
for /D /R G:\Develop %i in (Oracle*) do @echo %i >> tmps.xx
```

[^for]: /d: 这个参数可以只用来处理目录，这在搜素或者删除一系列无用的目录时可能很有用处。这需要使用[/r]选项指定具体搜索路径；后面的%i代表系统检索到的匹配的目录。 in ("string") :匹配模式，如果要操作目录，则必须要在目录后加通配符，如果目录包含特殊字符，则应该将它使用双引号引起来。do关键字用来对目录执行的具体命令，这里是将它打印出来的目录名称追加到tmps.xx文件中。

+ echo[^echo]:打印消息或者关闭命令回显。关闭命令回显  `echo off`

[^echo]: echo还可以用来查看环境变量值，如果某个环境变量包含的值含有特殊符号，则需要使用双引号将双百分号引起来 `echo %变量名%(双引号可选)`  在控制台打印消息 `echo 消息 > filename | nul`

+ more[^more]:逐屏显示输出，多个可选项，多种使用方法 `more [/c] [/e]..... < 文件名和路径`

[^more]: 连接管道逐屏显示文件内容，除了一些特殊命令，其它所有命令无法单屏完全显示的都可使用管道连接逐屏显示 如果需要显示多个文本文件内容,只需要用空格分隔,支持通配符。语法 `type filename | more 选项 ；命令 /? | more 选项` `more 选项 ..... filename1 filename2 ...filenameN`

+ goto
+ call
+ `:` 标签
+ rem 批处理脚本程序注释命令，等价于双冒号 ::
+ help 显示命令帮助信息,等价于命令后跟属性或者选项 /?
+ rar/7z：控制台压缩/解压程序(必须已经包含在环境变量中)，只能创建和解压rar压缩文件

```batch
rar command [-options1] [-options2] .... [-optionsN] 压缩包名 压缩文件(目录) 解压文件路径
```

> Command-List:

+ a:添加压缩文件/目录，如果选项后指定的是目录并且目录后没有转义符，则不添加-r选项也会将目录及其子目录进行压缩；如果是文件则支持通配符
+ x:以压缩文件中的路径解压压缩文件
+ e:无需压缩文件中的路径直接解压文件
+ l:列出压缩包的文件
+ u:更新压缩包

> Options-List(以'-'为前缀):

+ -df:文件创建成功之后删除源文件；
+ -s:创建固实压缩文件；
+ -ac:创建完成后清除存档属性
+ -p:为压缩文件设置密码(如果不在此选项之后紧跟密码(没有空格),则rar程序将会从控制台获取)
+ -r:如果对目录及其子目录进行压缩，并且目录后有转义符，则需要指定此项
+ -t:对压缩文件进行测试

--------------------------------

+ cls:清屏
+ exit:退出命令行解释程序

## *系统*

+ tasklist:根据选项列出系统中所有已经运行的程序 `tasklist Options `

> Options-List:

+ /m
+ /v:
+ /svc:
+ /apps:
+ /fi:
+ /fo:

-----------------------

+ taskkill:终止系统正在运行的任务或者进程 `taskkill Options`

> Options-List:

+ /im(imagename):根据进程名来终止进程
+ /pid:根据进程的pid号终止进程
+ /t:也终止进程所启动的子进程
+ /f:强行终止一个进程
+ /fi:根据筛选器终止进程
+ /s:指定系统
+ /p:指定密码

----------------------------------------

+ mode:配置系统设备。临时更改命令行解释器窗口大小的命令行： `mode con cols= lines=`
+ net：系统配置工具，需要管理员权限运行。 ` net command [options]`

> Command-List:

+ accounts:
+ computer:
+ config:
+ continue:
+ file
+ help
+ help
+ msg:
+ group:
+ start:
+ stop
+ share
+ statistics:
+ session:
+ time:
+ pause:
+ use:
+ user:更改远程或者本地系统用户相关 `net user [username [password]] [options] `

> Options-List:

+ /add:
+ /delete:
+ /times:
+ /active:

+ localgroup: `net localgroup [groupname] [Options] `

> Options-List:

+ /add:
+ /delete:
+ view:
+ share:共享

---------------------------------------

+ wmic

[全局开关] <命令>
可以使用以下全局开关:
/NAMESPACE 别名在其上操作的命名空间的路径。
/ROLE 包含别名定义的角色的路径。
/NODE 别名在其上操作的服务器。
/IMPLEVEL 客户端模拟级别。
/AUTHLEVEL 客户端身份验证级别。
/LOCALE 客户端应使用的语言 ID。
/PRIVILEGES 启用或禁用所有权限。
/TRACE 将调试信息输出到 stderr。
/RECORD 记录所有输入命令和输出内容。
/INTERACTIVE 设置或重置交互模式。
/FAILFAST 设置或重置 FailFast 模式。
/USER 会话期间要使用的用户。
/PASSWORD 登录会话时要使用的密码。
/OUTPUT 指定输出重定向模式。
/APPEND 指定输出重定向模式。
/AGGREGATE 设置或重置聚合模式。
/AUTHORITY 指定连接的 <授权类型>。
/?[:<BRIEF|FULL>] 用法信息。
有关特定全局开关的详细信息，请键入: switch-name /?

当前角色中可以使用以下别名:
ALIAS - 对本地系统上可用别名的访问
BASEBOARD - 基板(也称为主板或系统板)管理。
BIOS - 基本输入/输出服务(BIOS)管理。
BOOTCONFIG - 启动配置管理。
CDROM - CD-ROM 管理。
COMPUTERSYSTEM - 计算机系统管理。
CPU - CPU 管理。
CSPRODUCT - SMBIOS 中的计算机系统产品信息。
DATAFILE - 数据文件管理。
DCOMAPP - DCOM 应用程序管理。
DESKTOP - 用户的桌面管理。
DESKTOPMONITOR - 桌面监视器管理。
DEVICEMEMORYADDRESS - 设备内存地址管理。
DISKDRIVE - 物理磁盘驱动器管理。
DISKQUOTA - 用于 NTFS 卷的磁盘空间使用量。
DMACHANNEL - 直接内存访问(DMA)通道管理。
ENVIRONMENT - 系统环境设置管理。
FSDIR - 文件系统目录项管理。
GROUP - 组帐户管理。
IDECONTROLLER - IDE 控制器管理。
IRQ - 中断请求线路(IRQ)管理。
JOB - 提供对使用计划服务安排的作业的访问。
LOADORDER - 定义执行依赖关系的系统服务的管理。
LOGICALDISK - 本地存储设备管理。
LOGON - 登录会话。
MEMCACHE - 缓存内存管理。
MEMORYCHIP - 内存芯片信息。
MEMPHYSICAL - 计算机系统的物理内存管理。
NETCLIENT - 网络客户端管理。
NETLOGIN - 网络登录信息(属于特定用户)管理。
NETPROTOCOL - 协议(及其网络特征)管理。
NETUSE - 活动网络连接管理。
NIC - 网络接口控制器(NIC)管理。
NICCONFIG - 网络适配器管理。
NTDOMAIN - NT 域管理。
NTEVENT - NT 事件日志中的项目。
NTEVENTLOG - NT 事件日志文件管理。
ONBOARDDEVICE - 主板(系统板)中内置的通用适配器设备的管理。
OS - 已安装操作系统的管理。
PAGEFILE - 虚拟内存文件交换管理。
PAGEFILESET - 页面文件设置管理。
PARTITION - 物理磁盘的已分区区域的管理。
PORT - I/O 端口管理。
PORTCONNECTOR - 物理连接端口管理。
PRINTER - 打印机设备管理。
PRINTERCONFIG - 打印机设备配置管理。
PRINTJOB - 打印作业管理。
PROCESS - 进程管理。
PRODUCT - 安装程序包任务管理。
QFE - 快速修复工程。
QUOTASETTING - 卷上的磁盘配额设置信息。
RDACCOUNT - 远程桌面连接权限管理。
RDNIC - 对特定网络适配器的远程桌面连接管理。
RDPERMISSIONS - 特定远程桌面连接的权限。
RDTOGGLE - 远程打开或关闭远程桌面侦听程序。
RECOVEROS - 操作系统出现故障时将从内存收集的信息。
REGISTRY - 计算机系统注册表管理。
SCSICONTROLLER - SCSI 控制器管理。
SERVER - 服务器信息管理。
SERVICE - 服务应用程序管理。
SHADOWCOPY - 卷影副本管理。
SHADOWSTORAGE - 卷影副本存储区域管理。
SHARE - 共享资源管理。
SOFTWAREELEMENT - 系统上安装的软件产品元素的管理。
SOFTWAREFEATURE - SoftwareElement 的软件产品子集的管理。
SOUNDDEV - 声音设备管理。
STARTUP - 当用户登录到计算机系统时自动运行的命令的管理。
SYSACCOUNT - 系统帐户管理。
SYSDRIVER - 基本服务的系统驱动程序管理。
SYSTEMENCLOSURE - 物理系统外壳管理。
SYSTEMSLOT - 物理连接点(包括端口、插槽和外设以及专用连接点)的管理。
TAPEDRIVE - 磁带驱动器管理。
TEMPERATURE - 温度传感器(电子温度计)数据管理。
TIMEZONE - 时区数据管理。
UPS - 不间断电源(UPS)管理。
USERACCOUNT - 用户帐户管理。
VOLTAGE - 电压传感器(电子电压表)数据管理。
VOLUME - 本地存储卷管理。
VOLUMEQUOTASETTING - 将磁盘配额设置与特定磁盘卷相关联。
VOLUMEUSERQUOTA - 每用户存储卷配额管理。
WMISET - WMI 服务操作参数管理。

----------------------------------------

+  sc：配置系统服务。

> 语法: `sc <server-> command <servername-> [options]`

！选项和等号之间不要存在空格，而值和等号之间必须存在一个以上的空格。

> Command-List:

+ query:根据选项查询服务 `sc query [servername] [options]`

> query Options-List:

+ type= service|driver|all
+ state= all|active|inactive

+ create:创建一项服务 `sc create servicename options`

> create Options-List:

+ binPath= ""
+ DisplayName= ""
+ start= auto|dismand

+ delete:删除一项服务 `sc delete servername`

+ stop:停止系统正在运行的服务或者驱动
+ start:启动一项服务或者驱动
+ pause:暂停服务

-----------------------------------

+ reg/regedit，注册表工具 `reg 命令 注册表路径 选项`

+ `reg add 注册表路径 /v 名称 /t 类型 /d 可执行文件绝对路径(包含可执行文件名)` //添加到注册表指定路径
+ `reg export filename //将注册表指定项导出到文件`
+ `reg import filename //从文件中导入到注册表中`
+ `reg delete 注册表路径 /v 名称 //从注册表删除项`
+ `reg query 注册表路径 //查询指定注册表路径下的项`

----------------------------------

+ start
+ powercfg,windows电源方案管理工具
+ bcdedit:windows引导配置工具

```batch
-> bcdedit /set "{bootmgr}" Path \EFI\ubuntu\grubx64.efi //由ubuntu引导windows
-> bcdedit /timeout 秒..
```

+ 映射驱动器 mountvol `mountvol H: /S`
+ cmd：使用命令解释器执行一个命令后保留或者离开控制台窗口。 `cmd [/T:FG] [/K|/C] command`
+ dism:windows WIM镜像部署工具 `dism /online /cleanup-image /restorehealth`
+ fsutil
+ shutdown
+ syteminfo：显示系统信息
+ set:查看或者临时设置环境变量

* 键入不带参数的set，会列出系统所有环境变量
* 临时更改环境变量的值

```batch
set variable=value
set Desktop=%userprofile%\Desktop && cd /d %Desktop% & dir /a 
set /p variable= [prompt]
```

------------------------------

+ setx[^setx]:在系统注册表中永久增加一个环境变量，有一个或者多个可选项

[^setx]: [/M] 如果在命令中使用此选项，则会创建系统级变量，此选项意味着会对系统中所有用户生效；如果省略此选项，则默认创建用户级变量，只对当前用户生效。此命令共有三种语法。最后一个目录的目录名之后最好不要再有目录分隔符反斜杠(\)或者分号(;)。反引号(\)和分号(;)可能会造成下一次添加环境变量的混淆 `setx 变量名 "变量值" /M *ps:这里的双引号可省略，但如果变量值中包含空格或者特殊字符(最好不要是目录分隔符'\')，应该用双引号将变量值引起来`

+ logoff:注销系统,无选项

## *外部程序：可以直接被执行：它们被称之为外部命令(系统不会自动在内存中加载)*

+ winver：显示windows版本

## 附

### 命令提示符

[^batch]: 批处理脚本程序(以.bat为扩展)或者命令行脚本(以.cmd为扩展),二者本质上相同,但它们唯一的不同之处在于它们的用处不同；批处理程序主要处理一些较小型的作业，如关机，重启等命令。而命令行脚本主要用于处理一些较高级的作业，比如创建windows服务,修改一些系统设置.....

 windows下的路径一般指一个磁盘中已经存在的目录(目录末尾不含文件名和分隔符反斜杠)，也可以指具体某一个文件(在执行一个对文件的命令，如删除一个文件)。同样还可以是一个网络路径。有相对和绝对路径之分

！在批处理或者windows命令行脚本中运行两个以上程序会导致控制台挂起，失去响应,无法输入和执行命令。(此时，只能将控制台或者已经执行成功的程序关掉。) 发生这种原因在于，dos系统是单任务单用户操作系统。一次只能处理一个可执行程序。

所以，如果在脚本中运行多个可执行程序，但是却只会有一个程序被先执行。其它程序如果想要被执行只能等待这个先被执行的程序退出或者被强行关掉。一旦这个程序被系统成功执行，那么下一个程序只有在上一个可执行程序执行完毕或者被关闭后才会被执行。如果确实要在一个脚本中同时执行多个程序，可以在脚本中使用快捷方式(*.lnk)代替可执行文件名。


[^opt]: [] 可选项。/ 选项、属性、参数，命令与选项或者多个选项之间使用空格隔开。\ 路径分隔符，目录或者文件名如果存在空格或者特殊字符，则必须使用双引号将它们包裹，否则可能会被命令解释器解释为一个或者多个选项、命令。

[^-]: - 中划线允许被指定为某些程序的属性开关。(rar程序为选项)，与之前的命令使用空格隔开

[^<]: `<>` 未知的命令可选项

不带选项的命令可直接键入命令执行，带选项的命令之后可以有一个或者多个选项、开关，属性，使用空格隔开 windows下的命令、命令参数、命令选项和路径中的英文字母不区分大小写,一些命令的执行需要管理员权限

目录/文件夹 文件 快捷方式；相对路径是一种不含盘符的路径，对目录的引用；而绝对路径:包含盘符，对目录或者目录下的文件的引用；另外，还有一些特殊目录[^特殊路径]。

[^特殊路径]:  特殊路径:任何目录(包括空目录)之下都存在两个特殊的目录(.|..),这两个目录就是英文字符下的单句点(.)和双句点(..) . 当前目录，.. 上级目录 \ 当前驱动器的根目录；如果文件或者目录本身就具有或者已经添加系统属性，则它们被windows识别为系统文件或者目录，对具有系统属性的文件或者目录的操作可能不成功。如果确实要操作这些文件或者目录，则清除文件或者目录的系统属性也许是一个解决方案。

### 特殊字符：

+ ^：命令转义符 ` echo ^&` // 输出符号& ；如果想要显示某个特殊的字符，则需要使用^符号进行转义
+ @:屏蔽命令回显：如果想要命令在屏幕上不显示，则可在此命令前加上@
+ 标准输入(0)、标准输出(1)、标准错误(2)
+ 命令输入/输出重定向(>,>>,<,<<)
+ `>`：读取命令输出结果重定向写入到文件或者输出到设备，默认输出到设备屏幕 如果文件不存在，则会创建一个文件 将命令错误重定向到文件  `command 2>file` 如果不想显示错误消息，则可以将错误重定向到特殊文件null中  `command 2>null或者command 2>1` 将命令输出和错误同时重定向到文件，顺序不能颠倒，必须将错误重定向放到最后 `命令 > 文件 >2&1`
+ `>>`：读取命令输出并重定向写入到(追加)指定文件中，不覆盖原有内容，如果不存在此文件则创建一个文件
+ `<`：从文件中而不是从键盘中读取命令输入并输出 `more /c /e < Desktop.ini` 以下命令将会逐屏显示Desktop.ini文件的内容 
+ &：执行多个使用&连接的命令：连接两个以上命令，无论&之前的命令执行成功与否，都会继续执行&之后的命令
+ &&:执行多个使用&&连接的命令：连接两个命令，如果前一个命令执行成功，则继续执行&&之后的命令
+ ||:执行多个使用||连接的命令 连接两个命令，如果前一个命令执行失败，才继续执行||之后的命令
+ |:管道，从一个命令读取输出并将其写入到另一个命令的输入 将管道符|之前的命令作为管道符之后命令的标准输出
+ ::注释符，位于::之后的内容会被系统忽略，等同REM命令
+ %:必须使用%%来引用一个已经被定义的变量，如果被引用的变量的变量值中有特殊符号，应该在%%之外包含双引号,否则其中的特殊字符(如&)会被命令解释器解释为连接两个命令之间的&；也就是说如果在变量值存在字符&，并且没有使用双引号，则字符&之后的内容会被命令解释器视为命令试图执行

### Windows 卷[^vol]

[^vol]: windows将磁盘分区以驱动器(卷)的形式组织和呈现，一个磁盘分区就是一个驱动器或者卷。这些驱动器可能具有盘符、卷标...... 如果系统中没有超过26个以上的已挂载分区，则盘符使用一个英文字母(不区分大小写)紧跟一个英文冒号来描述,C盘(C:) ；windows资源管理器会以卷标(盘符)的形式列出所有可识别、可读的磁盘分区(驱动器/卷)；windows以扩展名来区分不同的文件，win95及以前的系统只能使用短文件名来表示文件，且使用3个以下的字符来作为文件的扩展名，并不支持长文件名(255个字符)。

### 环境变量(Enverinment Avriable)

+ Path变量:
 
一组不包含程序名称的目录集合，它们是不包含程序名的程序的绝对路径，它们之间使用英文中的分号隔开；这样，在运行(windows徽标键+R)或者windows的控制台窗口就可以直接键入程序名称来运行它们， 系统会依次到环境变量PATH和当前路径(优先级高于系统级PATH和用户级PATH)中查找这个程序或者可解释执行的脚本并尝试解释或者运行它，如果在已定义的PATH和当前路径中没有找到，命令解释器会返回一个command not found错误。而不必键入一个长长的路径(X:\ls\sl.exe)来运行它们

一些程序的运行必须依赖于另一些程序，这就是对于运行环境的描述。如果无法在环境变量PATH的路径中找到它们所依赖的程序，具有依赖的程序可能会无法运行

+ PATHEXT变量：提供一组以分号分隔的扩展名，控制那些扩展可以直接被Windows或者命令解释器解释执行。

+ PROMPT:命令解释器的命令提示符变量，默认没有，如果定义了这个环境变量则可以被命令解释器直接使用。

+ SystemRoot:

+ USERPROFILE:

+ TEMP/TMP:

+ HOMEPATH:

+ WINDIR:

+ APPDATA:

### 组策略编辑器(gpedit.msc)

### 注册表[^reg]编辑器(regedit)

一些软件的安装会向注册表中写入信息

### 动态链接库dll(Dynamic Sysmlink Library)

在C#中，dll被描述为程序集，它们是可执行文件(.exe)的扩展，可执行文件的运行依赖于它；c中,dll被描述为程序扩展，它们不能被直接执行，但可执行文件(.exe)在运行时却依赖于它；一些软件在安装过程需要向系统中注册dll才能被得到运行所需要的支持

### 服务(mmc service.msc)

服务是由应用程序创建的一些驻留在控制台的进程，由windows操作系统维护。一些软件的运行依赖于系统或者自身创建的服务；这也是为什么一些安装在非系统盘的软件在系统被重新安装之后无法重新使用的原因

### ACL(Access Control ....)

windows NT以上系统引入了ACL；T以上windows系统使用另一种新型文件系统ntfs(New Teconalagy FileSystem)来作为磁盘文件系统。文件、目录访问控制权限ACL在ntfs文件系统有效，可以设置哪些用户对某个目录或者文件有访问权限，又或者对某个目录或者文件没有访问权限(这通常对一个有多用户的windows系统，并且系统必须是XP或者更高版本而言)

### 配置文件：

+ hosts: `%windir%\System32\drivers\etc\hosts`
