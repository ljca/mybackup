#!/bin/bash -
#===============================================================================
#        AUTHOR: kyzs
#  ORGANIZATION: 
#       CREATED: 2017/04/22 星期六 15:24
#      REVISION:  ---
#===============================================================================

declare -a backroot
backdir=

if [ "$OS" == "Windows_NT" -a "$OSTYPE" == "msys" ];then
	backroot=(/i /g)
elif [ "$OSTYPE" == "linux-gnu" ];then
	backroot=(/media/Others /media/Applications)
else :
fi
	#echo "backuproot = $backroot"
	#echo "backdir = $backdir"

backdir=${backroot[0]}/Backup
destfile=
tmp_option=
tree="`which tree` -aF --sort=size"

#for i in $musicdir $ebookdir $docdir $docmht_dir $otherdocdir;do
for i in ${backroot[0]}/* ${backroot[1]}/*; do
	case `basename "$i" 2>/dev/null` in
		Audio*) 
			echo "Backup Music files....."
			tmp_option=" -h -I *.lrc"
			destfile=music.list
			;;
		Back*) 
			echo "Backup Backupfiles....."
			tmp_option=" -d"
			destfile=back_files.list
			;;
		Doc*) 
			echo "backup Document....."
			tmp_option=" -h -I mht"
			destfile=docs.list
			;;
		E_*) 
			echo "Backup E_books....."
			tmp_option=" -h -I *.ini"
			destfile=e_book.list
			;;
		mht) 
			echo "Backup MHT files....."
			tmp_option=" -h "
			destfile=doc-mht.list
			;;
		Ma*) 
			echo "Backup master pdf files....."
			tmp_option=" -h -I *.mp3"
			destfile=marster_pdf.list
			;;
		Other) 
			echo "Backup other files....."
			tmp_option=" -I *.mp3 -L 2 -d"
			destfile=other.list
			;;
		sr) 
			echo "Backup sr files....."
			tmp_option=" -h"
			destfile=sr.list
			;;
		Deve*) 
			echo "Backup Develop Application....."
			tmp_option=" -L 2 -d"
			destfile=develop_app.list
			;;
		system-to*) 
			echo "Backup system-tools Application....."
			tmp_option=" -L 2 -d"
			destfile=system-tools_app.list
			;;
		Study) 
			echo "Backup Study Application....."
			tmp_option=" -L 2 -d"
			destfile=study_app.list
			;;
		#Temp) 
		#	echo "Backup Tools Application....."
		#	tmp_option=" -L 2 -d"
		#	destfile=tmp.list
		#	;;
		Tools) 
			echo "Backup Tools Application....."
			tmp_option=" -L 2 -d"
			destfile=tools_app.list
			;;
		Pro*) 
			echo "Backup Genary Application....."
			tmp_option=" -L 2 -d"
			destfile=genary_app.list
			;;
		*) 
			echo "Backup other files...."
			tmp_option=" -L 1 -d"
			destfile=other_files.list
			;;
	esac
	[ -d $i ] && { pushd "$i/.." > /dev/null;$tree $tmp_option `basename "$i" 2>/dev/null` > $backdir/win/file-list/$destfile 2>/dev/null;popd > /dev/null; } || echo "directory isn't exists,skip backup."
# 
done
unset i

#
# /g <===> DeveLop ProgramFiles Study system-tools Temp Tools
# /i <===> Audio-Frequency Backup Document iso Other sr src-note Temp

unset backroot backdir destfile tree tmp_option

