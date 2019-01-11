#  让windows资源管理器消失的pdf缩略图重新显示出来

**据说，`windows`在安装了`Adobe Arocat Pro`之后，pdf 文档就不会显示缩略图了。**

>！**有人注意到了这个问题并对此编写了补丁，关于这个补丁，作者在他的网站上是这样 [介绍它](https://www.pretentiousname.com/adobe_pdf_x64_fix/index.html) 的**。**补丁的使用方式：**

* 首先从作者网站获取这个[ 补丁 ](https://www.pretentiousname.com/adobe_pdf_x64_fix/index.html#downl)[作者提供了有安装程序的和没有安装程序的] 并解压。

* 如果选择了安装程序？那就尝试运行里面的安装程序将它安装到系统(C:\Program Files(x86)) 中并运行安装程序释放的真正补丁程序 -> 选择 Apply Fix 就能即时在资源管理器中看到效果(这可能需要在资源管理器选项中开启文件和文件夹预览功能)。

* 如果是免安装的？how to install.txt 介绍了如何安装和使用这个补丁程序。不过，经测试发现，不将它们放到 C:\Program Files(x86) 下也是可以的。

 1. 首先将解包出来的两个文件夹中的文件放到一个文件夹中。(不要忘了给它取一个好听的名字，好吧，其实是我不喜欢目录和文件名中带有空格)。
 2. 写一个命令行脚本(如果不这样做那就到命令提示符里按照 how to install.txt 死敲命令吧。)并把它和第一步做好的放到一起(方便使用变量)，扩展可以是 .bat 或者 .cmd (一劳永逸不用再到命令提示符中死敲命令了)类似...然后尝试使用管理员权限运行这个脚本。
 
======= 安装脚本`install.cmd` ========
```batch
@echo off
:: 跳转到存放脚本的路径
cd /d "%~dp0"
Thumbridge.exe /regserver
regsvr32 /s Thumbridge32.dll
regsvr32 /s Thumbridge64.dll
echo "完毕...."
pause
```
 3. 运行真正的有效可执行文件选择`Apply Fix`就和安装程序的一样了。

========= 卸载脚本 `uninstall.cmd` ==========
```batch 
@echo off
:: 切换到脚本的路径
cd /d "%~dp0"
Thumbridge.exe /unregserver
regsvr32 /u /s Thumbridge32.dll
regsvr32 /u /s Thumbridge64.dll
echo "完毕...."
pause
```

----------------------------------------------------------------------------------------------
> **幸运的是：`Adode`已经在他们的新版本软件中修复了这个问题并将`在资源管理器中显示缩略图`这个功能集成到了软件首选项中。**

！不过据说，安装了最新版本的福昕之后是可以直接在资源管理器显示 pdf 文档缩略图的……
