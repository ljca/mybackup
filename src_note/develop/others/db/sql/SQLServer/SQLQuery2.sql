use [PhoneCardSys]
go
create table PhoneCard(PhoneCardId int identity(1,1) primary key,PhoneCardMoney int not null)
go
create table PhoneCardSale(SaleId int identity(1,1) primary key,PhoneCardId int not null,SaleCount int not null,SaleDate datetime not null,SalePrice int null,Remark varchar(100))
go
