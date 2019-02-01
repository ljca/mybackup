#!/bin/bash -
#####

#sh_dir=/home/external/sh

#[ -f "${sh_dir}/check_os.sh" ] && source "${sh_dir}/check_os.sh"

#echo $OS

case $OSTYPE in
  linux-gnu)
    back_dir=/media/Others/Backup

    if [ -x /usr/bin/lsb_release ] ;then
      des="`lsb_release -a|grep Description|cut -d: -f2|sed 's/\t//g'`"
      case $des in
        Arch*)
          #back_dir=$back_dir/Arch;;
          :;;
          #[ ! -d $back_dir ] && 
            Fedora*)
          :;;
      esac
      if [ $UID -ne 0 ];then
        echo "Backup User profiles...."
        back_dir=/media/Others/Backup/myback/src_note/Linux/config
        mkdir -p $back_dir/.vim
        cd 
        #cp -ur .config/{i3*,gtk*,font*,qt*} $back_dir &> /dev/null
        cp -ur ~/.config/{*.[a-z]?*,qt*,xfce4,vnote,i3*,tilda,font*,gtk-*} $back_dir
        #tar -cRJf $back_dir/config.tar.xz .config &> /dev/null
        cp -u .vim/{gvim*,vim*} $back_dir/.vim &> /dev/null
        #cp -u .tmux.conf .bash* .fbtermrc .pythonhist .inputrc .gtkrc-2.0 .zsh* .myclirc .xinitrc .Xresources .xprofile $back_dir
        cp -ru .*.conf .*his* .*rc* .*profile .Xresources $back_dir &> /dev/null
        echo "Backup user shell scripts...."
        cp -ru /home/external/sh $back_dir/../script

        echo "Checking the networks...."
        if ping -c 2 www.baidu.com &> /dev/null;then
          echo "pushd git...."
          cd $back_dir/../../..
          git add .
          #git commit -m "My Backup scripts."
          git commit -a -m "`hostname` `date`" > /dev/null
          git push origin master 
        else echo "无网络服务...";
        fi

      elif [ $UID -eq 0 ];then 
        echo "Backup boot & efi files..."
        tar -czRf "$back_dir/lin/pub/etc/${des:-linux}-etc.tar.gz" /etc &> /dev/null
        tar -cJRf "$back_dir/boot/efi.tar.xz" /boot/efi/EFI/boot &> /dev/null
        tar -cRf "$back_dir/boot/${des:-linux}-boot.tar" /boot/*-linux* &> /dev/null
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

