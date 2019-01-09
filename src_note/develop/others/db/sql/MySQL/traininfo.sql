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
-- Table structure for table `traininfo`
--

DROP TABLE IF EXISTS `traininfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `traininfo` (
  `tNumber` varchar(16) NOT NULL COMMENT '车次',
  `tFrom` varchar(20) NOT NULL COMMENT '起点站',
  `tDest` varchar(20) NOT NULL COMMENT '终点站',
  `tDistance` int(11) DEFAULT NULL COMMENT '起点站到终点站的里程',
  `tStartTime` datetime DEFAULT NULL COMMENT '始发时间',
  `tEndTime` datetime DEFAULT NULL COMMENT '到站时间',
  `tDay` int(11) DEFAULT '1' COMMENT '旅行总时间',
  `tSpeed` int(11) DEFAULT '120' COMMENT '列车速度，千米/时',
  `tUnitPrice` double DEFAULT '0.7' COMMENT '票价',
  PRIMARY KEY (`tNumber`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-08-09 22:31:09
