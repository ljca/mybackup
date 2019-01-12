# 为什么我的鼠标和触摸板在Linux上使用时总会出现反应延迟的问题？
> Tip: 也许这是因为 laptopmode-tools 工具的设备自动挂起功能，也有可能仅仅只是因为在桌面环境设置的鼠标和触摸板设置中启用了`在输入时（使用键盘时，包括 Alt Tab 切换窗口）禁用触摸板多长时间`这个功能而已……

-- 如果是后者的原因？

-- 如果是因为 laptopmode-tools（laptopmode-tools 使用了黑名单）？```AUTOSUSPEND_USE_WHITELIST=0```
> Note：新版本的 `laptopmode-tools` 已经将 USB 自动挂起功能从 usb-autosuspend 模块移动到运行时 pm 模块（关于它的配置文件移到了 /etc/laptop-mode/conf.d/runtime-pm.conf）。如果你希望知道 laptopmode-tools 的详细信息，请参阅 laptop-mode.conf（8）手册页。

&nbsp;&nbsp;可以尝试将 USB 设备的 VID 和 PID 号（！关于这个，可以尝试插拔 USB 设备并对比 lsusb 指令上下文的变化，多个设备的 vid 和 pid 使用空格分开）添加到

`AUTOSUSPEND_RUNTIME_DEVID_BLACKLIST=""` 段并重启　laptopmode-tools 服务，可能还要重新插拔一下　USB 设备。更多 laptopmode-tools 问题参见 Arch Linux laptopmode-tools Wiki.
