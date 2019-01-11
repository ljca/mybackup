#  convert-format

## mp3 编码: lame

动态编码与静态编码 `-b` `--preset`

+ wav --> mp3 `lame -V 0 song.wav` `lame -b 320 song.wav`

## ape 编/解码: mac
+ wav --> ape `mac song.wav song.ape -c2000`
+ ape --> wav `mac song.ape song.wav -d`
+ ape --> mp3

## flac 编/解码: flac
+ flac --> wav `flac -d song.flac`
+ wav --> flac `flac -5 song.wav`
+ flac --> ape 
+ flac --> mp3

## wav 编/解码：
&nbsp;&nbsp;wav 是没有压缩过的无损媒体文件。所以它是直接录制的声音或者是可以从其它无损压缩(flac/ape)媒体解码出来。

## m4a/aac 编/解码：faac

## [avconv](avconv.md)

## [ffmpeg](ffmpeg.md)

## `split2flac`

## `shntools`

+ shnconv `shnconv -i song.flac song.ape`

