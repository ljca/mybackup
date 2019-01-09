#include <stdio.h>
void *my_memset(void *v,char c,int size);

int main()
{
	int a = 10;
	printf("a %d\n",a);
	char arr[20] = "hello bunfly";
	printf("*(arr+11) %c\n",*(arr+11));
	printf("*(arr+20) %d\n",*(arr+20));
	my_memset(&a,0,sizeof(a));
	printf("a %d\n",a);
	int i= 0;
	for(i=0;i<sizeof(arr);i++) printf("%c",arr[i]);
	printf("\n");
	my_memset(arr,0,sizeof(arr));
	for(i=0;i<sizeof(arr);i++) printf("%d",arr[i]);
	printf("\n");
	return 0;
}

void *my_memset(void *v,char c,int size)
{
	char *str = (char *)v;
	int i = 0;
	for(i=0;i<size;i++)
	{
		//*(str+i) = c;
		str[i] = c;
	}
	return v;
}
