KERNEL_DIR=/home/external/Share/tiny4412/bunfly/source_code/linux-3.5
obj-m		=	led_mod.o
test.ko:
	make -C $(KERNEL_DIR) M=`pwd` modules
.PTHONY:clean
clean:
	make -C $(KERNEL_DIR) M=`pwd` modules clean
