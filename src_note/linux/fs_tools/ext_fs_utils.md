<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# §. Ext文件系统工具

+ badblocks
+ chattr

```Bash
chattr [Options] +-=[Aais..]
a:如果将这个选项对文件应用
！只有根用户才有权限使用这个命令更改文件或者目录的隐藏属性。一旦对目录应用了某个属性，将对所有用户生效(包括根用户)。
如果将这个属性对文件应用，那么被应用属性的文件只能以重定向追加的方式写入内容，不允许被删除，更新，移动。
！如果将这个属性对目录使用，则只允许创建文件和子目录，而且该目录下的文件只能以重定向追加的方式写入内容。但不允许对目录和文件有删除,移动，和更新的行为。
i:如果将这个属性对目录或者文件直接应用，那么将不能对文件或者目录进行任何操作，这些操作包括移动(包括重命名)，删除，更新(创建子目录，文件)
s:让文件或者目录在移除时可以被彻底删除并释放空间
```

+ compile_et
+ debugfs
+ dumpe2fs
+ e2freefrag
+ e2fsck
+ e2image
+ e2label
+ e2undo
+ e4crypt
+ e4defrag
+ filefrag
+ fsck.ext2
+ fsck.ext3
+ fsck.ext4
+ logsave
+ lsattr：显示文件的隐藏属性。用法：

```Bash
lsattr Options file/Directory
Options:
-d:只显示指定的目录的隐藏属性
-a:显示所有文件或者目录的隐藏属性
```

+ mk_cmds
+ mke2fs
+ mkfs.ext2
+ mkfs.ext3
+ mkfs.ext4
+ mklost+found
+ resize2fs
+ tune2fs

# 附

+ [数据恢复工具](../recovery_data.md)
