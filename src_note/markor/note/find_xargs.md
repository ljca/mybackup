<link href="../css/style.css" rel="stylesheet" type="text/css" />

# find & xargs 笔记

[^]: 在使用一些 Unix / Linux 工具集时，如果希望对 I/O 流或者文件中的每一行结果都执行同一指令，配合 xargs 的 -i 或者 -I 选项可以很容易地解决文件名中有特殊符号的问题。eg: `file *.lrc|grep -iE iso|cut -d: -f-1|xargs -I{} iconv -fcp936 -tutf-8 -c '{}' -o '{}'`。


[^]: 不幸的是：find 在检索磁盘上的文件时相当占用操作系统的文件 I/O。所以，如果只是随便找个文件，一般使用 locate 或者其它工具。

[^]: 首先使用 `dircolors -p > ~/.dircolors` 导出默认设定。做细微调整后 `eval "$(dircolors -b ~/.dircolors)"`，因为 `dircolors -b` 并不会真正执行 shell 指令，所以还要对其 eval 一次。
