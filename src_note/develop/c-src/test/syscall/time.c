#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main()
{
	struct tm *ptm;
	time_t the_time;
	(void)time(&the_time);
	if(!(ptm = gmtime(&the_time))){
		perror("gmtime called error");
		return -1;
	}
	printf("GMT DATE: \n");
	printf("%4d年%02d月%02d日 星期%2d %02d:%02d:%02d\n",
			ptm->tm_year + 1900,ptm->tm_mon+1,ptm->tm_mday,
			ptm->tm_wday,ptm->tm_hour,ptm->tm_min,ptm->tm_sec);
	ptm = NULL;
	if(!(ptm = localtime(&the_time))){
		perror("localtime called error");
		return -1;
	}
	printf("LOCAL DATE:\n");
	printf("%4d年%02d月%02d日 星期%2d %02d:%02d:%02d\n",
			ptm->tm_year + 1900,ptm->tm_mon+1,ptm->tm_mday,
			ptm->tm_wday,ptm->tm_hour,ptm->tm_min,ptm->tm_sec);

}

