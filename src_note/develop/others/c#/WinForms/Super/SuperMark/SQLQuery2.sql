use [SuperMark]
go
select [CustomerId],[CustomerType],[Score],[StatesName] from [UserInfo] as p,[States] as c
where c.Id = p.StatesId
go
