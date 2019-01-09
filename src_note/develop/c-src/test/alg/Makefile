objects=test
all:$(objects)
test:sum.o narcissus.o
	cc -ggdb -o test -lm test.c sum.o narcissus.o
.PHONY:clean distclean
clean:
	rm -f $(objects) *.o config.*
# vim:set noet noci ts=4 sts=4 st=4:
