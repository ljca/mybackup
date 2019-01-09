#include <stdio.h>
#include <unistd.h>
#include <fcntl.h>

int
main (int argc, char *argv[])
{
  if (argc == 1)
    return;
  int ret = 0;
  if (ret = access (argv[1], F_OK) != 0)
    {
      printf
	("Warning: FIFO FILE IS NOT EXISTS!CREATING FIFO FILE %s....\naccess return %d;\n",
	 (char *) argv[1], ret);
      if (mkfifo (argv[1], 0666) == 0)
	{
	  printf ("crate fifo success!\n");
	  return;
	}
      else
	return;
    }

  int fd = open (argv[1], O_RDWR);
  if (fd < 0)
    {
      perror ("");
      return -1;
    }
  char buf[25] = "";
  read (fd, buf, sizeof (buf));
  printf ("FIFO test text: %s\n", buf);
  close (fd);
  return 0;
}
