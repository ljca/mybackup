/* 1.创建数据库Book */
--检索数据库Book的存在性，如果存在则删除
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

/* 2.创建学生信息表：student */
--检索表student的存在性，如果存在则删除
if exists(select * from sysobjects
where name='student')
drop table student
go

create table student
(stuID char(10) not null,stuName varchar(10) not null,
major varchar(50) not null)
go

/* 3.创建图书表：book */
--检索表book的存在性，如果存在则删除
if exists(select * from sysobjects
where name='book')
drop table book
go

create table book
(BID char(10)  not null, --图书编号
title varchar(50) not null, --书名
author varchar(20) not null --作者
)
go

/* 4.创建借书信息表：borrow */
--检索表borrow的存在性，如果存在则删除
if exists(select * from sysobjects
where name='borrow')
drop table borrow
go

create table borrow
(borrowID char(10) not null, --借书编号
stuID char(10) not null, --学生编号
BID char(10) not null, --图书编号
T_time datetime, --借书日期
B_time datetime --还书日期
)
go

/* 5.添加student表、book表和borrow表的主外键约束 */
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

/************** 6.插入数据 ******************/
/* 主键表student插入数据 */
insert into student(stuID,stuName,major)
select '1001','王晓明','计算机' union
select '1002','李琦','工商管理' union
select '1003','杨石头','数学' union
select '1004','乌玉笛','英语' union
select '1005','乐乐','材料' 

/* 主键表book插入数据 */
insert into book(BID,title,author) 
select 'B001','c语言程序设计','谭浩强' union
select 'B002','英语四级','未知作者' union
select 'B003','入学那天遇见你','未知作者' union
select 'B004','人生若只如初见','未知作者' union
select 'B005','你的世界我曾走过','困在井底的鱼'

/* 外键表borrow插入数据 */
insert into borrow(borrowID,stuID,BID,T_time,B_time)
select 'Y001','1001','B001','2009-12-15','2011-2-5' union
select 'Y002','1002','B002','2011-2-1','2011-2-10' union
select 'Y003','1003','B003','2010-2-6','2010-3-20' union
select 'Y004','1004','B004','2011-3-2','2011-6-5' union
select 'Y005','1005','B005','2012-12-25','2012-1-23'

go

/* 7.查询“计算机”专业学生在“2009-12-15”至“2012-6-8”时间段内借书的学生编号、学生名称、图书编号、图书名称、借出日期 */
use Book
go
select a.stuID 学生编号,stuName 学生名称,c.BID 图书编号,title 图书名称,T_time 借出日期
from student as a
inner join borrow c on(a.stuID = c.stuID)
inner join book b on(b.BID = c.BID)
where T_time between '2009-12-15' and '2012-6-8'
and major=(select major from student 
where major='计算机')
go

/* 8. 查询所有借过图书的学生编号、学生名称、专业 */
select a.stuID 学生编号,stuName 学生名称,major 专业
from student as a
inner join borrow as b on(a.stuID = b.stuID)
where b.T_time is not null
go

/* 9.创建视图，查询所有借过的图书信息，包括学生姓名、图书名称、借出日期、归还日期 */
--检索存在性
if exists(select * from sysobjects
where name='vw_SelectBook')
drop view vw_SelectBook
go

create view vw_SelectBook
as
select stuName 学生姓名,title 图书名称,T_time 借出日期,B_time 归还日期
from student a,book b,borrow c
where a.stuID = c.stuID 
and b.BID = c.BID
and title = '人生若只如初见'
go
select * from vw_SelectBook

/* 10.创建查询目前借书但未归还图书的学生名称及未还图书数量的存储过程 */
--检索存在性
if exists(select * from sysobjects
where name='usp_BookNum')
drop proc usp_BookNum
go
create proc usp_BookNum
as
select stuName as 学生姓名,count(*) as 借书数量
from student
group by stuName
go





