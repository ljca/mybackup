#include <linux/init.h>
#include <linux/kernel.h>
#include <linux/types.h>
#include <linux/module.h>
#include <linux/fs.h>
#include <asm/io.h>
/*#include <linux/miscdevice.h> */

MODULE_VERSION("");
MODULE_LICENSE("GPL");
MODULE_DESCRIPTION("");
MODULE_AUTHOR("");

/* LED phys_addr */
#define GPM_PHYS_ADDR	0x11000000
#define GPM4CON		(*((unsigned long *) (GPM_PHYS_ADDR + 0x2e0)))
#define GPM4DAT		(*((unsigned long *) (GPM_PHYS_ADDR + 0x2e4)))
#define LED_DEVICE_NAME tiny4412_led

unsigned long virt_addr;
/* unsigned long *GPM4CON,*GPM4DAT; */

struct file_operations led_fops	=	{
  .open	=	led_open,
  .unlocked_ioctl	=	led_ioctl,
};

/*
struct miscdevice misc_led = {
	.minor	=	100,
	.name	=	LED_DEVICE_NAME,
	.fops	=	&led_fops,
};
*/

void init_led()
{
  virt_addr	=	ioremap(GPM_PHYS_ADDR,SZ_4K);
  GPM4CON	=	0xf;
  GPM4DAT	=	0xf;
}

void destroy_led()
{
}

void led_on(unsigned long args)
{
  GPM4CON	=	args;
  GPM4DAT	=	0x0;
}

void led_off(unsigned long args)
{
  GPM4CON	=	args;
  GPM4DAT	=	0xf;
}

#define LED_ON 1
#define LED_OFF	0

long led_ioctl(struct file *fp, unsigned int cmd, unsigned long args)
{
  init_led();
  if(args < 0 || args > 3){
	printk("args err,args is number within 0-3\n");
	return -1;
  }
  switch(cmd){
	case LED_ON:
	  led_on();
	  break;
	case LED_OFF:
	  led_off();
	  break;
	default:
	  printk("");
	  break;
  }
}

dev_t devno;
struct cdev cdev_led;
struct class *led_class;

int led_init()
{
  if(alloc_chrdev_region(&devno,0,1,LED_DEVICE_NAME)){
	prink("alloc_chrdev error\n");
	unregister_chrdev_region(devno,1);
	return -1;
  }
  cdev_init(&cdev_led,&led_fops);
  if(cdev_add(&cdev_led,devno,1)){
	printk("add error\n");
	unregister_chrdev_region(devno,1);
  }
  led_class = class_create(THIS_MODULE,LED_DEVICE_NAME);
  device_create(led_class,NULL,devno,LED_DEVICE_NAME);
  printk("led class success!\n");
  return 0;
}

int led_exit()
{
  device_destroy(led_class,devno);
  class_destroy(led_class);
  unregister_chrdev_region(devno,1);
  printk("led_class removed\n");
  return 0;
}

module_init(led_init)
module_exit(led_exit)

