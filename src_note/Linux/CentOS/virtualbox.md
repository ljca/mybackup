<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# §.VirtualBox[^virtualbox] 笔记
# §. 附
## Ⅰ. ViratulBox 增强包：

### 1.1 共享文件夹：在主机和虚拟机之间共享与交换文件

> 下载与安装 VirtualBox 增强包

```Bash
# 以根用户权限：

# 确认并挂载 Virtualbox 增强包镜像
ll /dev/cdrom # /dev/cdrom -> /dev/sr0

mount -t iso9660 -r /dev/cdrom /mnt

# 执行安装脚本并重启系统
cd /mnt;./VBoxLinuxAdditions.run
reboot
```

#### 1.1.1 虚拟机中添加共享文件夹

> Note！！！如果选择了自动挂载，系统会在开机时挂载共享文件夹；共享文件夹名称是随意的。

```flow
设置-> 共享文件夹-> 单击添加共享文件夹按钮->  设置共享文件夹路径(物理磁盘路径)-> 设置共享文件夹名称，不能和共享文件夹路径名相同 
```

#### 1.1.2 在系统内测试共享文件夹：

```Bash
mkdir /media/Others
mount -t vboxsf -o rw,uid=$UID,utf8=1 others /media/Others
sudo mount -t vboxsf  Others /media/Others 
sudo mount -t vboxsf -o rw,uid=$UID,gid=500 Others /media/others
```

### 1.2 USB 2.0及以上支持 。

### 1.3 图形界面可完整显示在显示器上。

## Ⅱ. 网络设置：端口转发（仅主机）：
> 网络设置：如果你懒得去理解什么端口转发[^port_fireward]，可以让虚拟机和主机桥接网卡[^brige]。

```flow
st=>start: 管理
op1=>operation: 全局设定
op2=>operation: 网络
op3=>operation: 仅主机(Host-Only)网络
op4=>operation: 点击添加按钮之后virtualbox会自动设置好主机虚拟网络界面的ipv4地址
(这个地址就是用来ssh到的virtualbox中的系统地址(如果已经开启了ssh服务的话))及掩码。
还可以点击编辑按钮手动设置主机虚拟网络界面的ipv4地址及网络掩码
e=>end: 结束
# st->op1->op2->op3->op4->e

```

```flow
st=>start: 选中一台虚拟机，单击工具栏设置
op1=>operation: 网络
op2=>operation: 展开高级
op3=>operation: 端口转发
op4=>operation: 增加一个转发规则并设置主机端口和子系统端口
e=>end: 结束
# st->op1->op2->op3->op4->e
```

##  Ⅲ. vdfuse：Read/Mounting VirtualBox disk images (VDI/VMDK/VHD)

> Arch Linux 详见维基 [virtualbox 条目][wiki]。其它系统可参阅[Google][google]。以下是在 `Arch Linux` 上的安装和对 `CentOS` 虚拟机硬盘镜像的测试：

### 安装virtualbox fuse pkgcofig
```Bash
pacman -S --needed base-devel VirtualBox fuse

cd;mkdir build;pushd build;
git clone https://aur.configlinux.org/vdfuse.git
pushd vdfuse
makepkg -srCci
# pacman -U vdfuse-82a-11-x86_64.pkg.tar.xz
```

### 准备
```Bash
mkdir -pv /tmp/{Freebsd,Centos/disk{1,2}}
vdfuse -t VHD -awv -f FreeBSD-11.0-RELEASE-amd64.vhd /tmp/Freebsd
vdfuse -t VHD -awv -f Centos.vhd /tmp/Centos/disk1
vdfuse -t VHD -awv -f home.vhd /tmp/Centos/disk2

# 
pushd /tmp/Centos/disk1
ll -ha
file *
```

### 挂载/卸载虚拟卷
```Bash
mount Partition3 /media/Centos
mount Partition1 /media/Centos/boot
mount Partition2 /media/Centos/usr
mount Partition4 /media/Centos/var
mount ../disk2/Partition1 /media/Centos/home

# 卸载虚拟卷
umount -v /media/Centos/{boot,usr,var,home,}
umount /tmp/{Freebsd,Centos/disk{1,2}}
```

## Ⅳ. VitualBox 命令行接口：`VBoxManage`

> 用法：`VBoxManage subcmd Options`，可将某些常用子命令封装为函数或者别名，如果需要的话。

### `list`：统计虚拟机系统情况

```Bash
VBoxManage list [--long|-l] Type
```

> Type：

- vms：已注册的
- runningvms：正在运行的
- ostypes：支持的所有系统类型
- hdds：所有虚拟硬盘文件
- dvds：所有光盘文件
- .......

```Bash
vboxmanage list -l vms
```

### `createvm/clonevm`：创建/克隆 虚拟机系统

> Options：

+ -- basefolder：虚拟机系统基目录
+ --ostypes 系统内型，见 `list ostypes`。

```Bash
# VirtualBox 5.1
vboxmanage createvm --name "RedHat7" --basefolder "~/VirtualBox" --ostypes RedHat_64 --register
```

### `showvminfo`：统计虚拟机系统基本信息

### `modifyvm`：修改虚拟机系统参数

```Bash
VBoxManage modifyvm         <uuid|vmname> Options
```

> Options：

