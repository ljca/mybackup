#include <stdio.h>
#include <string.h>
int main()
{
	printf("hahahahahaha\n");
	int tmp[20] = {0};
	printf("长度为%d\n",strlen("hello,world!"));
	//	sprintf();
	char ch1[127]={0};
	int i,tmp_num= sizeof(ch1)/sizeof(ch1[0]);
	for(i='!';i<=tmp_num;i++) ch1[i]=ch1[i]+i;
	for(i=0;i<=tmp_num;i++) printf("%c ",ch1[i]);
	printf("\n");
	printf("\nch-length:%d\n",tmp_num);
	for(i='A';i<='z';i++) printf("%c ",i);
	printf("\n");
	printf("%#o\n",36);
	printf("%#x\n",36);
	printf("%d\n",044);
	printf("%d\n",0x24);
	return 0;
}
