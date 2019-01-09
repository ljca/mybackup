#ifndef __LED_H
#define __LED_H
struct ledclass{
	char *name;
	unsigned long phys_addr;
	unsigned long gpio_virt,gpmcon,gpmdat;
	void (*led_on)(struct ledclass *);
	void (*led_off)(struct ledclass *);
};

void led_on(struct ledclass *led);
void tiny4412_led_off(struct ledclass *led);
void init_led_class(struct ledclass *led);
void destory_led_class(struct ledclass *led);
#endif
