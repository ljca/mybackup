#!/bin/bash -xv
#===============================================================================
#
#          FILE: capa.sh
# 
#         USAGE: ./capa.sh 
# 
#   DESCRIPTION: 
# 
#       OPTIONS: ---
#  REQUIREMENTS: ---
#          BUGS: ---
#         NOTES: ---
#        AUTHOR: YOUR NAME (), 
#  ORGANIZATION: 
#       CREATED: 2018年10月23日 20:26
#      REVISION:  ---
#===============================================================================


sync;sync;sync;sync;sync;

capa=`cat /sys/class/power_supply/BAT1/capacity`
ac=
ring='/home/external/usr/share/ring/Message07.ogg'
if [ $capa -le 30  && `cat /sys/class/power_supply/ACAD/online` -eq 0 ];then 
  #if [ $capa -le 60 ];then 
  #/usr/bin/mpv $ring &>/dev/null &
  #notify-send -i "$(echo terminal)" "你的设备电量不足30%！\n为了数据安全，系统将会挂起！请尽快为你的设备充电。" && 
    systemctl suspend;
elif [ $capa -eq 100 ];then
  /usr/bin/mpv $ring &
  #notify-send -i "$(echo terminal)" "请不要为你的设备过度充电。"
fi
unset capa ring

