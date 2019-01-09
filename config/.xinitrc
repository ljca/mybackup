#!/bin/sh

#xterm -geometry 80x20+494-0 &
#exec xterm -geometry 80x66+0+0 -name login
# xfce4-terminal &>/dev/null &
#twm &
#exec fvwm 

#xfwm4&
# ps aux|grep -v grep|grep fcitx &>/dev/null || LANG="zh_CN.UTF-8" fcitx &>/dev/null &
#export LC_ALL=POSIX
export LANG="zh_CN.UTF-8"
#export LANGUAGE="zh_CN:en_US"
export XIM=fcitx
export XIM_PROGRAM=fcitx
export GTK_IM_MODULE=fcitx
export XMODIFIERS="@im=fcitx"
export QT_IM_MODULE=fcitx

# mono /lib/docky/Docky.exe&>/dev/null&
xrdb -merge ~/.Xresources
#exec twm
exec i3 
# compiz &>/dev/null &


DEFAULT_SESSION=i3

#exec $DEFAULT_SESSION

#case $1 in
#  notion) 
#    exec notion
#    ;;
#  openbox) 
#    exec openbox-session
#    ;;
#  #awesome) 
#  #  exec awesome
#  #  ;;
#  *) 
#    exec $DEFAULT_SESSION
#    ;;
#esac

setxkbmap -option terminate:ctrl_alt_bksp

