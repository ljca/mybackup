<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# Thunar 显示 mp3 文件缩略图[^mp3]

[^mp3]: 本次在 Arch Linux 上测试。

::: alert-info

> 以-dd 选项移除系统源中的 tumbler，并重新编译 tumbler[^编译]，同时从 aur 安装 ffmpeg-audio-thumbnailer 或者在 `/usr/share/thumbnailers` 创建一个缩略图文件项：ffmpeg-audio-thumbnailer.thumbnailer

:::

```ini
[Thumbnailer Entry]
TryExec=ffmpeg
Exec=ffmpeg -i %i %o -fs %s
MimeType=audio/mpeg;audio/flac;audio/wavpack;audio/webm;audio/mp4;audio/aac;audio/x-matroska

```
![Thunar 显示部分音频文件缩略图](images/20221218215637126_261467503.png)

> 目录显示封面

以-dd 选项移除系统源中的 tumbler，并重新编译 tumbler[^编译]，同时从 aur 搜索、安装 folder-thumbnailer

```ini
[Thumbnailer Entry]
Version=1.0
Encoding=UTF-8
Type=X-Thumbnailer
Name=Folder Thumbnailer
MimeType=inode/directory;
Exec=/usr/bin/folder-thumbnailer %s %i %o %u

```

[^编译]: 依赖项根据需要解决。


