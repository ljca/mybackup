#!/bin/bash - 
#===============================================================================
#
#          FILE: sleep-button.sh
# 
#         USAGE: ./sleep-button.sh 
# 
#   DESCRIPTION: 
# 
#       OPTIONS: ---
#  REQUIREMENTS: ---
#          BUGS: ---
#         NOTES: ---
#        AUTHOR: YOUR NAME (), 
#  ORGANIZATION: 
#       CREATED: 2017年02月02日 10:19
#      REVISION:  ---
#===============================================================================
# button/power PBTN 00000080 00000000
# button/power LNXPWRBN:00 00000080 00000004
case "$3" in
PBTN)  echo -n mem > /sys/power/state ;;
	*) logger "ACPI action undefined: $3" ;;
esac

