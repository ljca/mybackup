#include "led.h"

void led_on(struct ledclass *led)
{
  iowrite32(iowrite32(led->gpmcon)  & ~0xf,led->gpmcon);
  iowrite32(iowrite32(led->gpmcon)  | 0x1,led->gpmcon);
  iowrite32(iowrite32(led->gpmdat)  & ~0x1,led->gpmdat);
}

void tiny4412_led_off(struct ledclass *led)
{
  iowrite32(iowrite32(led->gpmcon)  & ~0xf,led->gpmcon);
  iowrite32(iowrite32(led->gpmcon)  | 0x1,led->gpmcon);
  iowrite32(iowrite32(led->gpmdat)  | 0x1,led->gpmdat);
}

void init_led_class(struct ledclass *led)
{
  led->name = "tiny4412_led";
  led->phys_addr = ;
  led->gpio_virt = ioremap(led->phys_addr,SZ_4K);
  led->gmpcon = ;
  led->gpmdat = ;
  led->led_on = tiny4412_led_on;
  led->led_off = tiny4412_led_off;
}

void destory_led_class(struct ledclass *led)
{
  iounmap(led->gpio_virt);
}
