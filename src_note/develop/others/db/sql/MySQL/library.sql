drop database if exists library;
create database if  not exists library;
use library;
drop table if exists books;
create table if not exists books
(
  bid integer(50) not null,bName varchar(60) not null,
  author varchar(25) not null comment '作者姓名',pubComp varchar(200) comment '出版社名称',
  pubDate date,bCount integer(11) comment '库存',price float comment '价格',
  constraint PK_bid primary key(bid),
  CK_price check (price > 0),
  CK_bcount check (bCount >= 1)
);

drop table if exists reader;
create table if not exists reader
(
  rid varchar(50) not null comment '读者编号',
  rname varchar(25) not null comment '读者姓名',
  ledNum integer(50) comment '已借书数量',rAddress varchar(255),
  constraint 
  PK_rid primary key(rid),
  CK_lednum check (ledNum >= 0)
);
drop table if exists borrow;
create table if not exists borrow
(
  rid varchar(50) not null,
  bid varchar(50) not null,
  lendDate date not null,
  willDate date,
  returnDate date default '',
  constraint 
  PK_id primary key(rid,bid,lendDate),
  FK_rid foreign key(rid) references reader(rid),
  FK_bid foreign key(bid) references book(bid),
  CK_willDate check (willDate > lendDate)
);

drop table if exists penalty;
create table if not exists penalty
(
  rid varchar(50) not null,
  bid varchar(50) not null,
  pDate date not null comment '罚款日期',
  pType integer(11),
  aMount float(20),
  constraint
  PK_r_bid primary key(rid,bid,pDate),
  FK_rid_bid foreign key(rid) references key reader(rid),
  FK_bid_rid foreign key(bid) references key book(bid),
  CK_amount check aMount > 0
  CK_ptype check pType in(1,2,3)
);
