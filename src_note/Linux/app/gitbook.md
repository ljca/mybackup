<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# gitbook：

`gitbook -V`

```log
Installing GitBook 3.2.3
/usr/lib/node_modules/gitbook-cli/node_modules/npm/node_modules/graceful-fs/polyfills.js:287
      if (cb) cb.apply(this, arguments)
                 ^

TypeError: cb.apply is not a function
    at /usr/lib/node_modules/gitbook-cli/node_modules/npm/node_modules/graceful-fs/polyfills.js:287:18
    at FSReqCallback.oncomplete (node:fs:195:5)
```

::: alert-info

> Files: 

+ /usr/lib/node_modules/gitbook-cli/node_modules/npm/node_modules/graceful-fs/polyfills.js

:::

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

^_^-$   `gitbook -V`

```log
CLI version: 2.3.2
GitBook version: 3.2.3
```

^_^-$  `gitbook install -g gitbook-cli`

```log
info: nothing to install! 
```


```sh
gitbook init
```

```log
warn: no summary file in this book 
info: create README.md 
info: create SUMMARY.md 

TypeError [ERR_INVALID_ARG_TYPE]: The "data" argument must be of type string or an instance of Buffer, TypedArray, or DataView. Received an instance of Promise
```

详见：[TypeError: ](https://www.codeleading.com/article/35563499949/)


> Install [nvm](https://github.com/nvm-sh/nvm/blob/master/README.md).：node.js Version Manager

^_^-$ nvm list

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

```sh
nvm install v12.22.7
nvm use 12
node -v
```

```log
Now using node v12.22.7 (npm v6.14.15)

v12.22.7
```

` nvm list`

```log
->     v12.22.7
       v14.18.1
         system
...................
lts/dubnium -> v10.24.1 (-> N/A)
lts/erbium -> v12.22.7
lts/fermium -> v14.18.1
```

^_^-$   rm -f README.md
已删除 'README.md'

^_^-$  gitbook init

```log
warn: no summary file in this book
info: create README.md
info: create SUMMARY.md
info: initialization is finished
```

[^_^]:  为了创建 epub、pdf、mobi 等格式的文档，还需要安装 ebook-convert，而这个工具由 `caribble` 提供。另外，一些功能需要依赖插件才能正常使用。

> 参考：

+ [自己动手制作电子书的最佳方式（支持PDF、ePub、mobi等格式）](https://zhuanlan.zhihu.com/p/245763905)

