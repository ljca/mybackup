# Linux 上 网络的手动配置

***~~&nbsp;&nbsp;我相信没有多少人（除了那些可怜的服务器维护人员）会愿意使用命令行接口手动完成网络配置这一繁琐过程。在这个过程中，你很可能被迫去了解一些诸如网关之类专业晦涩的网络术语，可能会被活活逼疯。。。更何况，一切都是基于命令行的，那可怜的一点 Windows 命令行基础根本就不可能在 Windows 上手动完成这一过程，还好，Linux 的要简单很多。~~***

## Linux 无线网络[^wlan]手动配置残篇

### 连接到开放热点（分配 IP[^ip] 后可能需要登录验证）

```Bash
iw dev wlp3s0 scan 或者使用由 wireless_tools 包提供的 iwlist，i.e：iwlist wlp3s0 scan
iw wlp3s0 connect GuangShun 或者使用由 wireless_tools 包提供的 iwconfig

# 查询统计信息。
iw wlp3s0 station dump

# 显示接口状态
ip link show 

# 自动分配 IP 以及默认路由
dhcpcd wlp3s0
```


### 连接[^conn]到使用 WPA 或者 WPA2 加密的无线热点[^wlan]

```Bash
wpa_supplicant -i wlp3s0 -c /etc/wpa_supplicant/wpa_supplicant.conf -B

# 手动给无线网卡分配 IP 
ip address add 192.168.43.111/24 broadcast 192.168.43.255 [dev] wlp3s0
ip link set [dev] wlp3s0 up # 添加默认路由时需要打开网卡接口
ip route add default via 192.168.43.1 # 或者使用 route add default gw 192.168.43.1

# 关闭网络接口
ip address flush [dev] wlp3s0 
ip route flush [dev] wlp3s0
ip link set [dev] wlp3s0 down 

# 自动分配 IP，dhcpcd 或者 dhclient；i.e：dhcpcd wlp3s0
```

--------------------

## Linux 上的以太网手动配置残篇

### 手动分配虚拟 IP[^ip]……

```Bash
#1. find network adapter interface name
ifconfig -a # or:
ip

# Warning！一些指令需要用根用户权限运行！

#2. 给以太网适配器添加一个 IP，手动分配 IP,example：

# ifconfig [dev] address [broadcase address] [netmask address]
ifconfig enp2s0f1 192.168.2.21 broadcast 192.168.2.255 netmask 255.255.255.0 up
#or
# ip [-f type] addr add <ip/mask> [brd brodaddr] [dev] <dev>

#3. add default GetWay,example：

route add default gw 192.168.2.1

#4. add defafult DNS Server,example

```

> 接下来，还要配置 DNS 解析。`/etc/resolv.conf`

```config
nameserver 192.168.0.1
```

### 动态分配的虚拟 IP[^ip]……

```Bash
#1. 打开网络接口
ifconfig [option] enp2s0f1 up # 或者 ip link set enp2s0f1 up

#2. dhcpcd……
dhcpcd enp2s0f1
```

> 如果你希望手动删除给网卡分配的 IP

```Bash
# 更常用的做法
# ip [option] addr flush [dev] <device>
# example:
ip addr flush enp2s0f1 # or:

# ifconfig <device> 0.0.0.0 
# example:
ifconfig enp2s0f1 0.0.0.0 # or:

# ip [-f type] addr delete <ip/mask> [brd <addr>] [dev] <device>
# example:

ip -f inet addr delete 192.168.2.13/32 enp2s0f1

```

**&nbsp;&nbsp;如果你希望了解更多，可以参阅各种 Unix 及其变体包括 Linux 的 Wiki， Wiki 百科。**

+ [Arch Linux wiki 网络配置][net_set]

------------------------

# 附：

##  命令行无线网络工具

+ get-interface: `ifconfig` | `ip` | `iw `
+ open-interface: `ip link set <interface> up` | `ifcofig <interface> up`
+ get-essid | find networks: `iw` | `iwconfig` | `iwlist`

```Bash
iwlist <interface> scan | grep 'ESSID'
iw [dev] <interface> scan | grep -i 'ssid*'
```

> WPA+: `wpa_supplicant` | `wpa_passphrase` 

+ write to file: ` wpa_passphrase essid psk|password >> /etc/wpa_supplicant/wpa_supplicant.conf` `wpa_passphrase <ssid> [passphrase]`
+ INIT: `wpa_supplicant -i <interface> -c path&file `
+ get-ipaddreess: `dhcpcd <interface> || dhclient <interface>`
+ test network:  `ping -c 3 www.baidu.com`
+ show network-info: `iwconfig <interface> || iw dev <interface> `

## **调制解调器[^model][^model_2][^model_3]、路由器[^router]、IP[^ip]、路由[^route]、网关**

+ **拨号上网的网络** 

----------------------

> 参考：

