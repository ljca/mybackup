USE `bookstore`;
 ALTER TABLE `books`
 CHANGE COLUMN `book_id` `book_id` INTEGER(100) AUTO_INCREMENT PRIMARY KEY,
 CHANGE COLUMN `author` `author_id` INTEGER(100),
 ADD COLUMN 
(
`description` TEXT,
`genre` ENUM('novel','poetry','drema'),
`publisher_id` INTEGER(100),
`pub_year` VARCHAR(4),
`isbn` VARCHAR(20)
);
USE `bookstore`;
INSERT INTO `authors`(`author_last`,`author_first`,`country`)
VALUES
('Greene','Graham','The United Kindom');

INSERT INTO `books`(`title`,`author_id`,`description`,`genre`,`pub_year`,`ISBN`)
VALUES
('Gonggong JiChu ZhiShi',1,'Unknow','novel','1951','978-7-04-037232-8');