#  asciinema：高级的终端会话记录和回放工具
##  安装

&nbsp;&nbsp;[asciinema][asciinema] 是一个用 python 实现的程序，主要用于录制和回放终端会话（可以是 asciiname 网络上的，也可以是本地的）[^0][^1]。因此它没有太多的依赖，大多数较新的 Linux 发行都在官方源包含了这个工具，只需要使用包管理器就能直接安装它。 如果没有在官方源中找到这个工具，[asciinema][asciinema_install]网站上已经提供了较详细的安装教程，[git][asciinema_git]上也提供另外的安装方法。当然，如果是在 Linux 上，还可以直接使用 pip3/pip 安装 `sudo pip3 install asciinema`


```
Collecting asciinema
  Downloading asciinema-1.4.0.tar.gz
Installing collected packages: asciinema
  Running setup.py install for asciinema ... done
Successfully installed asciinema-1.4.0
You are using pip version 8.1.1, however version 9.0.1 is available.
You should consider upgrading via the 'pip install --upgrade pip' command.
```

> Tip：除非是内建指令，否则一般的命令行工具大多都提供有基本用法（`--help`选项）及手册。

## 录制终端会话
&nbsp;&nbsp;`asciinema` 比起 `script` 来说简单的太多了(第一次使用 script 时我有点不知所措，因为 script 录制时产生的时序信息是以标准错误产生的，如果不将它们单独重定向到一个文件中(后来才知道可以使用长参数避免这个问题)，它们不仅会发送到终端窗口上而让终端一片混乱，还会导致 script 录制的终端会话 scriptreplay 无法回放)，仅仅需要打开一个终端窗口，然后运行 `asciinema rec [localfile]`

> Note：

&nbsp;&nbsp;asciinema 使用 json 格式记录终端会话和时序信息。如果在命令行上没有指定本地文件名，则默认将会保存到 asciinema 网站上。即便如此，asciinema 在录制完毕(按下 Ctrl D 或者键入 exit 之后)仍然会询问是否将录制的会话文件上传到 asciinema 网站上。权衡是否会泄露隐私后再做打算，因为 asciinema 提供了单独上传的选项。 上传录制的会话文件： `asciinema upload localfile`。如果上传成功，`asciinema`将会返回一个 asciinema 上的[网络地址][addr]。在终端，你可以通过`asciinema`直接使用这种地址进行会话回放，不过这需要网络。另外，如果你尝试在浏览器中访问上述类似的地址或者是 asciinema 网站上的，没有意外的话将会出现一个播放器一样的东西，你可以尝试点击中间那个播放按钮看一看会发生什么事（你也许会觉得那很眼熟，它看起来就像是在用 HTML 5 播放视频）。


## asciinema 回放终端会话
&nbsp;&nbsp;与录制相似，不过 asciinema 并不需要单独的时序文件(因为所有的时序信息和终端输出信息使用了一种叫做 json 的格式保存在了同一个文件中)，回放时仅仅需要提供一个会话文件就行了，这可以是本地的会话文件，还可以是 asciinema 网站上的。 回放会话，file 可以是一个本地由 asciinema 录制成的 json 文件，还可以是一个 asciinema 网址。 `asciinema play [file]`

> Note：

 &nbsp;&nbsp;虽然`asciinema`作者声称自己提供了一个很酷的功能，那就是可以直接借助于`asciinema-player`脚本和样式表在本地编写一个简单的 HTML 5 文档之后，然后尝试在本地浏览器上访问（据说这不需要有网络连接）它就可以观看到那种类似于 HTML 5 视频播放的效果。但遗憾的是，这在我的 Linux 计算机上似乎不能正常工作。

&nbsp;&nbsp;另外，asciinema 还提供了一个可以管理 asciinema 个人账户所拥有的会话文件的功能，但我对此并不感兴趣。假如你对此有兴趣的话，可以直接参考： `asciinema auth -h`。 

[asciinema]: https://asciinema.org

[asciinema_install]: https://asciinema.org/docs/installation#installing-on-linux

[asciinema_git]: https://github.com/asciinema/asciinema

[addr]: https://asciinema.org/a/85ynwuypwontp7qake9qtc1rt

[^0]: &nbsp;&nbsp;虽然说`asciinema`和`script` 这两种工具都可以录制终端会话，然而 asciinema 似乎表现得技高一筹：script 录制的终端会话不仅需要用两个文件来存放，而且还需要单独的工具 scriptreplay 进行回放。它也不能存放到网站上。asciinema 在录制与回放时使用的都是同一个工具和文件，并不需要使用另外的文件来记录时间序列。也不需要使用另外的工具来回放会话。不仅如此，它还可以播放来自 asciinema 网站上的会话文件。而 `script` 可以借助于管道来同步显示输出，而 `asciinama` 做不到这一点。***但是很遗憾，`asciinema` 似乎并不支持记录终端中的交互式会话。比如 mysql，python 等。***

[^1]: &nbsp;&nbsp;虽然屏幕录制工具录制的视频多姿多彩，基本上在屏幕上能见到的和听到的都可以在其中找到。然而，这样做的代价是录制过程中需要占用不低的 cpu 资源以及录制后也因为视频文件太大不太好在网络之间传送与分享从而交换信息，或许，初衷并不一定就是要将所有的东西都录进去呢。
