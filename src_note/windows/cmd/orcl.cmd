@echo off
net start OracleServiceORCL & net start OracleOraDb11g_home1TNSListener

pause

net stop OracleOraDb11g_home1TNSListener & net stop OracleServiceORCL

REM exit