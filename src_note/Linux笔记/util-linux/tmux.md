# tmux

> `一对尖括号 <>` 扩起来的键是键盘上的区分于字母或者数字键的专有键，比如 `<Space> 代表空格键，<C-b> 代表了 Ctrl b，<M-b> 即是 Alt b。

***~~&nbsp;&nbsp;`<prefix>`代表 tmux 全局键，默认为`<C-b>`。根据需要，你可以在 `tmux` 配置文件中自行调整。如果 tmux 工作在 vi 模式，那么所有对 pane 或者 tmux 其它对象操作的按键都需要加上 `tmux 全局键` 才能正常工作。并且，这些操作均可使用 `tmux` 指令完成，如果在 vi 模式（默认），命令模式由 `<prefix>:` 触发。~~***

你可以在 tmux 中按下 `tmux 全局键 ?` 来查看所有 tmux 的键绑定。

常用功能：

> pane 操作：

+ 分割：

`%` 垂直 `split-window -h`

`"` 水平 `split-window`

+ 退出
 `x` 即 `kill-pane`

+ 交换：
`{` 或者 `}` `<==>` `swap-pane -U/-D`

+ layout 切换

`select-layout` layout

> 存在以下几种 layout 可切换：

+ even-horizontal <M-1>
+ even-vertical <M-2>
+ main-horizontal <M-3>
+ main-vertical <M-4>
+ tiled <M-5>


`<Space>` 可自由在几种 layout 中进行切换。

+ 大小调整
`<M-Up> <M-Down> <M-Left> <M-Right>`

等价于：

`resize-pane -L/-R [num]`

`resize-pane -U/-D [num]`

> panel 切换：
`q` 用于列出已经打开的 pane，如果在后跟上编号，即可切换到那个 pane。

`Up` / `Down` `<====>` `select-pane -U` / `select-pane -D`

`Left` / `Right` `<=====>` `select-pane -L` / `select-pane -R`

`;` `last-pane`

不过，你也可以自己在配置文件中定义：

========== $HOME/.tmux.conf ========== 

```config
# 这些指令都是可以在命令模式下工作的。因此，你随时可以在 tmux 命令模式下对它们进行调整。

# j <==> <Down>
unbind-key j
bind-key j select-pane -D

# k <==> <Up>
unbind-key k
bind-key k select-pane -U

# k <==> <Left>
unbind-key h
bind-key h select-pane -L

# k <==> <Right>
unbind-key l
bind-key l select-pane -R

```

> tmux 的 Copy-in 模式。

***~~&nbsp;&nbsp;如果你的 tmux 工作在 vi 模式下，那么只有在 Copy-in 模式，你才能在终端窗口进行上下滚动。它在 vi 模式下的默认键绑定是 `[`。~~***

+ 翻页／滚动：

一旦进入了 Copy-in 模式，就可以使用一些 vim 和 less 的键绑定了，包括翻页的 `<C-u> <C-d> <C-f> <C-b>`。


