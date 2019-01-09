@echo off & color 0a
set /p rs= reboot system? y/n  
if %rs% == y ( shutdown -r -t 0 ) else ( exit )

