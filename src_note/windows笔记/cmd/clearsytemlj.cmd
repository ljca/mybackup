@echo off 
echo 正在清除系统垃圾文件，请稍等...... 

::if exist %systemdrive%\*.tmp 
del /f /s /q %systemdrive%\*.tmp 
del /f /s /q G:\*.tmp 

::if exist %systemdrive%\*._mp 
del /f /s /q %systemdrive%\*._mp 

::if exist %systemdrive%\*.log 
del /f /s /q %systemdrive%\*.log 

::if exist %systemdrive%\*.gid 
del /f /s /q %systemdrive%\*.gid 

::if exist %systemdrive%\*.chk 
del /f /s /q %systemdrive%\*.chk 

::if exist %systemdrive%\*.old 
del /f /s /q %systemdrive%\*.old 

if exist %systemdrive%\recycled\*.* del /f /s /q %systemdrive%\recycled\*.* 

::if exist %windir%\*.bak 
del /f /s /q %windir%\*.bak 

if exist %windir%\prefetch\*.* del /f /s /q %windir%\prefetch\*.* 
rd /s /q %windir%\temp & md %windir%\temp 

if exist %userprofile%\cookies\*.* del /f /q %userprofile%\cookies\*.* 

if exist %userprofile%recent\*.* del /f /q %userprofile%\recent\*.* 

if exist %userprofile%\Local Settings\Temporary Internet Files\*.* del /f /s /q "%userprofile%\Local Settings\Temporary Internet Files\*.*" 

if exist %userprofile%\Local Settings\Temp\*.* del /f /s /q "%userprofile%\Local Settings\Temp\*.*" 
echo 清除系统LJ完成！ 
echo. & pause
