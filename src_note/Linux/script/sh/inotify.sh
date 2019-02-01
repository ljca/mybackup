#!/bin/bash - 
#===============================================================================
#
#          FILE: inotify.sh
# 
#         USAGE: ./inotify.sh 
# 
#   DESCRIPTION: 
# 
#       OPTIONS: ---
#  REQUIREMENTS: ---
#          BUGS: ---
#         NOTES: ---
#        AUTHOR: YOUR NAME (), 
#  ORGANIZATION: 
#       CREATED: 2018年12月09日 11:05
#      REVISION:  ---
#===============================================================================

set -o nounset                              # Treat unset variables as an error
/usr/bin/inotifywait -mq -r -e create,modify,move,moved_to,moved_from,delete /media/Others/Document /media/Others/Backup/myback/src_note/Linux笔记 /home/external/sh >> /home/external/var/log/inotify.log

