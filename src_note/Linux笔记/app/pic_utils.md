# Linux 图片工具

> 优化：

+ jpegoptim：jpeg 压缩
+ pngcrush：png 优化

## imagemagick

> 转换：

+ mogrify：`mogrify -format jpg *.png`
+ convert
+ parallel

```Bash
ls -1 *.png | xargs -n 1 bash -c 'convert "$0" "${0%.*}.jpg"'

The one I use. It uses GNU Parallel to run multiple jobs at once, giving you a performance boost. It is installed by default on many systems and is almost definitely in your repo (it is a good program to have around).

ls -1 *.png | parallel convert '{}' '{.}.jpg'

The number of jobs defaults to the number of processes you have. I found better CPU usage using 3 jobs on my dual-core system.

ls -1 *.png | parallel -j 3 convert '{}' '{.}.jpg'

And if you want some stats (an ETA, jobs completed, average time per job...)

ls -1 *.png | parallel --eta convert '{}' '{.}.jpg'

There is also an alternative syntax if you are using GNU Parallel.

parallel convert '{}' '{.}.jpg' ::: *.png

And a similar syntax for some other versions (including debian).

parallel convert '{}' '{.}.jpg' -- *.png
```

# 参阅

+ [Batch converting PNG to JPG in linux](https://superuser.com/questions/71028/batch-converting-png-to-jpg-in-linux)
+ [在Linux下将PNG和JPG批量互转的四种方法](https://blog.csdn.net/qq_36801146/article/details/53692635)
+ [Linux下压缩和优化jpg与png图片的方法](https://www.jb51.net/LINUXjishu/413137.html)

