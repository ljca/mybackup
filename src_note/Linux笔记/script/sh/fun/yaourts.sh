#!/bin/bash - 
#===============================================================================
#
#          FILE: yaourts.sh
# 
#         USAGE: ./yaourts.sh 
# 
#   DESCRIPTION: 
# 
#       OPTIONS: ---
#  REQUIREMENTS: ---
#          BUGS: ---
#         NOTES: ---
#        AUTHOR: YOUR NAME (), 
#  ORGANIZATION: 
#       CREATED: 2017年09月28日 08:38
#      REVISION:  ---
#===============================================================================

function yaourts()
{
  if [ $# -eq 1 ];then
    git clone https://aur.archlinux.org/$1.git
    [ -d `basenme $1` ] && { pushd `basename $1` && makepkg -srCci; } 
  fi
}

