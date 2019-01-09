#!/bin/bash - 
#===============================================================================
#
#          FILE: test-4.sh
# 
#         USAGE: ./test-4.sh 
# 
#   DESCRIPTION: 
# 
#       OPTIONS: ---
#  REQUIREMENTS: ---
#          BUGS: ---
#         NOTES: ---
#        AUTHOR: YOUR NAME (), 
#  ORGANIZATION: 
#       CREATED: 2016年10月30日 22:14
#      REVISION:  ---
#===============================================================================

set -o nounset                              # Treat unset variables as an error
echo "#########进制转换,传递至少一个正整数给这个脚本##########"
[ $# -ne 0 ]&&
  {
    echo -n "2进制=";echo "obase=2;$1"|bc
    echo -n "7进制=";echo "obase=7;$1"|bc
    echo -n "8进制=";echo "obase=8;$1"|bc
    echo -n "12进制=";echo "obase=12;$1"|bc
    echo -n "16进制=";echo "obase=16;$1"|bc
    echo -n "64进制=";echo "obase=64;$1"|bc
  }||echo 没有传递参数!
#
