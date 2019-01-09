#include <linux/kernel.h>
#include <linux/module.h>
#include <linux/init.h>

MODULE_VERSION("");
MODULE_AUTHOR("");
MODULE_LICENSE("GPL");
MODULE_DESCRIPTION("this is a led test programs....");

int led_init()
{
	return 0;
}

int led_exit()
{
	return 0;
}

module_init(led_init)
module_exit(led_exit)
