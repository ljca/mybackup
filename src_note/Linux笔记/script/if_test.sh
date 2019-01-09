#!/bin/bash - 
#===============================================================================
#
#          FILE: if_test.sh
# 
#         USAGE: ./if_test.sh 
# 
#   DESCRIPTION: 
# 
#       OPTIONS: ---
#  REQUIREMENTS: ---
#          BUGS: ---
#         NOTES: ---
#        AUTHOR: YOUR NAME (), 
#  ORGANIZATION: 
#       CREATED: 2017年01月11日 22:40
#      REVISION:  ---
#===============================================================================
echo -n "Is it morning?Please answer yes or no: "
read timeofday
	if [ "$timeofday" == "yes" ];then
		echo "Good morning"
	elif [ "$timeofday" == "no" ];then
		echo "Good eveing"
	else 
		echo "Sorry $timeofday is not recognized.Enter yes or no."
		exit 1
	fi
