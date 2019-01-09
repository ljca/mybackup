#include <linux/init.h>
#include <linux/kernel.h>
#include <linux/types.h>
#include <linux/module.h>
#include <linux/fs.h>
#include <asm/io.h>
#include <linux/platform_device.h>
#include <linux/miscdevice.h>
#include "ledtest.h"

MODULE_VERSION("");
MODULE_LICENSE("GPL");
MODULE_DESCRIPTION("");
MODULE_AUTHOR("");

void init_misc(void)
{
  led_virt_addr = ioremap(LED_PHYS_ADDR,SZ_4K);
  printk("buz_virt_addr %#x\n",buz_virt_addr);
  buz_virt_addr = ioremap(BUZ_PHYS_ADDR,SZ_4K);
  printk("led_virt_addr %#x\n",led_virt_addr);
  GPM4CON	&=	~0xffff;
  GPM4CON	=	0x1111;
  GPM4DAT	=	0xf;
  GPD0CON	&=	~0xffff;
}

int misc_remove(struct platform_device *pdev)
{
  if(misc_deregister(&misc_misc) < 0){
	printk("misc_deregister err\n");
  }
  iounmap(led_virt_addr);
  iounmap(buz_virt_addr);
  return 0;
}

void misc_led_on(int led_arg)
{
  GPM4CON	|=	0x1111;
  switch(led_arg){
	case 1:
	  GPM4DAT = 0x7;
	  break;
	case 2:
	  GPM4DAT = 0xB;
	  break;
	case 3:
	  GPM4DAT = 0xD;
	  break;
	case 4:
	  GPM4DAT = 0xE;
	  break;
	default:
	  break;
  }
}

void misc_led_off(int led_arg)
{
  switch(led_arg){
	case 1:
	  GPM4DAT = 0xf;
	  break;
	case 2:
	  GPM4DAT = 0xf;
	  break;
	case 3:
	  GPM4DAT = 0xf;
	  break;
	case 4:
	  GPM4DAT = 0xf;
	  break;
	default:
	  break;
  }
  GPM4CON	&=	~0xffff;
}

void misc_buz_on(void)
{
  GPD0CON	|=	0x1;
  GPD0DAT	=	0x1;
}

void misc_buz_off(void)
{
  GPD0DAT	=	0x0;
  GPD0CON	=	0x0;
}

long misc_ioctl(struct file *fp, unsigned int cmd,unsigned int arg)
{
  switch(cmd){
	case MISC_LEDON:
	   printk("LED %d ON\n",arg);
	  misc_led_on(arg);
	  break;
	case MISC_LEDOFF:
	   printk("LED %d OFF\n",arg);
	  misc_led_off(arg);
	  break;
	case MISC_BUZON:
	  printk("BUZ ON\n");
	  misc_buz_on();
	  break;
	case MISC_BUZOFF:
	  printk("BUZ OFF\n");
	  misc_buz_off();
	  break;
	default:
	  printk("unknow command\n");
	  break;
  }
  return 0;
}

int misc_probe(struct platform_device *pdev)
{
  init_misc();
  int ret;
  if((ret = misc_register(&misc_misc)) < 0){
	printk("register misc devices failed.\n");
	return -1;
  }
  printk("misc device register sucess.\n");
  return ret;
}

void misc_release(struct device *dev)
{
}

static int __init misc_init(void)
{
  platform_device_register(&misc_dev);
  platform_driver_register(&misc_drv);
  return 0;
}

static int __exit misc_exit(void)
{
  platform_device_unregister(&misc_dev);
  platform_driver_unregister(&misc_drv);
  printk("led_class removed\n");
  return 0;
}

module_init(misc_init)
module_exit(misc_exit)

