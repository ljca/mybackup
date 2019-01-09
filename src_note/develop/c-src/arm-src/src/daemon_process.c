#include <stdio.h>
#include <unistd.h>
#include <fcntl.h>
#include <string.h>
#include <stdlib.h>

int main ()
{
	int pid = fork ();
	if (pid > 0) {
		exit (0);
	}
	setsid ();
	int i = 0;
	for (i = 0; i < 3; i++)
		close (i);
	pid = fork ();
	if (pid > 0) {
		exit (0);
	}
	chdir ("/home/tmp/tmp/");
	umask (0);
	int fd = open ("date.log", O_CREAT | O_RDWR | O_APPEND, 0666);
	while (1) {
		char str[30] = "";
		strcat (str, __DATE__);
		strcat (str, " ");
		strcat (str, __TIME__);
		strcat (str, "\n");
		write (fd, str, strlen (str));
		sleep (5);
	}
	close (fd);
	return 0;
}
