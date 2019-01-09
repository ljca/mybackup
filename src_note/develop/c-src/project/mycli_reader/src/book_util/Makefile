C_FLAGS=-L. -lbook_util
default:libbook_util.so test.c
	cc -o test $(C_FLAGS) test.c
libbook_util.so: book_util.c book_util.h
	cc -o libbook_util.so -fPIC -shared book_util.c
.PHONY:test
test:
	@LD_LIBRARY_PATH=. ./test $(FILE)
.PHONY:clean
clean:
	@rm -f test *.so *.o

# vim:set noet noci ts=4 sts=4 st=4:
