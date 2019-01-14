@echo off
echo 关闭命令回显.......
echo 修改控制台背景大小颜色......
mode con cols=192 lines=52 & color 0d
pause

cd /D C:\
echo 更改文件所有者并修改文件属性.........
if exist autorun.inf cacls autorun.inf /G everyone:F && attrib +s +r -h *.inf && cacls autorun.inf /G everyone:R
cacls *.ico /G everyone:F && attrib +s +r -h *.ico && cacls *.ico /G everyone:R

cd /D D:\
echo 更改文件所有者并修改文件属性.........
cacls *.inf /G everyone:F && attrib +s +r -h *.inf && cacls *.inf /G everyone:R
cacls *.ico /G everyone:F && attrib +s +r -h *.ico && cacls *.ico /G everyone:R

cd /D G:\
echo 更改文件所有者并修改文件属性.........
cacls *.inf /G everyone:F && attrib +s +r -h *.inf && cacls *.inf /G everyone:R
cacls *.ico /G everyone:F && attrib +s +r -h *.ico && cacls *.ico /G everyone:R

cd /D I:\
echo 更改文件所有者并修改文件属性.........
cacls *.inf /G everyone:F && attrib +s +r -h *.inf && cacls *.inf /G everyone:R
cacls *.ico /G everyone:F && attrib +s +r -h *.ico && cacls *.ico /G everyone:R
echo 执行完毕.......
pause



