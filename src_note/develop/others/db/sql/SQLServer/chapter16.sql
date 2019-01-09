/*
create database  Live
on(
	name='Live',
	filename='E:\dbs\Live.mdf',
	size=5mb,
	maxsize=10mb
)
log on
(
	name='Live_log',
	filename='E:\dbs\Live_log.ldf',
	size=5mb,
	maxsize=10mb
)
go
*/

use Live
go
/*
create table Category
(
	CID int IDENTITY(1,1)  primary key,
	CName varchar(20) not null
)
go
create table Carbon
(
	CBID	int IDENTITY(1,1) primary key,
	CBName varchar(30) not null,
	CBUnit varchar(10) not null,
	CBValue float not null,
	CID	int not null
)
go
*/

/*
alter table Carbon
	add ChecK (CBValue > 0)
go

insert into Category 
select '衣' union
select '食' union
select '住' union
select '行'
go
insert into Carbon values (
	'电','度',0.45,3
)
go



update Carbon set
	CID = 4
where 
	CBID = 1
go
*/


 --- 查询资源
select 
 -- 资源编号，名称，单位，消耗量,类别名称
	r.CBID as 资源编号,
	r.CBName as 名称,
	r.CBUnit as 单位,
	r.CBValue as 消耗量,
	c.CName as 类别名称
from
 -- 资源表 , 类别表
 Carbon r,Category c
where
	r.CID = c.CID
go


/*
drop table Carbon
drop table Category
go
*/

/*
drop database Live 
go
*/