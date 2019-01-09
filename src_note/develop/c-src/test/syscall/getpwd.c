#include <stdio.h>
#include <unistd.h>
#include <stdlib.h>
#include <string.h>
#include <sys/stat.h>

int main(int argc,char *argv[])
{
	if(argc < 2) fprintf(stderr,"Usage: %s -c envVAR(is a DIR)|-p PATH\n",argv[0]);
	const size_t size = 255;
	char buf[size];
	int opt;
	struct stat statbuf;
	while((opt = getopt(argc,argv,":p:c:")) != -1){
		switch(opt){
			case 'p':
				lstat(optarg,&statbuf);
				if(S_ISDIR(statbuf.st_mode)){
					chdir(optarg);
					printf("cureent dir: %s\n",getcwd(buf,size));
				}
				break;
			case 'c':
				if(!getenv(optarg)){
					fprintf(stderr,"$%s is undfine env var.\n",optarg);
				}else{
					bzero(&statbuf,sizeof(statbuf));
					lstat(getenv(optarg),&statbuf);
					if(S_ISDIR(statbuf.st_mode)){
						strcpy(buf,getenv(optarg));
						chdir(buf);
						printf("cureent dir: %s\n",getcwd(buf,size));
					}else fprintf(stderr,"envVAR $%s is not a directory.\n",optarg);
				}
				break;
			case ':':
				fprintf(stderr,"option has been a value\n");
				break;
			case '?':
				fprintf(stderr,"Usage: %s -c PATHVAR|-p PATH\n",argv[0]);
				break;
			default:
				printf("cureent dir: %s\n",getcwd(buf,size));
				break;
		}
	}
}

