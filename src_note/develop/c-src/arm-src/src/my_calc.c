#include <stdio.h>
int Isleapyear(int year);
int days[12]={31,0,31,30,31,30,31,31,30,31,30,31};

int main()
{
	return 0;
}

int Isleapyear(int year)
{
	int total_days=0;
	if(year<0;)
	{
		return 0;
	}
	else if(0==year%4&&0!==year%100)
	{
		total_days=366;
		days[1]=29;
		return total_days;
	}
	else
	{
		total_days=365;
		days[1]=28;
		return total_days;
	}
}

