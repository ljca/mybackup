#  YCM：一个很厉害的VIM代码补全插件
vim version must support python：

```
$ vim --version

:version
:echo has('python') || has('python3')

```

> Quike Installation

```Bash
install.py --clang-completer ~/vim/bundles/YouCompleteMe ~/third_party/ycmd/clang_archives/clang+llvm-3.9.0-x86_64-opensuse13.2.tar.xz
```


> Full Installation
```
mkdir ~/{ycm_build,ycm_tmp}

tar -xf clang+llvm-3.9.0-x86_64-opensuse13.2.tar.xz -C ~/ycm_tmp

pushd ~/ycm_build;

cmake -G "Unix Makefiles" -DPATH_TO_LLVM_ROOT=~/ycm_tmp/clang+llvm-3.9.0-x86_64-opensuse13.2 . ~/.vim/bundle/YouCompleteMe/third_party/ycmd/cpp

cmake --build . --target ycm_core --config Release
 
cp ~/.vim/bundle/YouCompleteMe/third_party/ycmd/cpp/ycm/.ycm_extra_conf.py ~/.vim
```

> Configure，Edit User vimrc，add flowing this lines:

====== ~/.vim/vimrc =====

```
let g:ycm_global_ycm_extra_conf = '~/.vim/.ycm_extra_conf.py'
```

