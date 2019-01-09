all:sqliteinit.o main 

sqliteinit.o:sqliteinit.c sqliteinit.h

main:sqliteinit.o main.c sqliteinit.h
	cc -o main -lsqlite3 sqliteinit.o main.c

#.:clean dist
clean:
	rm -f main *.o

# vim:set noet noci ts=4 sts=4 st=4:
