use easybuy;
SET FOREIGN_KEY_CHECKS=0;

/*
Table structure for `easybuy_news`
*/
DROP TABLE IF EXISTS `easybuy_news`;
CREATE TABLE `easybuy_news` (
  `en_id` int(11) NOT NULL AUTO_INCREMENT,
  `en_title` varchar(50) NOT NULL,
  `en_content` varchar(200) NOT NULL,
  `en_create_time` date NOT NULL,
  PRIMARY KEY (`en_id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for `easybuy_order`
-- ----------------------------
DROP TABLE IF EXISTS `easybuy_order`;
CREATE TABLE `easybuy_order` (
  `eo_id` int(11) NOT NULL AUTO_INCREMENT,
  `eo_user_id` varchar(255) NOT NULL,
  `eo_user_name` varchar(15) NOT NULL,
  `eo_user_address` varchar(200) NOT NULL,
  `eo_create_time` date NOT NULL,
  `eo_cost` double NOT NULL,
  `eo_status` int(11) NOT NULL,
  `eo_type` int(11) NOT NULL,
  PRIMARY KEY (`eo_id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for `easybuy_product`
-- ----------------------------
DROP TABLE IF EXISTS `easybuy_product`;
CREATE TABLE `easybuy_product` (
  `ep_id` int(11) NOT NULL AUTO_INCREMENT,
  `ep_name` varchar(15) NOT NULL,
  `ep_description` varchar(100) NOT NULL,
  `ep_price` double NOT NULL,
  `ep_stock` int(11) NOT NULL,
  `epc_id` int(255) NOT NULL,
  `epc_child_id` int(255) DEFAULT NULL,
  `ep_file_name` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ep_id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for `easybuy_product_category`
-- ----------------------------
DROP TABLE IF EXISTS `easybuy_product_category`;
CREATE TABLE `easybuy_product_category` (
  `epc_id` int(11) NOT NULL AUTO_INCREMENT,
  `epc_name` varchar(255) NOT NULL,
  `epc_parent_id` int(255) NOT NULL,
  PRIMARY KEY (`epc_id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for `easybuy_order_detail`
-- ----------------------------
DROP TABLE IF EXISTS `easybuy_order_detail`;
CREATE TABLE `easybuy_order_detail` (
  `eod_id` int(11) NOT NULL AUTO_INCREMENT,
  `eo_id` int(255) NOT NULL,
  `ep_id` int(255) NOT NULL,
  `eod_quantity` int(11) NOT NULL,
  `eod_cost` double NOT NULL COMMENT '金额',
  PRIMARY KEY (`eod_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of easybuy_order_detail
-- ----------------------------

-- ----------------------------
-- Table structure for `easybuy_comment`
-- ----------------------------
DROP TABLE IF EXISTS `easybuy_comment`;
CREATE TABLE `easybuy_comment` (
  `ec_id` int(11) NOT NULL AUTO_INCREMENT,
  `ec_reply` varchar(50) NOT NULL,
  `ec_content` varchar(200) NOT NULL,
  `ec_create_time` date NOT NULL,
  `ec_reply_time` date NOT NULL,
  `ec_nick_name` varchar(50) NOT NULL,
  PRIMARY KEY (`ec_id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;


-- ----------------------------
-- Table structure for `easybuy_user`
-- ----------------------------
DROP TABLE IF EXISTS `easybuy_user`;
CREATE TABLE `easybuy_user` (
  `en_user_id` varchar(255) NOT NULL,
  `en_user_name` varchar(20) NOT NULL,
  `en_password` varchar(255) NOT NULL,
  `en_sex` varchar(2) NOT NULL,
  `en_birthday` date NOT NULL,
  `en_identity_code` varchar(18) NOT NULL,
  `en_email` varchar(50) NOT NULL,
  `en_mobile` varchar(255) NOT NULL,
  `en_address` varchar(50) NOT NULL,
  `en_status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

commit;
show tables;