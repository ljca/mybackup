#!/bin/bash - 
#===============================================================================
#
#          FILE: tmp.sh
# 
#         USAGE: ./tmp.sh 
# 
#   DESCRIPTION: 
# 
#       OPTIONS: ---
#  REQUIREMENTS: ---
#          BUGS: ---
#         NOTES: ---
#        AUTHOR: YOUR NAME (), 
#  ORGANIZATION: 
#       CREATED: 2018年05月06日 16:39
#      REVISION:  ---
#===============================================================================

set -o nounset                              # Treat unset variables as an error

#function sl()
#{
#  local tmp=/sys/class/backlight/intel_backlight/brightness
#  if
#    [ -r $tmp ];then
#    if [ $# -eq 1 ];then 
#      echo $1|${SUDO} tee $tmp >/dev/null #su -c "echo $1 > $tmp"
#    else echo "light:`cat $tmp`"
#    fi;
#  else echo "Intel video card driver maied not loading...."
#  fi;
#  unset tmp
#}


#export -f sl 
