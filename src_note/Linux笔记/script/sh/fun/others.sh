#!/bin/bash - 
#===============================================================================
#
#          FILE: others.sh
# 
#         USAGE: ./others.sh 
# 
#   DESCRIPTION: 
# 
#       OPTIONS: ---
#  REQUIREMENTS: ---
#          BUGS: ---
#         NOTES: ---
#        AUTHOR: YOUR NAME (), 
#  ORGANIZATION: 
#       CREATED: 2018年09月11日 22:24
#      REVISION:  ---
#===============================================================================


function mp4_play()
{
  mplayer $1 </dev/null &>/dev/null
}

export -f mp4_play

