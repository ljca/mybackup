--use QQManager
go
/*
select  top 3 * from QQUserInfo as C
inner join QQx as D on C.OnLineD = D.OnLineD
--inner join QQx as s on C.QQId = s.QQId
go
*/
select count(*) from QQUserInfo as C
inner join QQx as D on D.QQId = C.QQId
group by C.QQId

go
/*
exec sp_helpdb QQManager
go
exec sp_tables QQuserInfo
exec sp_tables LogInfo
exec sp_tables QQx
go
select * from QQD
go
*/ 