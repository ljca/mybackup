<link href="../css/style.css" rel="stylesheet" type="text/css" />

# low_interface

```
/sys
├── block
├── bus
├── class
├── dev
├── devices
├── firmware
├── fs
├── hypervisor
├── kernel
├── module
└── power
```

```
/sys/power/
├── autosleep
├── disk
├── image_size
├── mem_sleep 
├── pm_async
├── pm_freeze_timeout
├── pm_print_times
├── pm_test
├── pm_trace
├── pm_trace_dev_match
├── pm_wakeup_irq
├── reserved_size
├── resume
├── state # 电源状态，mem？disk？freeze？
├── wake_lock
├── wake_unlock
└── wakeup_count
```

```
# 如果驱动被正确的载入，可以从这里查看笔记本电池电量信息……
/sys/class/power_supply/BAT1@/
├── alarm
├── capacity # 这是电池当前电量……
├── capacity_level
├── charge_full
├── charge_full_design
├── charge_now
├── current_now
├── cycle_count
├── device -> ../../../PNP0C0A:00
├── manufacturer
├── model_name
├── power
│   ├── async
│   ├── autosuspend_delay_ms
│   ├── control
│   ├── runtime_active_kids
│   ├── runtime_active_time
│   ├── runtime_enabled
│   ├── runtime_status
│   ├── runtime_suspended_time
│   └── runtime_usage
├── present
├── serial_number # 电池序列号……
├── status
├── subsystem -> ../../../../../../../../class/power_supply
├── technology # 电池使用的技术……
├── type # 类型……
├── uevent
├── voltage_min_design
└── voltage_now
```

```
# /sys/class/power_supply/ACAD/
├── device -> ../../../ACPI0003:00
├── online
├── power
│   ├── async
│   ├── autosuspend_delay_ms
│   ├── control
│   ├── runtime_active_kids
│   ├── runtime_active_time
│   ├── runtime_enabled
│   ├── runtime_status
│   ├── runtime_suspended_time
│   ├── runtime_usage
│   ├── wakeup
│   ├── wakeup_abort_count
│   ├── wakeup_active
│   ├── wakeup_active_count
│   ├── wakeup_count
│   ├── wakeup_expire_count
│   ├── wakeup_last_time_ms
│   ├── wakeup_max_time_ms
│   ├── wakeup_prevent_sleep_time_ms
│   └── wakeup_total_time_ms
├── subsystem -> ../../../../../../../../class/power_supply
├── type
└── uevent
```

```
/sys/class/backlight/intel_backlight
├── actual_brightness
├── bl_power
├── brightness # 当前显示器亮度……
├── device -> ../../card0-eDP-1
├── max_brightness # 当前显示器最高亮度……
├── power
│   ├── async
│   ├── autosuspend_delay_ms
│   ├── control
│   ├── runtime_active_kids
│   ├── runtime_active_time
│   ├── runtime_enabled
│   ├── runtime_status
│   ├── runtime_suspended_time
│   └── runtime_usage
├── subsystem -> ../../../../../../../class/backlight
├── type
└── uevent
```

```
# 熄屏，空白屏幕（blank screen）
type sys_bs &>/dev/null || alias sys_bs='xset dpms force off'

# 锁屏
type sys_lock &>/dev/null || alias sys_lock='xtrlock&'

# 系统挂起，睡眠与锁屏
type sys_mem &>/dev/null || alias sys_mem="echo mem | sudo tee /sys/power/state &> /dev/null;xtrlock &"
```

