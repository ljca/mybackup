if exists(select * from sysdatabases
where name='Teacher')
drop database Teacher
go

create database Teacher
on
(
name='Teacher_Data',filename='G:\DataBase\Teacher\Teacher.mdf',size=5mb,filegrowth=100kb
)
log on
(
name='Teacher_Log',filename='G:\DataBase\Teacher\Teacher_Log.ldf',size=2mb,filegrowth=100kb
)
go

use Teacher
go

if exists(select * from sysobjects
where xtype='*' and name='Theachers')
drop table Teachers
go

create table Teachers
(
ID int identity(001,1) primary key not null,
Name nvarchar(50) not null,
Age int not null
)
go

