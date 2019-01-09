#include <stdio.h>
#include <string.h>
//char *my_strtok(char *,const char *);

struct book
{
	int price;
	char *name;
	char author[30];
}books[5];
int main()
{
	char tmp_book[5][20] = {""};
	char *arr[5] = {"10 mkszy mks", "30 mzdsx mzd", "20 dxpll dxp", "8 rlsz zxc", "2 yw xm"};	
	int i = 0;
	for(i=0;i<5;i++)
	{
		strcpy(*(tmp_book+i),*(arr+i));
		books[i].price = atoi(strtok(tmp_book[i]," "));
		books[i].name = strtok(NULL," ");
		strcpy(books[i].author,strtok(NULL," "));
	}
	//for(i=0;i<5;i++) printf("%s\n",*(tmp_book+i)); //
	//for(i=0;i<5;i++) my_strtok(tmp_book[i]," ");
	for(i=0;i<5;i++) 
	{
		printf("name:%s  author:%s  price:%d\n",books[i].name,books[i].author,books[i].price); //
	}
	int tmp=books[0].price;
	int j = 0;

	for(i = 0;i<5-1;i++)
	{
		for(j=0;j<5-i;j++) 
		{
			if(books[j].price < books[j+1].price)
			{
				tmp = books[j].price;
				books[j].price  = books[j+1].price;
				books[j+1].price = tmp;
			}
		}
	}
	
	printf("****************************\n");
//if (*(books[i].name) > *(books[++i].name))
	char *str = "";
	for(i = 0;i<4;i++)
	{
		for(j = 0;j<4;j++)
		{
			if (strcmp(books[j+1].name,books[j].name)==1)
			{
				str = books[j].name;
				books[j].name = books[j+1].name;
				books[j+1].name = str;
			}
		}
	}
	for(i=0;i<5;i++) 
	{
		printf("name:%s  author:%s  price:%d\n",books[i].name,books[i].author,books[i].price); //
	}
	printf("Exit Line %d,File %s,Date %s %s\n",__LINE__,__FILE__,__DATE__,__TIME__);
	return 0;
}

/*
char *my_strtok(char *new_str,const char *str)
{
	char *p=new_str;
	char *p1=new_str;
	int i = 0;
	while(p1=strtok(p1,str))
	{
		printf("%s\n",p1);
		p1=NULL;
	}
	//books[i++].price = atoi(p1);
	//books[i++].name = p1;
	//strcpy(books[i++].author,p1); 
	return NULL;
}
*/
