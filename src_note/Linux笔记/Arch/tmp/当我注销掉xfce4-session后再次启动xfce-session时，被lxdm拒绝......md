#  当我注销掉xfce4-session后再次启动xfce-session时，被lxdm拒绝.....
我遇到了一个问题，那就是当我注销掉 xfce4-session 然后尝试重新登录时，lxdm 就会弹出几个错误框并拒绝了启动 xfce4-session。

+ `未能与设置服务器联系`

+ `Failed to conencet socket /run/user/996/bus：拒绝连接`

+ `未能载入安全会话`

+ `未能确定安全会话名称。可能由于 xfconfd 没有运行(D-Bus设置问题)，未正确设置环境变量 $XDG_CONFIG_DIRS (必须包含 "/etc")或 xfce4-session 未正确安装。`

&nbsp;&nbsp;我重新建立了一个用户并尝试注销掉 xfce4-session 然后重新登录，结果一切正常。

&nbsp;&nbsp;然后我尝试查找 xfce4 的 xfconf 的配置文件(很顺利，它们就位于 ~/.config/xfce4/xfconf 目录下，是一组xml文档。备份它们之后删掉了原来的文件，然后注销掉会话并尝试重新登录系统(xfce4 除了要求重新配置 xfce4-panal 之外，其它的一切正常)。

&nbsp;&nbsp;后来我注意到，这些原因可能仅仅是因为我取消了注销系统而不必询问的选项，如果引起以上问题的真正的原因就是如此，那么解决方案会更简单，仅仅需要在 xfce4 设置的会话和启动中将注销方式设置为注销时提示就行了。
