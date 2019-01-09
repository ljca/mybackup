#include <stdio.h>
int main(void)
{
	int num=0;
	printf("键入成绩并回车：");
	scanf("%d",&num);
	printf("评估等级：");
	/*
	   switch(num/10)
	   {
	   case 10:
	   case 9:
	   printf("A");
	   break;
	   case 8:
	   printf("B");
	   break;
	   case 7:
	   printf("C");
	   break;
	   case 6:
	   printf("D");
	   break;
	   default:
	   printf("E");
	   }
	   printf("\n");
	   */
	if(num>=90) printf("A");
	else if(num>=80)printf("B");
	else if(num>=70)printf("C");
	else if(num>=60)printf("D");
	else printf("E");
	printf("\n");
	return 0;
}
