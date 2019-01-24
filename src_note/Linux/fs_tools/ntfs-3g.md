# ntfs-3g[^ntfs]: NTFS 驱动 & 工具集

+ ntfsfix[^fix]：NTFS 分区检查工具， `sudo ntfsfix /dev/sda8`

```log
Mounting volume... The disk contains an unclean file system (0, 0).
Metadata kept in Windows cache, refused to mount.
FAILED
Attempting to correct errors...
Processing $MFT and $MFTMirr...
Reading $MFT... OK
Reading $MFTMirr... OK
Comparing $MFTMirr to $MFT... OK
Processing of $MFT and $MFTMirr completed successfully.
Setting required flags on partition... OK
Going to empty the journal ($LogFile)... OK
Checking the alternate boot sector... OK
NTFS volume version is 3.1.
NTFS partition /dev/sda8 was processed successfully.
```

`pacman -Fyy`，`pacman -Fs ntfsundelete`，`pacman -S ntfs-3g`

+ ntfsundelete[^fix]：恢复在 NTFS 文件系统上误删的文件。 `sudo ntfsundelete /dev/sda9 -m "*.mp4"` [output](ntfsundelete.log) [output](ntfsundelete.log)

```Bash
sudo ntfsundelete /dev/sda9 -u -i `sudo ntfsundelete /dev/sda9 -m "*.mp4"|sed '1,2d;/^$/d;$d'|cut -d" " -f-1|xargs|tr ' ' ','` -d ./tmp
```

```Bash
for d in $(for i in `find ../video/ -type f -size 0 -name "*.mp4"`;do basename $i;done|xargs);do cp -ibv "$d" ../video/1069/;done`
```

[^ntfs]: 虽然 Linux 内核已经提供了 NTFS 模块，但只能读取 NTFS 文件而不支持写入。如果想要在 NTFS 上创建、删除、更新文件，还要在 Linux 上按安装 ntfs-3g。ntfs-3g 软件包不仅提供了支持 NTFS 读取/写入的模块，还提供了一系列用于 NTFS 的工具集。

[^fix]: 似乎要运行的更快更高效。
