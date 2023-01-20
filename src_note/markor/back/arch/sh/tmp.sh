#! /bin/bash -


#function echk
#{
#	echo -e "1: $1\n"
#	echo -e "2: $2\n"
#	echo -e "3: $3\n"
#}

if [[ $# -eq 0 || $# -gt 1 ]];then

cat <<EOF
argments is too few or too many.
The sed script is covert from , to ，in files. usage: $(basename $0) file
EOF

elif [ -w "$1" ];then

 sed -i -e 's/\!/！/g;s/;/；/g;s/,/，/g;s/?/？/g;s/:/：/g' "$1"

fi

#for i in "$@";do 
#declare file
#let i++;
#file[$i]=${file[$i]}
#done
