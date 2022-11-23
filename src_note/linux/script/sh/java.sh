#!/bin/bash - 
#===============================================================================
#
#          FILE: java.sh
# 
#         USAGE: ./java.sh install|uninstall
# 
#   DESCRIPTION: 
# 
#       OPTIONS: ---
#  REQUIREMENTS: ---
#          BUGS: ---
#         NOTES: ---
#        AUTHOR: YOUR NAME (), 
#  ORGANIZATION: 
#       CREATED: 2017年02月27日 19:41
#      REVISION:  ---
#===============================================================================
#tmp=/home/external/usr/develop
#jdk_dir=${1:-/home/external/usr/develop}

case $# in
  1)
    if [[ $1 != "install" || $1 != "uninstall" ]];then
      if [ -d $1 ];then 
        jdk_dir=$1
      else jdk_dir=/home/external/usr/develop
      fi
    fi;;
  2)
    :;;
  0|*)
    :;;
    #echo "Usage: ./java.sh [dir] {install|uninstall}";;
  esac

#[ -d $tmp ] && {
#	JAVA_HOME=$tmp/Java_Web/jdk7u80
#	JRE_HOME=$JAVA_HOME/jre
#	PATH=$JAVA_HOME/bin:$JRE_HOME/bin:$PATH
#	export JAVE_HOME JRE_HOME PATH
#	unset tmp
#}
[ -n $jdk_dir ] && [ -d $jdk_dir ] && {
	jdk=$jdk_dir/Java_Web/jdk7u80
	jre=$jdk/jre
	#dest=${dest:-$HOME/bin}
  dest=/usr/local/bin
  #for i in $jdk/bin/* $jre/bin/*;do ln -sv $i $dest/$i;done
  #for i in "$jdk/bin/*" "$jre/bin/*";do readlink $dest/`basename $i` &>/dev/null || ln -sv $i $dest/;done;
  cd $dest
  case $1 in
    install)
	for i in $jdk/bin/* $jre/bin/*;do [ -L $dest/${i##*/} ] || ${SUDO} ln -sv $i ;done;;
    uninstall)
	for i in $jdk/bin/* $jre/bin/*;do [ -L $dest/${i##*/} ] && ${SUDO} rm -vf $dest/${i##*/};done;;
  *)
    echo "Usage ./java.sh install|uninstall [dir]"
  esac
	unset jdk_dir jdk jre dest 
}
