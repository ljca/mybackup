use [PhoneCardSys]
go
insert into [PhoneCardSale](PhoneCardId,SaleCount,SaleDate,SalePrice,Remark)
select 4,10,'2012-2-2',10,'100' union 
select 5,20,'2011-2-2',20,'20' union
select 6,20,'2011-2-2',20,'20' union
select 7,20,'2011-2-2',20,'20'
go


