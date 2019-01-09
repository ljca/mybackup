use [SuperMark]
go
--insert into [States]([StatesName])
--select '合法账户' union
--select '非法账户' union
--select '被禁账户' 
--go
insert into [UserInfo]([CustomerId],[CustomerPassword],[CustomerType],[Score],[StatusId])
select '冯程程','922xs','铂金卡',2000,3 union
select '张巧巧','xdls2','金卡',500,3 union
select '猪八戒','lls3','钻石卡',5000,1 
go
