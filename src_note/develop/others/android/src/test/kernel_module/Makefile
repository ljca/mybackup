CC=arm-linux-gcc
LINUX_SRC=/home/external/Share/tiny4412/bunfly/source_code/linux-3.5

obj-m		+=	led_test.o
led_test.ko:
	make -C $(LINUX_SRC) M=`pwd` modules
.PTHONY:clean
clean:
	make -C $(LINUX_SRC) M=`pwd` modules clean
