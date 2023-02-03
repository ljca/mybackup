

## newfs 

> Create Filesystem: `newfs  -L FreeBSD -O 2 -U -n -j /dev/ada0p4`

```log
usage: newfs [ -fsoptions ] special-device [device-type]
where fsoptions are:
	-E Erase previous disk content
	-J Enable journaling via gjournal
	-L volume label to add to superblock
	-N do not create file system, just print out parameters
	-O file system format: 1 => UFS1, 2 => UFS2
	-R regression test, suppress random factors
	-S sector size
	-T disktype
	-U enable soft updates
	-a maximum contiguous blocks
	-b block size
	-c blocks per cylinders group
	-d maximum extent size
	-e maximum blocks per file in a cylinder group
	-f frag size
	-g average file size
	-h average files per directory
	-i number of bytes per inode
	-j enable soft updates journaling
	-k space to hold for metadata blocks
	-l enable multilabel MAC
	-n do not create .snap directory
	-m minimum free space %
	-o optimization preference (`space' or `time')
	-p partition name (a..h)
	-r reserved sectors at the end of device
	-s file system size (sectors)
	-t enable TRIM
```

checking dir... /boot/kernel `fusefs.ko ext2fs.ko`  is exists..

Mount NTFS: 

- check system load modules: `kldstat`
- load modules: fusefs  `kldload /boot/kernel/fusefs.ko` 

> install ntfs-3g: pkg install ntfs-3g


```sh

# mount: 
sudo mkdir -pv /media/Others
sudo ntfs-3g -o uid=$UID /dev/ada0p8 /media/Others


```



Mount ext2,ext3,ext4:

- load modules `ext2fs`: `kldload /boot/kernel/ext2fs.ko`
- check system load modules: `kldstat`

`mount -t ext2fs /dev/ada0p6 /mnt`

sudo sysrc kldlist+="fusefs ext2fs"

> /boot/loader.conf

fusefs_load="YES"
ext2fs_load="YES"


