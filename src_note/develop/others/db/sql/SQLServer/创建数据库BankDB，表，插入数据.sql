if exists(select * from sysobjects 
where name='BankDB')
drop database BankDB

/* �������ݿ�BankDB */
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

/* �����ͻ���Ϣ�� */
create table 
(
)
go

/* �����˻���Ϣ�� */

/* ���� */

/* �������׼�¼�� */


















