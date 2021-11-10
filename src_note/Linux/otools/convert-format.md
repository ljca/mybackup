<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# 在 Linux 上读取、转换、分隔多媒体格式的多媒体工具集

## Audio：音频

+ gnac
+ soundconverter

> mp3 编码[^mp3]: lame

[^mp3]: ，动态编码与静态编码 `-b` `--preset`。wav --> mp3 `lame -V 0 song.wav` `lame -b 320 song.wav`

>  ape 编/解码[^ape]: mac

[^ape]: wav --> ape `mac song.wav song.ape -c2000` ape --> wav `mac song.ape song.wav -d`  ape --> mp3

>  flac 编/解码[^flac]: flac

[^flac]: flac --> wav `flac -d song.flac` wav --> flac `flac -5 song.wav` flac --> ape flac --> mp3

>  wav 编/解码[^wav]：

[^wav]: wav 是没有压缩过的无损媒体文件。所以它是直接录制的声音或者是可以从其它无损压缩(flac/ape)媒体解码出来。

>  m4a/aac 编/解码：faac

+ `split2flac`
+ `shntools`
+ shnconv `shnconv -i song.flac song.ape`

## Video：视频

+  [ffmpeg：视频、音频读取、转换、生成工具](otools/ffmpeg.md)
+ [avconv](otools/avconv.md)
+ [mkvtoolnix：MKV 视频工具](otools/mkvtoolsnix.md)
+ [avidemux: avi 视频工具](otools/avidemux.md)

