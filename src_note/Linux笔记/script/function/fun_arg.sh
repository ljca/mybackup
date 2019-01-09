#!/bin/bash - 
#===============================================================================
#
#          FILE: fun_arg.sh
# 
#         USAGE: ./fun_arg.sh 
# 
#   DESCRIPTION: 
# 
#       OPTIONS: ---
#  REQUIREMENTS: ---
#          BUGS: ---
#         NOTES: ---
#        AUTHOR: YOUR NAME (), 
#  ORGANIZATION: 
#       CREATED: 2017/06/16 星期五 23:10
#      REVISION:  ---
#===============================================================================

function fun()
{
  echo '$0' = "$0" 
  echo '$1' = "$1" 
  echo '$2' = "$2" 
  echo '$3' = "$3" 
  echo '$4' = "$4" 
}

fun $1 $2 $3 $4

fun 1 2 3 4

unset -f fun
