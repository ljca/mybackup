#! /usr/bin/bash -

if [[ "$#" -eq 0 ]];then 
  #if [ ! -n "$1" ];then 
cat <<- EOF 

    这个 bash 脚本调用 flac mac lame 等工具用于将一些无损音乐🎶转换为 mp3 文件或者在无损之间转换。

    然而不幸的是，由于 lame 技术上的不成熟，无法将音频文件的元信息在转换过程中同时写入到转换后的 mp3 文件中。以下是一些可以转换的文件类型：

wav -> mp3
flac -> mp3
ape -> mp3
flac <-> wav
ape <-> wav
flac <-> ape

No input auido files.
Usage: 
w2mp3 <ape|flac|wav files> [标题] [艺术家] [专辑] [专辑封面]";
or
w2mp3 -a2f|--ape2flac apefile
w2mp3 -f2a|--flac2ape flacfile
w2mp3 -w2a|--wav2ape wavfile
w2mp3 -w2f|--wav2flac wavfile

EOF

exit -1;
elif [[ "$#" -eq 1 || "$#" -gt 2 ]];then
  wav="${1%%.*}.wav"
  mp3="${1%%.*}.mp3"
  #echo "$wav"
  #exit;
  opt="-b 320 --preset standard --add-id3v2"
  #function opt_chk
  #{
  [ -n "$2" ] && opt+=" --tt $2"
  [ -n "$3" ] && opt+=" --ta $3"
  [ -n "$4" ] && opt+=" --tl $4"
  [[ -n "$5" && -f "$5" ]] && opt+=" --ti $5"
  #echo -e "$opt\n"
  #}

elif [ "$#" -eq 2 ];then
  wav="${2%%.*}.wav"
  ape="${2%%.*}.ape"
  flac="${2%%.*}.flac"
cat <<-EOF
  $1
  $2
  wav is "$wav"
  ape is "$ape"
  flac is "$flac"
EOF

fi

if [ ! -f `which flac` ];then
  echo -e "flac is not found.\n"
  exit;
fi
if [ ! -f `which lame` ];then
  echo -e "lame is not found.\n"
  exit;
fi

if [ ! -f `which mac` ];then
  echo -e "mac is not found.\n"
  exit;
fi

# flac -> mp3, 320k
function flac2mp3
{

  if [ -f "$1" ];then
    #echo -e "$1 -> $mp3\n"
    flac -d -f "$1" && lame "$opt" "$wav"
    rm -iv "$wav"
  else echo -e "file $1 is not found.\n";
  fi
}

# ape -> mp3, 320k
function ape2mp3
{
  #echo "$wav"
  #exit;
  if [ -f "$1" ];then
    #echo -e "$1 -> $mp3\n"
    mac "$1" "$wav" -d && lame "$opt" "$wav"
    rm -iv "$wav"
  else echo -e "file $1 is not found.\n";
  fi
}

# wav -> mp3, 320k
function wav2mp3
{
  if [ -f "$1" ];then
    #echo -e "$1 -> $mp3\n"
    lame "$opt" "$wav"
    rm -iv "$wav"
  else echo -e "tools lame or audio file $1 is not found.\n";
  fi
}


# ape -> flac
function ape2flac()
{
  #echo "$flac $wav $ape"
  #echo "$1 $2"
  ##shift;
  #echo "$1 $2"
  #echo "$flac $wav $ape"
  #exit;
  if [ -f "$ape" ];then
    echo -e " $ape -> $flac....\n";
    mac "$ape" "$wav" -d && flac "$wav"
    rm -iv "$wav"
  else echo -e "file $1 is not found.\n";
  fi
}


# flac -> ape
function flac2ape()
{
  #shift;
  if [ -f "$flac" ];then
    echo -e "$flac -> $ape....\n";
    flac -d -f "$flac" && mac "$wav" "$ape" -c2000;
    rm -iv "$wav"
  else echo -e "file $1 is not found.\n";
  fi
}

# wav -> ape
function wav2ape()
{
  #shift;
  if [ -f "$wav" ];then
    echo -e "$wav -> $ape....\n";
    mac "$wav" "$ape" -c2000;
    rm -iv "$wav"
  else echo -e "file $1 is not found.\n";
  fi
}

# wav -> flac
function wav2flac()
{
  #shift;
  if [ -f "$wav" ];then
    echo -e "$wav -> $flac....\n";
    flac "$wav"
    rm -iv "$wav"
  else echo -e "file $1 is not found.\n";
  fi
}


#export -f flac2mp3 ape2mp3 wav2mp3



case ${1##*.} in
  -h|--help)
    echo "usage: w2mp3 <.flac|.wav|.ape file>";;
  ape)
    ape2mp3 "$1";;
  flac)
    flac2mp3 "$1";;
  wav)
    wav2mp3 "$1";;
  -f2a|--flac2ape)
    flac2ape "$2";;
  -a2f|--ape2flac)
    ape2flac "$2";;
  -w2a|--wav2ape)
    wav2ape "$2";;
  -w2f|--wav2flac)
    wav2flac "$2";;
  mp3|aac|m4a|*)
    echo -e "$1 is not a wav|ape|flac file. please check the audio file."
esac

unset -f flac2mp3 ape2mp3 wav2mp3 ape2flac flac2ape wav2ape wav2flac
unset opt wav flac ape
#unset -f opt_chk

