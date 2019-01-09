#!/bin/bash - 
#===============================================================================
#
#          FILE: test_file.sh
# 
#         USAGE: ./test_file.sh 
# 
#   DESCRIPTION: 
# 
#       OPTIONS: ---
#  REQUIREMENTS: ---
#          BUGS: ---
#         NOTES: ---
#        AUTHOR: YOUR NAME (), 
#  ORGANIZATION: 
#       CREATED: 2016年07月08日 19:30
#      REVISION:  ---
#===============================================================================

set -o nounset                              # Treat unset variables as an error
#[ -a file/file ] && rm file/file
tmp="/home/tmp/sh/mount-others.sh"
echo tmp:${tmp}
echo tmp-file:${tmp#*/}
echo tmp-file:${tmp##*/}
echo tmp-dir:${tmp%/*}

echo '$0'=$0;echo '$1'=$1;echo '$#'=$#;echo '$_'=$_;
