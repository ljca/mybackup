/* 创建数据库Library */

create database Library
on
(
name='Library_DB',filename='D:\Project\Library.mdf',filegrowth=15%,size=5mb
)
log on
(
name='Library_Log',filename='D:\Project\Library_Log.ldf',filegrowth=15%,size=1mb
)
go

use Library
go

/* 创建图书信息表 */
create table Book
(
BID nvarchar(50) not null check(BID like 'ISBN%') primary key,
BName nvarchar(50) not null,
Author char(10) null,
PubComp varchar(20) null,
PubDate DateTime null,
BCount int check(BCount > 1) null,
Price money check(Price > 0) null
)
go

/* 创建读者信息表 */
create table Reader
(
RID varchar(50) primary key not null,
RName varchar(50) not null,
LendNum int check(LendNum > 0) null,
RAddress varchar(50) null
)
go

/* 创建图书借阅表 */
create table Borrow
(
RID varchar(50) primary key not null,
BID varchar(50)  not null,
LendDate Datetime  not null default getdate(),
WillDate DateTime not null default getdate() + 1,
ReturnDate DateTime default null
)
go

/* 创建罚款记录表 */
create table Penalty 
(
RID varchar(50) not null,
BID varchar(50) not null,
PDate DateTime not null,
PType int check(PType in(1,2,3)) null,
Amount money check(Amount > 0) null
)
go








