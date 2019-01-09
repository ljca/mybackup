#!/bin/bash - 
#===============================================================================
#
#          FILE: arg-2.sh
# 
#         USAGE: ./arg-2.sh 
# 
#   DESCRIPTION: 
# 
#       OPTIONS: ---
#  REQUIREMENTS: ---
#          BUGS: ---
#         NOTES: ---
#        AUTHOR: YOUR NAME (), 
#  ORGANIZATION: 
#       CREATED: 2017/01/ 8 星期日 23:14
#      REVISION:  ---
#===============================================================================
#
echo $0 $1 $2 $3 $4 $5 $6 $7 $8 $9 ${10} ${11}
function test_arg()
{
	echo "The value of the second parameter is $0 !"
	echo "The value of the first parameter is $1 !"
	echo "The value of the second parameter is $2 !"
	echo "The value of the second parameter is $3 !"
	echo "The value of the second parameter is $4 !"
	echo "The value of the second parameter is $5 !"
	echo "The value of the second parameter is $6 !"
	echo "The value of the second parameter is $7 !"
	echo "The value of the second parameter is $8 !"
	echo "The value of the second parameter is $9 !"
	echo "The value of the tenth parameter is ${10} !"
	echo "The value of the eleventh parameter is ${11} !"
	echo "The amount of the parameters is $# !"
	echo "The string of the parameters is $* !"
}

test_arg
unset -f test_arg
