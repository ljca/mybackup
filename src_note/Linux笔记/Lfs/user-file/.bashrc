#!/bin/bash 
# Begin ~/.bashrc
[ -f /etc/bashrc ] && source /etc/bashrc
#export PATH="/usr/local/sbin:/usr/local/bin:/bin:/usr/bin:/usr/sbin:/sbin"
[ -f /home/tmp/sh/profile.sh ] && source /home/tmp/sh/profile.sh
#fbterm &>/dev/null
# End ~/.bashrc
if [ "$USER" = "lfs" ] ;then
 pathappend /sbin:/usr/local/sbin:/usr/sbin PATH
fi
alias rm='rm -i'
alias setqt4='source setqt4'
alias setqt5='source setqt5'

