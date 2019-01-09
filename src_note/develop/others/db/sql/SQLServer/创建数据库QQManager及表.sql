/*
create database QQManager
on(name= 'QQManager.mdf',filename='G:\DataBase\QQManager\QQManager.mdf',size=5,filegrowth=2%,
maxsize=20)
log on(name= 'QQManager_Log.ldf',filename='G:\DataBase\QQManager\QQManager_Log.ldf',size=1,
filegrowth=2%,maxsize=10)

--drop database QQManager
*/
use QQManager
go
/*
create table QQUserInfo(UNi nvarchar(50) not null,UP nvarchar(50) not 
null,Mail nvarchar(50) not null,QQJ int not null,OnLine nvarchar(50) not null)

create table QQD(QQjName nvarchar(50) not null,Onlinex nvarchar(50) not null,St char(10) not null)
*/
/*
drop table QQManager
go
*/

