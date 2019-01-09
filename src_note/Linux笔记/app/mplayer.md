#  mplayer
mplayer
mplayer下载地址：
http://mplayerhq.hu/design7/dload.html
mplayer编译选项
./configure --prefix=/usr/local --enable-menu --enable-gui --enable-x11 --enable-debug
make&&sudo makeinstall
皮肤安装：
sudo tar --xattrs -xf Blue.tar.bz2 -C /usr/local/share/mplayer/skins/
sudo mv /usr/local/share/mplayer/skins/{Blue,default}
mplayer后台播放技巧
mplayer test.mp4 < /dev/null &> /dev/null&
后台播放多个文件的技巧
\ls*.mp4 > mp4.list
mplayer -playlis tmp4.list < /dev/null &> /dev/null&
循环播放 -loop选项

mplayer -loop 0 test.mp4 < /dev/null &>/dev/null&
选择其它解码器播放
 
常用快捷键
Enter: 跳转到下一个
空格/p: 暂停/播放
上下左右方向键: 快进/快退
o：显示时间信息
I：查看播放文件
f：全屏播放
[/{
]/}：调节播放速度
/：调低播放时音量
*：调高播放时音量
<：上一个
>：下一个
d：启用/禁用硬件加速
_：隐藏播放界面
-：
(：
 
