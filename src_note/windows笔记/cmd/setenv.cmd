@echo off
mode con cols=170 lines=35 & color 0a
:: diskpart
rem SystemPath:
echo 备份环境变量...
if exist I:\Temp set > I:\Temp\env.log
echo 备份Path环境变量....
if exist I:\Temp\Path.log set Path >> I:\Temp\Path.log
echo 追加Path.......
setx Path "%PATH%;G:\system-tools\WinLikeUnix\Msys2\usr\bin;G:\Tools\Tools;G:\Tools\Tweak-Tools\PCMaster;G:\DeveLop\Editor\Vim\vim74;G:\DeveLop\Editor\Notepad2;G:\DeveLop\Editor\Notepad++;G:\DeveLop\Editor\SublimeText3;G:\DeveLop\Others\Qt\bin;G:\Tools\Tools\AutoHotkey_1\Compiler;G:\ProgramFiles\91Reader;G:\ProgramFiles\TTPlayer;G:\ProgramFiles\WinRar;G:\ProgramFiles\7z;G:\system-tools\WinLikeUnix\Msys2;G:\system-tools\WinLikeUnix\Cygwin;G:\system-tools\WinLikeUnix\Cygwin\bin;G:\system-tools\WinLikeUnix\Cygwin\usr\sbin;G:\Tools\Android\Android_Tools\adb;G:\Tools\Android\Android_Tools\imgBoot;G:\system-tools\DiskTools;I:\src-note\src\script;G:\Tools\Tweak-Tools\MacType;G:\system-tools\WinLikeUnix\putty;G:\system-tools\DiskTools\Defraggler" /M

:: PROMPT
setx PROMPT "$P$_:$C $G$S" /M 
setx desktop %userprofile%\Desktop /M 
:: setx Logs "I:\Logs" /M
setx doc "I:\Document" /M
set MySQL5.5=G:\DeveLop\DataBase\MySQL\MySQL5.5
set MySQL5.6=G:\DeveLop\DataBase\MySQL\mysql-5.6.24-winx64
if exist "%MySQL5.5%" "%MySQL5.5%\bin\mysqld" --install MySQL5.5 --defaults-file="%MySQL5.5%\my.ini"&setx MySQL5.5 "%MySQL5.5%\bin" /M
if exist "%MySQL5.6%" "%MySQL5.6%\bin\mysqld" --install MySQL5.6 --defaults-file="%MySQL5.6%\my.ini"&setx MySQL5.6 "%MySQL5.6%\bin" /M
pause
rem UserPath:
echo set UserPath........
setx JAVA_HOME "G:\DeveLop\Java_Web\Java\Jdk7u80\jdk"
rem Path:
setx Path "%%JAVA_HOME%%\bin;%%JAVA_HOME%%\jre\bin;G:\DeveLop\DataBase\Oracle\product\11.2.0\dbhome_1\BIN;G:\DeveLop\Others\Python;G:\DeveLop\Others\Python\Scripts;G:\DeveLop\DataBase\sqldeveloper"
setx CLASSPATH ".;%%JAVA_HOME%%\lib\*;G:\DeveLop\Java_Web\Java\extention_jar\web\lib\*" 
setx NLS_LANG "SIMPLIFIED CHINESE_CHINA.ZHS16GBK" /M
setx SQLPATH "I:\src-note\src\SQL\Oracle" /M
echo 环境变量Path设置结束.......
echo 添加开机启动项.....

:: reg add HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run /v MacTray /d "G:\Tools\Tweak-Tools
:: \MacType\MacTray.exe"
reg add HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run /v killwin8bar /d "G:\Tools\Tools\WinaeroCharmsBarKiller.exe"
:: reg add HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run /v 7tt /d "G:\Tools\Tweak-Tools\7+TaskbarTweaker\7tt.exe" -hidewnd
reg query HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run
echo 完毕..... & pause & start G:\ & exit


