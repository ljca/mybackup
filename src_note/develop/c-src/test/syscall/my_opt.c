#include <stdio.h>
#include <unistd.h>

int main(int argc,char *argv[])
{
	if(argc < 2){
		fprintf(stderr,"Usage: %s [-lkbc] [-i] <inode> -f [filename]]\n",argv[0]);
		return -1;
	}
	int opt;
	while(((opt = getopt(argc,argv,":bi:kf:lc")) != -1)){
		switch(opt){
			case 'b':
			case 'k':
			case 'l':
			case 'c':
				printf("option: %c\n",opt);
				break;
			case 'i':
				printf("option: %c argument: %s\n",opt,optarg);
				break;
			case 'f':
				printf("option: %c file: %s\n",opt,optarg);
				break;
			case ':':
				printf("option neend a value\n");
				break;
			case '?':
				printf("unkown option: %c\n",optopt);
				break;
			default:
				break;
				//fprintf(stderr,"Usage: %s [-lc] [-i] <inode> -f [filename]]\n",argv[0]);
		}
	}
	for(;optind < argc;optind++) printf("argument: %s\n",argv[optind]);
}

