#!/bin/bash - 
#===============================================================================
#
#          FILE: test.sh
# 
#         USAGE: ./test.sh 
# 
#   DESCRIPTION: 
# 
#       OPTIONS: ---
#  REQUIREMENTS: ---
#          BUGS: ---
#         NOTES: ---
#        AUTHOR: YOUR NAME (), 
#  ORGANIZATION: 
#       CREATED: 2016年07月08日 15:22
#      REVISION:  ---
#===============================================================================
if [[ $USER != "root" && $UID -eq 0 ]] ; then
  echo -e "user is $USER!\nmust as root!"
  elif [[ $UID -eq 0 && $USER = root ]] ; then
    echo user is $USER!
  else echo "user is other users!"
  fi
    
