#include <stdio.h>
#include <unistd.h>
#include <sys/mman.h>
#include <sys/stat.h>
#include <fcntl.h>
#include "book_util.h"

void check_encode(const char *file)
{
	FILE *fp = NULL;
	if(!(fp = fopen(file,"r"))){
		perror("open file error");
		return;
	}
	char buf[BUFSIZ] = {0};
	fread(buf,1,3,fp);
	int i = 0;
	for(;i < 3;i++){
		printf("%#x\t",buf[i]);
	}
	printf("\n");
	fclose(fp);
}

void read_file(const char *file)
{
	int fd;
	char *addr;
	fd = open(file,O_RDONLY);
	//struct stat sb;
	//fstat(fd,&sb);
	int flen;
	if(0 == (flen = lseek(fd,1,SEEK_END))){
		perror("");
	}
	
	printf("file: %s\tsize: %lubyte.\n",file,flen);
	if(MAP_FAILED == (addr = mmap(NULL,flen,PROT_READ,MAP_PRIVATE,fd,0))){
		perror("mmap error");
		return;
	}
	printf("%s\n",addr);
	close(fd);
	munmap(addr,flen);
}

