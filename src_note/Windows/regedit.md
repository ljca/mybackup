# 注册表笔记


注册表 
第一根键、第三根键互为映射
对第一根键的更改也会更改到第三根键中对应到的键值
位于根键下的项为主键项，主键项以下的项为子键
CLSID键,是第一根键，第三根键下的主键项
此主键主要保存系统的sid和某些右键服务项的sid
sid号，文件或目录的sid号，识别文件或者目录的特征码
主键路径:[hkey_clsid]
/* 此键的更改会对所有类型的文件右键产生影响 */
键路径：[hkey_classes_root\*\shell]

/*只对驱动器产生影响*/
[hkey_classes_root\drive\shell]
/*添加产生对文件夹驱动器有影响的右键*/
[Directory]
[Folder]
[DesktopBackGround\shell]
/*影响到所有文件夹及文件，但不会影响到驱动器*/
[AllFilesSystemObjects\shellex]
文件打开方式注册表路径
第一根键
HKEY_CLASSES_ROOT\
第一根键
HKEY_CLASSES_ROOT\Applications
第二根键
HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts
HKEY_CLASSES_ROOT\SystemFileAssociations

HKEY_CLASSES_ROOT\mplayerc64.mp3
HKEY_CLASSES_ROOT\SystemFileAssociations\.jpg
HKEY_CLASSES_ROOT\SystemFileAssociations\video

HKEY_CLASSES_ROOT\SystemFileAssociations\audio
HKEY_CLASSES_ROOT\SystemFileAssociations\audio
HKEY_CLASSES_ROOT\SystemFileAssociations\Directory.Audio

windows服务注册表路径
HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services
windows添加开机启动程序
注册表路径
HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run
新建字符串值,双击这个值，修改路径为开机启动程序绝对路径
注册表导入，文件路径分隔符需要用反斜杠\
windows regidit versions 5.1
[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run]
"字符串值"="开机启动程序路径"
> reg export 注册表路径 文件
* 使用命令添加
> reg add HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run /v 名称 /t 类型,默认REG_SZ /d 可执行文件绝对路径
* 删除开机启动程序
> reg delete HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run /v 名称
* 查询开机启动程序
> reg query HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run

调整控制台字体
HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Console\TrueTypeFont

开始菜单运行历史记录
HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\RunMRU

用户环境变量：
HKEY_CURRENT_USER\Environment
HKEY_CURRENT_USER\Volatile Environment
系统环境变量
HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Session Manager\Environment
 
HKEY_CLASSES_ROOT\xfplay
HKEY_CURRENT_USER\Software\xfplay
HKEY_LOCAL_MACHINE\SOFTWARE\Clients\Media\Xfplay
所有音频文件路径
Audio
HKEY_CLASSES_ROOT\SystemFileAssociations\audio\shell
项:PlayList,播放列表
子项:command,打开的程序
 
 
 
# 用注册表管理右键菜单

所有文件的右键菜单
两个主键分别为

HKEY_CLASSES_ROOT\*\shell和HKEY_CLASSES_ROOT\*\shellex\ContextMenuHandlers

后者保存了大多数右键菜单命令

\shellex\ContextMenuHand lers子键下也保存了不少右键菜单命令

这类命令叫做壳扩展（Shell Extensions）要想删除这些命令，就要删除该子键下相应的键值项





在右键菜单下添加用记事本打开

1.在HKEY_CLASSES_ROOT\*\shell（如果不存在需要新建该主键）下新建一子键，命名为“右键记事本菜单”或您喜欢的名字，然后修改默认键值项的值为“用记事本打开”

2.在新建的子键下再新建一子键，改名为“command”

3.修改command子键的默认键值项值为“C:\Windows\notepad.exe%1”

现在右键单击任何命令都会看到这个命令了





所有文件和文件夹的右键菜单

在HKEY_CLASSES_ROOT\AllFilesystemObjects\shell和HKEY_CLASSES_ROOT\AllFilesystemObjects\shellex\ContextMenuHandlers中

我们使用后者在右键中添加复制到文件夹的命令

1.在该键下新建一子键，命名为copy to

2.选中copy to主键，在右窗格中修改“默认”键值项的值为{C2FBB630-2971-11D1-A18C-00C04FD75D13}即可





为浏览器右键菜单做主

浏览器右键集中在HKEY-CURRENT-USER\Software\Microsoft\Internet Explorer\MenuExt主键下。每一个子键就是一个菜单命令，主键名称就是菜单名，因此，要想删除IE浏览器右键菜单中的一个命令，删除该主键下的相应子键即可。


5


巧用发送到菜单

发送到菜单对应的是一个“SendTo”文件夹，在Windows xp中，该文件夹位于“X:\Documents and Settings\用户名\”目录下。在该目录下添加和删除文件或文件夹的快捷方式，就可在“发送到”菜单中添加或删除命令

# 更改右键上下文
注册表 
第一根键、第三根键互为映射
对第一根键的更改也会更改到第三根键中对应到的键值

位于根键下的项为主键项，主键项以下的项为子键

CLSID键,是第一根键，第三根键下的主键项
此主键主要保存系统的sid和某些右键服务项的sid
sid号，文件或目录的sid号，识别文件或者目录的特征码
主键路径:[hkey_clsid]

/* 此键的更改会对所有类型的文件右键产生影响 */
键路径：[hkey_classes_root\*\shell]


/*只对驱动器产生影响*/
[hkey_classes_root\drive\shell]

/*添加产生对文件夹驱动器有影响的右键*/
[Directory]
[Folder]
[DesktopBackGround\shell]

/*影响到所有文件夹及文件，但不会影响到驱动器*/
[AllFilesSystemObjects\shellex]

文件打开方式注册表路径
第一根键
HKEY_CLASSES_ROOT\

第一根键
HKEY_CLASSES_ROOT\Applications

第二根键
HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts

HKEY_CLASSES_ROOT\SystemFileAssociations

HKEY_CLASSES_ROOT\mplayerc64.mp3

HKEY_CLASSES_ROOT\SystemFileAssociations\.jpg
HKEY_CLASSES_ROOT\SystemFileAssociations\video

HKEY_CLASSES_ROOT\SystemFileAssociations\audio
HKEY_CLASSES_ROOT\SystemFileAssociations\Directory.Audio


windows服务注册表路径
HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services

windows添加开机启动程序
注册表路径
HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run
新建字符串值,双击这个值，修改路径为开机启动程序绝对路径

注册表导入，文件路径分隔符需要用反斜杠\
windows regidit versions 5.1
[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run]
"字符串值"="开机启动程序路径"

  > reg export 注册表路径 文件

* 使用命令添加
  > reg add HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run /v 名称 /t 类型,默认REG_SZ /d 可执行文件绝对路径

* 删除开机启动程序
  > reg delete HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run /v 名称

 * 查询开机启动程序
  > reg query HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run 


调整控制台字体
HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Console\TrueTypeFont


开始菜单运行历史记录
HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\RunMRU