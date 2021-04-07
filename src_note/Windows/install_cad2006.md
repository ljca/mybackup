<link href="../css/style.css" rel="stylesheet" type="text/css" />



windows8.1 64位安装CAD2006  

2017-04-19 22:45:41|  分类： Windows相关 |字号 订阅
       

  下载LOFTER
我的照片书  |

  使用了旧程序框架的程序需要旧的程序框架的支持。在较新一点的windows版本上运行较旧的程序可能需要考虑兼容性以及操作系统是否提供了对旧版本程序的支持。 

  安装过程中产生的很多问题都可以通过安装日志来发现，而大多数的安装日志位于系统的临时目录下。

要查看日志，可以直接在运行栏(windows + R)输入%temp%或者直接在资源管理器地址栏键入: %temp%并回车进入系统临时文件目录，找到并打开安装日志(文件名类似于程序名加上.log后缀的文件)

这是一段CAD2006在widnows8.1上的安装错误日志：

[8/15/2016 17:08:59] Installation skipped: .NET Framework Runtime 1.1

[8/15/2016 17:08:59] Installation skipped: .NET Framework Runtime 1.1 Language

Pack can't be installed on Windows 64-bit

[8/15/2016 17:08:59] Installation aborted

[8/15/2016 17:09:01] === Installation ended ===

上面的问题提示需要先安装.net frameworker 1.1及其语言包来支持应用程序。

ACD2006已经提供了.net frameworker 1.1的安装程序，它是support\dotnetfx\dotnetfx.exe

如果直接运行失败或者有兼容性提示，那么可能需要以兼容xp或者vista的模式安装.net framewroker 1.1及其语言包

切换到这个目录并选中程序，然后右键选择属性，切换到兼容性选项卡，勾选以兼容模式运行程序

错误二：安装失败，提示权限错误，并需要重启计算机。

acad.msi为cad2006的安装程序，安装时可能需要提升至管理员权限来运行这个程序包。

方法可以是：以管理员权限运行acad.msi程序包(如果右键没有这种选择，点击当前目录下的任意空白处，可在当前目录下按住shift然后右键 -> 在此打开命令提示符(如果以这种方式打开的不是以管理员权限运行的命令提示符，那么可以以其它的方式打开一个以管理员权限运行的命令提示符。在这种命令提示符下运行的所有程序都使用了管理员权限。)在打开的控制台窗口键入程序名称: acad.msi && exit，卸载时使用相同的方法和程序名。

其它安装步骤详见Sn.txt

CASS7.0安装

CASS7.0依赖CAD2006,所以需要先安装CAD2006。如果直接运行CASS的安装程序可能会运行失败。

1.运行Setup.exe程序而非当前目录下的CASS70.msi程序包

2.可选(安装之后的文件用安装程序Setup.exe所在的上一级目录下的BIN文件夹下的所有文件替换，如果需要的话); 