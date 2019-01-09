CC=gcc
RM=rm
SRC=linktest.c
C_FLGAS=-llinkutil -L.
DEST=test
all:
	$(CC) -o liblinkutil.so -fPIC -shared linkutil.c
	$(CC) $(C_FLGAS) -o $(DEST) $(SRC)
run:
	LD_LIBRARY_PATH=. ./$(DEST)

clean:
	@$(RM) $(DEST) liblinkutil.so
