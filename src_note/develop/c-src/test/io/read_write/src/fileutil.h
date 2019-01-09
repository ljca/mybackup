/*
 * =====================================================================================
 *
 *       Filename:  file_util.h
 *
 *    Description:  
 *
 *        Version:  1.0
 *        Created:  2017年04月13日 09时38分32秒
 *       Revision:  none
 *       Compiler:  gcc
 *
 *         Author:  YOUR NAME (), 
 *   Organization:  
 *
 * =====================================================================================
 */
#ifndef __FILEUTIL_H
#define __FILEUTIL_H
#include <stdio.h>
FILE *open_file(const char *file,const char *mode);
void f_fclose(FILE *fp);
void read0(const char *file);
void read1(const char *file);
void read2(const char *file);
void write1(const char *file,char text[]);
void write2(const char *file,char text[]);
#endif
