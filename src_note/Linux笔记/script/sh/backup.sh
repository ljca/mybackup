#!/bin/bash -xv
#####

#sh_dir=/home/external/sh

#[ -f "${sh_dir}/check_os.sh" ] && source "${sh_dir}/check_os.sh"

#echo $OS

case $OSTYPE in
  linux-gnu)
    back_dir=/media/Others/Backup/lin/pub

    if [ -x /usr/bin/lsb_release ] ;then
      des="`lsb_release -a|grep Description|cut -d: -f2|sed 's/\t//g'`"
      case $des in
        Arch*)
          back_dir=$back_dir/Arch;;
          #[ ! -d $back_dir ] && 
            Fedora*)
          :;;
      esac
      mkdir -p $back_dir/config/vim
      if [ $UID -ne 0 ];then
        cd 
        cp -ur .config/{i3*,gtk*,font*} $back_dir/config &> /dev/null
        tar -cRJf $back_dir/config.tar.xz .config &> /dev/null
        cp -u .vim/vim* $back_dir/config/vim &> /dev/null
        cp -u .tmux.conf .bash* .fbtermrc .pythonhist .inputrc .gtkrc-2.0 .zsh* .myclirc .xinitrc .Xresources .xprofile $back_dir/config
        cp -ru .*conf* .*his* .*rc* .*profile* $back_dir/config &> /dev/null
      elif [ $UID -eq 0 ];then tar -czRf "$back_dir/${des:-linux}-etc.tar.gz" /etc &> /dev/null
      fi
    fi

    #for i in *.conf;do
    #	[ -f $i ] && \cp $i $tmp;
    #done;;
    :;;
  msys)
    tar -czRf "/i/Backup/lin/msys-etc.tar.gz" /etc;;
  *)
    echo "no backup.";;
esac

unset des back_dir
#######

