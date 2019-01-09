#!/bin/bash
#
others="/media"

# function echo_usage()
# {
# 	echo -e "usage: $0 <dir> [dir] \nor $0 <dir>"
# }
# 
# function mount_others()
# {
# 	a=`ls ${others}/$1 -a | wc -l `
# 	[[  -e /dev/disk/by-label/$1 && -d $others/$1 &&  $a -eq 2 ]] && SUDO mount -t ntfs /dev/disk/by-label/$1 ${others}/$1
# 	[[ -e /dev/disk/by-label/Application && -d $others/$2 ]] && [ `ls ${others}/$2 -a|wc -l` -eq 2 ] && SUDO mount -t ntfs /dev/disk/by-label/Application ${others}/$2
# 	unset a 
# }
# 
# function test_dir()
# {
# [[ -z $1 && -z $2 ]] && echo_usage && return 1;
# 	if [[ -n $1 && -z $2 ]];then 
# 	case $1 in
# 		"Others")
# 			[ ! -d $others/$1 ] && SUDO mkdir -pv $others/$1;
# 			[ `\ls $others/$1 -a|wc -l` -eq 2 ] && [ -e /dev/disk/by-label/$1 ] && SUDO mount -t ntfs /dev/disk/by-label/$1 $others/$1;;
# 		"App")
# 			[ ! -d $others/$1 ] && SUDO mkdir -pv $others/$1;
# 			[ `\ls $others/$1 -a|wc -l` -eq 2 ] && [ -e /dev/disk/by-label/Application ] && SUDO mount -t ntfs /dev/disk/by-label/Application $others/$1;;
# 		"xu_qiao_lin")
# 			:;;
# 		"TMP")
# 			[ `\ls $others/$1 -a|wc -l` -eq 2 ] && [ -e /dev/disk/by-label/$1 ] && SUDO mount -t vfat -o rw,flush,utf8=1,uid=$UID /dev/disk/by-label/$1 $others/$1;;
# 		*)
# 			echo dir don\'t allow,dir only allow is Others or App;;
# 	esac
# 	elif [[ -s $1 && -s $2 ]];then
# 		[[ $1 == "Others" && $2 == "App" ]] && mount_others
# 	else echo_usage && return 1;
# fi
# 	
# 
# #	if [[ ${others}/$1 == "${others}/Others" && ! -d ${others}/$1 ]] ; then
# #		SUDO mkdir -pv ${others}/$1
# #	elif [[ ${others}/$1 == "${others}/App" && ! -d ${others}/$2 ]] ; then
# #		SUDO mkdir -pv ${others}/$2
# #	else {
# #		echo path error
# #		return;
# #	}
# #	fi
# }
# 
# #test_dir
# 	unset others
# 	unset -f mount_others test_dir echo_usage
[ -z $1 ] && echo "usage: $0 <dir> [<dir>]" || {
	[ -e /dev/disk/by-label/$1 ]||[[ -e /dev/disk/by-label/${1,2} || ! -e /dev/disk/by-label/$2 ]]&&{
		[[ -n $1 && -n $2 ]] && {
			for i in ${1,2};do
				case $i in
					"Others") [ ! -d $others/$1 ] && SUDO mkdir -p $others/$1;;
					"Applications") [ ! -d $others/$1 ] && SUDO mkdir -p $others/$1;;
					"*")  echo "device will mounted $others/tmp...."
				esac
			done
		}

		[[ -n $1 && -z $2 ]] && {
		case $1 in
			"Others") 
				[ ! -d $others/$1 ] && SUDO mkdir -p $others/$1 || {
				[ `\ls -a $others/$1|wc -l` -eq 2 ] && SUDO mount /dev/disk/by-label/Others $others/$1||echo "devices already mouted..."
			};;
				#[ -d $others/$1 ] && 
			"Applications") 
				[ ! -d $others/$1 ] && SUDO mkdir -p $others/$1;
				[ `\ls -a $others/$1|wc -l` -eq 2 ] && SUDO mount /dev/disk/by-label/$1 $others/$1||echo "devices already mouted...";;
			"*") 
				[ ! -d $others/tmp ]&& SUDO mkdir $others/tmp || echo "device will mounted $others/tmp....";
				[ `\ls -a $others/tmp|wc -l` -eq 2 ] && SUDO mount /dev/disk/by-label/$1 $others/tmp||echo "devices already mouted...";;
		esac
		} || [[ -n $1&& -n $2 ]]&&[[ $1 == "Others"&&$2 == "Application" ]]&&[[ `\ls -a $others/$1|wc -l` -eq 2&&`\ls -a $others/$2|wc -l` -eq 2 ]]&&SUDO mount /dev/disk/by-label/$1 $others/$1;SUDO mount /dev/disk/by-label/$2 $others/$2
	} || echo No such device....

}
unset others




function check_env()
{
	if [ $# -gt 0 ];then
		case $1,$2 in
			Others)
				tmp-mount=/media/Others;;
			Applications)
				tmp-mount=/media/Applications;;
			tmp)
				tmp-mount=/media/tmp;;
			*)
				tmp-mount=/mnt
		esac
		[ ! -d $1 ] && SUDO mkdir -p /media/$1;
		[[ -n $2  &&  ! -d $2 ]] && SUDO mkdir -p /media/$2;
	
		[ `\ls -a /media/$1|wc -l` -ne 2 ] && { echo "device  is mounted /media/$1";exit 0; }
	else 
		echo "If you want mount a disk device,Please use $0 [mount-point] executeble the bash script And if you wants to see has mounted disk,executeble df -h";exit 0
	fi
}

function mount-disk()
{
	check_env $1 $2
}

