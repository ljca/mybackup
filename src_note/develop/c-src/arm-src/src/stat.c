/*
* File Name: stat.c
* Create Date: 2016年12月02日 星期五 15时17分41秒
*/
#include <stdio.h>
#include <stdlib.h>
#include <sys/stat.h>
#include <sys/types.h>

void file_stat(char *);

int main(int argc,char *argv[])
{
	if(argc == 1) 
	{
		printf("Usage: \n%s pathname\n",argv[0]);return;
	}
	file_stat(argv[1]);
	return 0;
}

void file_stat(char *path)
{
	struct stat *sb;
		sb = malloc(sizeof(struct stat));
	if(stat(path,sb) != -1){
		printf("file: %s is a ",path);
		switch(sb->st_mode & S_IFMT){
			case S_IFBLK: printf("block file!\n");break;
			case S_IFDIR: printf("directory file!\n");break;
			case S_IFREG: printf("reg file!\n");break;
			default: printf("unknown file!\n");break;
		}
		printf("ionde\tUID,GID\tsize\tblock_size\n");
		//printf("%ld\t%d %d\t%lld\t%ld\n",(long)sb.st_ino,(int)sb.st_uid,(int)sb.st_gid,(long long)sb.st_size,(long)sb.st_blksize);
		printf("%ld\t%d %d\t%lld\t%ld\n",(long)sb->st_ino,(int)sb->st_uid,(int)sb->st_gid,(long long)sb->st_size,(long)sb->st_blksize);
		//printf("inode: %ld\t",(long)sb.st_ino);
		//printf("mode: UID=%d,GID=%d\t",(int)sb.st_uid,(int)sb.st_gid);
		//printf("size: %lld bytes.\t",(long long)sb.st_size);
		//printf("block size: %ld bytes.\n",(long)sb.st_blksize);
		free(sb);
	}
}

