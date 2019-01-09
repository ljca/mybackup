use Library
go

/* 图书信息表插入记录 */
insert into Book(BID,BName,Author,PubComp,Bcount,Price)
select 'ISBN_2012_3s','《你的世界我曾经走过》','困在井底的鱼','未知',20,'2' union
select 'ISBN_922SP','《灯火》','萧萧','未知',20,'1'
go

/* 读者信息表插入记录 */
insert into Reader(RID,RName,LendNum)
select 'so2','海底有鱼',2 union 
select 'ysl2','枯木逢春',3
go

/* 图书借阅表插入记录 */
insert into Borrow(RID,BID,LendDate)
select 'ysl2','ISBN_2012_3s','2012-1-1' union
select 'so2','ISBN_922SP','2013-2-1'
go

/* 罚款记录表插入记录 */
insert into Penalty(RID,BID,PDate,PType,Amount)
select 'so2','ISBN_922SP','2012-12-04',2,'20' union
select 'ysl2','ISBN_2012_3s','2013-2-5',3,'50'
go


