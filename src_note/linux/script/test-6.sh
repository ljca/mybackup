#!/bin/bash - 
#===============================================================================
#
#          FILE: test-6.sh
# 
#         USAGE: ./test-6.sh 
# 
#   DESCRIPTION: 
# 
#       OPTIONS: ---
#  REQUIREMENTS: ---
#          BUGS: ---
#         NOTES: ---
#        AUTHOR: YOUR NAME (), 
#  ORGANIZATION: 
#       CREATED: 2017年01月01日 18:09
#      REVISION:  ---
#===============================================================================
read -n 5 -p "Enter UserName(only five char,Don't Press Enter key!!): " var
echo;echo User is $var
unset var;

read -s -t 2 -p "Enter Password(Please press password in 2 seconds): " var
echo;echo Password is $var,Please Remember Password.
unset var
