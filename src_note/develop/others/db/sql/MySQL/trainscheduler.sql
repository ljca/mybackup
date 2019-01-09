-- MySQL dump 10.13  Distrib 5.6.24, for Win64 (x86_64)
--
-- Host: localhost    Database: train
-- ------------------------------------------------------
-- Server version	5.6.24

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `trainscheduler`
--

DROP TABLE IF EXISTS `trainscheduler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trainscheduler` (
  `sNumber` varchar(16) NOT NULL COMMENT '调度编号，外键，引用基本信息表主键',
  `sDate` datetime NOT NULL COMMENT '发车时间',
  `sCondutor` varchar(20) DEFAULT NULL COMMENT '值班列车长',
  `sSeatNumber` int(11) DEFAULT NULL COMMENT '可销售硬座数',
  `sLineNumber` int(11) DEFAULT NULL COMMENT '可销售硬卧数',
  `sVisaNumber` int(11) DEFAULT NULL COMMENT '可销售软卧数',
  PRIMARY KEY (`sNumber`,`sDate`),
  CONSTRAINT `trainInfo_Scheduler_fk` FOREIGN KEY (`sNumber`) REFERENCES `traininfo` (`tNumber`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-08-09 22:31:09
