host echo ������System�û��Ŀ��
conn System
desc v$nls_parameters
column parameter format a50
column value format a50
select * from v$nls_parameters;
disconnect
-- host echo ������Ҫ�л����û������û����
conn tmp
select tablespace_name from user_tablespaces;
-- conn tmp
