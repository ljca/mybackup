#include <stdio.h>
#include <time.h>

int main()
{
	time_t the_time;
	(void)time(&the_time);
	//printf("%s\n",asctime(localtime(&the_time)));
	//printf("%s\n",asctime(gmtime(&the_time)));
	puts(asctime(gmtime(&the_time)));
	puts(asctime(localtime(&the_time)));
	puts(ctime(&the_time));
}
