<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# cscope&ctags
## vim 插件 cscope&ctags

### Search And Install ctags

First,only run ctags -R <dir> generate ctags's index.

```Bash
ctags -R .
```

and then edit vim profiles
~/.vimrc or ~/.vim/vimrc or /etc/vimrc

add following the line
set ctags += path(abslote)

### Search And Install：cscope

If you want using cscope,First：

1. Generate the cscope cross refrences file *cscope.out*

```Bash
# this is simple ways
cscope -Rbq
```

If using quickly index with -b 

```Bash
find . -type f -name "*.c" -o -name "*.h" -o -name "*.ch" > cscope.files
cscope -bq
```
and then edit vim profiles,add this line

========== ~/.vim/vimrc ========== 

```
if has("cscope")
	set cscopequickfix=s-,c-,d-,i-,t-,e-
	set cscopetag 
	set csto=0
	if filereadable("cscope.out")
		cs add cscope.out
  elseif filereadable("../cscope.out")
		cs add ../cscope.out ..
	"elseif $CSCOPE_DB != ""
	"	cs add $CSCOPE_DB
	endif
  set cscopeverbose
endif
```

