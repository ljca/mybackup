# mocp[^mocp]：Linux 上的一个轻量级命令行音乐播放器。

> **`它至少支持下列音频格式：`**

 - [x] flac
 - [x] ape
 - [x] mp3
 - [x] aac,m4a,……

-----------------------------------

## Install mocp from system mirrorlist 

+ 基本上很多 Linux 发行的官方仓库中已经包含了这个软件包[^mocp_tray]，因此安装的话直接使用默认的软件包管理工具安装就行了。如果你需要自定义特性及其支持，那么你可以选择手动编译……


##  ![](images/1543757688_489799211.png)mocp Configure 

### 1. mocp 配置[^start]文件[^config]

![](images/1543757935_1545699836.png) 如果你希望对 mocp 进行配置，那么在配置 mocp 之前，从 moc 的帮助页`mocp --help`，man 手册页`man mocp`或者 info 页`info mocp`获取更多的信息(比如，基本使用方式？配置文件又是什么？从哪里可以找到？应该放到什么位置？格式应该是什么样的......)就是有必要的。

```Bash
 mkdir ~/.moc 
 cp $(locate config.example) ~/.moc/config 
```
 
命令行上的 -O 选项能覆盖任何配置文件中的选项！


```Bash
mocp -O AutoNext=no -O messagelingertime=1 -O XTerms+=xxt:xwt 
```

========== ![](images/1543758336_1061117187.png) [~/.moc/config](.moc/config) ========== 
 
### 2. mocp 键盘映射配置 
![](images/1543757663_1255876179.png)假如你不喜欢`mocp`的默认键盘映射，你可以将其中的部分键盘映射通过配置文件改成自己喜欢的。&nbsp;&nbsp;关于`mocp`键盘映射，在`$prefix/share/moc/keymap.example`（`$prefix` 一般是 /usr 或者 /usr/local）可以找到，mocp 最终的键映射可以直接在 mocp 界面按 h 或者 ? 获得。mocp 键盘映射文件名需要和 mocp 的配置文件中的 Keymap 字段定义一致。下面这个是我的：

========== ~/.moc/keymap ==========  

```ini
menu_up            = k UP 
menu_down        = j DOWN 
menu_page_up            = ^b PAGE_UP 
menu_page_down        = ^d PAGE_DOWN 
menu_first_item        = M-b HOME 
menu_last_item        = M-d END 
```

----------------------------------------------------------------------------------------------------
### 3. mocp 主题[^mocp_theme]：如果你希望调整一下显示效果的话。

> 如果你决定自定义 mocp 外观，那么首先创建 ~/.moc/themes 目录以及拷贝主题骨架文件：
 
```Bash
 mkdir -pv ~/.moc/themes 
 cp /usr/share/moc/themes/moca_theme ~/.moc/themes/user_moca_theme  
```

&nbsp;&nbsp;然后根据需要进行调整：

========== ![](images/1543758428_368853186.png)[~/.moc/themes/user_moca_theme](.moc/themes/user_moca_theme) ========== 

通常只需要简单的改改就行了。

```config
background        = white    default bold     
frame            = white    default bold     
window_title        = yellow    default    bold 
directory        = white        default 
selected_directory    = white        default bold 
playlist        = white default 
selected_playlist    = cyan        default    bold 
file            = green default bold 
selected_file        = white black bold 
....... 
```

&nbsp;&nbsp;随后在配置文件中永久设定。

##  mocp 基本使用[^usage]

+ 添加音乐到播放列表？按下制表符切换到文件列表面板，选好了的话 Shift A 添加整个目录或者按下 a 仅添加单个音频文件，还可以按下回车直接进行播放。
+ b/n 上一首与下一首，p/Space 播放与暂停
+ G 回到当前播放文件所在的地方，i 去往一个目录，U 回到上级目录
+ q/Q 退出 mocp 界面/退出 mocp 并停止 mocp 服务。只要位于 mocp 界面，随时可以使用 h 或者 ? 来获取更多的播放控制键。

## osdlyrics[^osdlyrics]

