#obj-m			+=	hello.o
#KERNEL_DIR ?=		/home/external/usr/src/linux-3.19
#hello.ko:
#	make -C $(KERNEL_DIR) M=`pwd` modules
ifneq ($(KERNELRELEASE),)
	obj-m			:=	hello.o
else
	KERNELDIR ?=	/lib/modules/$(shell uname -r)/build
	PWD		:=		$(shell pwd)
hello.ko:
	$(MAKE) -C $(KERNELDIR) M=$(PWD) modules
endif

.PHONY:clean
clean:
	$(MAKE) -C $(KERNELDIR) M=$(PWD) modules clean
