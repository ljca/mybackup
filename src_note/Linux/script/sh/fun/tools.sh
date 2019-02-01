#!/bin/bash -xv

# 此函数用来调整和查看显示器背光……
function sl()
{
  local tmp=/sys/class/backlight/intel_backlight/brightness
  if
    [ -r $tmp ];then
    if [ $# -eq 1 ];then 
      echo $1|${SUDO} tee $tmp >/dev/null #su -c "echo $1 > $tmp"
    else echo "light:`cat $tmp`"
    fi;
  else echo "Intel video card driver maied not loading...."
  fi;
  unset tmp
}

# 系统挂起，睡眠与锁屏
function sys_mem()
{
  echo mem | ${SUDO}tee /sys/power/state &> /dev/null;
  xtrlock &
}

# 此函数用来调用 iconv 将原始文件编码转换到 utf-8 ……

function gbk2utf8 ()
{
  code=
  codes=("cp936" "gb18030" "gbk" "gb2312")
  #echo ${codes[0]} ${codes[1]}
  #echo "current dirctory: `pwd`,please select a file: "
  #select f in `find . -maxdepth 1 -type f|sed 's:\./::'`;do 
  if [ $# -eq 1 ] ;then
    #if [ -f $f ];then
    [ -r "$1" ] && {
      echo "select an encode: "
    select d in ${codes[*]};do
      iconv -f $d -tutf-8 "$1" &>/dev/null && iconv -f $d -tutf-8 "$1" -o "$1";break;
    done;
  }
  # echo "Usage: $FUNCNAME <src_code> <input_file> [<output_file>]";return 2;;
  #for i in ${codes[*]};do 
  #  #iconv -f $i -t utf-8 $1 &> /dev/null && iconv -f $i -t utf-8 $1 -o $1 
  #  #return
  #done
else echo "please mixed files."
fi
#break;
#done
unset codes code
}

function utf1628()
{
  if [ $# -eq 1 -a -f "$1" ];then
    iconv -f utf16le -t utf-8 "$1" -o "$1"
  else echo "utf1628 file.";
  fi
}

## 此函数用来调用 ffmpeg 分割视频，仅支持 mp4,avi…… 
function vsplit()
{
  # test filetype $1

  local arg=

  #if [ $# -eq 4 ];then
  case $# in
    4)
      if [[ "x$2" != "x-s" && "x$2" != "x-t" ]];then
        arg="-ss $2 -to $3"
      else
        case $2 in
          -s) arg="-ss $3";;
          -t) arg="-to $3";;
        esac;
      fi;;

      #elif [ $# -eq 3 ];then
      3)
      set $1 $2 $3 new_$1
      case $2 in
        -s) arg="-ss $3";;
        -t) arg="-to $3";;
        #[0-9]\+:[0-9]\+:[0-9]\+) arg=-ss $2;;
        *) arg="-ss $2 -to $3";;
      esac;;

      #elif [ $# -eq 2 ];then
      2)
      set $1 $2 "" new_$1
      arg="-ss $2" # default
      ;;

      #else
      *) echo -e "Usage:\n $FUNCNAME <input_file> {start_time end_time | -s start_time | -t end_time} [output_file] \nOr:\n $FUNCNAME <input_file> start_time"; return 2;;

      #fi;
    esac

    #echo "$arg"
    #echo "\$1=$1 \$2=$2 \$3=$3 \$4=$4"; #$1 $2 $3 $4
    ffmpeg -i $1 -c copy $arg $4 
    unset arg
  }

  # 
  function txt2pdf()
  {
    local doc=$1
    [ -f medit-env.sh ] && . medit-env.sh
    doc="${LATEX_MASTER:-$DOC}"
    doc_base=`basename "$doc" .tex`
    latex --src-specials "$doc" && \
      dvips "$doc_base.dvi" && \
      ps2pdf "$doc_base.ps"
  }

  # 此函数用来调用 ffmpeg 转换视频格式，默认转换到 mkv 
  function vc2mkv()
  {
    case $# in
      1) set $1 ${1%%.*}.mkv;;
      2) set $1 ${1%%.*}.mkv;;
      *) echo -e "Usage:\n $FUNCNAME <input_file> [output_file]"; return 1;;
    esac
    ffmpeg -i $1 $2;
  }

  #  remove files special character
  #
  type rfsc &>/dev/null || {
    function rfsc()
  {
    pushd . &>/dev/null
    #local tmp="${1:-[]@#+=%}"
    tmp="$1"
    for i in *;do 
      #if [[ $# -eq 1 ]];then set " ()";fi
      ##mv -iv "$i" "`echo $i|sed 's/[$1]//g'`" 2>/dev/null
      mv -iv "$i" "`echo $i|sed \"s/ /-/g;s/[$tmp]//g\"`"
      popd &>/dev/null
    done
  }
}

# md2 -> html -> pdf

function tools_check()
{
  #pandoc
  #wkhtmltopdf
  echo "convert sequce: markdown -> html -> pdf.";
  type pandoc &> /dev/null || { echo "pandoc is not found, please install it. "; exit 255; }
  type wkhtmltopdf &> /dev/null || { echo "wkhtmltopdf is not found, please install it."; exit 255; }
}

function md2pdf()
{
  tools_check
  unset -f tools_check
  if [ -r $1 ];then
    echo "convert $1 -> ${1%%.*}.html -> ${1%%.*}.pdf."
    pandoc -f markdown_github -t html $1 -o ${1%%.*}.html
    tool=/home/user/Kyzs/bin/wkhtmltopdf
    set ${1%%.*}.html ${1%%.*}.pdf
    #echo "${1%.*} ${1%%.*}.pdf"
    $tool --page-size A4 --orientation Portrait --margin-bottom 10mm --margin-left 10mm --margin-right 10mm --margin-top 16mm --encoding utf-8 --background --javascript-delay 10000 toc --toc-text-size-shrink 1.0 $1 $2
    unset tool opt
    rm -f ${1%%.*}.html
  else echo "please a fixed markdown file.";
  fi
}

export -f sl md2pdf gbk2utf8

