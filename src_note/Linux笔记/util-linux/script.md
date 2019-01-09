# 记录终端会话：script

时序输出使用-t或者--timing=制定文件。如果不指定session_file，默认为typescript
o如果使用了短的选项，时序信息会以标准错误的形式发送到终端，必须将它重定向为一个文件才能和session_file配合一起作为scriptreplay的输入文件才能产生播放一样的效果。

```bash
script -t 2>time_save [-a] [session_file]
script -t -af `date +%F`_python 2>`date +%F`_python.time  <===> script --timing=`date +%F`_python.time -af `date +%F`_python
```

# 回放终端回话：scriptreplay

```bash
scriptreplay [-t] time [-s] session
scriptreplay [-t] `date +%F`_python.time `date +%F`_python
```

尽管看起来很原始，而且还使用了两个文件来分别保存时序输出和命令输出。

一个很酷的选型是-f。 -f(--flush)选项可以用来同步一个终端窗口的输入和输出到另一个终端窗口。
在一个终端窗口中创建一个有名管道，并使用cat阻塞：
```bash
mkfifo fifo;cat fifo;
```

打开一个新的终端窗口，运行
```
script -f fifo
```

参见：[asciinema][asciinema]

[asciinema]: ../otools/asciinema.md

