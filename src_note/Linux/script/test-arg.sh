#!/bin/bash - 
#===============================================================================
#
#          FILE: test-arg.sh
# 
#         USAGE: ./test-arg.sh 
# 
#   DESCRIPTION: 
# 
#       OPTIONS: ---
#  REQUIREMENTS: ---
#          BUGS: ---
#         NOTES: ---
#        AUTHOR: YOUR NAME (), 
#  ORGANIZATION: 
#       CREATED: 2017年01月08日 20:48
#      REVISION:  ---
#===============================================================================
#

echo '$#='${#}
echo '$0='${0} '$1='${1} '$2='${2}
function test_arg()
{
	echo function......
	echo '$#='${#}
	echo '$0='"${0}" '$1='"${1}" '$2='${2}
	echo $HOME $PWD $USER $UID
	#[[ -n $1 && -n $2 ]] && echo $1,$2
}

test_arg
unset -f test_arg
