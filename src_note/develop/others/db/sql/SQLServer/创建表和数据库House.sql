/*
create database House
on
(
name='House_DB',filename='G:\DataBase\House\House.mdf',
size=5mb,maxsize=20mb,filegrowth=1%
)
log on
(
name='House_Log',filename='G:\DataBase\House\House_Log.ldf',
size=2mb,maxsize=10mb,filegrowth=300kb
)
go
*/
use House
go

create table sys_user
(
[UID] int identity(1,1) primary key not null,
UName varchar not null,UPASSWORD varchar check(DataLength(UPASSWORD) >= 6) not null
)
go

create table hos_district
(
DID int identity(1,1) primary key not null,
DName varchar not null
)
go

create table hos_street
(
[SID] int identity(1,1) primary key not null,
SName varchar not null,SDID int not null
)
go

create table hos_type 
(
HTID int identity(1,1) primary key not null,
HTName varchar not null
)
go

create table hos_house
(
HMID int identity(1,1) primary key not null,
[UID] int not null,[SID] int not null,HTID int not null,
PRICE decimal default 0  check(PRICE >= 0) not null,
TOPIC varchar not null,CONTENTS varchar not null,
HTIME datetime not null default getdate() check(HTIME <= getdate()),
COPY varchar 
)
go




