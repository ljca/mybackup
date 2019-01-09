-- MySQL dump 10.13  Distrib 5.6.24, for Win64 (x86_64)
--
-- Host: localhost    Database: bookdb
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

--
-- Current Database: `bookdb`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `bookdb` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `bookdb`;

--
-- Table structure for table `bookmanage`
--

DROP TABLE IF EXISTS `bookmanage`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bookmanage` (
  `b_id` int(10) NOT NULL AUTO_INCREMENT,
  `b_name` varchar(40) NOT NULL,
  `b_author` varchar(40) NOT NULL,
  `b_time` date NOT NULL,
  `b_type` varchar(40) NOT NULL,
  PRIMARY KEY (`b_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bookmanage`
--

LOCK TABLES `bookmanage` WRITE;
/*!40000 ALTER TABLE `bookmanage` DISABLE KEYS */;
INSERT INTO `bookmanage` VALUES (1,'天龙八部','金庸','2015-05-22','武侠'),(2,'川菜大全','张大厨','2015-04-22','美食'),(3,'盗墓笔记','张三','2016-06-15','科幻'),(4,'航空母舰','李四','2016-06-15','军事');
/*!40000 ALTER TABLE `bookmanage` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Current Database: `bookstore`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `bookstore` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `bookstore`;

--
-- Table structure for table `authors`
--

DROP TABLE IF EXISTS `authors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `authors` (
  `author_id` int(11) NOT NULL AUTO_INCREMENT,
  `author_name` varchar(50) NOT NULL,
  `country` varchar(50) DEFAULT NULL,
  `tmp` int(20) DEFAULT NULL,
  PRIMARY KEY (`author_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `authors`
--

LOCK TABLES `authors` WRITE;
/*!40000 ALTER TABLE `authors` DISABLE KEYS */;
INSERT INTO `authors` VALUES (1,'Greene Graham','The United Kindom',0),(2,' Yang DongQin','China',NULL),(3,'Loney.K Bryla.B',NULL,NULL),(4,'Robert Sedgewick　Kevin Wayne',NULL,NULL);
/*!40000 ALTER TABLE `authors` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `books`
--

DROP TABLE IF EXISTS `books`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `books` (
  `book_id` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(50) NOT NULL,
  `author_id` int(11) NOT NULL,
  `description` text,
  `genre` enum('novel','poetry','drema') DEFAULT NULL,
  `publisher_id` int(100) DEFAULT NULL,
  `pub_year` varchar(4) DEFAULT NULL,
  `ISBN` varchar(20) NOT NULL,
  PRIMARY KEY (`book_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `books`
--

LOCK TABLES `books` WRITE;
/*!40000 ALTER TABLE `books` DISABLE KEYS */;
INSERT INTO `books` VALUES (1,'Gonggong JiChu ZhiShi',1,'Unknow','novel',NULL,'2013','978-7-04-037232-8'),(2,'ShuJuKu YuanLi',2,'Unknow','novel',NULL,'2013','978-7-04-036948-8'),(3,'Oracle Database 11g DBA Handbook',3,NULL,NULL,NULL,'2009','978-7-302-19139-1'),(4,'Shuan Fa',4,NULL,NULL,NULL,NULL,'978-7-115-29380-0');
/*!40000 ALTER TABLE `books` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Current Database: `company`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `company` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `company`;

--
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `employees` (
  `employeeNumber` int(11) NOT NULL AUTO_INCREMENT,
  `lastName` varchar(50) DEFAULT NULL,
  `firstName` varchar(50) DEFAULT NULL,
  `mobile` varchar(25) NOT NULL,
  `officeCode` int(10) NOT NULL,
  `jobTitle` varchar(50) NOT NULL,
  `birth` datetime NOT NULL,
  `note` varchar(255) DEFAULT NULL,
  `sex` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`employeeNumber`),
  UNIQUE KEY `uq_mobile` (`mobile`),
  KEY `fk_o_emp` (`officeCode`),
  CONSTRAINT `fk_o_emp` FOREIGN KEY (`officeCode`) REFERENCES `offices` (`officeCode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employees`
--

LOCK TABLES `employees` WRITE;
/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `offices`
--

DROP TABLE IF EXISTS `offices`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `offices` (
  `officeCode` int(10) NOT NULL,
  `city` int(11) NOT NULL,
  `address` varchar(50) DEFAULT NULL,
  `country` varchar(50) NOT NULL,
  `postalCode` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`officeCode`),
  UNIQUE KEY `uq_pCode` (`postalCode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `offices`
--

LOCK TABLES `offices` WRITE;
/*!40000 ALTER TABLE `offices` DISABLE KEYS */;
/*!40000 ALTER TABLE `offices` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Current Database: `leave`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `leave` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `leave`;

--
-- Table structure for table `leaverecords`
--

DROP TABLE IF EXISTS `leaverecords`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `leaverecords` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) NOT NULL,
  `Time` datetime NOT NULL,
  `Reason` varchar(200) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `leaverecords`
--

LOCK TABLES `leaverecords` WRITE;
/*!40000 ALTER TABLE `leaverecords` DISABLE KEYS */;
INSERT INTO `leaverecords` VALUES (2,'徐航','2016-06-23 09:00:00','出门旅游，游山玩水'),(3,'李雪冬','2015-02-03 00:00:00','回老家，看父母'),(4,'李季','2014-02-02 00:00:00','带孩子参观博物馆'),(5,'李季','2015-02-03 00:00:00','未知请假原因');
/*!40000 ALTER TABLE `leaverecords` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Current Database: `myschool`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `myschool` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `myschool`;

--
-- Table structure for table `grade`
--

DROP TABLE IF EXISTS `grade`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `grade` (
  `gradeId` int(11) NOT NULL AUTO_INCREMENT COMMENT '年级编号',
  `gradeName` varchar(50) DEFAULT NULL COMMENT '年级名称',
  PRIMARY KEY (`gradeId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grade`
--

LOCK TABLES `grade` WRITE;
/*!40000 ALTER TABLE `grade` DISABLE KEYS */;
INSERT INTO `grade` VALUES (1,'S1'),(2,'S2'),(3,'Y2');
/*!40000 ALTER TABLE `grade` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `results`
--

DROP TABLE IF EXISTS `results`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `results` (
  `resId` int(11) NOT NULL AUTO_INCREMENT COMMENT '成绩编号，自增列',
  `stuId` int(11) NOT NULL COMMENT '学生Id，外键，引用学生信息表主键',
  `subId` int(11) NOT NULL COMMENT '课程编号，外键，引用课程表主键',
  `stuResult` int(11) DEFAULT NULL COMMENT '学生成绩',
  `examDate` date DEFAULT NULL COMMENT '考试时间',
  PRIMARY KEY (`resId`),
  KEY `stu_results_fk` (`stuId`),
  KEY `subject_results_fk` (`subId`),
  CONSTRAINT `stu_results_fk` FOREIGN KEY (`stuId`) REFERENCES `stu` (`stuId`),
  CONSTRAINT `subject_results_fk` FOREIGN KEY (`subId`) REFERENCES `subject` (`subId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `results`
--

LOCK TABLES `results` WRITE;
/*!40000 ALTER TABLE `results` DISABLE KEYS */;
INSERT INTO `results` VALUES (1,1,1,70,'2015-06-12');
/*!40000 ALTER TABLE `results` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stu`
--

DROP TABLE IF EXISTS `stu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `stu` (
  `stuId` int(11) NOT NULL AUTO_INCREMENT,
  `stuNo` varchar(50) NOT NULL COMMENT '学号',
  `loginPwd` varchar(20) DEFAULT '123456' COMMENT '登录密码',
  `stuName` varchar(25) NOT NULL COMMENT '学生姓名',
  `sex` varchar(2) NOT NULL COMMENT '性别',
  `gradeId` int(11) NOT NULL COMMENT '年级编号，外键，引用年级表',
  `phone` varchar(255) DEFAULT NULL COMMENT '手机',
  `address` varchar(255) DEFAULT '学生宿舍',
  `bornDate` datetime DEFAULT NULL COMMENT '出生日期',
  `email` varchar(255) DEFAULT NULL COMMENT '电子邮件地址',
  PRIMARY KEY (`stuId`,`stuNo`),
  KEY `student_grade_fk` (`gradeId`),
  CONSTRAINT `student_grade_fk` FOREIGN KEY (`gradeId`) REFERENCES `grade` (`gradeId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stu`
--

LOCK TABLES `stu` WRITE;
/*!40000 ALTER TABLE `stu` DISABLE KEYS */;
INSERT INTO `stu` VALUES (1,'17114062547','512xie36','许XX','男',3,'18215564716','武兴花园9栋2单元604','1995-06-20 00:00:00','k_y_z_s@yeah.net');
/*!40000 ALTER TABLE `stu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subject`
--

DROP TABLE IF EXISTS `subject`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `subject` (
  `subId` int(11) NOT NULL AUTO_INCREMENT COMMENT '课程编号',
  `subName` varchar(20) DEFAULT NULL COMMENT '课程表',
  `classHour` int(11) DEFAULT NULL COMMENT '学时',
  `gradeId` int(11) NOT NULL COMMENT '年级编号，外键',
  PRIMARY KEY (`subId`),
  KEY `grade_subject_fk` (`gradeId`),
  CONSTRAINT `grade_subject_fk` FOREIGN KEY (`gradeId`) REFERENCES `grade` (`gradeId`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subject`
--

LOCK TABLES `subject` WRITE;
/*!40000 ALTER TABLE `subject` DISABLE KEYS */;
INSERT INTO `subject` VALUES (1,'使用Java理解程序逻辑',3,1),(2,'C#语言和数据库技术基础',3,1),(3,'使用HTML&CSS开发商业站点',2,1),(4,'使用C#开发数据库应用系统',2,1),(5,'优化MySchool数据库设计',2,2),(6,'JavaScript&jQuery',3,2),(7,'.NET',3,2);
/*!40000 ALTER TABLE `subject` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Current Database: `netbar`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `netbar` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `netbar`;

--
-- Table structure for table `card`
--

DROP TABLE IF EXISTS `card`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `card` (
  `cardId` varchar(10) NOT NULL,
  `passWord` varchar(50) DEFAULT '123456',
  `balance` int(11) DEFAULT '0' COMMENT '卡上余额',
  `userName` varchar(50) DEFAULT 'kyzs',
  PRIMARY KEY (`cardId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `card`
--

LOCK TABLES `card` WRITE;
/*!40000 ALTER TABLE `card` DISABLE KEYS */;
INSERT INTO `card` VALUES ('c1','123456',5,'kyzs1'),('c10','123456',5,'kyzs10'),('c11','123456',5,'kyzs11'),('c12','123456',5,'kyzs12'),('c13','123456',5,'kyzs13'),('c14','123456',5,'kyzs14'),('c15','123456',5,'kyzs15'),('c16','123456',5,'kyzs16'),('c17','123456',5,'kyzs17'),('c18','123456',5,'kyzs18'),('c19','123456',5,'kyzs19'),('c2','123456',5,'kyzs2'),('c20','123456',5,'kyzs20'),('c21','123456',5,'kyzs21'),('c22','123456',5,'kyzs22'),('c23','123456',5,'kyzs23'),('c24','123456',5,'kyzs24'),('c25','123456',5,'kyzs25'),('c26','123456',5,'kyzs26'),('c27','123456',5,'kyzs27'),('c28','123456',5,'kyzs28'),('c29','123456',5,'kyzs29'),('c3','123456',5,'kyzs3'),('c30','123456',5,'kyzs30'),('c31','123456',5,'kyzs31'),('c4','123456',5,'kyzs4'),('c5','123456',5,'kyzs5'),('c6','123456',5,'kyzs6'),('c7','123456',5,'kyzs7'),('c8','123456',5,'kyzs8'),('c9','123456',5,'kyzs9');
/*!40000 ALTER TABLE `card` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `computer`
--

DROP TABLE IF EXISTS `computer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `computer` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `computerId` varchar(10) NOT NULL COMMENT '计算机编号',
  `computer_name` varchar(30) DEFAULT NULL,
  `onUse` varchar(1) NOT NULL COMMENT '是否正在使用',
  `note` varchar(100) DEFAULT NULL COMMENT '备注信息',
  PRIMARY KEY (`id`,`computerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `computer`
--

LOCK TABLES `computer` WRITE;
/*!40000 ALTER TABLE `computer` DISABLE KEYS */;
/*!40000 ALTER TABLE `computer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `record`
--

DROP TABLE IF EXISTS `record`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `record` (
  `recId` int(11) NOT NULL AUTO_INCREMENT,
  `cardId` varchar(10) NOT NULL,
  `computerId` varchar(10) NOT NULL COMMENT '计算机编号，引用计算机表',
  `beginTime` date DEFAULT NULL COMMENT '开始时间',
  `endTime` date DEFAULT NULL,
  `fee` decimal(10,0) DEFAULT NULL COMMENT '上机费用',
  PRIMARY KEY (`recId`),
  KEY `computer_record_fk` (`computerId`),
  KEY `fk_card_rec` (`cardId`),
  CONSTRAINT `fk_card_rec` FOREIGN KEY (`cardId`) REFERENCES `card` (`cardId`),
  CONSTRAINT `fk_com_rec` FOREIGN KEY (`recId`) REFERENCES `computer` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `record`
--

LOCK TABLES `record` WRITE;
/*!40000 ALTER TABLE `record` DISABLE KEYS */;
/*!40000 ALTER TABLE `record` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-12-04  3:53:46
