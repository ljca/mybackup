# 检查主机是网络little-enddle还是big-enddle


```C
int main()
{
  typedef union check{
    int num;
    char ch;
    char *p_num;
  }Check;

  Check  ck;
  ck.num = 0x1;
  printf("%d,%d\n",ck.num,ck.ch);
  printf("%s\n",ck.ch == 0x1 ? "little-enddle" : "big-enddle");
  ck.p_num = &ck.ch;
  printf("%p,%p\n",(void *)&ck.p_num,(void *)&ck.p_num);
  printf("%p,%p\n",(void *)&ck.num,(void *)&ck.ch);
  printf("%p\n",(void *)(&ck.ch + 1));
 printf("%p,%p,%p,%p\n",(void *)(&ck.p_num),(void *)(ck.p_num + 1),(void *)(ck.p_num + 2),(void *)(ck.p_num + 3));
  // *(&ch + 1)
}
```


