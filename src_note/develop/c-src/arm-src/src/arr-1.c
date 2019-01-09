#include <stdio.h>
int main(void)
{
	int i=0,num[7] = {5,20,10,570,1,701,50};
	printf("%d\n",sizeof(num)/sizeof(int));
	printf("num addr=%p\n",num);
	int tmp=0,max=num[0],index=0;
	for(i=0;i<=7;i++)
	{
		printf("num[%d]=%d\t",i,num[i]);
		printf("num[%d]=%d\n",i,*(num+i));
		//printf("arr[%d]=%p\n",i,&num[i]);
		if(num[i]>max)
		{
			//tmp = num[i];
			//num[i]=tmp;
			max=num[i];index=i;
		}
	}
	printf("max is %d个=%d\n",index,max); 
	return 0;
}
