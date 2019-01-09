/* 缓冲区大小 */
#ifndef BUFSIZE
#define BUFSIZE 1024
#endif

/* 端口 */
#ifndef UDP_PORT
#define UDP_PORT 5555
#endif

/* addr size */
#ifndef ADDR_SIZE
#include <netinet/in.h>
int addr_size = sizeof(struct sockaddr_in);
#define ADDR_SIZE addr_size
#endif
