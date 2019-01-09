/* datebase:music */
create database if not exists song;

###### song_user ######
create table if not exists song.song_user
(
  id integer auto_increment not null comment 'id',
  user_id varchar(25) not null comment '用户id',
  user_type integer not null comment '',
  user_name varchar(25) not null comment '',
  user_psk  varchar(30) not null comment '',
  primary key(id)
) AUTO_INCREMENT = 1;


##### singer_type #####
create table if not exists song.singer_type
(
  singer_type_id integer auto_increment not null comment '',
  singer_type_name varchar(25) not null comment '',
  primary key(singer_type_id)
) AUTO_INCREMENT = 1;

##### singer_location #####
create table if not exists song.singer_location
(
  location_id integer auto_increment not null comment '',
  location_name varchar(50) not null comment '',
  primary key(location_id)
) AUTO_INCREMENT = 1;

##### singer_info ######
create table if not exists song.singer_info 
(
  singer_id integer auto_increment comment '',
  singer_name varchar(50) not null comment '',
  singer_type_id integer not null comment '',
  singer_location_id integer not null comment '',
-- song_id integer not null comment '',
  primary key(singer_id),
  constraint fk_singer_type foreign key(singer_type_id) references song.singer_type(singer_type_id),
  -- constraint fk_
  constraint fk_location_singer foreign key (singer_location_id) references song.singer_location(location_id)
) AUTO_INCREMENT = 1;

###### song_type ######
create table if not exists song.song_type
(
  song_type_id integer auto_increment comment ''
  song_type_name varchar(25) not null comment '',
  primary key (song_type_id)
) AUTO_INCREMENT = 1;

###### song_path ######
create table if not exists song.song_path
(
  path_id integer auto_increment not null comment '',
  song_path varchar(255) not null comment '',
  primary key(path_id)
) AUTO_INCREMENT = 1;


##### song_info #####
create table if not exists song.song_info
(
  song_id integer auto_increment not null,
  singer_id integer not null,
  song_name varchar(255) not null,
  song_type_id integer not null,
  song_path_id integer not null,
  lrc_id integer not null,
  primary key(song_id),
  constraint fk_song_singer foreign key(singer_id) references song.singer_info(singer_id),
  constraint fk_song_type foreign key(song_type_id) references song_type(song.song_type_id),
  constraint fk_song_path foreign key(song_path_id) references song.song_path(song_path_id),
  constraint fk_song_lrc foreign key(lrc_id) references song.lrc_info(path_id)

) AUTO_INCREMENT = 1;

###### lrc_info #######
create table if not exists song.lrc_info
(
  lrc_id integer auto_increment not null,
  lrc_name integer varchar(255),
  primary key(lrc_id)
) AUTO_INCREMENT = 1;
