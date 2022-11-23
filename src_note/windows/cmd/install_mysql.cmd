set MySQL5.5=G:\DeveLop\DataBase\MySQL\MySQL5.5
set MySQL5.6=G:\DeveLop\DataBase\MySQL\mysql-5.6.24-winx64
if exist "%MySQL5.5%" "%MySQL5.5%\bin\mysqld" --install MySQL5.5 --defaults-file="%MySQL5.5%\my.ini"&setx MySQL5.5 "%MySQL5.5%" /M
if exist "%MySQL5.6%" "%MySQL5.6%\bin\mysqld" --install MySQL5.6 --defaults-file="%MySQL5.6%\my.ini"&setx MySQL5.6 "%MySQL5.6%" /M
pause