#  ffmpeg[^ffmpeg]：视频、音频读取、转换、生成工具

> 分割视频：

```Bash
ffmpeg -i 2264.mp4 -vcodec copy -acodec copy -ss 00:00:00 -to 00:21:32 2264_test.mp4
ffmpeg -i in.mp4 -vcodec copy -acodec copy -ss 00:00:00 -to 00:18:50 out.mp4
ffmpeg -i in.mp4 -vcodec copy -acodec copy -ss 00:18:50 out.mp4
```

+ 合并，连接、拼接视频：`ffmpeg -f concat -i flie.list -c copy 08.mp4`

============= file.list ============
```
file: xxx.mp4
file: xxx1.mp4
file: xxx2.mp4
file: xxx3.mp4
```

> mp4 批量转换到 mkv：

```Bash
for i in `file *.mp4|grep -i 'mp4 v2'|cut -d: -f1`;do ffmpeg -i "$i" -f matroska "`echo $i|sed 's/\.mp4/.mkv/g'`";done
```

+ 视频输出到 gif：`ffmpeg -i compiz.mp4 -ss 46 -t 5 -f gif compiz_exo.gif`

+ 录屏： `ffmpeg -f x11grab -s wxga -r 25 -i :0.0 -qscale 0 screensaver.mkv`

+ 提取视频中的音频：`ffmpeg -i xx.mp4 -acodec copy xx.aac`

+ 读取、转换 flac 到 ape： `ffmpeg -i song.flac song.ape` `ffmpeg -i song.ape song.flac`

[^ffmpeg]: 也许有一天，你用上了`Linux`，并希望在那上面处理一下多媒体文件（比如：读取、转换、提取多媒体文件的文件流……），那你一定要花点时间试试`ffmpeg`[^1]。我真的很希望你可以相信我：因为它是基于命令行的工具而非具有`GUI`，选项也多到不行（或许其中的一些选项你未必有用的上的一天），但它在`Linux`上[^2]处理多媒体文件被证实真的很厉害很有优势。这也就意味着：如果你仅仅需要完成一些小小的任务（比如：提取分割？转换音视频格式……），那所要进行了解、知道的选项仅仅只有那么几个。真的，我不开玩笑。

[^4]: 好了，很不好意思，让大家浪费这么多时间来阅读这么些无聊的东西，我只是希望能通过文字传达一点个人的看法而已（毕竟言论自由嘛），还请大家原谅则个……

[^1]: [ffmpeg](https://)

[^2]: 虽然`ffmpeg`是基于`Linux`的，但它也有`Windows`版本的……
