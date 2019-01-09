#include <stdio.h>
//#pragma pack(4)
struct stest
{
	char c;/*sizeof(c)  = 1 if sizeof(c)%sizeof(s) == 0;if (sizeof(c)+sizeof(s)+sizeof(n))%sizeof(n)==0;return 
  	
			 */
	short s;//sizeof(s) = 2
	int n; //sizeof(n) = 4
};
int main()
{
	struct stest s1;
	printf("struct stest size %d\n",sizeof(s1));
	printf("sizeof(s1.n) %d\n",sizeof(s1.n));
	printf("sizeof(s1.c) %d\n",sizeof(s1.c));
	printf("sizeof(s1.s) %d\n",sizeof(s1.s));
	return 0;
}
