<link href="../../css/style.css" rel="stylesheet" type="text/css" />


# network
网络基础:
TCP/IP七层协议：
^ 应用层 
| 表示层 
| 会话层 
| 运输层 TCP/UDP
| 网络层 IP协议族(IP/ICMP...)
| 数据链路层 ARP(根据主机ip地址查询/询问对应主机的物理地址)/RARP(根据物理地址询问对应主机的ip)
| 物理层 集线器 ---> 交换机 ---> 路由器

原始套接字

主机字节序(小端)

网络字节序(大端)

验证方式：
使用联合体来判断：

使用函数判断
int num = 1;

*(char *)&num == 1 ? 0 : 1

socket编程
bind
listen
accept

setsockopt
inet_addr
inet_ntoa
