#include <stdio.h>
#include "circ.h"
int main(void)
{
	double r = 1.0,area = 0.0;
	area = circularArea(r);
	printf("r\t\tarea\n");
	printf("%.1f\t\t%.2f\n",r,area);
	r = 5.0;
	area = circularArea(r);
	printf("%.1f\t\t%.2f\n",r,area);
	return 0;
}

double circularArea(double r)
{
//	const double pi=3.1415926536;
	return PI * r * r;
}
