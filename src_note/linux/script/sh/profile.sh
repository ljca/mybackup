#! /bin/bash -

#dir="$(cd -P $(dirname $0);pwd)"
SH_DIR= #"$(cd -P $(readlink -f .);pwd)"
#dir="$(dirname $(readlink -f $dir))"
SH_DIR="${SH_DIR:-/home/external/sh}"
export SH_DIR

[ $EUID -ne 0 ] && SUDO='sudo ' || SUDO=
export SUDO

#export PS1="\[\e[1;31m\]\$?\[\e[0m\]\[\e[1;36m\]:\[\e[0m\]\#\[\e[1;36m\]:\[\e[0m\]\[\e[1;31m\]\u\[\e[0m\]\[\e[1;36m\]:\[\e[0m\]\[\e[1;37m\]\w\[\e[0m\]\n\`if [ \$? != 0 ];then echo -e \"\[\e[1;36m\]:(\[\e[0m\]\";else echo -e \"\[\e[1;37m\]^_^\[\e[0m\]\";fi\`\[\e[0m\]\[\e[1;33m\]/=>\[\e[0m\] "

#if [[ -z $normal&&-z $red ]];then
#
normal="\[\e[0m\]"
black="\[\e[1;30m\]"
red="\[\e[1;31m\]"
green="\[\e[1;32m\]"
yellow="\[\e[1;33m\]"
blue="\[\e[1;34m\]"
pink="\[\e[1;35m\]"
cyan="\[\e[1;36m\]"
white="\[\e[1;37m\]"

#export PS1='\[\e[1;31m\]\!\[\e[0m\]\[\e[1;36m\]:\[\e[0m\]\#\[\e[1;36m\]:\[\e[0m\]\
	#\[\e[1;31m\]\u\[\e[0m\]\[\e[1;36m\]:\[\e[0m\]\[\e[1;37m\]\w\[\e[0m\]\n\
	#`echo $?`:\[\e[1;33m\]\$\[\e[0m\] '

#export PS1="${red}`echo $?`${normal}${color}:${normal}\#${color}:${normal}\
	#${red}\u${normal}${color}:${normal}${yellow}\w${normal}\n\
	#${color}\!${normal}${color}:${normal}${green}\\$ ${normal}"

#
#${green}\!${normal}${yellow}:${normal}\
#${cyan}\#${normal}${yellow}:${normal}\

export PS1="${red}\$?${normal}${yellow}:${normal}\
${pink}\u${normal}${yellow}:${normal}\
${white}\w${normal}\n\
\`if [ \$? -eq 0 ];then echo \"${white}^_^${normal}\";else echo \"${red}:(${normal}\";fi\`\
${pink}-${red}${normal}${yellow}\\$ ${normal}"
export PS2="$pink>> $normal"

unset normal black red green yellow blue pink cyan white
#fi
#$(date +%H:%M)

#
export HISTSIZE=5000
export HISTFILESIZE=30720
export HISTCONTROL="ignoreboth:erasedups"
export HISTTIMEFORMAT='%F %T '
#export HISTIGNORE="&:[ ]*"
#export HISTIGNORE='sync:history[ \t]*:du[ \t]*:df:free:ll:ll[ \t]*:ls:ls[ \t]*:top:ps:exit'

[ -r $SH_DIR/ck_os.sh ] && source $SH_DIR/ck_os.sh

#
case $OS in
	msys|cygwin)
		[ -r "/usr/local/sh/bash_aliases" ] && source "/usr/local/sh/bash_aliases"
		[ -x /usr/bin/dircolors ] && [ -r /usr/local/sh/dircolors ] && eval "$(dircolors -b /usr/local/sh/dircolors)"
		CDPATH="$CDPATH:/i:/g:."
		back="/i/Backup/lin"
		;;

		#
    *Linux*|FreeBSD*)
		[ -r "${SH_DIR}/bash_aliases" ] && source ${SH_DIR}/bash_aliases

		[ -x /usr/bin/dircolors ] && [ -r ${SH_DIR}/dircolors ] && eval "$(dircolors -b ${SH_DIR}/dircolors)"

		[ -r ${SH_DIR}/wifi.sh ] && source ${SH_DIR}/wifi.sh

		[ -r ${SH_DIR}/genary.sh ] && source ${SH_DIR}/genary.sh

		[ -r ${SH_DIR}/cowsay.sh ] && source ${SH_DIR}/cowsay.sh

		#[ -r ${SH_DIR}/set_user_path.sh ] && source ${SH_DIR}/set_user_path.sh

		#[ -x ${SH_DIR}/java.sh ] && source ${SH_DIR}/java.sh

		back="/media/Others/Backup/lin"
		CDPATH=".:$HOME/Desktop:/media/Others:/media/Applications:/home/external:${back:-home/external}/../myback"
		;;
esac

export VISUAL="vim" EDITOR="vim"
export CDPATH back;

shopt -s autocd

