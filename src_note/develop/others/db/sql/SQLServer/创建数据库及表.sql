/*
create database QQ
on(name='QQ.mdf',filename='E:\dbs\QQ.mdf',size=5,maxsize=10,filegrowth=2%)
log on(name='QQ_Log.ldf',filename='E:\dbs\QQ_Log.ldf',size=2,maxsize=10,filegrowth=2%)
go
*/
use QQ
go
/*
create table QQList(QQId int not null primary key,QQN nvarchar(50) not null default '天边那只会飞的猪',Mail nvarchar(50) 
default 'tbnzhhdz@yeah.net',QQd nvarchar(50) not null default '☆',OnlineD float default 0.0)
go
*/
/*	
insert into QQList(QQId,QQN,QQd,OnLineD)
select 11133344,'会游泳的猪','☀☀☀★☆',234.2 union
select 111133223,'想飞的猪','☀☀★☆',210.2 union
select 116256232,'有理想的猪伤不起','☀☀☀☀☀★★',500.2 union
select 10644323,'没理想的猪伤的起','☀☀☀★☆',234.2 union
select 734377854,'一只特行独立的猪','★★☆',35.2 union
select 1402359,'有异性没猪性的猪','★☆☆',29.2 union
select 15557842,'想逃跑的猪','☀☀☀☀',342.2 union
select 23357438,'猪的猪生观','☆',14.2 union
select 52133684,'猪当杀手的生涯','☆',2.2 
go
*/





