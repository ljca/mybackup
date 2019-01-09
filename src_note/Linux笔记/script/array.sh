#!/bin/bash - 
#===============================================================================
#
#          FILE: array.sh
# 
#         USAGE: ./array.sh 
# 
#   DESCRIPTION: 
# 
#       OPTIONS: ---
#  REQUIREMENTS: ---
#          BUGS: ---
#         NOTES: ---
#        AUTHOR: YOUR NAME (), 
#  ORGANIZATION: 
#       CREATED: 2017/04/28 星期五 21:04
#      REVISION:  ---
#===============================================================================
array=(/i /g)
for i in ${array[0]}/* ${array[1]}/*;do
	[ -d "$i" ] && echo $i || echo "$i not found."
done

unset array
