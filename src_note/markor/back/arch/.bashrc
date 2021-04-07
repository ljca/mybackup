# ~/.bashrc
#

# If not running interactively, don't do anything
[[ $- != *i* ]] && return

type l &> /tmp/tmp || alias l='ls --color=auto -aFh'
type md &> /tmp/tmp || alias md='mkdir -pv'
alias cp='cp -v'
alias rm='rm -v'
alias mv='mv -v'
alias rm='rm -v'
alias du='du -h'
alias dirs='dirs -v'

alias df='df -h'
alias free='free -mh'

type paci &> /tmp/tmp || alias paci="sudo pacman -S --needed"
type pacr &> /tmp/tmp || alias pacr="sudo pacman -Rcn"
type pacs &> /tmp/tmp || alias pacs="pacman -Ss"
type pacq &> /tmp/tmp || alias pacq="pacman -Q"
type pacfs &> /tmp/tmp || alias pacfs="pkgfile"
type s &> /tmp/tmp || alias s="sed -E"
type e &> /tmp/tmp || alias e="vim"
type c &> /tmp/tmp || alias c="cat"

#PS1='[\u@\h \W]\$ '
PS1='\u:\w\n\$ '
HISTCONTROL="ignoreboth"
LANG="zh_CN.UTF-8"
PATH="$HOME/bin:$PATH"
EDITOR=vim
HISTFILE=his

export PS1 HISTCONTROL LANG PATH EDITOR HISTFILE

eval "$(dircolors -b ~/.dircolors)"


function taocl() {
	curl -s https://raw.githubusercontent.com/jlevy/the-art-of-command-line/master/README-zh.md|
		pandoc -f markdown -t html |
		iconv -f 'utf-8' -t 'unicode' |
		xmlstarlet fo --html --dropdtd |
		xmlstarlet sel -t -v "(html/body/ul/li[count(p)>0])[$RANDOM mod last()+1]" |
		xmlstarlet unesc | fmt -80
	}

type gbk2utf8 &> /tmp/tmp || function gbk2utf8 ()
{
	[[ $# -eq 1 &&  -w "$1" ]] && iconv -c -fcp936 -tutf8 "$1" -o "$1" || echo "usage: gbk2utf8 file"
}

type search &> /tmp/tmp || function search()
{
  [ $# -eq 1 ] && grep "$1" -r . || echo 'usage: search ""'

}

> /tmp/tmp


