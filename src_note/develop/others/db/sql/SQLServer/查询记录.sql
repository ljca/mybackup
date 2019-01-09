use Library
goa
set nocount on
select * from Book as a,
Borrow as b,Reader as c,Penalty as d
where a.BID = b.BID and c.RID = b.RID and a.BID = d.BID
go
