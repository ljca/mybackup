#!/bin/bash -

function check_env()
{
	echo "Disk map relations："
	for i in /dev/disk/by-label/*;do echo "$(readlink -f $i) <==================> $i";done
	echo  "Has been mounted disk device."
	echo -e "\e[1;33mdevice\tmount-point\e[0m："
	df -h|grep '[sh]d[a-z][1-9]'|awk '{print $1,$6}'
}

declare -a choose
function select-device()
{
	check_env;unset -f check_env 
	echo "Please select a disk device's volume or name："
	local -a disk
	local j=0
	for i in /dev/{[sh]d[a-z][1-9]*,disk/by-label/*};do
		#disk[$j]=`basename $i`;
		disk[$j]=$i;
		let j++;
	done
	unset i j
	#echo ${disk[*]};exit;

	select e in ${disk[*]};do
		echo "$e has selected.";
		choose[0]=$e
		echo "Mount Point is a null diectory.If you enter custom direcotry，Please Enter the <Ctrl D>，Select a mount point："
		local tmp=/media
		select e in $tmp/{Others,Applications,tmp} /mnt;do
			echo "$e has selected.";#($REPLY) 
			choose[1]=$e
			break;unset tmp
		done
		break;unset disk
	done
}

select-device;unset -f select-device

	function mount-dev()
	{
		[ -z ${choose[0]} ] && { echo -e "\e[1;31mThe disk divice hasn't choose,exit script.\e[0m";exit -1;}
		[ -z ${choose[1]} ] && { choose[1]=/mnt;echo "The mount-point hasn't choose,default：${choose[1]}"; }
		[ ! -d ${choose[1]} ] && sudo mkdir -p ${choose[1]} 
		# If the choose is disk volume.

		# If disk hasn't mounted and mount-point is null directories.
		df -h|grep -iE "${choose[@]}" &>/dev/null || sudo mount ${choose[0]} ${choose[1]};
	}

	mount-dev;unset choose;unset -f mount-dev

