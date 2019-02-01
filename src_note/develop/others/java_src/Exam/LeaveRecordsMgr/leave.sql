/*
SQLyog Professional v12.09 (64 bit)
MySQL - 5.6.24 : Database - leave
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`leave` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `leave`;

/*Table structure for table `leaverecords` */

DROP TABLE IF EXISTS `leaverecords`;

CREATE TABLE `leaverecords` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) NOT NULL,
  `Time` datetime NOT NULL,
  `Reason` varchar(200) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

/*Data for the table `leaverecords` */

insert  into `leaverecords`(`Id`,`Name`,`Time`,`Reason`) values (2,'徐航','2016-06-23 09:00:00','出门旅游，游山玩水'),(3,'李雪冬','2015-02-03 00:00:00','回老家，看父母'),(4,'李季','2014-02-02 00:00:00','带孩子参观博物馆');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
