<link href="../../css/style.css" rel="stylesheet" type="text/css" />


# pidgin-lwqq & Smart QQ 已经快要玩完，都散了吧
据说，[pidgin-lwqq](https://github.com/xiehuc/pidgin-lwqq) 项目已经快要停止维护，而且 webqq 也有了另外一个名字，它被称作 *Smart QQ*。现在，它的账号密码登录接口已经没有了，只能通过手机扫码登录。因此，pidgin-lwqq 也算快要玩完了，假如侬不死心的话，可以尝试手动编译安装它后打开 pidgin 登录看看。详细编译 `pidgin-lwqq`教程见作者编写的 [wiki](https://github.com/xiehuc/lwqq/wiki/Build-From-Source)。
1. 首先使用包管理器安装 `pidgin`
2. 手动编译安装 pidgin-lwqq
因为 pidgin-lwqq 基于 lwqq，所以需要首先编译 lwqq
lwqq 可选依赖：`libev`、`libuv`
 + 同步并编译 [lwqq](https://github.com/xiehuc/lwqq)
```Bash
git clone https://github.com/xiehuc/lwqq xiehuc-lwqq
cd xiehuc-hwqq
mkdir -v build;cd build;
cmake -DCMAKE_PREFIX_INSTALL=/usr ..
make && sudo make install
```
 + 编译 `pidgin-lwqq`
```Bash
git clone https://github.com/xiehuc/pidgin-lwqq
cd pidgin-lwqq
mkdir -v build;cd build;
cmake ..
make && sudo make install 
sudo mv /usr/local/lib/purple-2/libwebqq.so /usr/lib/pidgin
```

可以发现，虽然 pidgin 已经可以使用 webqq 协议，但已经不能登录。所以吴在此告诉达嘎，pidgin-lwqq & Smart QQ 已经快要玩完，都散了吧……
