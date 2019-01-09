#!/bin/bash - 
#===============================================================================
#
#          FILE: test-5.sh
# 
#         USAGE: ./test-5.sh 
# 
#   DESCRIPTION: 
# 
#       OPTIONS: ---
#  REQUIREMENTS: ---
#          BUGS: ---
#         NOTES: ---
#        AUTHOR: YOUR NAME (), 
#  ORGANIZATION: 
#       CREATED: 2017年01月01日 17:34
#      REVISION:  ---
#===============================================================================

#set -o nounset                              # Treat unset variables as an error
set -x
echo -en "Enter Password: "
stty -echo 
read password
stty echo
echo Password already Read.

