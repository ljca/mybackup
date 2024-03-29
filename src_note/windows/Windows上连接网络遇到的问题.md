<link href="../css/style.css" rel="stylesheet" type="text/css" />

# Windows上连接网络遇到的问题

> **如果某一天你发现你的 Windows 在连接以太网后居然有两个以上的活动连接[^conn]？其中的某个还无法连接到互联网…… 如果你喜欢使用命令行，以管理权限运行命令提示符 [^netsh]：**

```batch
:: 未来的某一天，Microsoft 计划移除 netsh，改用 Power Shell……

:: 显示网关/路由信息
netsh interface ipv4 show rotue

:: 显示 ip 地址信息
netsh interface ipv4 show addresses

:: 显示接口信息 
netsh interface ipv4 show interface

:: 删除网关 192.168.1.1
netsh interface ipv4 del rotue 0.0.0.0/0 "以太网" 192.168.1.1
```

```batch
:: 尝试以 ipconfig 显示网络适配器详细统计信息
ipconfig /all
```

> 统计信息类似：

```
> 以太网适配器 以太网:
   连接特定的 DNS 后缀 . . . . . . . :
   描述. . . . . . . . . . . . . . . : Realtek PCIe GBE 系列控制器
   DHCP 已启用 . . . . . . . . . . . : 是
   自动配置已启用. . . . . . . . . . : 是
   IPv4 地址 . . . . . . . . . . . . : 192.168.2.25(首选)
   子网掩码  . . . . . . . . . . . . : 255.255.255.0
   获得租约的时间  . . . . . . . . . : 2017年8月26日 星期六 9:31:08
   租约过期的时间  . . . . . . . . . : 2017年8月27日 星期日 21:51:41
   默认网关. . . . . . . . . . . . . : 192.168.2.1
   DHCP 服务器 . . . . . . . . . . . : 192.168.2.1
   DHCPv6 IAID . . . . . . . . . . . : 68958535
   DHCPv6 客户端 DUID  . . . . . . . : 00-01-00-01-20-C3-F7-8D-1C-39-47-F6-32-18
   DNS 服务器  . . . . . . . . . . . : 192.168.2.1
   TCPIP 上的 NetBIOS  . . . . . . . : 已禁用
 ```

> “以太网”没有有效的 IP 配置？ 或许是因为：

 ![](_v_images/1543941323_7890.jpg)

[^route]: 网关一般是指路由器……

[^netsh]: 也可以在命令提示符中交互式运行 netsh 配置

[^conn]:  如果你遇到了这个问题，那也许是因为在你的 Windows 上存在着多个网关[^route]，可能还有某个网关地址是错误的……
