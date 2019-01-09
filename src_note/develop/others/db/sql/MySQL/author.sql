USE `bookstore`;
CREATE TABLE IF NOT EXISTS `authors`
(
`author_id` INTEGER AUTO_INCREMENT PRIMARY KEY,
`author_last` VARCHAR(50),
`author_first` VARCHAR(50),
`country` VARCHAR(50)
);