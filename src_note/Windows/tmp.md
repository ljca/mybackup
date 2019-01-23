windows8.1上安装mapGIS K9
必须安装.NET Framework2.0和安装c++2005 32位运行库
windows8.1启用.NET Framework2.0可到控制面板 -> 启用或关闭windows功能 -> 勾选.NET Framework3.5下的复选框然后单击确定即可完成激活，这必须要联网。
windows8.1上安装mapGIS K9 - yl_hh_gg - yl_hh_gg的博客

安装程序位于：
.....k9 的目录
2016年08月22日, 周一  下午,15:48    <DIR>          .
2016年08月22日, 周一  下午,15:48    <DIR>          ..
2016年08月22日, 周一  下午,15:47    <DIR>          MapGIS K9 SP3 技能大赛版
2016年08月22日, 周一  下午,12:12    <DIR>          MapGIS K9 学习版证书服务
2014年10月29日, 周三  上午,10:08           354,585 学习版续期.pdf
2014年10月29日, 周三  上午,10:08           557,007 安装指南.pdf
2014年10月29日, 周三  上午,10:08           705,983 常见安装问题.pdf
2014年10月29日, 周三  上午,10:08           206,087 添加、修复、卸载.pdf
               4 个文件      1,823,662 字节
               4 个目录 45,283,733,504 可用字节

安装程序：
...........k9\MapGIS K9 SP3 技能大赛版 的目录

2012年04月01日, 周日  上午,10:35             8,320 Config.xml
2011年12月08日, 周四  上午,11:31         2,097,152 MapGISSetup.exe

必须先安装MapGIS K9 学习版证书服务才能继续安装MapGIS K9 SP3 技能大赛版
方法：
以管理员权限运行MapGIS K9 学习版证书服务目录下的程序ZDlccsvc-Study.EXE
位于：
对于安装过程产生的错误，可以通过来安装c++ 2005 运行库来解决。
.....k9\MapGIS K9 学习版证书服务\vcredist_x86 c++2005 的目录
2016年08月22日, 周一  下午,12:04    <DIR>          .
2016年08月22日, 周一  下午,12:04    <DIR>          ..
2011年02月28日, 周一  上午,00:00         2,745,256 vcredist_x86.exe
注：Microsoft Visual C++ 2005 Service Pack 1 Redistributable Package ATL Security Update 

安装完成如果没有意外，确认学习版证书服务已经打开,Win+R键入mmc services.msc -> 按M键

在服务已经打开的情况下，运行MapGIS K9 SP3 技能大赛版 的目录下的MapGISSetup.exe，
然后确认MapGIS K9基本运行环境:python2.5,c++ 2005,msxml等....环境，如果没有安装这些环境，则会询问安装，否则一直点击下一步即可完成安装。