#
# ~/.bashrc
#
# If not running interactively, don't do anything
[[ $- != *i* ]] && return
echo $PATH|grep -io $HOME &>/dev/null || { [ -d $HOME/bin ] && export PATH="$PATH:$HOME/bin"; }
#[ -r /etc/bash.bashrc ]&&source /etc/bash.bashrc
#[ -r /home/external/sh/profile.sh ]&&source /home/external/sh/profile.sh
type mysql_clo &> /dev/null || alias mysql_clo='mysqladmin -umysql -p shutdown'
ps aux|grep -v grep|grep X &> /dev/null || alias startx='startx &>/dev/null '
#alias ls='ls --color=auto'
#PS1='[\u@\h \W]\$ '

#source ~/.shell_prompt.sh

# [ -f /usr/share/doc/pkgfile/command-not-found.bash ] && source /usr/share/doc/pkgfile/command-not-found.bash

[ "$TERM" = "linux" ] && {
  echo -en "\e]P7ffffff"
#   alias external_env='ps aux|grep -v grep|grep fcitx &>/dev/null || fcitx&>/dev/null& \
#     exec tmux'
} 

#alias gcc="color_compile gcc"
#alias g++="color_compile g++"
#alias make="color_compile make"

#&& type fbterm &> /dev/null
 #if [[ `tty` = \/dev\/tty[1-6]  ]];then
 if [[ `tty` = \/dev\/tty1  ]];then
#   # set the default text color. this only works in tty (eg $TERM == "linux"), not pts (eg $TERM == "xterm")
#   #setterm -background black -foreground green -store
# 
#   #cursor_styles="\e[?${cursor_style_full_block};c" # only seems to work in tty
#   cursor_styles="\e[?16;2;112;c" # only seems to work in tty
# 
#   #PS1="$PS1${cursor_styles}"
# 
#   PS1="\u:\W \\$ ${cursor_styles}"
#   #su -c 'echo -e "`dumpkeys|grep keymaps`\nkeycode 100 = Alt" | loadkeys'
  dumpkeys | grep 'keycode 100 = Alt' &>/dev/null || sudo loadkeys alt
   LANG="zh_CN.UTF-8" fbterm
   #startx
 fi
#fbterm;fi #

 if [[ `tty` = \/dev\/tty2  ]];
   then startx &>/dev/null;
 fi

alias bd='source $HOME/.local/bin/bd -si'

#cd /media/Others/Backup/lin/publicUser/src_note/lin/shell

type vb &> /dev/null || alias vb='vboxmanage'
type vbm &> /dev/null || alias vbm='vboxmanage modifyvm'
type vbc &> /dev/null || alias vbc='vboxmanage controlvm'
type vbs &> /dev/null || alias vbs='vboxmanage storageattach'

#http_proxy="http://192.168.43.191:31285/"
#https_proxy="$http_proxy"
#export http_proxy https_proxy
type e &>/dev/null || alias e='vim'
if ps aux|grep -v grep|grep X &>/dev/null;then synconf;fi
