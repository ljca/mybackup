tmp-dir=/home/external/usr/develop/Java_Web/Web/Server/MySQL5.6
c_flags=-I$(tmp-dir)/include -L$(tmp-dir)/lib -lmysqlclient
default:
	cc -o bin/mysql_con $(c_flags) mysql_con.c
.PHONY:test
test:
	bin/mysql_con
