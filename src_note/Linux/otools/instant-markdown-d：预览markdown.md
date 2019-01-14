# instant-markdown-d：在浏览器中预览 markdown
+ 首先安装 npm
+ 并同步 [instant-markdown-d.git](https://github.com/suan/instant-markdown-d)，这一步其实是可选的。

``` Bash 
mkdir ~/build-src;cd ~/build-src;   
git clone https://github.com/suan/instant-markdown-d.git;cd ..
```

+ 使用 npm 安装 instant-markdown-d

``` Bash
# 如果你希望将它安装到系统目录中的话。则以根用户权限来执行……
[sudo] npm -g install instant-markdown-d
```

```
# 如果执行成功，将会打印下列消息……
/usr/bin/instant-markdown-d -> /usr/lib/node_modules/instant-markdown-d/instant-markdown-d
/usr/lib
└── instant-markdown-d@0.1.0
```

+ 安装 vim 的 vim-instant-markdown 插件……
 + 手动通过 git 克隆或者同步 [vim-instant-markdown](https://github.com/suan/vim-instant-markdown) 或者直接在 vim 的 Bundle 中搜索安装.

``` Bash
# 如果是通过手动安装，拷贝插件到相对固定的位置
mkdir -pv ~/.vim/after/ftplugin/markdown
cp instant-markdown-d.vim ~/.vim/after/ftplugin/markdown
```

+ vim 配置 vim-instant-markdown
~/.vimrc 或者 ~/.vim/vimrc

> 当vim打开一个 markdown 文件时会自动使用默认浏览器打开预览窗口，如果不需要这样做，可以在 vimrc 中设置变量
 g:instant_markdown_autostart 为 0
` let g:instant_markdown_autostart = 0 `
 > 扩展如样式表/图片等默认已经启用，不需要的话，在 vimrc
 中设置
g:instant_markdown_allow_external_content 为 0
` let g:instant_markdown_allow_external_content = 0 `

vim-instant-markdown 更多配置见 [git](https://github.com/suan/vim-instant-markdown)

> vim-markdown 语法高亮插件可以直接在 vim 的 Bundle 中通过 markdown 检索安装.
