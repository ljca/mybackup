<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# `LVM`：逻辑卷管理

> ***~~为了方便调整某个分区的大小，有人发明了逻辑卷。 然而，要进行逻辑卷管理，我们必须要先创建好 `物理卷（PV)` 、`卷组（VG）` 、`逻辑卷（LV）`，才能进行诸如调整大小、快照等卷管理活动。~~***

！在创建 LVM 之前，需要先启动 LVM 服务。

***~~物理卷位于`LVM`逻辑卷最底层，所以在创建逻辑卷时应该最先被创建。 `pvcreate `~~***

`vgcreate`

`lvcreate`

`pvdisplay/vgdisplay/lvdisplay`

> 参考： 

+ [LVM (简体中文) - ArchWiki][lvm]

[lvm]: https://wiki.archlinux.org/index.php/LVM_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
