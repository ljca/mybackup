# ntfs-util: NTFS 工具集

`sudo blkid`

```
/dev/sda1: SEC_TYPE="msdos" LABEL="ESP" UUID="0000-4823" TYPE="vfat" PARTLABEL="EFI System Partition" PARTUUID="69d56666-9053-4130-b728-c551d84346f1"
/dev/sda2: LABEL="windows8.1" UUID="E2D09041D0901DBB" TYPE="ntfs" PARTLABEL="Basic data partition" PARTUUID="5955e854-8a49-4b4a-bb1a-9fb22e8437c4"
/dev/sda3: LABEL="Arch" UUID="ae912fc6-72dc-4fd3-80a0-d799dd919f33" TYPE="ext4" PARTUUID="d7775fc6-2a52-400b-a39b-b15d78ca4af5"
/dev/sda4: LABEL="Fedora" UUID="4d43cf85-d29c-43ee-bb08-657a246004a4" TYPE="ext4" PARTUUID="070a565f-1ad6-4d62-9114-f66007fb6e9f"
/dev/sda5: LABEL="Gentoo" UUID="54e88760-50fa-4bd9-b423-4f3da369237d" TYPE="ext4" PARTUUID="2409e23b-bb72-4877-a5b7-0d67658522db"
/dev/sda6: LABEL="Lfs" UUID="fe31d6fa-344d-49a8-ad09-8a6475edb4e9" TYPE="ext4" PARTUUID="49681ac5-5049-4343-864c-adcb2973cbf7"
/dev/sda7: LABEL="Home" UUID="310e162d-b839-46a2-afe4-daaef5930d51" TYPE="ext4" PARTUUID="c45793da-843b-4b88-99e9-ccf40dd9377d"
/dev/sda8: LABEL="Applications" UUID="0000678400004823" TYPE="ntfs" PARTLABEL="Basic data partition" PARTUUID="3b7f0983-87cf-46fb-9b33-dc8918fda6d6"
/dev/sda9: LABEL="Others" UUID="70D35C2C1C8ED47A" TYPE="ntfs" PARTLABEL="Basic data partition" PARTUUID="67a250b5-86c1-40ae-b574-0a144c5cf8b9"
/dev/sda10: LABEL="Swap" UUID="097f25f0-ceb5-4510-aa5a-cd1760969406" TYPE="swap" PARTLABEL="Linux swap partition" PARTUUID="4341375d-0f64-4368-a565-cb150999ef7c"
/dev/loop0: LABEL="Ext4" UUID="69fab154-0de1-4747-b12b-e8e73e41600b" TYPE="ext4"
/dev/loop1: LABEL="Xfs" UUID="ced03b26-bafe-4d0d-b780-5079946b3f69" TYPE="xfs"
```

`sudo ntfsfix /dev/sda8`


```
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

`sudo ntfsundelete /dev/sda9 -m "*.mp4"` [output](ntfsundelete.log)


```Bash
sudo ntfsundelete /dev/sda9 -u -i `sudo ntfsundelete /dev/sda9 -m "*.mp4"|sed '1,2d;/^$/d;$d'|cut -d" " -f-1|xargs|tr ' ' ','` -d ./tmp
```

[output](ntfsundelete.log)

```Bash
for d in $(for i in `find ../video/ -type f -size 0 -name "*.mp4"`;do basename $i;done|xargs);do cp -ibv "$d" ../video/1069/;done`
```
