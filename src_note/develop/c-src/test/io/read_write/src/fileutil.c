/*
 * =====================================================================================
 *       Filename:  fileutil.c
 *    Description:  
 *        Version:  1.0
 *        Created:  2017/5/13 09:38:23
 *       Revision:  none
 *       Compiler:  gcc
 *         Author:  YOUR NAME (), 
 *   Organization:  
 * =====================================================================================
 */
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "fileutil.h"

/* */
FILE *
open_file(const char *file,const char *mode)
{
	FILE *fp;
	if(!(fp = fopen(file,mode))){
		perror("open file error");
		exit(-1);
	}
	return fp;
}

/* */
void f_fclose(FILE *fp)
{
	if(fclose(fp) != 0) perror("close file error");
	fp = NULL;
}

void read0(const char *file)
{
	FILE *fp = open_file(file,"r");
	char buf[BUFSIZ] = {0};
	unsigned long t = 0;
	//int tmp = fread(buf,1,20,fp);
	//printf("read %d bytes\n",tmp);
	//printf("read buf from %s is %s\n",file,buf);
	while((t = fread(buf,1,192,fp)) != 0){
		printf("%s\n",buf);
		bzero(&buf,sizeof(buf));
	}
	f_fclose(fp);
}

void read1(const char *file)
{
	FILE *fp = open_file(file,"r");
	char *buf;
	size_t n = 0;
	while((n = getline(&buf,&n,fp)) != (size_t)-1){
		printf("%s",buf);
		bzero(buf,sizeof(buf));
	}
	//if(buf) free(buf);
	f_fclose(fp);
} 

void read2(const char *file)
{
	FILE *fp = open_file(file,"r");
	char buf[BUFSIZ] = "";
	while(fgets(buf,BUFSIZ,fp)){
		printf("%s",buf);
		bzero(buf,BUFSIZ);
	}
	f_fclose(fp);
}

/* */
void write1(const char *file,char text[])
{
	FILE *fp = open_file(file,"w+t");
	//char buf[BUFSIZ] = "c is a very languages!\n";
	fwrite(text,1,strlen(text),fp);
	f_fclose(fp);
}

/* */
void write2(const char *file,char text[])
{
	FILE *fp = open_file(file,"a+t");
	if(fputs(text,fp) == EOF) perror("fputs call error");
	f_fclose(fp);
}

