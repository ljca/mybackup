#include <stdio.h>
int main(void)
{
#if 0 

	switch(1)
	{
		case 1:
		case 2:
		case 3:
		case 4:
			printf("1-4\n");
			break;
		case 5:
		case 6:
		case 7:
			printf("5-7\n");
			break;
		default:
			break;
	}
	return 0;

#endif
#if 0
	int week = 1;
	switch(week)
	{
		case 1:
			printf("today is monday!\n");break;
		case 2:
			printf("today is tuesday!\n");break;
		case 3:
			printf("today is wednesday!\n");break;
		case 4:
			printf("today is thursday!\n");break;
		case 5:
			printf("today is firday!\n");break;
		case 6:
			printf("today is saturday!\n");break;
		case 7:
			printf("today is sunday!\n");break;
		default:
			printf("today is !\n");break;
	}
	printf("%p\n",&week);
	printf("%p\n",&week+1);
#endif

	/*第一题*/
	printf("\n*******第一题*********\n");
	int n=7;
	while(1)
	{
		if(n%2==1&&n%3==2&&n%4==3&&n%5==4&&n%6==5&&n%7==0)
		{
			printf("台阶数n至少应该有:%d阶\n",n);break;
		}
		n++;
	}
	/* 第二题*/
	/* 第三题 */
	printf("\n*******第三题*********\n");
	int sum=0,i=1;for(;i<=100;i++) sum+=i;printf("1+2+3+..+100=%d\n",sum);
	//printf("n:%d\n",n);
	/* 第四题*/
	printf("\n********第四题*******\n");
	int j;
	for(i=1;i<=9;i++)
	{
		for(j=1;j<=i;j++)
		{
			printf("%d * %d = %d  ",j,i,i*j);
		}
		printf("\n");
	}

	/* 第五题*/
	/*第六题*/
	/*第七题*/
	/*第八题*/
	int count = 0;
	for(i=100;i<=2000;i++)
	{
		if(i%2==1&&i%3==1&&i%5==1)
		{
			printf("%d ",i);
			++count;
			if(count==10) {break;}
			//else continue;
		}
	}
	/*第九题*/
	/*第十题*/
	/*第十一题*/
	/*第十二题*/
	/*第十三题*/
	/*第十四题*/
	/*第十五题*/	
	/*第十六题*/
	return n;
}
