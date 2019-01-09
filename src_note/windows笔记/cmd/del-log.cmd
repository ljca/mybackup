@echo off
echo Deleting MySQL5.6 Error Logs........
if exist %mysql5.6%\data\*.err echo find err_log in %mysql5.6%\data && del /s /p %mysql5.6%\data\*.err
set tmp=I:\Temp\log\mysql
if exist %tmp% echo find err_log in %tmp% && del /p /s %tmp%\*.err & pause
