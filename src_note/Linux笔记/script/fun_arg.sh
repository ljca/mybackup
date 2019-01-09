#!/bin/bash -
function filename()
{
	if [ $# -eq 0 ];then
		echo "Usage: $0 <bash script>";return
	fi
	echo $1;
	[ -f $1 ] && source $1 || echo "file $1 not found." 
}

filename $1
unset -f filename

