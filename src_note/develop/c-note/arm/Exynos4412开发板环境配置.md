<link href="../../../css/style.css" rel="stylesheet" type="text/css" />


# 嵌入式第一课：Exynos4412开发板环境配置小结

## 安装配置minicom
    
```
minicom -s
```

## 传输工具 dnw

    
Host：

```
 tar -xf dnw-linux.tar.gz
 make && make install
 ```

## uboot烧写

Host：

```
# Example：
 ./sd_fusing.sh /dev/sdb  
```

## 安装/引导

### 查看分区

    
TINY4412：

```
fdisk -p 1
fdisk -p 0

### 配置emmc分区

TINY4412    
# fdisk -c 1 320 809 524
# fatformat mmc 1:1
# ext3format mmc 1:2
# ext3format mmc 1:3
# ext3format mmc 1:4
# emmc open 1
# dnw 0x40000000  <==========> dnw E4412_N.bl1.bin
# mmc write 1 0x40000000 0 0x10
# dnw 0x40000000 <==========> dnw bl2.bin
# mmc write 1 0x40000000 0x10 0x1C
# dnw 0x40000000 <=======> dnw ../../u-boot.bin
# mmc write 1 0x40000000 0x20c 0x21D
# dnw 0x40000000 <=======> dnw E4412_tzsw.bin
# mmc write 1 0x40000000 0x30 0xB8
# emmc close 1
```
    

### 配置nfs文件系统

close iptables or add filter to iptables......

Host：

```
service iptables stop
chkconfig --level 235 iptables off //或者使用 setup停用iptables
chkconfig --level 235 nfs on
```

Add rootfs abstract path to /etc/exports  and restart nfs server.


========== Host File：/etc/exports ===========

```
# format: 
/home/tmp/kernel *(rw)
```

```
# If init is is not systemd，Example：
service nfs status
service nfs start
```

### 测试

minicom(TINY4412):
    
```    
set bootargs console=ttySAC0 root=/dev/nfs rootfs=192.168.1.10 ip=192.168.1.20
set ipaddr 192.168.1.20
save
dnw 40008000 <===========> dnw zImage
bootm 4000800 //测试引导 

# Host executeable command：
ifconfig eth0 192.168.1.10
```

### 设置开发板引导参数

minicom(TINY4412):：

```
# set bootargs console=ttySAC0 root=/dev/nfs nfsroot=192.168.1.10:/home/tmp/kernel ip=192.168.1.20
# set bootcmd movi kernel 0 \;bootm 40008000
# set ipaddr 192.168.1.20
# save
```
    
### 刷写内核到开发板


# Host：

```
# minicom
./fastboot -w

# Host 
./fastboot flash kernel zImage
### 重启开发板，引导系统
reset 
```

### 主机作为 nfs server 配置交叉编译工具  

### 交叉编译工具链
  
