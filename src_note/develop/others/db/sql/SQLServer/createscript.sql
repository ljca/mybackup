use master
go
if exists(select * from sysdatabases where name='Users')
drop database Users
go
create database Users
on (
name='Users_DB',filename='G:\DataBase\Users\Users.mdf',filegrowth=1mb,size=5mb,maxsize=10mb
)
log on
(
name='Users_Log',filename='G:\DataBase\Users\Users_Log.ldf',filegrowth=1mb,size=2mb,maxsize=10mb
)
go
if exists(select * from sysdatabases where name='Users')
use Users
go

if exists(select * from sysobjects where name='UserList')
drop table UserList
go
create table [UserList] 
(
username varchar(20) not null,userpwd varchar(50) not null
)
go

insert into UserList(username,userpwd)
select 'admin1','admin' union
select 'admin2','admin'
go

