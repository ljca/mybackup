<link href="../../../css/style.css" rel="stylesheet" type="text/css" />


# Db2安装配置笔记

下载地址：https://www-01.ibm.com/marketing/iwm/iwm/web/pick.do?source=swg-db2expressc&S_TACT=000000VR&S_OFF_CD=10000761&lang=en_US
ibm db2 Express-C 10.1 64位下载地址：
DB2 Express-C light（仅限英语。不包含 Text Search、Configuration Assistant 或 First Steps）
db2_v101_winx64_expc_lite.exe (371 MB)
https://www6.software.ibm.com/sdfdl/v2/regs2/db2pmopn/db2_v101/expc/Xa.2/Xb.aA_60_-i7wn_sM010lfXXCE7XWCdSywiF6-TIA6vAEw/Xc.db2_v101/expc/db2_v101_winx64_expc_lite.exe/Xd./Xf.LPr.D1vk/Xg.8786919/Xi.swg-db2expressc/XY.regsrvs/XZ.PKm27a_BuJkKDJ71hgFJ1tQ5MqM/db2_v101_winx64_expc_lite.exe
DB2 Express-C
db2_v101_winx64_expc.exe (507 MB) 
https://www6.software.ibm.com/sdfdl/v2/regs2/db2pmopn/db2_v101/expc/Xa.2/Xb.aA_60_-i7wn_sM010lfXXCE7XWCdSywiF6-TIA5eVFM/Xc.db2_v101/expc/db2_v101_winx64_expc.exe/Xd./Xf.LPr.D1vk/Xg.8786919/Xi.swg-db2expressc/XY.regsrvs/XZ.AsEeJ6gzZm4XIfCjzHJ7ggApr3I/db2_v101_winx64_expc.exe
Data Studio Administration Client
ibm_data_studio_standalone_win_V311.zip (336MB) 
https://www6.software.ibm.com/sdfdl/v2/regs2/db2pmopn/db2_v101/expc/Xa.2/Xb.aA_60_-i7wn_sM010lfXXCE7XWCdSywiF6-TIOs3rc0/Xc.db2_v101/expc/ibm_data_studio_standalone_win_V311.zip/Xd./Xf.LPr.D1vk/Xg.8786919/Xi.swg-db2expressc/XY.regsrvs/XZ.pxNT3fbNknI6yKGqSZwytxdYj-0/ibm_data_studio_standalone_win_V311.zip
DB2 Accessories Suite Text Search
db2_v101_winx64_accsuite_ts.zip (169MB) 
https://www6.software.ibm.com/sdfdl/v2/regs2/db2pmopn/db2_v101/expc/Xa.2/Xb.aA_60_-i7wn_sM010lfXXCE7XWCdSywiF6-TIH2HoLw/Xc.db2_v101/expc/db2_v101_winx64_accsuite_ts.zip/Xd./Xf.LPr.D1vk/Xg.8786919/Xi.swg-db2expressc/XY.regsrvs/XZ.sedeOsrNZVMjHXk57uoMs-1PlUw/db2_v101_winx64_accsuite_ts.zip
DB2 add-ins for Visual Studio
db2_v101_win_vsai.exe (64MB)
https://www6.software.ibm.com/sdfdl/v2/regs2/db2pmopn/db2_v101/expc/Xa.2/Xb.aA_60_-i7wn_sM010lfXXCE7XWCdSywiF6-TIMcmIn0/Xc.db2_v101/expc/db2_v101_win_vsai.exe/Xd./Xf.LPr.D1vk/Xg.8786919/Xi.swg-db2expressc/XY.regsrvs/XZ.N1ecIOYzuP_iejrEEDNLaaOT2OM/db2_v101_win_vsai.exe
IBM Data Server Driver for JDBC and SQLJ V10.1 Fix Pack 5
https://delivery04.dhe.ibm.com/sdfdl/v2/sar/CM/IM/05fz2/1/Xa.2/Xb.jusyLTSp44S0Qs61wesNF_HcDRx0gpuuK_4rfS43OUlhmN3q02aLc15obIE/Xc.CM/IM/05fz2/1/v10.1fp5_jdbc_sqlj.tar.gz/Xd./Xf.LPR.D1vk/Xg.8788446/Xi.habanero/XY.habanero/XZ.XCmWMXHp6UxsJ_67oCl4IxdWK0E/v10.1fp5_jdbc_sqlj.tar.gz
 
G:\DeveLop\DataBase\DB2\BIN
:( > db2start
DB2 : 服务已返回特定的服务错误代码。
SQL1042C 发生了意外的系统错误。 SQLSTATE=58004
！
:( > db2start
DB21009E 必须在命令窗口中以完整管理特权运行才能启动此命令。
SQL1092N 由于用户标识无权执行所请求的命令或操作，因此请求的命令或操作失败。用户标识：""。
！以管理员权限运行命令提示符
:( > db2
DB21061E 未初始化命令行环境。
！必须先运行db2cmd初始化命令行环境
SQL1031N 在指示的文件系统中找不到数据库目录。 SQLSTATE=58031
重新编目(Catalog)数据库
db2 catalog db db_name
:( > db2 catalog db sample
:( > db2 list db directory
db2 => create database test on G:\Temp\Data
SQL1052N 数据库路径 "G:\Temp\Data" 不存在。
:( > db2set DB2_CREATE_DB_ON_PATH=yes
 vim:set filetype=markdown: 
