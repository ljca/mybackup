use MyKTV
go
declare @a int
update singer_info  set @a = @a * 2 from singer_type as a 
inner join singer_type  on a.singertype_id = singer_info.singertype_id and singer_type = 1
