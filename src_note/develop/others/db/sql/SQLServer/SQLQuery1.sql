create database PhoneCardSys
on
(name= 'PhoneCardSys.mdf',filename='E:\PhoneCardSys\PhoneCardSys.mdf',filegrowth=2%,size=10mb,maxsize=30mb
)
log on
(
name= 'PhoneCardSys_Log.ldf',filename='E:\PhoneCardSys\PhoneCardSys_Log.ldf',filegrowth=2%,size=5mb,maxsize=15mb
)
go
