use easybuy;
/*
用户信息表easybuy_user
字段名称	说　　明
eu_user_id	用户ID	
eu_user_name	用户名	
eu_password	密码	
eu_sex	性别	
eu_birthday	出生日期	
eu_identity_code	身份证号	
eu_email	email	
eu_mobile	手机	
eu_address	地址	
eu_status	类型	1 普通用户 2 管理员
*/
delete from easybuy_user;
insert into easybuy_user(en_user_id,en_user_name,en_password,en_sex,en_birthday,
en_identity_code,en_email,en_mobile,en_address,en_status)
values
('easybuy1','admin','admin','男','1988-2-22','50100202020220233','admin@yeah.net','125906800521','北京市朝阳区xx路',1),
('easybuy2','含笑','admin','女','1983-2-21','52100202020250939','hanxiao@163.com','125906800521','成都市金牛区xx路',2),
('easybuy3','小米','admin','女','1991-2-22','54100202020220334','ximi@yeah.net','125906800521','福州市晋安区xx路',1),
('easybuy4','想飞的鱼','admin','男','1952-2-22','52100202020220236','xfdy@yeah.net','125906800521','北京市东城区xx路',1),
('easybuy5','喜欢游泳的猪','admin','女','1995-2-22','52200202020220254','xhyydz@yeah.net','125906800521','福州市马尾区xx路',1),
('easybuy6','未知用户名','admin','男','1994-2-22','50156202020220209','wz@yeah.net','125906800521','杭州市xx路',2)
;

/*
新闻表easybuy_news
字段名称	说　　明
en_id	编号	自动编号（标识列），从1开始，主键
en_title	标题	
en_content	内容	
en_create_time	录入日期
*/
delete from easybuy_news;
insert into easybuy_news(en_title,en_content,en_create_time)
values
('Inter酷睿系列Hardware架构CPU降价了','经Inter证实....Inter Hardward架构Cpu降价了，促销活动中','2012-2-2'),
('xx地震了','xx地震了？新闻组。。。。','2012-10-2'),
('双11大促销','双11大促销，本店商品9折处理，买二还送一......','2012-11-9'),
('积分兑换开始了','积分兑换开始了，可以使用积分兑换话费，充值卡等商品......','2012-2-2'),
('新年特惠','29日到30日，因为新年即将到来，本店所有商品特惠.....','2012-1-30'),
('加入会员赢礼包','加入会员可赢礼包千万......','2012-5-7')
;

/*
留言表 easybuy_comment
字段名称	说　　明
ec_id	编号	自动编号（标识列），从1开始，主键
ec_reply	回复	
ec_content	内容	
ec_create_time	创建时间	
ec_reply_time	回复时间	
ec_nick_name	留言用户昵称	
*/
delete from easybuy_comment;
insert into easybuy_comment(ec_reply,ec_content,ec_create_time,ec_reply_time,ec_nick_name)
values
('货已发，请查收','掌柜的，啥时候发货呢？','2012-2-3','2012-2-3','weixiao'),
('货已发，接收货物时请检查包裹完整','定了台Ipad,很期待呢','2013-3-5','2013-3-5','mls'),
('很抱歉，经过我们的测试，这款耳机并不匹配您的机型，您可以看看其它牌子的耳机，祝您购物愉快！','麻烦掌柜的帮忙看看啦...','2013-6-3','2013-6-8','xiaomo')
;

/*
商品分类
图书 音像 图书 音乐 
百货 
运动 健康 服装 家居 美妆 母婴食品 手机数码 家具首饰 手表饰品 鞋包 家电 电脑办公 玩具文具 汽车用品
音乐
 影视
 少儿
 动漫
 小说
 外语
 数码相机
 笔记本
 羽绒服
 秋冬靴
 运动鞋
 美容护肤
 家纺用品
 婴幼奶粉

商品列表
法国德菲丝松露精品巧克力500g/盒￥108.0
 乐扣普通型保鲜盒圣诞7件套￥69.90
 欧珀莱均衡保湿四件套￥279.0
 联想笔记本电脑 高速独立显存￥4199
 法姿韩版显瘦彩边时尚牛仔铅笔裤￥49.00
 Genius925纯银施华洛世奇水晶吊坠￥69.90
 利仁2018M福满堂电饼铛 好用实惠￥268.0
 达派高档拉杆箱20寸 经典款式￥198.0
 爱国者MP4 全屏触摸多格式播放 4G￥289.0
 多美滋金装金盾3阶段幼儿配方奶粉￥186.0
 法国德菲丝松露精品巧克力500g/盒￥108.0
 乐扣普通型保鲜盒圣诞7件套￥69.90
*/

