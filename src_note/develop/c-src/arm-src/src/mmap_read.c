/*
 * File Name: nmap.c
 * Create Date: 2016年12月05日 星期一 14时44分12秒
 */
#include <stdio.h>
//#include <stdlib.h>
#include <sys/types.h>
#include <sys/stat.h>
//#include <string.h>
#include <fcntl.h>
#include <unistd.h>
#include <sys/mman.h>

	int
main (int argc, char *argv[])
{
	if (1 == argc){
		printf ("usege:\n%s path&name\n", argv[0]);
		return;
	}
	int fd = open (argv[1], O_RDWR, 0777);

	if (-1 != fd) {
		struct stat st;
		fstat (fd, &st);
		char *ch = mmap (NULL, st.st_size, PROT_READ | PROT_WRITE, MAP_SHARED, fd, 0);
		if (NULL != ch) {
			//sleep(1);
			perror("");
			printf ("%s\n", ch);
			munmap (ch, st.st_size);
		}
		close (fd);
	}else {
		perror ("");
	}
	return 0;
}
