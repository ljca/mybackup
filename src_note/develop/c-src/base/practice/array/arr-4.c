#include <stdio.h>
int main()
{
#if 0
	char arr[4][8]={"for","in","do","done"};
	//printf("%s\n",arr);
	char *p = *arr;
	/*
	printf("%s",p+5);
	p=*arr;
	*/
	int i=0;
	for(i=0;i<=20;i+=8)
	{
		printf("%p=%s  ",p,p);
		p+=8;
	}
	/*
	for(i=20;i>=0;i-=5)
	{
		printf("%s  ",p);
		p-=5;
	}
	*/
	printf("\n");
	int *p1 = (int *)arr;
	printf("%s\n",p1+2);
	char **p3=arr;
	printf("%s",p3+6);
#endif	
	int i=0, arr[10] = {0};
	for(i=0;i<10;i++)
	{
		arr[i] = i+1;
	}
	int *p = arr;
	for(i=0;i<10;i++) printf("%d  ",arr[i]);
	printf("\n");
	for(i=0;i<10;i++) printf("%d  ",p[i]);
	printf("\n");
	for(i=0;i<10;i++) printf("%d  ",*(arr+i));
	printf("\n");
	for(i=0;i<10;i++) printf("%d  ",*(p+i));
	printf("\n");
	for(i=10;i>0;i--) printf("%d  ",*(arr + i - 1));
	return 0;
}
