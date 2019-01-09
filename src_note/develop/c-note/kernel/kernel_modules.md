#  kernel_modules
内核模块实现:
#include <linux/init.h>
#include <linux/kernel.h>
#include <linux/module.h>

MODULE_LICENSE("");
MODULE_AUTHOR("");
MODULE_DESCRIPTION("");
MODULE_VERSION("");

EXPORT_SYMBOL() //导出符号,内核符号表 /proc/kallsyms

static __init module_init()
{
}

static __eixt module_exit()
{
}

内核态打印函数printk

内核模块构建方式：
配置交叉编译器
CROSS-COMPIER.. ?= 

将自实现模块添加到内核选项中
1.添加到内核源代码树下
----> Kconfig
在menu节下增加config节
config xxxxx
	tristate/bool xxxx
	deepend on xxx
	default y/n
	help xxxxx

----> Makefile
obj-m += xxx.o OR obj-$(CONFIG_NAME) += xxx.o OR obj-y	+= ?

2.drivers下使用自定义目录
	1.1.添加Kconfig
	1.2.添加Makefile
	1.3.-----> ../Kconfig
	source xxx/Kconfig

仅编译自定义内核模块
添加Makefile
------> Makefile
KERNEL ?= 内核源代码顶层树
obj-m	+= xxx.o
make -C $(KERNLE) M=$(shell pwd) modules
clean:
	make -C $(KERNLE) M=$(shell pwd) modules clean

自动构建方式：


编译内核和模块
make 
make zImage
make modules


模块的载入与卸载:
insmod/rmmod

lsmod/modinfo

modprobe

depmod