/*
商品分类表 easybuy_product_category
字段名称	说　　明
epc_id	编号	自动编号（标识列），从1开始，主键
epc_name	名字	
epc_parent_id	父分类	
*/
delete from easybuy_product_category;
insert into easybuy_product_category(epc_name,epc_parent_id)
values
('图书',1),('音像',2),('图书',3),('音乐',4),('运动',5),('健康',6),('服装',7),('家居',8),
('汽车用品',9),('玩具文具',10),('电脑办公',11),('鞋包',12),('手表饰品',13),('家具首饰',14),
('手机数码',15),('母婴食品',16),('美妆',17);

/*
商品信息表 easybuy_product
字段名称	说　　明
ep_id	编号	自动编号（标识列），从1开始，主键
ep_name	名字	
ep_description	描述	
ep_price	价格	
ep_stock	库存	
epc_id	分类ID	
epc_child_id	二级分类ID	
ep_file_name	文件名
*/
delete from `easybuy_product`;
insert into `easybuy_product`(`ep_name`,`ep_description`,`ep_price`,`ep_stock`,`epc_id`,
`epc_child_id`,`ep_file_name`)
values
('巧克力','法国德菲丝松露精品巧克力500g/盒',108.0,1000,11,null,null),
('圣诞7件套','乐扣普通型保鲜盒圣诞7件套',69.90,2000,7,null,null),
('保湿四件套','欧珀莱均衡保湿四件套',279.0,300,7,null,null),
('笔记本电脑','联想笔记本电脑 高速独立显存',4199.0,10000,11,null,null),
('牛仔铅笔裤','法姿韩版显瘦彩边时尚牛仔铅笔裤',49.00,500,7,null,null),
('水晶吊坠','Genius925纯银施华洛世奇水晶吊坠',69.90,30,13,null,null),
('福满堂电饼铛','利仁2018M福满堂电饼铛 好用实惠',268.0,1000,5,null,null),
('拉杆箱','达派高档拉杆箱20寸 经典款式',198.0,300,12,null,null),
('爱国者MP4','爱国者MP4 全屏触摸多格式播放 4G',289.0,1000,15,null,null),
('幼儿配方奶粉','多美滋金装金盾3阶段幼儿配方奶粉',186.0,500,16,null,null)
;

/*
订单表 easybuy_order
字段名称	说　　明
eo_id	编号	自动编号（标识列），从1开始，主键
eo_user_id	用户ID	
eo_user_name	用户名	
eo_user_address	用户地址	
eo_create_time	创建时间	
eo_cost	金额	
eo_status	状态	1 下单 2 审核通过 3 配货 4 送货中 5收获并确认
eo_type	付款方式	1 货到付款 2 网上支付
*/

delete from easybuy_order;
insert into easybuy_order(eo_user_id,eo_user_name,eo_user_address,
eo_create_time,eo_cost,eo_status,eo_type)
values
('easybuy1','admin','北京市朝阳区xx路','2012-3-7',200.0,1,1),
('easybuy3','小米','福州市晋安区xx路','2012-5-7',152.0,2,2),
('easybuy4','想飞的鱼','北京市东城区xx路','2013-11-7',30.0,3,2),
('easybuy5','喜欢游泳的猪','福州市马尾区xx路','2013-3-7',800.80,5,1)
;

/*
订单明细表 easybuy_order_detail
字段名称	说　　明
eod_id	编号	自动编号（标识列），从1开始，主键
eo_id	订单ID	
ep_id	商品ID	
eod_quantity	数量
eod_cost	金额	
*/
delete from easybuy_order_detail;
insert into easybuy_order_detail(eo_id,ep_id,
eod_quantity,eod_cost)
values
(1,12059,2,200),(2,27356,2,152),
(3,79202,1,30),(4,32938,5,800.8);
commit;