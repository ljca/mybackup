#include <dirent.h>
#include <stdio.h>
#include <unistd.h>
#include <sys/stat.h>
#include <stdlib.h>

void printdir(int argc,char *argv[],char path[])
{
	int opt;
	DIR *dirp;
	struct dirent *pdir;
	//argv[1] == NULL ? "." : argv[1];
	if(!(dirp = opendir(argv[1]))){
		perror("opendir called error");
		exit(-1);
	}
	struct stat stbuf;
	lstat("",&stbuf);
	while((opt = getopt(argc,argv,":rAaFlR:s:h:")) != -1){
		while((pdir = readdir(dirp))){
			printf("%s\n",pdir->d_name);
		}
		switch(opt){
			case 'r':
				printdir(argc,argv,path);
				break;
			case 'R':
				break;
			case 'F':
				break;
			case 'A':
				break;
			case 'a':
				break;
			case 'l':
				break;
			case 't':
				break;
			case 'h':
				break;
			case '?':
				break;
			case ':':
				break;
			default:
				break;
		}
	}
	chdir("..");
	closedir(dirp);
}

int main(int argc,char *argv[])
{
	if(argc < 2){
		*++argv = ".";
		fprintf(stdout,"Usage: %s -aAsFtlrR --color={[auto,tty,always]} [dir]\n",argv[0]);
	}
	printdir(argc,argv,"");
}
