create database if not exists MyOrder;

use MyOrder;

create table if not exists order_defail
(
  ##  订单详情表：order_defail
  defail_id integer NOT NULL auto_increment comment '',
  express_num varchar(50) NOT NULL comment '快递单号:',
  express_inc varchar(100) NULL comment '快递公司:',
  oder_id varchar(255) NULL comment '订单号:', 
  premises_name varchar(30) NULL comment '店铺名称：',
  # unit_price comment '商品单价:',
  freight_num  varchar(100) NULL comment '货运单号:',
  goods_coding varchar(100) NULL comment '商品编码:', #bar_code varchar(30) NOT NULL comment '商品条形码:',
  dispatch_location varchar(30) NULL comment '发货地区：', 
  
#  goods varchar(50) NULL comment '商品名称及规格:',
#  goods_count integer NOT NULL comment '数量:', goods_privilege double NULL comment '优惠:',
#  price double NOT NULL comment '金额:', fare double NULL comment '*运费:',
  primary key(defail_id)
) AUTO_INCREMENT = 1;

/*
create table if not exists order
(
  id integer NOT NULL auto_increment comment '',
  sen_addr varchar(200) NOT NULL comment '寄件人地址:', rec_addr varchar(200) NOT NULL comment '收件人地址:',
  #  sen_inc varchar(200) NULL comment '*寄件人公司:',
  sen_tel varchar(25) NULL comment '寄件人电话:', rec_tel varchar(12) NOT NULL comment '收件人电话:',
  sender varchar(25) NOT NULL comment '寄件人:',recipients varchar(25) NOT NULL comment '收件人: ',
  rec_date timestamp NULL comment '日期:',
  goods_desc varchar(255) NULL comment '备注/描述:',
  defail_id integer not null comment '',
  #  nick varchar(25) NULL comment '*买家昵称:', postal_code varchar(6) NULL comment '*邮编:',
  primary key(id),
  constraint fk_order_defail foreign key(defail_id) references order_defail(defail_id)
);
 */

create table if not exists myorder
(
  id int auto_increment NOT NULL comment '',
  sender varchar(30) NOT NULL comment '', #recipients varchar(30) NOT NULL comment '',
  sen_tel varchar(20) NULL comment '寄件人电话',
  sen_addr varchar(255) NULL comment '',# rec_addr varchar(255) DEFAULT '武兴花园9栋二单元1103/三单元604' comment '',
  goods varchar(100) NULL DEFAULT '未知' comment '',
  price double NOT NULL comment '',
  goods_count int DEFAULT 1,
  # rec_tel varchar(11) DEFAULT '18215564716' comment '',
  rec_date date NULL,

  primary key(id)
);
/*
# 申通快递总部:上海市赵重公路1888号
#黑色带身 105cm
#打印编号,订单编号
#订单号,货运单号,货品编号
# order_id,快递,商品编码,厂家,货位,快递单号
888130154112471,33016789,江苏京东技术有限公司,2015-5-12 09:48:49,4438.90
9334159294,刘毅,18408218925
许巧林,9347376552,18215564716
/*