![](images/1543758591_1647209463.png) 虽然 mocp 声称自己可以在控制台上加载歌词(但我发现，这仅限于那些 utf-8 编码的 ascii 文本(纯英文)，而且不支持同步滚动)，假如你和我一样真的需要一个能加载歌词（包括桌面歌词）的软件的话，倒是可以尝试一下`osdlyrics`。

> `mocp` & `osdlyrics`：

![](../images/1543756533_1573776349.png)

## moc 在 Fedora 上运行出现的一个错误...... 

```
WARNING: The following fatal error message may be bogus! 
If you have an empty /etc/popt.d directory, try adding an empty file to it.  
If that does not fix the problem then you have a genuine error.
```

![](images/1543758613_1737871373.png) FATAL_ERROR: Error reading default POPT config file: 
这个错误很好解决，你只需要创建一个空的文件到这个目录即可。以根用户权限执行：

```Bash
 mkdir -pv /etc/popt.d
 touch /etc/popt.d/mocp.conf
```

ljca&copy; 2017-?

[0]:  https://wiki.archlinux.org/index.php/Arch_Linux_Localization_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)

[^1]: ~~我无意教唆别人学`极客`，虽然在某些时刻，我也挺喜欢`Unix 哲学`的。~~

[^cmd_music]: ~~也许，命令行音乐播放器不具备许多图形界面音乐播放器的某些花哨的功能，但请相信我，如果你需要的仅仅是一个本地音乐播放器，那么，那些图形界面的音乐播放器所具备的基本功能，在你将它配置完成了之后也是会有的，真的。最重要的是：它对内存的要求真的比图形界面音乐播放器少太多了。如果你对带有图形化界面的音频播放器的高内存占用真的有些不感冒，在`Linux`的世界又喜欢折腾不息，生命不止，那你不妨鼓起勇气，去试试命令行音乐播放器。~~

[^mocp]: ***~~mocp 是一款运行在 Linux 终端（终端 TTY 和伪终端 PTY)上的本地音乐播放器（据我所知，cmus 是另外一款有名的命令行音乐播放器，它的功能貌似要比 mocp 强一些，配置也稍简单一点。虽然不知道 cmus 是否可以支持使用 osdlyrics 加载桌面歌词，但毫无疑问，mocp 是可以的），假如有 gpm 的话貌似还可以在终端上使用鼠标。~~***

[^mocp_tray]: ![](images/1543757709_1159148631.png) ~~假如你希望 mocp 可以像某些应用程序一样能有一个图标停靠在面板上并能通过这个图标对播放器进行控制的话，那就需要将 moc 的 tray 版本一起安装到系统（虽然它只是一个封装），它允许在启动时直接启动 mocp 服务和播放器并停靠在面板上。你可以通过它在停止/播放/暂停/退出、下一首/上一首等动作中切换，不过其中的一些动作需要在 mocp 中配置播放列表才能得到正确响应。~~

[^3]: ~~因为是基于 ncurses 库的，所以它在黑乎乎的 Linux 核心控制台(字符界面)上也能工作的很好。然而：Linux 核心控制台默认是没有中文支持的，但假如你是在 fbterm (因为 fbterm 是直接从核心控制台启动的，不需要运行 X 服务)上运行的，字体又配置好了的话却能获得不错的体验（需要一番手动配置才行，如果你的全是英文歌曲的话就不用太在意这些小细节了）。~~

[^tags]: ~~可能会发现一些音频文件在 mocp 播放列表中总是乱码。别担心，这是因为 mocp 启动时会读取音频文件的 ID 标签（包括标题，歌手，专辑等信息）并显示在播放列表，如果你有一些音频文件来自于 Windows 而且又是中文歌曲，因为 Windows 中的音频文件中的 ID 标签所使用的 GBK 字符编码集（如果你的 windows 的系统语言是中文）和 Linux 使用的 UTF-8 字符编码集在编码方式上存在着很大的差异。因此，你可能会发现也许不读取这些确实可以让 moc 的播放列表的文件 ID 标签不乱码，但并不能从根本上（如果你在其它的播放器上打开它可能还是会乱码）解决这个问题……![](images/1543757663_1255876179.png) 希望音频文件 ID 标签[^tags]可以被正常显示，可以尝试在 [Arch wiki 中文化条目][0] 寻找解决方案。~~

