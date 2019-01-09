if not exists(select name from sys.databases where name='tmp')
begin
create database tmp
on primary
(name='',filename='',size=1M,filegrowth=100KB,maxsize=5MB),
filegroup filegroup1
(name='',filename='',size=1M,filegrowth=100KB,maxsize=5MB),
(name='',filename='',size=1M,filegrowth=100KB,maxsize=5MB)
log on
(name='',filename='',size=50KB,filegrowth=100KB,maxsize=5MB),
(name='',filename='',size=50KB,filegrowth=100KB,maxsize=5MB);
end;
go

alter database tmp add filegroup tms;

alter database tmp add file
(name='',filename='',size='',filegrowth=100KB,maxsize=5MB),
(name='',filename='',size='',filegrowth=100KB,maxsize=5MB)
to filegroup tms;
go

use master;
alter database tmp modify name = tlsl;
exec sp_renamedb tlsl tmp;
go

--alter database tmp;
