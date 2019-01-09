#ifndef __DATATYPE_H__
#define __DATATYPE_H__
#include <sys/types.h>
#include <stddef.h>

#ifndef CUPPPER
#define CUPPER (('a') - ('A'))
#endif

enum Color{Black,Red,Blue,Yellow,Pink,Cyan,White};

wchar_t wchart(wchar_t wch);

char *convert_upper(char **str);

enum Color
enum_(enum Color color);


#endif
