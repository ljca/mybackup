<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# gitbook 

<div class="p">

::: alert-info

为了完成从 markdown 到 epub pdf 等格式文档的转换创建，Linux 提供了多种工具，gitbook 只是其中一种方式。可参考 `pandoc`。而 gitbook 需要调用 ebook-convert 工具，所以在使用 gitbook 之前还需要安装 ebook-convert，这个工具由 `caribble` 提供。另外，一些功能还需要配置 gitbook 的插件才能正常使用。

一般情况下，安装并不困难，不过因为版本的问题，会出现各种安装和使用上的问题，这些问题可能只需要换一个版本的 node.js 即可。

:::

</div>

## 安装

+ 首先安装 node.js。gitbook 运行环境依赖于 node.js，因此安装之前需要安装配置 node.js。
+ 接着，使用 node.js 提供的包管理工具 `npm` 安装 gitbook。`npm -g install gitbook`
+ 最后，使用 gitbook 安装 `gitbook-cli`。`gitbook -g intall gitbook-cli`

> 安装[^install]过程并不算顺利和愉快。以下是一些我在安装和使用上出现的问题：

[^install]: 本次使用 Linux 安装。如果是 Windowns，还需要另行安装和配置 node.js 运行环境和环境变量。

`^_^-$ gitbook -V`

```log
Installing GitBook 3.2.3
/usr/lib/node_modules/gitbook-cli/node_modules/npm/node_modules/graceful-fs/polyfills.js:287
      if (cb) cb.apply(this, arguments)
                 ^

TypeError: cb.apply is not a function
    at /usr/lib/node_modules/gitbook-cli/node_modules/npm/node_modules/graceful-fs/polyfills.js:287:18
    at FSReqCallback.oncomplete (node:fs:195:5)

```

可参考：[#](#)

`^_^-$  gitbook -V`

```log
CLI version: 2.3.2
Installing GitBook 3.2.3
gitbook@3.2.3 ../../../tmp/tmp-528807qN0QUYrJzKK/node_modules/gitbook
├── escape-html@1.0.3
├── escape-string-regexp@1.0.5
├── bash-color@0.0.4
├── gitbook-plugin-livereload@0.0.1
├── ...........
└── npm@3.9.2
GitBook version: 3.2.3
```

`^_^-$   gitbook -V`

```log
CLI version: 2.3.2
GitBook version: 3.2.3
```

`^_^-$  gitbook install -g gitbook-cli`

```log
info: nothing to install! 
```


`^_^-$ gitbook init`

```log
warn: no summary file in this book 
info: create README.md 
info: create SUMMARY.md 

TypeError [ERR_INVALID_ARG_TYPE]: The "data" argument must be of type string or an instance of Buffer, TypedArray, or DataView. Received an instance of Promise
```

详见：[TypeError: ](https://www.codeleading.com/article/35563499949/)


> Install [nvm](https://github.com/nvm-sh/nvm/blob/master/README.md).：node.js Version Manager

`^_^-$ nvm list`

```log

       v12.22.7
->     v14.18.1
         system
default -> v14.18.1
iojs -> N/A (default)
unstable -> N/A (default)
node -> stable (-> v14.18.1) (default)
stable -> 14.18 (-> v14.18.1) (default)
lts/* -> lts/fermium (-> v14.18.1)
lts/argon -> v4.9.1 (-> N/A)
lts/boron -> v6.17.1 (-> N/A)
lts/carbon -> v8.17.0 (-> N/A)
lts/dubnium -> v10.24.1 (-> N/A)
lts/erbium -> v12.22.7
lts/fermium -> v14.18.1

```
> command:

+ `nvm install v12.22.7`
+ `nvm use 12`
+ `node -v`

```log
Now using node v12.22.7 (npm v6.14.15)
v12.22.7
```

> command:

+ `mkdir -p epub`
+ `cd epub`
+ `gitbook init`

> log

```log
warn: no summary file in this book
info: create README.md
info: create SUMMARY.md
info: initialization is finished
```

> 安装结束。参考：

+ [自己动手制作电子书的最佳方式（支持PDF、ePub、mobi等格式）](https://zhuanlan.zhihu.com/p/245763905)

## gitbook 插件

