KERNEL_DIR=/home/external/Share/tiny4412/bunfly/source_code/linux-3.5
obj-m		=	ledtest.o
led_mod.ko:
	make -C $(KERNEL_DIR) M=`pwd` modules
.PTHONY:clean
clean:
	make -C $(KERNEL_DIR) M=`pwd` modules clean
