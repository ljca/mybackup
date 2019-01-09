#include "tlpi_hdr.h"
#ifndef __ERRFUN_H
#define __ERRFUN_H
void errMsg(const char *format,...);
void errExit(const char *format,...);
void err_exit(const char *format,...);
void errExitEN(int errnum,const char *format,...);
void fatal(const char *format,...);
void usageErr(const char *format,...);
void cmdLineErr(const char *format,...);
#endif
