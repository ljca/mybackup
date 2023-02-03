<link href="../css/style.css" rel="stylesheet" type="text/css" />

# find与xargs：

## find[^find]：文件搜索……

[^find]: 因为 find 复杂的命令行参数组合和磁盘 I/O 占用，现在更常用的是 fd 或者 fzf 或者是 [locate](#locate).

> 指令中的括号约定：

<> 表示必选项，{} 表示从多个项中必须选择一项，[] 表示可选项

```Bash
find [path] [options] [command & options] # 除非不指定任何选项，否则必须指定 path 并紧跟在 find 后，所有选项之前……
```

> 常用的 find 搜索 Optios[^option]： 
 

+ -name "" 根据指定的表达式查找
+ -type {type} 根据指定的类型查找

> type 可以是：

+ f 普通文件
+ d 目录文件
+ s socket 文件
+ l 链接文件
+ c 字符设备文件
+ b 块设备文件
+ -time 
+ -size[^size] [+/-]size 根据指定的大小查找（这也许仅限于普通文件）
+ -mtime 
+ -perm permision number 根据指定的权限数字来查找

[^size]: size 后可以直接跟一个文件大小的单位，比如 K、M、G……如果希望查找大于 size 的文件，在指定的大小 size 前置一个'+'号，反之置'-'号

```Bash
find . -type f -perm 0755  # 比如在 Ext 系列文件系统上，可以用这个选项来查找那些可执行的普通文件。
```

> find command & options

```Bash
find [主命令及主命令选项] [附加指令及附加指令选项]
```

> find 附加指令及附加指令选项

```Bash
find <> 附加指令 {} ;  # 此处的 {} 表示find 查找的文件集合……，末尾处的分号在使用时要使用单引号或者转移符去引用。
```

+ -exec 
+ -print
+ -rm
+ -ask

[^option]: 如果你希望组合条件，-a 或者 -o， 那么务必要使用圆括号将它们包围起来，由于圆括号会被 shell 解释，圆括号也要转义，条件与圆括号之间还要留空。就像这样子：`\( -name "" -o -name "" \)`

## [locate](#locate)[^locate]

```Bash
locate "reg"
```

[^locate]: locate 位于 mlocate 软件包中。使用前需要使用 updatedb 更新数据库。

## which：定位指令在系统中的路径[^which]……


[^which]: which 无法定位命令别名……

## xargs[^xargs]


> xargs 常用选项

+ -n
+ -I/-i -I{}[^-i]

```Bash
xargs

```

[^xargs]: xargs 可以在 I/O 流后直接使用，大多数直接跟在管道后将输出传递给下一指令。xargs 的 -I 选项可以解决文件名中带有特殊字符的文件。
[^-i]: 这个选项后的{}表示文件列表。
