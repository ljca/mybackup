#!/bin/bash - 
#===============================================================================
#
#          FILE: mybackup.sh
# 
#         USAGE: ./mybackup.sh 
# 
#   DESCRIPTION: 
# 
#       OPTIONS: ---
#  REQUIREMENTS: ---
#          BUGS: ---
#         NOTES: ---
#        AUTHOR: YOUR NAME (), 
#  ORGANIZATION: 
#       CREATED: 2018年12月01日 17:24
#      REVISION:  ---
#===============================================================================


cd /media/Others/Backup/myback
mkdir -p config/vim

cp -ur ~/.config/{i3*,gtk*,font*} config &> /dev/null
#tar -cRJf config.tar.xz .config &> /dev/null
cp -u ~/.vim/vim* config/vim &> /dev/null
cp -u ~/{.tmux.conf,.bashrc,.bash_profile,.bash_logout,.fbtermrc,.inputrc,.gtkrc-2.0,.zsh*,.myclirc,.xinitrc,.Xresources,.xprofile} config
cp -u ~/{.*conf*,.*rc*,.*profile*} config &> /dev/null
tar -czRvf sh.tar.gz /home/external/sh 

if ping -c 2 www.baidu.com &> /dev/null;then
  git add .
  #git commit -m "My Backup scripts."
  git commit -a -m "`date`"
  git push back master 
else echo "无网络服务...";
fi


