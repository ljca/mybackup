use master
go
if exists(select * from sys.databases where name='newsxql')
drop database newsxql
go

create database newsxql
on
(
name='News_DB',filename='G:\DataBase\TempDataBase\newsxql.mdf',filegrowth=2mb,size=5mb,maxsize=20mb
)
log on
(
name='News_Log',filename='G:\DataBase\TempDataBase\newsxql_Log.ldf',filegrowth=2mb,size=2mb,maxsize=20mb
)
go
