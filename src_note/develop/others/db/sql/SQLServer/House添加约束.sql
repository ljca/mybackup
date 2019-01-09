use House
go

/**/
alter table hos_street
add constraint FK_SDID_DID foreign key(SDID) references hos_district(DID)
go

/**/
alter table hos_house
add constraint FK_UID_UID foreign key ([UID]) references sys_user([UID])
go

/**/
alter table hos_house
add constraint FK_SID_SID foreign key([SID]) references hos_street([SID])
go

/**/
alter table hos_house
add constraint FK_HTID_HTID foreign key(HTID) references hos_type(HTID)
go
select * from sysobjects
go