CREATE TABLESPACE prictice
datafile 
'G:\DeveLop\DataBase\Oracle\orcl\tmp\prictice.dbf' size 10M,
'G:\Develop\DataBase\Oracle\orcl\tmp\prictice2.dbf' size 10M autoextend on;

CREATE USER tmp
IDENTIFIED BY tmp
DEFAULT TABLESPACE prictice;

GRANT CONNECT,RESOURCE TO tmp;
GRANT CREATE,UPDATE,INSERT,SELECT TO tmp; 

--GRANT ALL ON prictice.* TO tmp;
