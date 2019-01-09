/*
 * =====================================================================================
 *
 *       Filename:  encode.c
 *
 *    Description:  
 *
 *        Version:  1.0
 *        Created:  2017年06月15日 11时42分31秒
 *       Revision:  none
 *       Compiler:  gcc
 *
 *         Author:  YOUR NAME (), 
 *   Organization:  
 *
 * =====================================================================================
 */

#include <stdio.h>
#include <fcntl.h>
#include <sys/mman.h>
#include <sys/stat.h>
#include <unistd.h>
#include "book_util.h"

int main(int argc,char **argv)
{
	if(argc != 2){
		fprintf(stderr,"Usage: %s <file>\n",argv[0]);
		return -1;
	}
	read_file(argv[1]);
}

