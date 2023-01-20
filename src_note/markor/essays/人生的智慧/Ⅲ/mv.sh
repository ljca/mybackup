#!/bin/bash -xv

#function mv_num()
#{
  #local 
  m=1;
  #n=$#;
  if [ $# -ne 0 ];then
  tmp=$(($# - 1))
  echo $#
  #echo ${$#}
  #shift;
  #for i in *.md;do
  echo $1
  echo $2
  echo $3
  declare f=$@
  set $f
  echo $f
  for (( n=0;n<=$#;n++));do
  #for i in $@;do
    #mv "$i" "$m$2"
    echo -e "\$$n = ${n}\n"
    #echo -e  "m : ${m}\n"
    #echo -e "n : ${n}\n"

    #let m++;
    #let n--;
  done
  fi
#}



