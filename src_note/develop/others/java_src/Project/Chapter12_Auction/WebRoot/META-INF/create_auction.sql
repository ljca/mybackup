alter table auctionRecord
   drop constraint FK_rec_REF_user;

alter table auctionRecord
   drop constraint FK_rec_REF_AUC;

drop table auction cascade constraints;

drop table auctionRecord cascade constraints;

drop index Index_1;

drop table auctionUser cascade constraints;

create table auction  (
   auctionId            number(6)                       not null,
   auctionName          nvarchar2(50)                   not null,
   auctionStartPrice    number(9,2)                     not null,
   auctionUpset         number(9,2)                     not null,
   auctionStartTime     TIMESTAMP                       not null,
   auctionEndTime       TIMESTAMP                       not null,
   auctionPic           BLOB                            not null,
   auctionPicType       nvarchar2(20)                   not null,
   auctionDesc          nvarchar2(500),
   constraint PK_AUCTION primary key (auctionId)
);

comment on table auction is
'拍卖品';

comment on column auction.auctionId is
'拍卖品编号';

comment on column auction.auctionName is
'拍卖品名称';

comment on column auction.auctionStartPrice is
'拍卖品起拍价';

comment on column auction.auctionUpset is
'拍卖品底价';

comment on column auction.auctionStartTime is
'拍卖品拍卖开始时间';

comment on column auction.auctionEndTime is
'拍卖品拍卖结束时间';

comment on column auction.auctionPic is
'拍卖品图片';

comment on column auction.auctionPicType is
'拍卖品图片扩展名';

comment on column auction.auctionDesc is
'拍卖品描述';

create table auctionUser  (
   userId                number(6)                      not null,
   userName             nvarchar2(20)                   not null,
   userPassword         nvarchar2(20)                   not null,
   userCardNo           nvarchar2(20),
   userTel               nvarchar2(20),
   userAddress          nvarchar2(200),
   userPostNumber       nvarchar2(6),
   userIsadmin          number(1)                      default 0,
   userQuestion         nvarchar2(100),
   userAnswer           nvarchar2(100),
   constraint PK_AUCTIONUSER primary key (userId)
);

comment on table auctionUser is
'用户表';

comment on column auctionUser.userId is
'用户编号';

comment on column auctionUser.userName is
'用户名';

comment on column auctionUser.userPassword is
'用户密码';

comment on column auctionUser.userCardNo is
'用户身份证号';

comment on column auctionUser.userTel is
'用户电话';

comment on column auctionUser.userAddress is
'用户地址';

comment on column auctionUser.userPostNumber is
'用户邮政编号';

comment on column auctionUser.userIsadmin is
'用户是否是管理员，0是竞拍者，1是管理员，默认值是0';

comment on column auctionUser.userQuestion is
'用户找回密码的问题';

comment on column auctionUser.userAnswer is
'用户找回密码答案';

create table auctionRecord  (
   id                   number(9)                       not null,
   userId                number(6),
   auctionId            number(6)                       not null,
   auctionTime          TIMESTAMP                      default SYSDATE not null,
   auctionPrice         number(9,2)                     not null,
   constraint PK_AUCTIONRECORD primary key (id),
   constraint FK_rec_REF_user foreign key (userId)
         references auctionUser (userId),
   constraint FK_rec_REF_AUC foreign key (auctionId)
         references auction (auctionId)
);

comment on table auctionRecord is
'竞拍记录';

comment on column auctionRecord.id is
'竞拍记录编号';

comment on column auctionRecord.userId is
'竞拍者编号';

comment on column auctionRecord.auctionId is
'拍卖品编号';

comment on column auctionRecord.auctionTime is
'竞价时间';

comment on column auctionRecord.auctionPrice is
'竞拍价格';

create unique index Index_1 on auctionUser (
   userName ASC
);

