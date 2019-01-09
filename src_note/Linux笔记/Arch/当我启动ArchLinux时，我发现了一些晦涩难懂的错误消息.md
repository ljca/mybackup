#  当我启动Arch Linux时，我发现了一些晦涩难懂的错误消息
通过查看日志时发现了更多的错误

```Bash
sudo journalctl -p 3 -xb --no-hostname --no-pager
```

```
6月 01 12:07:53 kernel: usb 1-5: string descriptor 0 read error: -22
6月 01 12:07:53 kernel: ACPI Error: [\_SB_.PCI0.LPCB.H_EC.ECWT] Namespace lookup failure, AE_NOT_FOUND (20160930/psargs-359)
6月 01 12:07:53 kernel: ACPI Error: Method parse/execution failed [\_TZ.FN00._ON] (Node ffff88015a0ec640), AE_NOT_FOUND (20160930/psparse-543)
6月 01 12:07:53 kernel: ACPI Error: [\_SB_.PCI0.LPCB.H_EC.ECWT] Namespace lookup failure, AE_NOT_FOUND (20160930/psargs-359)
6月 01 12:07:53 kernel: ACPI Error: Method parse/execution failed [\_TZ.FN00._ON] (Node ffff88015a0ec640), AE_NOT_FOUND (20160930/psparse-543)
6月 01 12:07:53 kernel: acpi PNP0C0B:00: Failed to set initial power state

6月 01 12:07:53 kernel: ACPI Error: [\_SB_.PCI0.LPCB.H_EC.ECRD] Namespace lookup failure, AE_NOT_FOUND (20160930/psargs-359)
6月 01 12:07:53 kernel: ACPI Error: Method parse/execution failed [\_TZ.TZ00._TMP] (Node ffff88015a0ef438), AE_NOT_FOUND (20160930/psparse-543)
6月 01 12:07:53 kernel: ACPI Error: [\_SB_.PCI0.LPCB.H_EC.ECRD] Namespace lookup failure, AE_NOT_FOUND (20160930/psargs-359)
6月 01 12:07:53 kernel: ACPI Error: Method parse/execution failed [\_TZ.TZ01._TMP] (Node ffff88015a0ef4d8), AE_NOT_FOUND (20160930/psparse-543)
6月 01 12:07:56 laptop-mode[1056]: Failed to set power saving mode for wireless card

6月 01 12:22:16 NetworkManager[3495]: <error> [1496290936.3023] dispatcher: could not get dispatcher proxy! Error calling StartServiceByName for org.freedesktop.nm_dispatcher: GDBus.Error:org.freedesktop.systemd1.NoSuchUnit: Unit dbus-org.freedesktop.nm-dispatcher.service not found.
6月 01 12:22:50 laptop-mode[4629]: Failed to re-set power saving mode for wireless card
6月 01 14:21:17 sudo[11083]: pam_unix(sudo:auth): conversation failed
6月 01 14:21:17 sudo[11083]: pam_unix(sudo:auth): auth could not identify password for [hcra]

6月 01 15:50:11 kernel: ACPI Error: [\_SB_.PCI0.LPCB.H_EC.ECWT] Namespace lookup failure, AE_NOT_FOUND (20160930/psargs-359)
6月 01 15:50:11 kernel: ACPI Error: Method parse/execution failed [\_TZ.FN04._OFF] (Node ffff88015a0ecc80), AE_NOT_FOUND (20160930/psparse-543)
6月 01 15:50:11 kernel: ACPI Error: [\_SB_.PCI0.LPCB.H_EC.ECWT] Namespace lookup failure, AE_NOT_FOUND (20160930/psargs-359)
6月 01 15:50:11 kernel: ACPI Error: Method parse/execution failed [\_TZ.FN03._OFF] (Node ffff88015a0ec140), AE_NOT_FOUND (20160930/psparse-543)
6月 01 15:50:11 kernel: ACPI Error: [\_SB_.PCI0.LPCB.H_EC.ECWT] Namespace lookup failure, AE_NOT_FOUND (20160930/psargs-359)
6月 01 15:50:11 kernel: ACPI Error: Method parse/execution failed [\_TZ.FN02._OFF] (Node ffff88015a0ecf50), AE_NOT_FOUND (20160930/psparse-543)
6月 01 15:50:11 kernel: ACPI Error: [\_SB_.PCI0.LPCB.H_EC.ECWT] Namespace lookup failure, AE_NOT_FOUND (20160930/psargs-359)
6月 01 15:50:11 kernel: ACPI Error: Method parse/execution failed [\_TZ.FN01._OFF] (Node ffff88015a0ec398), AE_NOT_FOUND (20160930/psparse-543)
6月 01 15:50:14 kernel: ACPI Error: [\_SB_.PCI0.LPCB.H_EC.ECWT] Namespace lookup failure, AE_NOT_FOUND (20160930/psargs-359)
6月 01 15:50:14 kernel: ACPI Error: Method parse/execution failed [\_TZ.FN00._OFF] (Node ffff88015a0ec168), AE_NOT_FOUND (20160930/psparse-543)
```

其中有几个错误都和 laptopmode-tools 直接有关，因此我首先尝试了禁用掉了 laptop-mode 服务：
```Bash
sudo systemctl disable laptop-mode.service 
```

但遗憾的是：我发觉这样做并没有什么用处，重新引导系统后，最初出现的错误依旧没有消失。

很困惑，有人认为这可能跟位于主板上的`BIOS`存在一定的关联性，难道是因为我的计算机更换了主板后一直没有更新`BIOS`的原因吗？或许我应该尝试更新一下它？

