all:isatty menu1 terminfo terms ncurses1

terminfo:
	cc -Wall -o terminfo terminfo.c -lcurses 

ncurses1:
	cc -Wall -o ncurses1 ncurses1.c -lcurses 

clean:
	rm -f ncurses1

# vim:set noet noci ts=4 sts=4 st=4:
