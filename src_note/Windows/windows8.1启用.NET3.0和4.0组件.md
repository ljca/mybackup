# Windows 8.1 启用 .NET Framework 组件[^.net]

**&nbsp;&nbsp;在 `Windows更新服务`不好使或者`没有网络的状态下`可以直接使用 win8.1 的安装媒体（光盘，U 盘，iso 镜像）启用[^method] .NET 组件：首先挂载 iso 镜像，然后`以管理员权限运行命令提示符`使用 `Windows 部署工具：dism` 部署即可。**

[^.net]: `.NET Framework` 框架是 windows 上一组很重要的组件或者说运行时环境（实际上，它为用它实现的程序提供了运行时需要的库），它提供了某些应用程序和游戏运行时支持，如果你在运行一个程序时收到了 `需要安装 .NET Framework...` 类似的警告和提示，那就表明你的系统中没有安装 Windows 的这个功能。为了启用 windows  .Net Framework. 组件，你需要在 Windows 的程序和功能组件中安装这些更新（当然，你同样可以选择从他们的官网下直接下载这个组件然后运行安装程序来安装）。不过启用 windows 功能和更新需要联网，因此请确保网络畅通。另外，某些刚出厂的win8系统已经默认开启....

[^method]: 你可以直接直接在开始菜单上用鼠标右键 (或者按住键盘上的 windows 徽标键不放的同时按下键盘上的 X 键）然后选择程序和功能 >> 启用或关闭windows 功能 >> 最后勾选上带有 .NET 字样的选项然后只需要耐心等待就行了。如果一切顺利的话，那么windows 更新将会要求重启系统完成更新。这需要连接到网络。~~***然而，操作系统自带的 .NET 组件实际上只能满足少部分程序的运行要求，很多程序以及旧版本的 .Net 组件和运行库常常需要到微软官网或者其它网站自行下载后安装到系统***~~。。。。
