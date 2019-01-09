#include <stdio.h>
void count_char();
int decTo(int); //十进制转换到其它进制

int main()
{
	count_char();
	decTo(64);
	return 0;
}

void count_char()
{
	char str[] = "I am the king ll ql 192 6Ax";
	int count_ch = 0,i=0,count_num=0,count_space=0;
	//	printf("%s\n",str);
	//	printf("%c\n",*str);
	printf("str size %d\n",sizeof(str));
	for(i=0;i<=sizeof(str)/sizeof(str[0]);i++)
	{
		if('A'<=str[i]&&'Z'>=str[i]||'a'<=str[i]&&'z'>=str[i])
		{
			count_ch++;
		}
		else if(32==str[i])
		{
			count_space++;
		}
		else if('0'<=str[i]&&'9'>=str[i])
		{
			count_num++;
		}
	}
	printf("char %d,number %d,space %d\n",count_ch,count_num,count_space);
}

int decTo(int num)
{
	int tmp[8] = {0};
	int i = 0;
	int remain=0,trade;
	if(0!=num)
	{
		for(i=0;i<sizeof(tmp)/sizeof(tmp[0]);i++)
		{
			remain=num%2;
			trade=num/2;
			tmp[i]=remain;
			if(0==num/2)
			{
				break;
			}
		}
		printf("num %d binary = ",num);
		for(i=sizeof(tmp)/sizeof(tmp[0]);i>0;i--)
		{
			printf("%d ",tmp[i]);
		}
	}
	return num;
}

