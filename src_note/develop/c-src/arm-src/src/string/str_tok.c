#include <stdio.h>
#include <string.h>

int main()
{
	char str[100] = "Happy familys a prospesll lalo hesa macc mox oaz";
	char *p = str;;
	;
	//printf("%s\n",strcpy(str2,str));
	//printf("%s\n",strstr(str," "));
	//printf("%s\n",strtok(str2," "));
	//printf("%s\n",strtok(NULL," "));
	//printf("%s\n",strtok(NULL," "));
	//printf("%s\n",strtok(NULL," "));
	//printf("",*str);
	//printf("%s\n",strtok(str," "));
	//printf("%s\n",str);
	//printf("%s\n",strstr(str," "));
	//printf("%s\n",str);
	//strtok(str,", ");
	//printf("%s\n",str);
	//printf("%s\n",str+strlen(str)+1);
	//p = str + strlen(str)+1;
	//printf("strstr %s\n",strstr(p," "));
	//printf("%s\n",p);
	//strtok(p,", ");
	//printf("%s\n",p);
	printf("p=%s\n",p);
	strtok(str," ,");
	printf("p=%s\n",p);
	p = p + strlen(p)+1;
	printf("str=%s\n",str);
	printf("p=%s\n",p);
	printf("p=%s\n",strstr(p," "));
	return 0;
}


