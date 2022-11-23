<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# [avconv](https://libav.org/download/)

::: alert-info

> 编译：首先安装 nasm

```Bash
#./configure --prefix=$HOME/.local/libav --bindir=$HOME/bin && make -j4 && make install
./configure && make -j4 && sudo make install
```

:::

+ 以根用户录制 tty 数据： `avconv -f fbdev -r 30 -i /dev/fb0 tty1.avi`

参考：

+ [11个'Avconv'命令来记录，转换和从Linux终端提取视频和音频][avconv]

[avconv]: https://www.howtoing.com/avconv-command-examples