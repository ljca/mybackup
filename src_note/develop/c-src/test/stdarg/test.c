#include <stdio.h>
#include <stdarg.h>

void miniprintf(char *fmt, ... )
{
	va_list ap;
	char *p,*sval;
	int ival;
	double dval;
	va_start(ap,fmt);
	for(p = fmt;*p;p++){
		if(*p != '%'){
			putchar(*p);
			continue;
		}
		switch(*++p){
			case 'd':
				ival = va_arg(ap,int);
				printf("%d",ival);
				break;
			case 'f':
				dval = va_arg(ap,double);
				printf("%f",dval);
				break;
			case 's':
				for(sval = va_arg(ap,char *);*sval;sval++) putchar(*sval);
				break;
			default:
				putchar(*p);
				break;
		}
	}
	va_end(ap);
}

int main()
{
	miniprintf("miniprintf\n");
	int i = 10;
	double x = 10.0;
	miniprintf("%d\n",i);
	printf("%.2f\n",x);
	miniprintf("%f\n",x);
	return 0;
}
