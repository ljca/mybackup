if exists(select * from sysobjects 
where name='BankDB')
drop database BankDB

/* 创建数据库BankDB */
create database BankDB
on 
(name='BankDB',filename='E:\Temp\BankDB\BankDB_Data.mdf',filegrowth=1%
,size=5mb,maxsize=20mb)
log on 
(
name='BankLog',filename='E:\Temp\BankDB\BankDB_Log.ldf',filegrowth=1%
,size=2mb
)
go

use BankDB
go

/* 创建客户信息表 */
create table 
(
)
go

/* 创建账户信息表 */

/* 创建 */

/* 创建交易记录表 */


