+ [Arch Linux实现wifi和有线联网_Linux教程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2016-11/137666.htm)
+ [archlinux 无线网卡资料一-heiyou-ChinaUnix博客](http://blog.chinaunix.net/uid-108863-id-136997.html)
+ [Network configuration (简体中文) - ArchWiki][network]
+ [NetworkManager (简体中文) - ArchWiki][nm]
+ [en_users_Documentation_iw - Linux Wireless](http://linuxwireless.org/en/users/Documentation/iw/)
+ [Wireless network configuration - ArchWiki](https://wiki.archlinux.org/index.php/Wireless_network_configuration#Manual_setup)
+ [Wirelessnetworkconfiguration简体中文-ArchWiki][wireless]
+ [Linux系统下中 在命令行中实现Wifi 连接的方法_LINUX_操作系统_脚本之家](http://www.jb51.net/LINUXjishu/234506.html)
+ [LINUX下如何配置使用无线网络啊？-CSDN论坛-CSDN](http://bbs.csdn.net/topics/340101949)
+ [linux下使用无线网卡的命令行方法 - 彩虹天堂 - 博客频道 - CSDN](http://blog.csdn.net/goodlixueyong/article/details/6461871)
+ [linux以命令行下配置连接wlan无线网卡 - Linux操作系统：Ubuntu_Centos_Debian - 红黑联盟](http://www.2cto.com/os/201205/133898.html)
+ [NetworkManager——Linux强大的网络管理工具 - lclc - 博客园](http://www.cnblogs.com/lcword/p/5917336.html)
+ [使用ssh连接虚拟机网络的方法 - 虚拟机教程文章_推动虚拟化发展 - 红黑联盟](http://www.2cto.com/os/201206/137291.html)
+ [完全教程 Aircrack-ng破解WEP、WPA-PSK加密利器 - 51CTO](http://netsecurity.51cto.com/art/201105/264844_all.htm)


[nm]: https://wiki.archlinux.org/index.php/NetworkManager_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[network]: https://wiki.archlinux.org/index.php/Network_configuration_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)#.E5.90.AF.E7.94.A8.E5.92.8C.E7.A6.81.E7.94.A8.E7.BD.91.E7.BB.9C.E6.8E.A5.E5.8F.A3
[wireless]: https://wiki.archlinux.org/index.php/Wireless_network_configuration_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)
[net_set]: https://wiki.archlinux.org/index.php/Wireless_network_configuration

[^wlan]: &nbsp;&nbsp;无线 AP(WIFI)和无线网络(WLAN)是一个截然不同的概念。目前，无线网又分加密的和开放的，开放的又分验证登录的和直接可连接的，加密的又分 WEB 、WPA、WPA2 几种。其中，WPA2 加密等级最高，即最安全。`WPA2` 使用 `RSA`() 加密。比 `WPA`(WIFI Pro Acecess) 协议保护性更高。

[^conn]: &nbsp;&nbsp;你必须事先知道网络 SSID 和密钥。直接使用 `iw` 或者 `iwlist` 扫描仅仅能获取到网络的 SSID 以及一些基本信息，网络密码是不可能出现在扫描结果中的。然后使用 `wpa_passphrase` 将 SSID 和密钥（密钥在写入过程会经过加密，一般用户是没有权限查看的）写入配置文件，一般是 `/etc/wpa_supplicant/wpa_supplicant.conf`，`wpa_supplicant` 可能会用到它。当然，你完全可以使用进程替换(类似 `wpa_supplicant -i wlp3s0 -B -c <(wpa_passphrase "ESSID" "PSK")` 的方式来避免频繁的对配置文件进行写入和读取。

[^ip]: &nbsp;&nbsp;这里分配的 IP 只是局域的。

[^route]: 即下一跳。

[^model]: &nbsp;&nbsp;调制解调器(Model),俗称猫 主要包括调制器和解调器两部份，调制器用于将模拟信号转换为数字信号，解调器用于将数字信号转换为模拟信号，一般的调制解调器都提供了至少一个Wan口和一个Lan口和一个用于ADSL拨号上网电话线的接口，调制解调器可能由网络提供商提供，也有可能需要自己购买。

[^model_2]: &nbsp;&nbsp;在调制解调器上的的Wan接口不能使用RJ-45水晶头网线直接和计算机的以太网接口连接，Wan口一般用于连接外网或者实现路由交换，至少需要一台路由器和调制解调器通过一条RJ-45水晶头网线分别连接到对方的Wan口上，如果需要使用有线连接，那么需要另外一条网线分别连接到无线路由(调制解调器)的Lan口和计算机的以太网接口上。调制解调器可能提供了多个网口，但通常只有一个网口可以正常使用，即同一时间只有一台计算机可以连接到Internet上。
 
[^model_3]: &nbsp;&nbsp;一些调制解调器同时具有调制解调器和无线路由的功能，表现为提供了两个网口或者以上，但通常只有一个可以直接连接到计算机，其余的几个只能被用来作为路由交换使用(如果一定要使用，则需要特殊手段进行破解),如果使用网线直接连接到计算机上，受限；网口2可直接通过网线连接到计算机上，正常上网。

[^route_swap]: &nbsp;&nbsp;路由器具有路由交换功能（允许连接更多具有以太网接口的终端设备。同时，还可以提供多个无线 AP）。要实现路由交换，可以是调制解调和路由器之间，或者两台或以上路由器之间，一台作为主路由，通过网线将 WAN 口和调制解调器的 WAN 口相连。作为次级路由，同样通过 RJ-45 水晶头网线将自己的 WAN 口和主路由的任意一个 LAN 口连接。LAN 口用于和计算机的以太网接口先连访问网络。

[^router]: **&nbsp;&nbsp;路由器内部嵌入了一个小型但完整的嵌入式系统，主要用于多台终端设备共享一个网络。同时，路由器还具备路由交换[^route_swap]的功能。为了使用路由器提供的无线 AP[^wlan]（无线 AP，即 WIFI[^wlan]。一些特殊的调制解调器同时具有调制解调和无线AP的功能，而另一些特殊的调制解调器经过破解之后也能实现提供无线 AP，但通常的调制解调器没有提供无线 AP 功能)，在设置了管理员密码之后一般是可以直接连接的，但为了安全起见，你通常需要对路由器进行更多的配置。**
