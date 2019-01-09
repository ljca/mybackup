/*
 * =====================================================================================
 *
 *       Filename:  ftell_test.c
 *
 *    Description:  
 *
 *        Version:  1.0
 *        Created:  2017/06/18 星期日 13:11:29
 *       Revision:  none
 *       Compiler:  gcc
 *
 *         Author:  YOUR NAME (), 
 *   Organization:  
 *
 * =====================================================================================
 */

#include <stdio.h>
#include <errno.h>
#include <unistd.h>
#include <fcntl.h>
#include <sys/types.h>
#include <stdlib.h>
#include <sys/stat.h>

off_t fsize_lseek(const char *file)
{
	int fd;
	if(-1 == (fd = open(file,O_RDONLY))){
		perror("");
		exit(EACCES);
	}
	off_t len = lseek(fd,0,SEEK_END);
	close(fd);
	printf("**** %s call: ****\n",__FUNCTION__);
	return len;
}

unsigned long fsize_ftell(const char *file)
{
  FILE *fp;
  if(!(fp = (fopen(file,"r")))){
    perror("open fiile error");
    exit(EACCES);
  }
  unsigned long end_;
  //fseek(fp,0,SEEK_SET);
  //start_ = ftell(fp);
  if(-1 == fseek(fp,0,SEEK_END)){
    perror("error");
  }
  end_ = (unsigned)ftell(fp);
  fclose(fp);
	fp = NULL;
	printf("**** %s call: ****\n",__FUNCTION__);
	return end_;
}

off_t fsize_fstat(const char *file)
{
	struct stat st;
	int fd;
	if(-1 == (fd = open(file,O_RDONLY))){
		perror("open file error");
		exit(EACCES);
	}
	fstat(fd,&st);
	close(fd);
	printf("**** %s call: ****\n",__FUNCTION__);
	return st.st_size;
}

int main(int argc,char **argv)
{
  if(argc != 2){
    fprintf(stderr,"Usage：%s <file>\n",argv[0]);
		return EINVAL;
  }
  printf("%s %ld bytes.\n",argv[1],fsize_ftell(argv[1]));
  printf("%s %ld bytes.\n",argv[1],fsize_fstat(argv[1]));
  printf("%s %ld bytes.\n",argv[1],fsize_lseek(argv[1]));
}

