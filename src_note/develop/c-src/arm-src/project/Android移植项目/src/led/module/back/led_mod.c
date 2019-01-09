#include <linux/module.h>
#include <linux/init.h>
#include <linux/sched.h>
#include <linux/thread_info.h>
#include <linux/io.h>
#include <linux/ioport.h>
#include <linux/interrupt.h>
#include <linux/irq.h>
#include <linux/clk.h>
#include <linux/gpio.h>
#include <linux/fs.h>
#include <linux/cdev.h>
#include <linux/device.h>

#define LED_ON  555 
#define LED_OFF 666
#define DEVICE_NAME "bunflyled"

MODULE_LICENSE("GPL");


void led_on();
void init_led();
void led_off();
int led_open(struct inode *no, struct file *fp);
long led_unlocked_ioctl(struct file *fp, unsigned int cmd, unsigned long args);

unsigned long led_init;
unsigned long *GPM4CON,*GPM4DAT;
struct cdev bunflyLed;
struct class *cdev_class;

struct file_operations op = {
  .open = led_open,
  .unlocked_ioctl = led_unlocked_ioctl,
};
dev_t devno;

int bunfly_init()
{
  int result;
  int err;

  result = alloc_chrdev_region(&devno,0,1,DEVICE_NAME);
  if(result){
	printk("alloc devno failure.\n");
	unregister_chrdev_region(devno,1);
	return result;
  }else{
	printk("alloc devno success.\n");
  }

  cdev_init(&bunflyLed,&op);

  err = cdev_add(&bunflyLed,devno,1);
  if(err){
	printk("add error.\n");
	unregister_chrdev_region(devno,1);
	return err;
  }
  cdev_class = class_create(THIS_MODULE, DEVICE_NAME);//动态创建设备结点
  device_create(cdev_class,NULL, devno, 0, DEVICE_NAME);

  printk("bunflyled driver init success.\n");

  return 0;
}

void bunfly_exit()
{
  device_destroy(cdev_class, devno);
  class_destroy(cdev_class);
  unregister_chrdev_region(devno,1);
  printk("bunflyled driver delete success.\n");
}


module_init(bunfly_init);
module_exit(bunfly_exit);


int led_open(struct inode *no, struct file *fp)
{
  printk("bunfly led driver open.\n ");

  return 0;
}
long led_unlocked_ioctl(struct file *fp, unsigned int cmd, unsigned long args)
{
  init_led();
  switch(cmd)
  {
	case LED_ON:
	  led_on();
	  break;
	case LED_OFF:
	  led_off();
	  break;
	default:
	  printk("unkown command\n");
	  break;
  }

  return 0;
}
void init_led()
{
  led_init = ioremap(0x11000000,SZ_4K);
  GPM4CON = led_init + 0x2e0;
  GPM4DAT = led_init + 0x2e4;

  *GPM4CON = 0x1111;
  *GPM4DAT = 0xf;
}

void led_on()
{
  *GPM4CON = 0x1111;
  *GPM4DAT = 0x0;
}
void led_off()
{
  *GPM4CON = 0x1111;
  *GPM4DAT = 0xf;
}
