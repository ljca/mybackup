use Library
go

/* 添加主键 */

/* 图书信息表主键 图书编号 */
alter table Book 
add constraint PK_BID primary key(BID)
go

/* 读者信息表主键 读者编号 */
alter table Reader 
add constraint PK_RID primary key(RID)
go

/* 图书借阅表主键 读者编号-图书编号-借阅日期 */
alter table Borrow
add constraint PK_RID_BID primary key(RID,BID,LendDate)
go

/* 罚款记录表主键 读者编号-图书编号-罚款日期 */
alter table Penalty 
add constraint PK_RID_BID_Pdate primary key(RID,BID,PDate)
go

print '* 添加主键成功！*'

/* 添加外键 */

/* 图书借阅表外键 图书借阅表-读者信息表，读者编号 */
alter table Borrow
add constraint FK_RID_R Foreign key(RID) references Reader(RID)
go

/* 图书借阅表外键 图书借阅表-图书信息表,图书编号 */
alter table Borrow 
add constraint FK_BID_B Foreign key(BID) references Book(BID)
go

/* 罚款记录表外键 罚款记录表-读者信息表,读者编号 */
alter table Penalty
add constraint FK_RID_RID Foreign key(RID) references Reader(RID)
go

/* 罚款记录表外键 罚款记录表-图书信息表,图书编号 */
alter table Penalty
add constraint FK_BID_BID Foreign key(BID) references Book(BID)
go

print '* 外键添加成功！*'

/* 查询所有外键 */
select * from sysobjects
where xtype='F'
go

