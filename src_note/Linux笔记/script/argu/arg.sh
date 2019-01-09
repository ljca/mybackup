#!/bin/bash - 
#===============================================================================
#
#          FILE: arg.sh
# 
#         USAGE: ./arg.sh 
# 
#   DESCRIPTION: 
# 
#       OPTIONS: ---
#  REQUIREMENTS: ---
#          BUGS: ---
#         NOTES: ---
#        AUTHOR: YOUR NAME (), 
#  ORGANIZATION: 
#       CREATED: 2017/01/ 8 星期日 23:03
#      REVISION:  ---
#===============================================================================
echo '$#='$#
echo '$0='$0 '$1='$1 '$2='$2
function test_arg()
{
	echo 'in function.....'
	echo '$#='$#
	echo '$0='$0 '$1='$1 '$2='$2
}

test_arg
unset -f test_arg
