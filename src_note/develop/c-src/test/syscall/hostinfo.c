#include <stdio.h>
#include <unistd.h>
#include <sys/utsname.h>
#define BUFZ 256

int main()
{
	printf("hostid: %ld\n",gethostid());
	char tmp[BUFZ];
	struct utsname uts;
	if(gethostname(tmp,BUFZ - 1) != 0 || uname(&uts) < 0){
		fprintf(stderr,"could't hostinfo.\n");
		return -1;
	}

	printf("hostname: %s\n",tmp);
	printf("%s %s %s %s %s\n",uts.sysname,uts.version,uts.machine,uts.release,uts.nodename);
}

