create database if not exists bookms;

use bookms;

/* 图书信息表 */
create table if not exists bookinfo
(
  id int auto_increment primary key,
  bid varchar(30) not null, /* 图书编号，条形码 */
  name varchar(70) not null,
  author varchar(20),
  translator varchar(20),
  isbn varchar(20),
  price float(8,2),
  page int(10),
  typeid int(10), /* 类型编号 */
  isdel tinyint(1),
  operator varchar(20),
  bcase varchar(10), /* 书架 */
  inTime date, /* 入库时间 */
  stroage int(10) /* 库存 */
);

/* 借阅信息:borrow */

create table if not exists borrow
(
  id int(10) primary key,auto_increment,
  rid int(10) not null, /* 读者编号 */
  bid int(10), /* 图书编号 */
  borrowTime date,
  backTime date,
  operator varchar(20),
  isback tinyint(1) default 0
);

/* 读者信息:reader */

create table if not exists reader
(
  rid int(10) primary key auto_increment, /* 编号 */
  name varchar(20) not null,
  sex varchar(4) not null,
  tel varchar(20) not null,
  email varchar(100) not null,
  cType varchar(10), /* 证件类型：card type */
  cid varchar(20) not null, /* 证件编号：card id */
  rcode varchar(30) not null, /* 读者编号 */
  cation varchar(30), /* 职业 */
  birthday date,
  typeid int(11), /* 类型编号 */
  notice varchar(255), /* 备注 */
  operator varchar(20)
);


insert into bookinfo() values();

