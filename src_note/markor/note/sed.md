<link href="../css/style.css" rel="stylesheet" type="text/css" />

# sed 笔记

<!--

```bash

sed -i 's|&nbsp；|\&nbsp;|g' 1.md
sed -i-bk "s|,|，|g;s|?|？|g;s|:|：|g;s|;|；|g;s|\!|！|g;s|x|、|g" 9.md 
sed -i "41,165{s|$|<br \/>|;}" "周末选读 │ 周兴嗣：千字文.md" 
sed -i -e "50s| $|\n|" songs.md   

```

-->

> 参考：
+ [Sed 命令完全指南](https://linux.cn/article-10232-1.html)
+ [sed 行处理](https://www.cnblogs.com/jjzd/p/6892891.html)
+ [sed简单使用(一)加空行](https://www.cnblogs.com/zhanglong71/p/5424633.html)
+ [sed简单使用(五)选择性删除](https://www.cnblogs.com/zhanglong71/p/5548742.html)

