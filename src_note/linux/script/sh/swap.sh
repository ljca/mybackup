#!/bin/bash 
#
function swap_on()
{
  df -h|grep sda|column -t -o" "|cut -d" " -f4,5;return;
  swap="/swap/swapfile"
  [ ! -d "${swap%/*}" ]&&SUDO mkdir ${swap%/*}
  if [ ! -f ${swap} ];then SUDO dd if=/dev/zero of=${swap} bs=1024 count=512000&&SUDO chmod 600 ${swap}&&SUDO mkswap -L "swap" ${swap};fi
  if cat /proc/swaps|grep "${swap}";then echo 'memory already exists swapfile.';return;fi
  [ -f ${swap} ]&&if file ${swap}|grep swap;then SUDO swapon ${swap};else SUDO mkswap -L "swap" ${swap}&&SUDO swapon ${swap};fi
unset swap
}
swap_on;
unset -f swap_on;
