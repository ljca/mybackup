#!/bin/bash - 
#===============================================================================
#
#          FILE: ck_os.sh
# 
#         USAGE: ./ck_os.sh 
# 
#   DESCRIPTION: 
# 
#       OPTIONS: ---
#  REQUIREMENTS: ---
#          BUGS: ---
#         NOTES: ---
#        AUTHOR: YOUR NAME (), 
#  ORGANIZATION: 
#       CREATED: 2017年10月12日 14:26
#      REVISION:  ---
#===============================================================================

function check-os()
{
	if [[ -z "${OS}" && "${SHELL}" == "/bin/bash" ]];then
	 OS= 
	 else 
		 unset -f check-os;return 1;
	fi
}

check-os

case $OSTYPE in
  msys|cygwin)
		OS="msys";;
  linux-gnu)
  if [[ -f /etc/redhat-release && `grep -io Fedora /etc/redhat-release` == "Fedora" ]];then
    OS="Fedora Linux"
  elif [[ -f /etc/issue && `grep -io Arch /etc/issue` == "Arch" ]];then
    OS="Arch Linux"
  elif [[ -f /etc/issue && `grep -io Gentoo /etc/issue` == "Gentoo" ]];then
    OS="Gentoo Linux"
  else 
    OS="Other Linux"
  fi
  ;;
freebsd13.1)
  OS="FreeBSD";;
esac

export OS
unset -f check-os

