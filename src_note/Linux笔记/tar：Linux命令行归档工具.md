# tar：Linux/Unix 归档工具

***&nbsp;&nbsp;tar 是一个在 `Linux` 和 `Unix变体` 上~~表现的十分腻害~~的归档工具，但并不常用来归档（除非是归档一堆已经压缩的文件或者是因为版本和平台问题不支持在归档时同时压缩），因为默认的 tar 只会归档打包，而不会压缩。所以通常都会搭配压缩工具一起使用。 `tar` 已经支持在归档时通过选项直接调用压缩/解压工具展开和归档文件及目录。***

**&nbsp;&nbsp;受 `Unix` 启发，`GNU` 项目提供的 `tar` 版本允许长短参数组合(可以传递类似bsd风格(没有-)的命令行参数，GNU长参数(以--开始)，或者多个参数连在一个-之后，也允许在归档文件时根据传递的命令行参数自动调用压缩/展开工具来自动压缩或者展开归档文件，而某些类Unix(比如BSD)不允许这么做。tar工具一些类Unix发行的默认归档工具tar与GNU项目提供的tar存在着差异。**


**&nbsp;&nbsp;使用tar工具时，如果使用了多参数组合(多个参数使用一个-连接)，f(file)选项应该在其它参数的最后，GNU长参数在组合参数之前的顺序。**

```Bash
tar [other options] -{<c|r|A|x|d>}f tar归档文件 文件1|目录1[...文件n|目录n]
```
> options:

+ -f选项(等价与GNU长参数--file=)指定的参数是一个归档名，归档名之后可以同时指定多个文件或者目录。

+ -c 选项创建一个新的归档，可以调用压缩工具在归档的同时压缩归档。

**&nbsp;&nbsp;尽管下列的这些选项在更新归档文件时非常有用，然后不幸的是这只对那些在归档之前没有调用任何压缩工具的tar归档有效。example：`tar --delete -cf test.tar test.txt`**

+ -r 选项用于增加文件到tar归档末尾，
+ -A 将一个tar归档增加另外的一个tar归档，同上。
+ -d --compare --diff
+ --delete 选项可以从一个tar归档文档中删除文件，
 
**&nbsp;&nbsp;默认的归档扩展名是tar,调用了压缩工具的扩展可能是.tar.gz|.tgz|.tar.bz2|.tar.lzma|.tar.xz|.tar.Z；旧版本的tar压缩/展开一个不是默认扩展名的tar归档需要同时使用选项指定要调用那个压缩/解压工具来提取或者压缩一个归档；而新版本的tar可以使用-xf选项直接展开/提取某个归档，而不需要刻意指定选项比如-j调用bz2压缩/解压工具来直接展开一个.tar.bz2归档。**

`tar -xf test.tar.bz2`

> &nbsp;&nbsp;当然，需要文件同时归档和压缩却是需要显式指定选项来让tar在归档的同时调用某个压缩工具，几个可用的常用的压缩选项是：

+ -j 调用 bzip2 压缩
+ -J 调用 xz 压缩，据说压缩比最高
+ --lzma 调用 lzma 压缩
+ -z 调用 gz 压缩
+ -Z 调用 copmoress 压缩

`tar -czf test.tar.gz test*.txt`

> &nbsp;&nbsp;在展开或者归档文件时，还可以对文件或者目录进行特殊处理，比如在将文件归档之后同时移除掉已经归档的文件。

```Bash
tar --remove-files --xattrs -cJRf test.tar.xz test/
tar --xattrs -p -xf test.tar.xz
```

+ --remove-files 选项在将文件归档到一个归档文件中之后就会移除已经归档的文件。
+ --xattrs 选项在归档文件时保留用户权限等属性,归档文件时使用。--remove-files在展开归档文件时使用无效
+ -p 选项在展开归档时保留文件的用户权限，展开归档文件时使用

+ gzip/gunzip
+ bzip2|unbzip2|bzcat
+ xz|unxz
+ compress|uncpress

## 归档时不能通过选项调用的压缩/解压工具

+ zip/unzip
+ squashfs
+ ar
+ 7z
+ rar/unrar

 vim:expandtab tabstop=2 shiftwidth=2 softtabstop=2
