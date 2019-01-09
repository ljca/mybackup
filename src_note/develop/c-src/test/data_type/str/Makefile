objects=findstr strtoint my_strcmp test tmp2 tmp3 tmp
all:$(objects)
test:reversestr.o
reversestr.o:reversestr.h

.PHONY:clean distclean
clean:
	@echo clean up tmpfile.....
	@$(RM) -r *.o
distclean:
	@echo clean up tmpfile.....
	@$(RM) -r *.o $(objects) config.* autom4te.cache
# vim noet noci ts=4 sts=4 st=4:
