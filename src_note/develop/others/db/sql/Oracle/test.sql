host echo 请输入System用户的口令：
conn System
desc v$nls_parameters
column parameter format a50
column value format a50
select * from v$nls_parameters;
disconnect
-- host echo 请输入要切换的用户名和用户口令：
conn tmp
select tablespace_name from user_tablespaces;
-- conn tmp
