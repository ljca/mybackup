-- MySQL dump 10.13  Distrib 5.6.24, for Win64 (x86_64)
--
-- Host: localhost    Database: myorder
-- ------------------------------------------------------
-- Server version	5.6.24-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
create database if not exists myorder;

use myorder;

--
-- Table structure for table `myorder`
--

DROP TABLE IF EXISTS `myorder`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `myorder` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `sender` varchar(30) NOT NULL,
  `sen_tel` varchar(20) DEFAULT NULL COMMENT '寄件人电话',
  `sen_addr` varchar(255) DEFAULT NULL,
  `goods` varchar(100) DEFAULT '未知',
  `price` double NOT NULL,
  `goods_count` int(11) DEFAULT '1',
  `recipients` varchar(25) DEFAULT 'XU' COMMENT 'rec',
  `rec_addr` varchar(200) DEFAULT NULL COMMENT 'address',
  `rec_tel` varchar(11) DEFAULT NULL COMMENT 'tel',
  `rec_date` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `myorder`
--

LOCK TABLES `myorder` WRITE;
/*!40000 ALTER TABLE `myorder` DISABLE KEYS */;
INSERT INTO `myorder` VALUES (1,'乡亲网上药店','4008892790','NULL','复方酮康唑软膏 7g',6.7,1,'xu_qiao_lin','成都市武侯区武兴花园9幢3单元1103','18215564716','2016-04-23'),(2,'孙海龙','13327871488','江苏省连云港市灌云县金源购物中心A303','',0,0,'xu_qiao_lin','成都市武侯区武兴花园9幢3单元1103','18215564716','2015-12-21'),(3,'李小姐','15919789089','广东省深圳市福田区ABC','男士性感丁字裤T裤牛奶丝小内裤超薄冰丝细带低腰诱惑女透明T-177 ',0,0,'xu_qiao_lin','成都市武侯区武兴花园9幢3单元1103','18215564716',NULL),(4,'李小姐','15919789089','广东省深圳市福田区ABC','男士性感丁字裤T裤牛奶丝小内裤超薄冰丝细带低腰诱惑女透明T-177 ',0,0,'xu_qiao_lin','成都市武侯区武兴花园9幢3单元1103','18215564716',NULL),(5,'任衍霞','18660731401','山东省兖州市兴隆庄镇四庄新村1号','衣服',0,1,'xu_qiao_lin','成都市武侯区武兴花园9幢3单元1103','18215564716','2015-09-20'),(6,'柯生','18688504200','广东省江门市鹤山市新环路1104号二楼','NULL',0,0,'xu_qiao_lin','成都市武侯区武兴花园9幢3单元1103','18215564716','0000-00-00'),(7,'丁香',NULL,'','无痕丁字裤头诱惑性感T裤 T_BACK日系少女生低腰丁字内裤白黑色 ',0,0,'xu_qiao_lin','成都市武侯区武兴花园9幢3单元1103','18215564716',NULL),(8,'希翼梦幻船',NULL,NULL,'男士性感丁字裤T裤牛奶丝小内裤超薄冰丝细带低腰诱惑女透明T-177 ',0,0,'xu_qiao_lin','成都市武侯区武兴花园9幢3单元1103','18215564716',NULL),(9,'李小姐','NULL','广东省深圳市福田区ABC','男士性感丁字裤T裤牛奶丝小内裤超薄冰丝细带低腰诱惑女透明T-177 ',0,1,'xu_qiao_lin','成都市武侯区武兴花园9幢3单元1103','18215564716','2015-09-24'),(10,'东方文硕','01053603308/18811183','北京市丰台区西南物流展厅','',0,0,'xu_qiao_lin','成都市武侯区武兴花园9幢3单元1103','18215564716',NULL),(11,'肖ZIYU/上海内存卡','','上海市宝山区电台路599弄69号101','',0,0,'xu_qiao_lin','成都市武侯区武兴花园9幢3单元1103','18215564716',NULL),(12,'jasongamo旗舰店','15257776664',NULL,'',0,0,'xu_qiao_lin','成都市武侯区武兴花园9幢3单元1103','18215564716',NULL),(13,'柳奕林','13826450489',NULL,'',0,0,'xu_qiao_lin','成都市武侯区武兴花园9幢3单元1103','18215564716',NULL),(14,'李松青','0755-25852770','NULL','NULL',0,0,'xu_qiao_lin','成都市武侯区武兴花园9幢3单元1103','18215564716','2016-03-24'),(15,'NULL','187177715154','NULL','去甲锉刀',0,0,'xu_qiao_lin','成都市武侯区武兴花园9幢3单元1103','18215564716',NULL),(16,'陈美华/可可儿数码','15622890689','广东省深圳市龙岗区坂田杨美上段龙景路二巷','NULL',0,0,'xu_qiao_lin','成都市武侯区武兴花园9幢3单元1103','18215564716','0000-00-00'),(17,'永胜数码2008','NULL','NULL','天语C968T电池28',15,1,'xu_qiao_lin','成都市武侯区武兴花园9幢3单元1103','18215564716',NULL),(18,'何','NULL','上海市闵行区浦江镇903C库房','透明/C-29透明',0,1,'xu_qiao_lin','成都市武侯区武兴花园9幢3单元1103','18215564716','2015-09-19'),(19,'石一豪','15152171005','外环看守所对面仓库','康本立特交期景喷剂35ML 1支装',39,1,'xu_qiao_lin','成都市武侯区武兴花园9幢3单元1103','18215564716','2015-06-18'),(20,'郭林','13177774306','江西省南昌市西湖区孺子路菜肴故事楼上','鼠标',0,0,'xu_qiao_lin','成都市武侯区武兴花园9幢3单元1103','18215564716',NULL),(21,'',NULL,NULL,'女用夫妻房事人体阴道润滑剂男用自慰水溶性润滑油液成人情趣用品',0,1,'XU',NULL,NULL,NULL),(22,'',NULL,'广东省深圳市福田区ABC','男士性感丁字裤T裤牛奶丝小内裤超薄冰丝细带低腰诱惑女透明T-177 ',0,1,'XU',NULL,NULL,NULL),(23,'',NULL,NULL,'独爱220ML极润水溶性人体润滑剂热感快感冰感组合装润滑油性用品',0,1,'XU',NULL,NULL,NULL),(24,'',NULL,NULL,'金属不锈钢肛塞男女用G点后庭肛门塞自慰器具另类玩具情趣SM用品',0,1,'XU',NULL,NULL,NULL),(25,'',NULL,NULL,'女用SM刑具金属肛塞扩肛后庭肛门塞超大拉珠激情用具情趣性用品',0,1,'XU',NULL,NULL,NULL),(26,'',NULL,NULL,'USB双跳蛋强力震动静音女用自慰器高潮棒成人情趣性用品激情用具',0,1,'XU',NULL,NULL,NULL),(27,'',NULL,NULL,'女用夫妻房事人体阴道润滑剂男用自慰水溶性润滑油液成人情趣用品',0,1,'XU',NULL,NULL,NULL),(28,'',NULL,'广东省深圳市福田区ABC','男士性感丁字裤T裤牛奶丝小内裤超薄冰丝细带低腰诱惑女透明T-177 ',0,1,'XU',NULL,NULL,'2017-02-18');
/*!40000 ALTER TABLE `myorder` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order_defail`
--

DROP TABLE IF EXISTS `order_defail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `order_defail` (
  `defail_id` int(11) NOT NULL AUTO_INCREMENT,
  `express_num` varchar(50) NOT NULL COMMENT '快递单号:',
  `express_inc` varchar(100) DEFAULT NULL COMMENT '快递公司:',
  `oder_id` varchar(255) DEFAULT NULL COMMENT '订单号:',
  `premises_name` varchar(30) DEFAULT NULL COMMENT '店铺名称：',
  `freight_num` varchar(100) DEFAULT NULL COMMENT '货运单号:',
  `goods_coding` varchar(100) DEFAULT NULL COMMENT '商品编码:',
  `dispatch_location` varchar(30) DEFAULT NULL COMMENT '发货地区：',
  PRIMARY KEY (`defail_id`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order_defail`
--

LOCK TABLES `order_defail` WRITE;
/*!40000 ALTER TABLE `order_defail` DISABLE KEYS */;
INSERT INTO `order_defail` VALUES (1,'400449330448','中通','TM1541874650067574','昆明滇虹药业有限公司','NULL','2130301048','04-03-04'),(2,'373378504544','中通',NULL,NULL,NULL,NULL,NULL),(3,'374563385136','中通',NULL,NULL,NULL,NULL,NULL),(4,'375952686253','中通',NULL,NULL,NULL,NULL,NULL),(5,'367129539805','中通',NULL,NULL,NULL,NULL,NULL),(6,'1089493283516','EMS','NULL','NULL','529700','M1150B',NULL),(7,'374556261085','中通','NULL','NULL','292673','NULL','合肥'),(8,'NULL','NULL',NULL,NULL,NULL,NULL,NULL),(9,'367372118146','中通','NULL','NULL','NULL','NULL','福田新景田'),(10,'3101001834120','韵达',NULL,NULL,NULL,NULL,NULL),(11,'3100816132935','韵达',NULL,NULL,NULL,NULL,NULL),(12,'3901930622201','韵达','1612996090287574','杰森格慕旗舰店','NULL','NULL','NULL'),(13,'367123252614','中通',NULL,NULL,NULL,NULL,NULL),(14,'229456627217','申通','16032400465',NULL,NULL,NULL,NULL),(15,'227447562217','申通',NULL,NULL,NULL,NULL,NULL),(16,'2404217397915','中通','11612996090297574','NULL','29914','NULL','深圳龙华'),(17,'NULL','申通','11503912747347574','6032400465',NULL,NULL,NULL),(18,'367144275347','中通','陈行',NULL,NULL,NULL,NULL),(19,'NULL','京东','9532102716','七旭化妆品专营店','VA06270524934','JDKBjqj001',NULL),(20,'220050903934','百世汇通',NULL,NULL,NULL,NULL,NULL),(21,'','韵达快递 ','2936767082047574','百宝阁成人用品专营店',NULL,NULL,NULL),(22,'','申通快递 ','2938593491427574','译爱情趣用品商城 ',NULL,NULL,NULL),(23,'','圆通速递 ','2936758882937574',' 春梦阁成人珍品',NULL,NULL,NULL),(24,'','圆通速递 ','3149496516847574',' 花样年华.性感男士女',NULL,NULL,NULL),(25,'',NULL,NULL,' 花样年华.性感男士女',NULL,NULL,NULL),(26,'',NULL,'3149253917127574',' 保乐堂情趣商城',NULL,NULL,NULL),(27,'',NULL,'3149253917137574','粉奈尔情趣商城',NULL,NULL,NULL);
/*!40000 ALTER TABLE `order_defail` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-12-04  3:54:46
