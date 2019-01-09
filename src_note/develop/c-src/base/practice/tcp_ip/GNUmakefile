CC=gcc
RM=rm -fv
%.o : %.c
	$(CC) -c -Wall $< -o $@ 
tmp : %.o
	$(CC)  $< -o $@
clean:
	$(RM) *.o

