use [PhoneCardSys]
go
insert into [PhoneCardSale](PhoneCardId,SaleCount,SaleDate,SalePrice,Remark)
select 1,10,2012/2/2,10,'10Ԫ' union 
select 2,20,2011/2/2,20,'20Ԫ' union 
select 3,30,2013/2/2,30,'30Ԫ' 
go