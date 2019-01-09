#ifndef __LEDTEST_H
#define __LEDTEST_H
/* LED phys_addr */
#define LED_PHYS_ADDR	0x11000000
/* BUZZER phys_addr */
#define BUZ_PHYS_ADDR	0x11400000

#define GPM4CON		(*((volatile unsigned long *) (led_virt_addr + 0x02e0)))
#define GPM4DAT		(*((volatile unsigned long *) (led_virt_addr + 0x02e4)))

#define GPD0CON		(*((volatile unsigned long *) (buz_virt_addr + 0x00A0)))
#define GPD0DAT		(*((volatile unsigned long *) (buz_virt_addr + 0x00A4)))

#define DEVICE_NAME "tiny4412led"
#define MISC_MINOR 100
#define MISC_ID 0

#define MISC_LEDON 100
#define MISC_LEDOFF 101
#define MISC_BUZON 102	
#define MISC_BUZOFF 103 

/* LED ioremap virtual addr */
unsigned long led_virt_addr;

/* BUZZER ioremap virtual addr */
unsigned long buz_virt_addr;

/* init led */
void init_misc(void);
/* */
int misc_remove(struct platform_device *);

/* led_arg 是打开第几个led */
void misc_led_on(int led_arg);
void misc_led_off(int led_arg);

void misc_buz_on(void);
void misc_buz_off(void);

long misc_ioctl(struct file *fp, unsigned int cmd,unsigned int arg);

/* */
int misc_probe(struct platform_device *pdev);

void misc_release(struct device *dev);

struct platform_device misc_dev	=	{
  .name	=	DEVICE_NAME,
  .id	=	MISC_ID,
  .dev	=	{
	.release	=	misc_release,
  },
};

struct platform_driver	misc_drv	=	{
  .driver	=	{
	.name	=	DEVICE_NAME,
  },
  .probe	=	misc_probe,
  .remove	=	misc_remove,
};

struct file_operations misc_fops	=	{
  .unlocked_ioctl	=	misc_ioctl,
};

struct miscdevice misc_misc = {
  .minor	=	MISC_MINOR,
  .name	=	DEVICE_NAME,
  .fops	=	&misc_fops,
};
#endif

