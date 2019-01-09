#include <stdio.h>

typedef enum COLOR
{
	black=30,red,blue,yellow,green,pink,cyan,white
}color;
int main()
{
	printf("black %d\n",black);
	printf("red %d\n",red); 
	printf("blue %d\n",blue); 
	printf("yellow %d\n",yellow);
	printf("green %d\n",green);
	printf("pink %d\n",pink);
	printf("cyan %d\n",cyan);
	printf("white %d\n",white);
//	printf("color %d\n",color=red);
	color r = red;
	printf("r %d\n",r);
	return 0;
}
