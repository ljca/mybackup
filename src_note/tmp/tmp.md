# tmp
Linux 核心控制台自定义
1. 自定义 Linux 核心控制台的光标

```bash
  # http://linuxgazette.net/137/anonymous.html
  # cursor_style_default=0 # hardware cursor (blinking)
  # cursor_style_invisible=1 # hardware cursor (blinking)
  # cursor_style_underscore=2 # hardware cursor (blinking)
  # cursor_style_lower_third=3 # hardware cursor (blinking)
  # cursor_style_lower_half=4 # hardware cursor (blinking)
  # cursor_style_two_thirds=5 # hardware cursor (blinking)
  # cursor_style_full_block_blinking=6 # hardware cursor (blinking)
  # cursor_style_full_block=16 # software cursor (non-blinking)
```

~/.bashrc
```bash
if [ $TERM == "linux" ];then
  cursor_styles="\e[?16;2;112;c" # only seems to work in tty
 PS1="\u:\W \\$ ${cursor_styles}"
endif
```

参考页：
[1](http://www.bashguru.com/2010/01/shell-colors-colorizing-shell-scripts.html)
[2](http://linuxgazette.net/137/anonymous.html)

2. 自定义字体，自定义背景和前景

