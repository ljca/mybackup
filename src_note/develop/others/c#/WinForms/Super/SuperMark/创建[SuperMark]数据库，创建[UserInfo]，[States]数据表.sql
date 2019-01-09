create database [SuperMark]
on
(
name='SuperMark.mdf',filename='H:\SuperMark\SuperMark.mdf',filegrowth=2%,size=10mb,maxsize=20mb
)
log on
(
name='SuperMark_Log.ldf',filename='H:\SuperMark\SuperMark_Log.ldf',filegrowth=2%,size=5mb,maxsize=10mb
)
go

use [SuperMark]
go
create table [States]
(
[Id] int identity(1,1) not null primary key,
[StatesName] varchar(20) not null
)
on [primary]
go
create table [UserInfo]
(
[Id] int identity(1,1) not null primary key,
[CustomerId] varchar(20) not null,
[CustomerPassword] varchar(20) not null,
[CustomerType] varchar(10) not null,
[Score] int not null,
[StatusId] int not null
)
on [primary]
go
