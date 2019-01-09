/*
* File Name: errfun.c
* Create Date: 2016年12月31日 星期六 13时08分37秒
*/
#include "tlpi_hdr.h"
#include <stdarg.h>
#include "ename.c.inc"
#ifdef __GNUC__
__attribute__ ((__noreturn__))
#endif

static void terminate(Boolean useExit)
{
	char *s;
	s = getenv("EF_DUMPCORE");
	if(s != NULL && *s != '\0'){
		abort();
	}else if(useExit){
		exit(EXIT_FAILURE);
	}else _exit(EXIT_FAILURE);
}

static void outputError(Boolean useErr,int err,Boolean flushStdout,const char *format,va_list ap)
{
#define BUF_SIZE 500
	char buf[BUF_SIZE],useMsg[BUF_SIZE],eerrText[BUF_SIZE];
	vsnprintf(useMsg,BUF_SIZE,format,ap);
	if(useErr){
		snprintf(errText,BUF_SIZE,"[%s %s]",(err > 0 && err <= MAX_ENAME)?ename[err]:"?unknown?",strerror(err));
	}else snprintf(buf,BUF_SIZE,":");
	snprintf(bu,BUF,BUF_SIZE,"ERROR%s %s\n",errText,useMsg);
	if(flushStdout){
		fflush(stdout);
	}
	fputs(buf,stderr);
	fflush(stderr);
}

static void errMsg(const char *format,...)
{
	va_list ag;
	int saveErrno = errno;
	va_start(ag,format);
	outputError(TRUE,errno,TRUE,format,ag);
	va_end(ag);
	errno = saveErrno;
}

void errExit(const char *format,...)
{
	va_list vg;
	va_start(vg,format);
	outputError(TRUE,errno,TRUE,format,ag);
	va_end(vg);
	terminate(TRUE);
}

err_exit(const char *format,...)
{
	va_list vg;
	va_start(vg,format);
	outputError(TRUE,errno,FALSE,format,ag);
	va_end(format);
	terminate(FALSE);
}

void errExitEN(int errnum,const char *format,...)
{
	va_list vg;
	va_start(vg,format);
	outputError(TRUE,errnum,TRUE,format,ag);
	va_end(vg);
	terminate(TRUE);
}

void fatal(const char *format,...)
{
	va_list vg;
	va_start(vg,format);
	outputError(FALSE,0,TRUE,format,ag);
	va_end(vg);
	terminate(TRUE);
}

void usageErr(const char *format,...)
{
	va_list vg;
	fflush(stderr);
	fprintf(stderr,"Comand-Line usage error: ");
	va_start(vg,format);
	vfprintf(stderr,format,ag);
	va_end(vg);
	fflush(stderr);
	exit(EXIT_FAILURE);
}