[^start]: ~~然而，要启动`mocp`，还需要正确安装和配置了声卡固件（哦，不好意思，可能一些系统和计算机并不需要如此，我这里说的是我的……）和驱动，否则可能会和我的一样连启动 mocp 都不行，^\_^。另外，别怪我没提醒你，`mocp`播放音频是通过插件调用多媒体解码器（如果你发现某一种格式的音频文件无法播放，那很有可能就是因为它所对应的解码器没有安装……）播放音频的，关于多媒体解码器，你可以去 [Arch Linux 的多媒体解码器条目](https://wiki.archlinux.org/index.php/Codecs) 看看。~~

[^config]: ~~虽然可以通过带选项（参数）启动 `mocp` 来测试它的某些功能是否工作正常，但要想对 mocp 的设置可以“永久保存”，还得更新和创建 mocp  的配置文件。mocp 的用户级配置文件是： ~/.moc/config（关于 mocp 详细的参数配置，你可以在它的示例文件 config.example（你可以尝试运行 locate 或者 find 进行查找，而这些，在 moc 的 man 或者 info 页有更详细的介绍））。~~

[^mocp_theme]: ![](images/1543758394_1882100373.png)**~~就算不喜欢 mocp 的默认主题，那也没关系。无论是通过命令行参数还是在启动 mocp 后直接按下 Shift T 都可以重新选择一个主题，当然，如果对系统自带的主题还是觉得不满意，还可以自定义 mocp 主题。默认情况下，mocp 主题被安装到 `$prefix/share/moc/themes` 目录下，自定义的主题文件只对用户生效( ~/.moc/themes 目录下)。mocp 在启动时会根据命令行选项或者用户级配置文件 ~/.moc/config 中指定的主题从 `$prefix/share/moc/themes` 和 ~/.moc/themes 中读取(mocp 主题如果不是放在系统级也不是放在用户级目录下，那就要在 ~/.moc/config 使用绝对路径来指定) 。~~**

[^usage]: ~~毫无疑问，如果你已经配置好了（哦，如果你只是听听音乐的话，这无所谓） mocp，那么它的使用是非常简单的。仅仅只需要在终端提示符后键入 mocp 就能启动 mocp 服务并进入 mocp 播放器界面。~~

[^err]: ![](images/1543758565_780022243.png) ~~如果你的 mocp 要运行在 fbterm 上并且不打算运行 tmux， 不要随意改变终端类型，这样做可能会得不偿失（这样的设定仅仅会改变少部分程序 UI ，但却会让一些基于 ncursers 库的命令行程序（比如 mc 和 alsamixer，mocp 等）的界面变得凌乱……）。 + 假如你真的希望不用改终端类型也能让 fbterm 好看些，*tmux*（应用程序可以在运行了 tmux 的 fbterm 上正常运行和绘制，最主要的是实际内存占用也不算高，但 tmux 需要你熟悉……）可以让你得到图形界面终端模拟器般的体验。~~

[^osdlyrics]:  ~~*`osdlyrics`是一个集下载，加载与显示音频歌词(lrc 格式)的 Linux 通用实现，它支持多种播放器，比如 smplayer，vlc，RhythmCat，moc 等，理论上，osdlyrics 是支持 moc 的，实际上也确实支持，但在加载歌词时却存在卡顿的问题。而且，假如某一首音频文件所对应或者关联的 *lrc* 文件存在着问题（比如：编码格式不被支持）的话，也会让 mocp 直接阻塞，这个时候点击 mocp 时是不会产生响应的。osdlyrics 有两种启动方式，一种是先启动一个 osdlyrics 所支持的播放器（关于它所支持的播放器，当未打开任何播放器时打开 osdlyrics 即可看到)，然后再启动 osdlyrics 时会自动加载音频文件的歌词。另外一种方式就是直接启动 osdlyrics 的同时启动想要启动的播放器，mocp 也支持被这样启动（这同样需要进行设置）。*~~
