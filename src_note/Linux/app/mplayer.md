<link href="../../css/style.css" rel="stylesheet" type="text/css" />


# [mplayer](http://mplayerhq.hu/design7/dload.html)[^mplayer]

# 附：
## 从源码编译安装 mplayer

```Bash
./configure --prefix=/usr/local --enable-menu --enable-gui --enable-x11 --enable-debug
make && sudo make install
# 皮肤安装：
sudo tar --xattrs -xf Blue.tar.bz2 -C /usr/local/share/mplayer/skins/
sudo mv /usr/local/share/mplayer/skins/{Blue,default}
```

## mplayer 常用快捷键 & 播放技巧

+ Enter: 跳转到下一个
+ 空格/p: 暂停/播放
+ 上下左右方向键: 快进/快退
+ o：显示时间信息
+ I：查看播放文件
+ f：全屏播放
+ [/{
+ ]/}：调节播放速度
+ /：调低播放时音量
+ *：调高播放时音量
+ `<`：上一个
+ `>`：下一个
+ d：启用/禁用硬件加速
+ _：隐藏播放界面
+ -：
+ `(`：

> 播放技巧：

+ 后台播放[^1]: `mplayer test.mp4 < /dev/null &> /dev/null&`
+ 后台播放多个文件: `\ls*.mp4 > mp4_list; mplayer -playlist tmp4_list < /dev/null &> /dev/null&`
+ 循环播放 -loop选项: `mplayer -loop 0 test.mp4 < /dev/null &>/dev/null&`
+ 选择其它解码器播放

[^mplayer]: mplayer 从终端启动，运行速度很快。甚至还支持在 fbterm 上播放多媒体视频文件。
[^1]: `</dev/null &>/dev/null` 屏蔽标准输入、标准输出、标准错误。
