#include <linux/init.h>
#include <linux/module.h>

MODULE_LICENSE("GPL");

static int __init helloword_exit(void)
{
	printk("helloword module init\n");
	return 0;
}

static int __exit helloword_init(void)
{
	printk("helloword module exit\n");
	return 0;
}

module_init(helloword_init)
module_exit(helloword_exit)
