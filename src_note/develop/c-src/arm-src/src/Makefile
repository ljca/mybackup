CC = gcc
C_FLAG=gcc -c
FILES=del_link1.o del_link.o find_link.o insert_head.o insert_tail.o link_list.o link_reverse.o show.o link_sort.o find_max.o
OBJ=test_link
RM=rm -fv 
DES=/usr/local
$(OBJ):$(FILES)
	 $(CC) $(FILES) -o $@
%.o:%.c
	$(C_FLAG) $^
clean:
	  $(RM) $(FILES) $(OBJ)
install:
#test -f $(DES)/bin/$(OBJ) && rm -rfv $(DES)/bin/$(OBJ) 
	 install -m755 -v $(OBJ) $(DES)/bin/$(OBJ)
uninstall:
	rm -rfv $(DES)/bin/$(OBJ)
