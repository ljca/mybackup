#include <stdio.h>
#include <stdlib.h>

int main()
{
	//char tmmp[L_tmpnam];
	//puts(tmpnam(tmmp));
	/* 
	char tmpf[] = mkstemp("XXXXXX");
	if(!tmpf){
		perror("mktemp called error");
		return -1;
	}
	puts(tmpf);
 */
	FILE *ptmpf;
	if(!(ptmpf = tmpfile())){
		perror("tmpfile call error");
		return -1;
	}else puts("tmpfile crate and open OK");
	ptmpf = NULL;

}
