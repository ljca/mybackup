CC=gcc
CXX=g++
CPP=cpp
BINDIR = bin
LIBDIR = lib
DEST = test
C_FLAGS := -L./$(LIBDIR) -lfileutil
all:fsize test
test:src/fileutil.h
ifeq "$(CC)" "gcc"
	@echo "compier shared libraries and executeable file...."
	$(CC) -fPIC -shared -o lib/libfileutil.so src/fileutil.c 
	$(CC) $(C_FLAGS) -o $(BINDIR)/$(DEST) src/test.c
	@echo "Now,run make $(BINDIR)/$(DEST) FILE=[filename] execute it......"
else
	@echo CC in not gcc.....
endif
fsize:src/fsize.c
	$(CC) -o $(BINDIR)/fsize src/fsize.c

.PHONY:test
.PHONY:clean
.PHONY:distclean
test:
	LD_LIBRARY_PATH=./lib $(BINDIR)/$(DEST) $(FILE)

clean:
	$(RM) -r *.o src/*.o
	$(RM) -r config.log autoconf.* autom4te.cache configure.scan

distclean:
	$(RM) -r *.o
	$(RM) $(LIBDIR)/*.so
	$(RM) -r $(BINDIR)/* config.log Makefile autoconf.* autom4te.cache configure.scan configure
