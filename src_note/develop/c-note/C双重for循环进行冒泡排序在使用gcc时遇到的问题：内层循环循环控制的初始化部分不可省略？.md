<link href="../../css/style.css" rel="stylesheet" type="text/css" />


# C双重for循环进行冒泡排序在使用gcc时遇到的问题：内层循环循环控制的初始化部分不可省略？
在一个双重 for 循环之外，我声明了两个局部变量并将它们初始化用做控制循环迭代的变量。

然后，我省略掉了内层循环检查的初始化部分(按照语法，这没有任何问题)；我尝试着在两个循环的循环体中对一个数组中的元素进行了冒泡排序。

然而，奇怪的是，这在用 gcc 编译之后运行所得到的结果却不是正确的。


```C
int main()
{
  int num[] = {9102,95,2910,22,3232,172,29,2922};
#define NUM_LEN ((sizeof(num)/sizeof(num[0])))
  static const int num_len = sizeof(num) / sizeof(num[0]);
  printf("arr length = %ld\n",NUM_LEN);
  printf("num_len = %d\n",num_len);
  static int i = 0;
  for(;i < num_len;i++) printf("num[%d] = %d\n",i,num[i]);
  /*  数组排序 */
  int j = num_len - 1,tmp;
  for(i = 0;i < num_len - 1;i++){
    for(;j > i;j--){
      if(num[j - 1] > num[j]){
        tmp = num[j - 1];
        num[j - 1] = num[j];
        num[j] = tmp;
      }
    }
  }
  
  puts("");
  for(i = 0;i < num_len;i++) printf("num[%d] = %d\n",i,num[i]);
}
```

// 未排序之前

>  num_len = 8
    num[0] = 9102
    num[1] = 95
    num[2] = 2910
    num[3] = 22
    num[4] = 3232
    num[5] = 172
    num[6] = 29
    num[7] = 2922

// 排序之后
> num[0] = 22
    num[1] = 9102
    num[2] = 95
    num[3] = 2910
    num[4] = 29
    num[5] = 3232
    num[6] = 172
    num[7] = 2922

我发现，内层循环用来控制迭代的变量在第一次循环后不知道为什么直接变为了 0，因此，内层循环在第二次及以后做了无用功。但如果内层循环循环控制的初始化部分没有省略，结果则是正常的。


