#include <stdio.h>
#include <stdlib.h>
#ifdef HAVE_RESOLV_H
#include <rersolv.h>
#endif /* HAVE_RESOLV_H */
#include "config.h"

int main(void)
{
  int retval;
#ifdef HAVE_MMAP
  fprintf(stdout,"have mmap()\n");
#else
  fprintf(stderr,"no mmap()\n");
#endif
  if(HAVE_UTIME_NULL) fprintf(stdout,"utime() allows NULL\n");
  else fprintf(stderr,"utime() dons't allow NULL\n");
  if(SYS_SIGLIST_DECLARED) fprintf(stdout,"sys_siglist() declared\n");
  else fprintf(stderr,"sys_siglist() declared\n");
#ifdef HAVE_NCURSES_H
  fprintf(stdout,"ncurses.h found\n");
#else
  fprintf(stderr,"ncurses.h not found\n");
#endif

  if(HAVE_FCNTL_H) fprintf(stdout,"sys/fcntlh found.\n");
  else fprintf(stderr,"sys/fcntlh not found.\n");
#ifdef NLIST_NAME_UNION
  fprintf(stdout,"");
#else 
  fprintf(stderr,"");
#endif

  if(HAVE_VOID_POINTER) fprintf(stdout,"void pointer allow access.\n");
  else fprintf(stderr,"void pointer hasn't allow access.\n");
  exit(EXIT_SUCCESS);
}

