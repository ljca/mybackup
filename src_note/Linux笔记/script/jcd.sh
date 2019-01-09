#!/bin/bash - 
# Usage: source jcd.sh
# Date: 2017年 08月 23日 星期三 11:56:41 CST
# Author: NULL

declare -a odir
odir[0]=${PWD}

function jcd()
{
  ndir=$(echo "${odir[0]}"|sed 's@\(.*/'$1'/\).*@\1@')
  builtin cd "${ndir}";
  #[ $? -eq 0 ] && odir=$OLDPWD
}

export -f jcd
