#  Unix网络编程
## 网络模型 ##
> &nbsp;&nbsp;虽然 *ISO* 提出了 *OSI* (Open System Internet，中文译作开放系统互联）模型并规定网络应该有七个层次，但实际上，仅仅只有四层的 *TCP/IP 协议族* 已经成为了网络模型事实上的标准。

OSI 模型：

|  逻辑层 | 协议 |
|:---------: | :---------: |
| 应用层  | NULL |
| 表示层  | NULL |
| 会话层  | NULL |
| 传输层  | TCP/UDP |
| 网络层  | IP,ICMP/IGMP…… |
| 链路层  | ARP/RARP |
| 物理层  | NULL |

>  &nbsp;&nbsp;TCP/IP 不是仅仅包含了 TCP 和 IP 协议，而是一系列位于不同层次上的协议的总称，它们共同构成了一个协议族。现在它只有四层了（顶上三层：会话层，表示层，应用层 已经合并为一层：应用层），从顶层到底层分别是应用层、传输层、网络层、而最底层的物理层与链路层也合并为物理链路层了。

TCP/IP 协议族：

| 逻辑层 | 主要使用协议 | 基本组成及功能 |
| :----: | :-----: | :--------------------: |
| 应用层 | NULL | 应用层包含基本数据包的基本数据，负责处理特定应用程序的细节。| 
| 传输层 | TCP/UDP/SCTP…… | 传输层负责数据端到端的传输，该层主要使用了 TCP、UDP 以及较新的 SCTP 协议来完成数据的封装和传输。|
| 网络层 | IP,ICMP/IGMP…… | 网络层负责数据点到点的传输，主要负责分组在网络中的活动。该层主要使用 IP 协议，然后还使用了一些附属协议，比如 ICMP/IGMP 等。|
| 物理链路层 | ARP/RARP | 链路层及物理层包含了设备驱动程序和硬件，负责底层的数据传输，主要使用 ARP/RARP 协议。|

## 套接字基本编程模型 ##
&nbsp;&nbsp;网络编程大多是面向传输层的。而关于网络编程，Unix 网络编程卷中有更详细的介绍和讨论。以下是 TCP/UDP 的基本编程模型：
```C
/* sockaddr_in 结构及其主要成员 */
  sin_family
  sin_port
  struct sin_addr s;
```

1. TCP 编程模型

```C 
/* TCP 服务端：socket() -> init sockaddr_in struct -> bind() -> listen() -> accept() -> write() -> close() */

/* TCP 客户端：socket() -> init sockaddr_in struct -> connect() ->  read() -> close() */
```
2. UDP 用户数据报(8位)，编程模型

```C
/* UDP 服务端：socket() -> init sockaddr_in struct  -> bind() -> recvfrom() -> sendto() */
/* UDP 客户端：socket() -> init sockaddr_in struct -> sendto() -> recvfrom() -> close() */
```
编程 API：

 + inet_pton()/inet_ntop()
 + ntohl()/ntohs()
 + htonl()/htons()
 + bzero()/memset()
 + strcpy()/memcpy()/bcopy()


关于《Unix 网络编程卷》源码可以从它的[ 网站 ][0]或者[ 图灵社区 ][1]下载。
[0]: https://
[1]: https://