- `--name <name>` 重命名虚拟机名称
- `--description <desc>`
- `--ostype <ostype>`
- `--memory <memorysize in MB>` 内存大小，以 MB 为单位
- `--vram <vramsize in MB>` 显存大小
- `--acpi on|off`
- `--ioapic on|off`
- `--apic on|off`
- `--hwvirtex on|off` 硬件是否启用虚拟化
- `--vtxux on|off` VT-X 虚拟
- `--pae on|off`
- `--cpus <number>` cpu 个数
- `--firmware bios|efi|efi32|efi64` 固件引导方式
- `--boot<1-4> none|floppy|dvd|disk|net>` 引导时读取顺序
- `--nic<1-N> none|null|nat|bridged|intnet|hostonly| generic|natnetwork` 网络连接方式，网卡
- `--bridgeadapter<1-N> none|<devicename>` 桥接驱动器设置
- `--macaddress<1-N> auto|<mac>`
- `--mouse ps2|usb|usbtablet|usbmultitouch`
- `--keyboard ps2|us`
- `--audio none|null|oss|alsa|pulse`
- `--clipboard disabled|hosttoguest|guesttohost   bidirectional` 剪贴板共享方式
- `--usb on|off`
- `--usbehci on|off`
- `--usbxhci on|off`
- `--snapshotfolder default|<path>`
- `--autostart-enabled on|off`
- `--autostart-delay <seconds>`
- `--videocap on|off` 录像是否启用
- `--videocapscreens all|<screen ID> [<screen ID> ...]]`

```Bash
vboxmanage modifyvm CentOS7 --description "CentOS 7.2 x86_64" --memory 256 --vram 10 --acpi on --ioapic on --cpus 1 --hwvirtex on --apic on --vtxux on --firmware efi --usb off --audio none --videocap on --nic1 bridged --bridgeadapter1 wlp3s0
```

### `startvm`：启动一个虚拟机系统

```Bash
# VBoxManage startvm          <uuid|vmname> [--type gui|sdl|headless|separate]
vboxmanage startvm "CentOS7" --type headless
```

### `controlvm`：对虚拟机系统进行某些控制。

```Bash
VBoxManage controlvm        <uuid|vmname> Options
```

> Options：

```Bash
vboxmanage controlvm "CentOS7" poweroff
```

### `storagectl`：创建/移除、调整存储控制器

```Bash
VBoxManage storagectl       <uuid|vmname> --name <name>
```

+ `--add ide|sata|scsi|....`
+ `--portcount <1-n>` 端口数
+ `--hostiocache on|off` 主机缓存
+ `--bootable on|off`
+ `--rename <name>`
+ `--remove`

```Bash
vboxmanage storagectl CentOS7 --name "SATA" --add sata --portcount 3 --hostiocache on --bootable on
```

### `storageattach`：附加/分离、更改存储控制器介质
>  存储介质可能是虚拟光盘文件，也可能是虚拟硬盘文件，二者都需要先一步准备、创建，见 `createmedium`。

```Bash
VBoxManage storageattach    <uuid|vmname> --storagectl <name> options
```

> Options：

+ `--port <number>` 端口
+ `--device <number>` 驱动器
+ `--type dvddrive|hdd|fdd`
+ `--medium none|emptydrive|additions| <uuid|filename>|host:<drive>|iscsi`
+ `--.....`

```Bash
# 附加光盘文件/虚拟硬盘
vboxmanage storageattach CentOS7 --storagectl SATA --device 0 --port 0 --type hdd --medium "/../xxx.vhd"
vboxmanage storageattach CentOS7 --storagectl SCSI --device 0 --port 1 --type dvddrive --medium /media/Others/iso/tmp/CentOS-7-x86_64-DVD-1804.iso

# 从存储控制器上移除附加的光驱文件或者虚拟硬盘|分离虚拟光盘或者硬盘
vboxmanage storageattach CentOS7 --storagectl SCSI|SATA|IDE|... --device 0 --port 0 [--type dvddrive|hdd|...] --medium none
```

### `createmedium`：创建虚拟硬盘介质
> ***手动创建的虚拟硬盘介质还需要附加到存储控制器上才能工作。在附加之前，存储控制器必须已经创建完成。如果是已经创建好的，直接附加即可。见  `storagectl` 和 `storageattach`。***

```Bash
VBoxManage createmedium     [disk|dvd|floppy]  Options
```

> options：

+ --filename ""
+ --sizebyte byte
+ --format VDI|VHD|VDMK|... 默认为 VDI

```Bash
vboxmanage createmedium disk --filename "home.vhd" --sizebyte $(( 8 * 1024 * 1024 * 1024 )) --format VHD
```

### `showmediuminfo`：统计虚拟介质基本信息

### `closemedium`：关闭、释放/删除一个介质

> 在释放一个介质之前，虚拟介质需要从所有附加过的存储控制器上先分离出来，见 `storageattach`。

```Bash
# closemedium [disk|dvd] UUID|NAME [--delete]
vboxmanage closemedium dvd "/home/iso/test.iso"
```

### `unregistervm`：移除虚拟机系统

```Bash
# VBoxManage unregistervm     <uuid|vmname> [--delete]
vboxmanage unregistervm CentOS7 --delete
```

### `import/export`：导入/导出

```Bash
vboxmanage export CentOS7 -o centos7.ovf
```

```Bash
# Ⅳ Ⅵ Ⅶ Ⅷ Ⅸ
vboxmanage import centos7.ovf
```

## Ⅴ. vboxtool

[^virtualbox]: VirtualBox 是一种虚拟机软件，在各个 PC 端 OS 上都有。这里仅在 Linux 上。
[^port_fireward]: 子系统端口是虚拟机中的系统的端口，主机端口可以和子系统端口一样
[^brige]: 桥接网卡并不需要端口转发，它们都有独立的局域网ip，它们的访问是双向的。这需要正确配置了虚拟机系统内的防火墙。如果启用了的话。

[wiki]: https://wiki.configlinux.org/index.php/File_systems_
[google]: https://www.google.com/ncr

