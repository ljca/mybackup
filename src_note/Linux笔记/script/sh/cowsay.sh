#!/bin/bash -xv
#===============================================================================
#
#          FILE: cowsay.sh
# 
#         USAGE: ./cowsay.sh 
# 
#   DESCRIPTION: 
#
#       OPTIONS: ---
#  REQUIREMENTS: ---
#          BUGS: ---
#         NOTES: ---
#        AUTHOR: YOUR NAME (), 
#  ORGANIZATION: 
#       CREATED: 2017年02月23日 20:51
#      REVISION:  ---
#===============================================================================
cow_dir=
#app_install="SUDO dnf install -y";;
#app_install="SUDO pacman -S --needed";;
#app_install="SUDO dnf install -y";;

[ -f /home/external/sh/ck_os.sh ] && source /home/external/sh/ck_os.sh
case $OS in
  Arch*)
    cow_dir=/usr/share/cows;;
  Fed*)
    cow_dir=/usr/share/cowsay;;
  Gentoo*)
    cow_dir=/usr/share/cowsay-3.03/cows;;
esac

function cow_say()
{
  if type cowsay >& /dev/null && type lolcat &> /dev/null;then
    echo -en "\e[1;33mDid you know that？\e[0m"
    echo -en "\e[1;36m`whatis $(\ls /usr/bin /usr/sbin /bin /sbin 2>/dev/null|shuf -n1) 2>&1`\e[0m\n"|cowsay -f $(\ls ${cow_dir}|shuf -n1)|lolcat; 
  elif type cowsay >& /dev/null;then
    echo -en "\e[1;33mDid you know that？\e[0m"
    echo -en "\e[1;36m`whatis $(\ls /usr/bin /usr/sbin /bin /sbin 2>/dev/null|shuf -n1) 2>&1`\e[0m\n"|cowsay -f $(\ls ${cow_dir}|shuf -n1);
  else :;
  fi
#[[ $? -eq 0 ]] && echo suceccess!|pv -qL 50 || echo failed
#[[ $? -eq 0 ]] && echo suceccess!|cowsay -f $(\ls /usr/share/cows|shuf -n1)|lolcat || echo failed
#|cut -d. -f1)
}
cow_say

unset cow_dir 
unset -f cow_say

