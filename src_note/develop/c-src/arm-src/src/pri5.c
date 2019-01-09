#include <stdio.h>
int main(void)
{
//	unsigned char = '';
	int tmp = 127;
	printf("sizeof(unsigned char)=%d\n",sizeof(unsigned char));
	printf("sizeof(unsigned short)=%d\n",sizeof(unsigned short));
	printf("sizeof(unsigned int)=%d\n",sizeof(unsigned int));
	printf("sizeof(unsigned long)=%d\n",sizeof(unsigned long));
	printf("sizeof(float)=%d\n",sizeof(float));
	printf("sizeof(double)=%d\n",sizeof(double));
	printf("127 is %c\n",tmp);
	return 0;
}
