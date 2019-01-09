#include <stdio.h>
#include <stdlib.h>
#include <fcntl.h>
#include <unistd.h>

int test_lock(struct flock *lk,int fd)
{
	fcntl(fd,F_GETLK,&lk);
	if(F_UNLCK == lk->l_type){
		return 0;
	}else return lk->l_pid;
}

int main(int argc,int *argv[])
{
	if(1==argc) return;
	int fd = open((char *)argv[1],O_RDWR|O_CREAT,0666);
	int pid = fork();
	struct flock lk;
	lk.l_type = F_RDLCK;
	lk.l_whence = SEEK_SET;
	lk.l_start = 0;
	lk.l_len = 0;
	lk.l_pid = getpid();
	fcntl(fd,F_SETLKW,&lk);
	if(pid > 0){
		wait(NULL);
		test_lock(&lk,fd);
		printf("lock is %d\n",getpid());
	}
	else if(pid == 0){
		test_lock(&lk,fd);
		printf("lock is %d\n",getpid());
	}

	close(fd);
	return 0;
}

/*
 *
 switch(lk.l_type){
 case F_RDLCK:
 return lk.l_pid;
 printf("locked has been %d\n",lk.l_pid);
 break;
 case F_WRLCK:
 printf("locked has been %d\n",lk.l_pid);
 break;
 case F_UNLCK:
 printf("locked has been %d\n",lk.l_pid);
 break;
 default:
 printf("false");
 }

*/
