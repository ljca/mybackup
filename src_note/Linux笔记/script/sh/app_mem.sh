#!/bin/bash -
# 一个根据程序进程名来大概统计程序的物理内存占用的shell脚本(虚拟内存不计入物理内存占用)。
# Major <k_y_z_s@yeah.net> #echo "$(($(echo -e ``)/1024))M"
if [ "x$1" != "x" ];then 
mem=`ps aux|grep -Ev "grep|${0}"|grep -i ${1}|awk '{print $6}'`
[ "x$mem" = "x" ] && { echo -e "\e[1;31mNot found the ${1} Process,exit.\e[0m";exit -1; }
total=
	for i in $mem;do
		let total+=$(($i/1024))
	done
	unset i mem
	echo "${1} ${total}M"
	unset total
else echo "Usage： `basename $0` <Process>"
fi

