exec sp_databases;

exec sp_tables;

use Live;
go
exec sp_columns @table_name='Carbon';
go

if exists (select name from sys.databases where name='Live')
begin
print '******数据库存在！*******';
end
else 
begin
print '数据库不存在，请创建数据库！';
end
go

select * from sys.databases;

if exists (select name from sys.databases where name='tmp')
select *  into tmp from sys.databases;
go

exec sp_helpdb Live;

use Live
go
exec sp_tableswc @table_name='Carbon';
go
