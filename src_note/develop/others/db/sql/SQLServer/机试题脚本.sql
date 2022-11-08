/* 1.�������ݿ�Book */
--�������ݿ�Book�Ĵ����ԣ����������ɾ��
if exists(select * from sysobjects
where name='Book')
drop database Book
go

create database Book
on
(name='Book_DB',filename='E:\Book_Date.mdf',
filegrowth=1%,size=5mb,maxsize=50mb)
log on
(name='Book_LOG',filename='E:\Book_Log.ldf',
filegrowth=1%,size=2mb)
go

use Book
go

/* 2.����ѧ����Ϣ��student */
--������student�Ĵ����ԣ����������ɾ��
if exists(select * from sysobjects
where name='student')
drop table student
go

create table student
(stuID char(10) not null,stuName varchar(10) not null,
major varchar(50) not null)
go

/* 3.����ͼ���book */
--������book�Ĵ����ԣ����������ɾ��
if exists(select * from sysobjects
where name='book')
drop table book
go

create table book
(BID char(10)  not null, --ͼ����
title varchar(50) not null, --����
author varchar(20) not null --����
)
go

/* 4.����������Ϣ��borrow */
--������borrow�Ĵ����ԣ����������ɾ��
if exists(select * from sysobjects
where name='borrow')
drop table borrow
go

create table borrow
(borrowID char(10) not null, --������
stuID char(10) not null, --ѧ�����
BID char(10) not null, --ͼ����
T_time datetime, --��������
B_time datetime --��������
)
go

/* 5.���student��book���borrow��������Լ�� */
alter table student 
add constraint PK_stuID primary key(stuID)
go

alter table student 
add constraint PK_BID primary key(BID)
go

alter table book 
add constraint PK_borrowID primary key(borrowID)
go

alter table borrow 
add constraint FK_stuID_stuID foreign key(stuID) references student(stuID)
go

alter table borrow 
add constraint FK_BID_BID foreign key(BID) references book(BID)
go

/************** 6.�������� ******************/
/* ������student�������� */
insert into student(stuID,stuName,major)
select '1001','������','�����' union
select '1002','����','���̹���' union
select '1003','��ʯͷ','��ѧ' union
select '1004','�����','Ӣ��' union
select '1005','����','����' 

/* ������book�������� */
insert into book(BID,title,author) 
select 'B001','c���Գ������','̷��ǿ' union
select 'B002','Ӣ���ļ�','δ֪����' union
select 'B003','��ѧ����������','δ֪����' union
select 'B004','������ֻ�����','δ֪����' union
select 'B005','������������߹�','���ھ��׵���'

/* �����borrow�������� */
insert into borrow(borrowID,stuID,BID,T_time,B_time)
select 'Y001','1001','B001','2009-12-15','2011-2-5' union
select 'Y002','1002','B002','2011-2-1','2011-2-10' union
select 'Y003','1003','B003','2010-2-6','2010-3-20' union
select 'Y004','1004','B004','2011-3-2','2011-6-5' union
select 'Y005','1005','B005','2012-12-25','2012-1-23'

go

/* 7.��ѯ���������רҵѧ���ڡ�2009-12-15������2012-6-8��ʱ����ڽ����ѧ����š�ѧ�����ơ�ͼ���š�ͼ�����ơ�������� */
use Book
go
select a.stuID ѧ�����,stuName ѧ������,c.BID ͼ����,title ͼ������,T_time �������
from student as a
inner join borrow c on(a.stuID = c.stuID)
inner join book b on(b.BID = c.BID)
where T_time between '2009-12-15' and '2012-6-8'
and major=(select major from student 
where major='�����')
go

/* 8. ��ѯ���н��ͼ���ѧ����š�ѧ�����ơ�רҵ */
select a.stuID ѧ�����,stuName ѧ������,major רҵ
from student as a
inner join borrow as b on(a.stuID = b.stuID)
where b.T_time is not null
go

/* 9.������ͼ����ѯ���н����ͼ����Ϣ������ѧ��������ͼ�����ơ�������ڡ��黹���� */
--����������
if exists(select * from sysobjects
where name='vw_SelectBook')
drop view vw_SelectBook
go

create view vw_SelectBook
as
select stuName ѧ������,title ͼ������,T_time �������,B_time �黹����
from student a,book b,borrow c
where a.stuID = c.stuID 
and b.BID = c.BID
and title = '������ֻ�����'
go
select * from vw_SelectBook

/* 10.������ѯĿǰ���鵫δ�黹ͼ���ѧ�����Ƽ�δ��ͼ�������Ĵ洢���� */
--����������
if exists(select * from sysobjects
where name='usp_BookNum')
drop proc usp_BookNum
go
create proc usp_BookNum
as
select stuName as ѧ������,count(*) as ��������
from student
group by stuName
go





