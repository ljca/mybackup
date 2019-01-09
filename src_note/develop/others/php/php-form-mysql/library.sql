-- MySQL dump 10.13  Distrib 5.6.16, for Linux (x86_64)
--
-- Host: localhost    Database: db_library
-- ------------------------------------------------------
-- Server version	5.6.16-log

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
drop database if exists db_library;

create database if not exists library;

use library;


--
-- Table structure for table `tb_bookcase`
--
DROP TABLE IF EXISTS `bookcase`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_bookcase` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=54 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_bookcase`
--

LOCK TABLES `tb_bookcase` WRITE;
/*!40000 ALTER TABLE `tb_bookcase` DISABLE KEYS */;
INSERT INTO `tb_bookcase` VALUES (49,'VC书架'),(50,'VB书架'),(51,'Delphi书架'),(46,'PHP书架'),(48,'net书架'),(37,'ASP图书架'),(47,'JSP书架'),(52,'其他');
/*!40000 ALTER TABLE `tb_bookcase` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_bookinfo`
--

DROP TABLE IF EXISTS `bookinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bookinfo` (
  `barcode` varchar(30) DEFAULT NULL,
  `bookname` varchar(70) DEFAULT NULL,
  `typeid` int(10) unsigned DEFAULT NULL,
  `author` varchar(30) DEFAULT NULL,
  `translator` varchar(30) DEFAULT NULL,
  `ISBN` varchar(20) DEFAULT NULL,
  `price` float(8,2) DEFAULT NULL,
  `page` int(10) unsigned DEFAULT NULL,
  `bookcase` int(10) unsigned DEFAULT NULL,
  `storage` int(10) unsigned DEFAULT NULL,
  `inTime` date DEFAULT NULL,
  `operator` varchar(30) DEFAULT NULL,
  `del` tinyint(1) DEFAULT '0',
  `id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bookinfo`
--

LOCK TABLES `bookinfo` WRITE;
/*!40000 ALTER TABLE `bookinfo` DISABLE KEYS */;
INSERT INTO `bookinfo` VALUES ('123456789','PHP数据库系统开发完全手册',1,'邹天思、潘凯华、刘中华','me','7-121',65.00,530,46,666,'2007-12-07','Tsoft',0,5),('123454321','PHP程序开发范例宝典',2,'邹天思、潘凯华','hehe','7-121',89.00,730,46,299,'2007-12-07','Tsoft',0,6),('987654321','PHP函数参考大全',3,'邹天思、潘凯华','me','7-121',99.00,950,46,799,'2007-11-12','mr',0,2),('9787115154101','Visual Basic控件参考大全',5,'高春艳、刘彬彬','无','7-121',86.00,777,50,10,'2007-12-06','Tsoft',0,20);
/*!40000 ALTER TABLE `bookinfo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `booktype`
--

DROP TABLE IF EXISTS `booktype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `booktype` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `typename` varchar(30) DEFAULT NULL,
  `days` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `booktype`
--

LOCK TABLES `booktype` WRITE;
/*!40000 ALTER TABLE `booktype` DISABLE KEYS */;
INSERT INTO `booktype` VALUES (1,'数据库技术',30),(2,'宝典系列',45),(3,'信息科学技术',20),(5,'计算机程序设计',30);
/*!40000 ALTER TABLE `booktype` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `borrow`
--

DROP TABLE IF EXISTS `borrow`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `borrow` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `readerid` int(10) unsigned DEFAULT NULL,
  `bookid` int(10) DEFAULT NULL,
  `borrowTime` date DEFAULT NULL,
  `backTime` date DEFAULT NULL,
  `operator` varchar(30) DEFAULT NULL,
  `ifback` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=50 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `borrow`
--

LOCK TABLES `borrow` WRITE;
/*!40000 ALTER TABLE `borrow` DISABLE KEYS */;
INSERT INTO `borrow` VALUES (14,1,6,'2007-01-01','2007-12-06','Tsoft',1),(42,1,2,'2007-12-06','2008-01-05','Tsoft',0),(49,18,2,'2007-12-07','2008-01-06','Tsoft',0),(48,18,20,'2007-12-06','2007-12-06','Tsoft',1),(33,11,2,'2007-12-05','2007-12-05','Tsoft',1),(47,18,20,'2007-12-06','2007-12-06','Tsoft',1),(46,16,20,'2007-12-06','2007-12-06','Tsoft',1),(45,1,5,'2007-12-06','2008-01-05','Tsoft',0),(44,11,2,'2007-12-06','2008-01-05','Tsoft',0),(43,1,5,'2007-12-06','2007-12-06','Tsoft',1);
/*!40000 ALTER TABLE `borrow` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `library`
--

DROP TABLE IF EXISTS `library`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `library` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `libraryname` varchar(50) DEFAULT NULL,
  `curator` varchar(10) DEFAULT NULL,
  `tel` varchar(20) DEFAULT NULL,
  `address` varchar(100) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `url` varchar(100) DEFAULT NULL,
  `createDate` date DEFAULT NULL,
  `introduce` text,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `library`
--

LOCK TABLES `library` WRITE;
/*!40000 ALTER TABLE `library` DISABLE KEYS */;
INSERT INTO `library` VALUES (1,'吉林***师范大学博考图书馆','纯净水3434','1363444****','吉林省长春市****路**号','zts**@***.com','http://www.mrbccd.com','1996-05-29','博、学、精、深');
/*!40000 ALTER TABLE `library` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `manager`
--

DROP TABLE IF EXISTS `manager`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `manager` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(30) DEFAULT NULL,
  `pwd` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=24 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `manager`
--

LOCK TABLES `manager` WRITE;
/*!40000 ALTER TABLE `manager` DISABLE KEYS */;
INSERT INTO `manager` VALUES (1,'Tsoft','111'),(22,'lx','lx'),(23,'al','al');
/*!40000 ALTER TABLE `manager` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `parameter`
--

DROP TABLE IF EXISTS `parameter`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `parameter` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `cost` int(10) unsigned DEFAULT NULL,
  `validity` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `parameter`
--

LOCK TABLES `parameter` WRITE;
/*!40000 ALTER TABLE `parameter` DISABLE KEYS */;
INSERT INTO `parameter` VALUES (1,120,12);
/*!40000 ALTER TABLE `parameter` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `publishing`
--

DROP TABLE IF EXISTS `publishing`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `publishing` (
  `ISBN` varchar(20) DEFAULT NULL,
  `pubname` varchar(30) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `publishing`
--

LOCK TABLES `publishing` WRITE;
/*!40000 ALTER TABLE `publishing` DISABLE KEYS */;
INSERT INTO `publishing` VALUES ('7-115','清华出版社'),('7-111','机械工业出版'),('7-121','人民邮电出版社');
/*!40000 ALTER TABLE `publishing` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `purview`
--

DROP TABLE IF EXISTS `purview`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `purview` (
  `id` int(11) NOT NULL DEFAULT '0',
  `sysset` tinyint(1) DEFAULT '0',
  `readerset` tinyint(1) DEFAULT '0',
  `bookset` tinyint(1) DEFAULT '0',
  `borrowback` tinyint(1) DEFAULT '0',
  `sysquery` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purview`
--

LOCK TABLES `purview` WRITE;
/*!40000 ALTER TABLE `purview` DISABLE KEYS */;
INSERT INTO `purview` VALUES (22,1,1,1,0,0),(1,1,1,1,1,1);
/*!40000 ALTER TABLE `purview` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reader`
--

DROP TABLE IF EXISTS `reader`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reader` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(20) DEFAULT NULL,
  `sex` varchar(4) DEFAULT NULL,
  `barcode` varchar(30) DEFAULT NULL,
  `vocation` varchar(50) DEFAULT NULL,
  `birthday` date DEFAULT NULL,
  `paperType` varchar(10) DEFAULT NULL,
  `paperNO` varchar(20) DEFAULT NULL,
  `tel` varchar(20) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `createDate` date DEFAULT NULL,
  `operator` varchar(30) DEFAULT NULL,
  `remark` mediumtext,
  `typeid` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=20 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reader`
--

LOCK TABLES `reader` WRITE;
/*!40000 ALTER TABLE `reader` DISABLE KEYS */;
INSERT INTO `reader` VALUES (1,'陈丽','女','123456789','职员','1980-09-29','身份证','22010412331***','13633333****','wgh***@s**u.com','2006-05-27','admin','哈哈',4),(2,'张勇','男','3214555555','职员','1983-02-22','军官证','2201043222******','113655422555','dream****@**u.com','2006-05-27','admin','??',1),(16,'小丽','女','123456','程序员','1985-02-25','身份证','54515452***','136********','xl***@163.com','2007-12-06','Tsoft','无',16),(8,'纯净水','女','13579','职员','1982-12-14','身份证','2220000000***','1375666***','44**@sina.com','2006-06-10','mr','图书迷',14),(19,'小刚','男','222222','硬件维护','1982-05-06','身份证','2132123*****','136********','xg**@163.com','2007-12-06','Tsoft','无',20),(11,'小凡','女','1255***','IT业','1980-02-25','工作证','55255**','421552***','53**34@sina.com','2007-12-01','Tsoft','我是一个图书迷',13),(18,'小欣','女','111111','程序员','1985-02-25','身份证','21212345546***','136********','xx***@163.com','2007-12-06','Tsoft','无',14);
/*!40000 ALTER TABLE `reader` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `readertype`
--

DROP TABLE IF EXISTS `readertype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `readertype` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(50) DEFAULT NULL,
  `number` int(4) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=23 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `readertype`
--

LOCK TABLES `readertype` WRITE;
/*!40000 ALTER TABLE `readertype` DISABLE KEYS */;
INSERT INTO `readertype` VALUES (1,'学生',4),(4,'公务员',5),(14,'图书爱好者',3),(15,'教师',2),(16,'程序员',2),(20,'硬件维护',10);
/*!40000 ALTER TABLE `readertype` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-11-25 12:51:30
