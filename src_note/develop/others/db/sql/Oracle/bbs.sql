conn System
create tablespace bbs 
datafile 
'G:\DeveLop\DataBase\Oracle\orcl\tmp\bbs.dbf' size 10M reuse autoextend on next 10M maxsize 25M,
'G:\DeveLop\DataBase\Oracle\orcl\tmp\bbs2.dbf' size 10M reuse autoextend on next 10M maxsize 25M
offline logging extent management local uniform size 100K
segment space management manual;
disconnect
