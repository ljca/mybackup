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
select '��' union
select 'ʳ' union
select 'ס' union
select '��'
go
insert into Carbon values (
	'��','��',0.45,3
)
go



update Carbon set
	CID = 4
where 
	CBID = 1
go
*/


 --- ��ѯ��Դ
select 
 -- ��Դ��ţ����ƣ���λ��������,�������
	r.CBID as ��Դ���,
	r.CBName as ����,
	r.CBUnit as ��λ,
	r.CBValue as ������,
	c.CName as �������
from
 -- ��Դ�� , ����
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