# Linux进程的虚拟地址空间中的堆(heap)和栈(stack)缺省是什么样的生长方向？

```C
int main()
{
  int tmp = 0;
  int num[] = {10,20};
  printf("&tmp = %p\n",(void *)&tmp);
  printf("&tmp = %d\n",*((int *)((unsigned long long)&tmp - sizof(num[0]))));
  printf("&a[0] = %p,&a[1] = %p\n",(void *)&num[0],(void *)&num[1]);
  int *heap_addr_num = (int *)malloc(sizeof(int));
  char *heap_addr_char = (char *)malloc(sizeof(char));
  printf("heap_addr_num = %p,heap_addr_char = %p\n",(void *)heap_addr_num,(void *)heap_addr_char);

  free(heap_addr_num);
  heap_addr_num = NULL;
  free(heap_addr_char);
  heap_addr_char = NULL;
}
```

结果是：

> &tmp = 0x7ffcc5744b3c
&tmp = 20
&a[0] = 0x7ffcc5744b34,&a[1] = 0x7ffcc5744b38
heap_addr_num = 0x12c5420,heap_addr_char = 0x12c5440

由此可以看出，栈在为数组分配内存时是直接分配连续的空间。并且，数组的基址位于低处，从数组的第一个元素开始，其它元素的地址是依次递增的。栈上的内存是从高处地址开始分配的。

也就是说，栈的生长方向是从高到低的。而堆是从低地址处开始分配内存空间的，生长方向是从低到高的。
