@echo off 
set /p cs= close system£¿y/n  
if %cs% == y  (shutdown -s -f -t 0)  else (exit )