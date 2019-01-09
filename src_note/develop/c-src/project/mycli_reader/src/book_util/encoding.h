#ifndef ENCODING_H
#define ENCODING_H

#include <stdlib.h>

/* Type for Unicode characters */
typedef unsigned long unichar;

#ifdef __cplusplus
#define EXTERN_C extern "C"
#else
#define EXTERN_C
#endif

EXTERN_C int file_encoding(
        const unsigned char *buf,
        size_t nbytes,
        const char **code,
        const char **code_mime,
        const char **type
        );

#endif // ENCODING_H

