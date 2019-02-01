@echo off
set ls=bat

echo %ls%

echo %JAVA_HOME%
echo %JRE_HOME%
echo %MySQL5.6%
set PATH
pause
echo %1 %2 %3 %4 & pause 
dir "%1" "%2" "%3" "%4" /a 

echo %0
