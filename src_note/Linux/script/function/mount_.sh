#!/bin/bash - 
#===============================================================================
#
#          FILE: mount_.sh
# 
#         USAGE: ./mount_.sh 
# 
#   DESCRIPTION: 
# 
#       OPTIONS: ---
#  REQUIREMENTS: ---
#          BUGS: ---
#         NOTES: ---
#        AUTHOR: YOUR NAME (), 
#  ORGANIZATION: 
#       CREATED: 2017/06/16 星期五 23:19
#      REVISION:  ---
#===============================================================================

function mount_()
{
  case $1 in
    Others)
      if ! -d /media/Others;then sudo mkdir /media/Others;fi
      if [ `ls -a /media/Others|wc -l` -eq 2 ];then sudo mount /dev/disk/by-label/Others /media/Others;else echo 'mount point has not null!';fi;;
    App*)
      if ! -d /media/Applications;then sudo mkdir /media/Applications;fi
      if [ `ls -a /media/Applications|wc -l` -eq 2 ];then sudo mount /dev/disk/by-label/Applications /media/Applications;else echo 'mount point has not null!';fi;;
    all*)
      if [ `ls -a /media/Others|wc -l` -eq 2 ];then sudo mount /dev/disk/by-label/Others /media/Others;else echo 'mount point has not null!';fi;
      if [ `ls -a /media/Applications|wc -l` -eq 2 ];then sudo mount /dev/disk/by-label/Applications /media/Applications;else echo 'mount point has not null!';fi;;
    *)
      select e in "mount disk device？" "show mounted device？" "quit？";do 
        case $REPLY in 
          1)
            read -p "Select a disk device mounted："
            if [ `ls -a /media/tmp|wc -l` -eq 2 ];then sudo mount /dev/disk/by-label/.. /media/tmp && echo "mount point is /media/tmp";else echo 'mount point has not null!';fi;
            break;;
          2)
            df -h|grep -v grep|grep "[sh]d[a-z][0-9]{0,2}"|awk '{print $1,$6}';break;;
          3)
            return 0;break;;
        esac
      done;;
  esac
}

mount_ $1

unset -f mount_
