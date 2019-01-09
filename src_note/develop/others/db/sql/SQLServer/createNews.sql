use master
go
--exec xp_cmdshell 'dir /a G:\DataBase\News'

if exists(select * from sysdatabases where name='News')
drop database News
go

create database News
on primary
(name='News_db',filename='G:\DataBase\News\News.mdf',filegrowth=800KB,size=5MB,maxsize=20MB
)
log on
(
name='News_Log',filename='G:\DataBase\News\News_Log.ldf',filegrowth=800KB,size=2MB,maxsize=20MB
)
go

use News
go
create table news
(
id int identity(1,1) primary key not null,name varchar(100) default 'X' not null
)
go
