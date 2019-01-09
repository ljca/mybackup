if filereadable(expand("~/.vimrc.bundles"))
	source ~/.vimrc.bundles
endif

source ~/.vim/bundle/vim-pathogen/autoload/pathogen.vim
execute pathogen#infect()

  " don't write swapfile on most commonly used directories for NFS mounts or USB sticks
  autocmd BufNewFile,BufReadPre /media/*,/run/media/*,/mnt/* set directory=~/tmp,/var/tmp,/tmp
  " start with spec file template
  autocmd BufNewFile *.spec 0r /usr/share/vim/vimfiles/template.spec
  augroup END

if has("cscope") && filereadable("/usr/bin/cscope")
   set csprg=/usr/bin/cscope
   set csto=0
   set cst
   set nocsverb
   " add any database in current directory
   if filereadable("cscope.out")
      cs add $PWD/cscope.out
   " else add database pointed to by environment
   elseif $CSCOPE_DB != ""
      cs add $CSCOPE_DB
   endif
   set csverb
endif

" Switch syntax highlighting on, when the terminal has colors
" Also switch on highlighting the last used search pattern.
if &t_Co > 2 || has("gui_running")
  syntax on
"  set hlsearch
endif

filetype plugin on

if &term=="xterm"
     set t_Co=8
     set t_Sb=[4%dm
     set t_Sf=[3%dm
endif

" Don't wake up system with blinking cursor:
" http://www.linuxpowertop.org/known.php
let &guicursor = &guicursor . ",a:blinkon0"


"""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
" user .......
filetype plugin indent on
set completeopt=longest,menu
set tabstop=2
set softtabstop=2
set shiftwidth=2
set smarttab
set autoindent
set smartindent
set cindent
set number
set mouse=a
set backspace=2
""nmap <F3> :exporer
nmap <F5> :call CompierAndrun()<CR>
nmap <F6> :call Debug()<CR>
imap <F5> <ESC>:call CompierAndrun()<CR>
imap <F6> <ESC>:call Debug()<CR>
imap <c-f> <PageDown>
imap <c-u> <PageUp>
imap <c-j> <Down>
imap <c-k> <Up>
imap <c-l> <Left>
imap <c-r> <Right>
imap <c-f> <c-Right>
imap <c-b> <c-Left>
imap <F3> <ESC>:sh<CR>
nmap <F3> :sh<CR>
imap <c-F12> <Esc>:qall<CR>
nmap <c-F12> :qall<CR>
nmap <Esc><Esc><Esc> :nohlsearch<CR>
nmap <C-j> <c-w>j
nmap <C-k> <c-w>k
nmap <C-h> <c-w>h
nmap <C-l> <c-w>l

"colorscheme morning
colorscheme ron
set wildmenu
"hi MatchParen ctermbg=Black ctermfg=yellow
  set ruler
set showcmd
nmap gg=G gg=GggVG:s/=/\ =\ /gc<CR>

"
function CompierAndrun()
	:w
	if &filetype == 'c'
		 :!clear;gcc -o %< % && ./%<
	elseif &filetype == 'cxx' || &filetype == 'cpp'
		 :!clear;g++ -o %< % && ./%<
	 elseif &filetype == 'sh' || &filetype == 'bash'
		 :![ -x % ] && ./% || chmod +x % && ./%
"	else return ""
	endif
endfunction

function Debug()
	:w
	if &filetype == 'c'
	:!clear;gcc -g -o %< % && gdb %<
	elseif &filetype == 'cpp'
	:!clear;g++ -g -o %< % && %<
"else return ""
	endif
endfunction


autocmd BufNewFile *.c,*.sh,*.cpp,*.cxx exec ":call SetTitle()"
autocmd BufNewFile * normal Go
function SetTitle()
	if &filetype == 'c' "|| &filetype == 'h'
		call setline(1,"\/*")
		call append(line("."),"* File Name: ".expand("%"))
		call append(line(".")+1,"* Create Date: ".strftime("%c"))
		call append(line(".")+2,"*\/")
		call append(line(".")+3,"#include <stdio.h>")
	elseif &filetype == 'cpp' || &filetype == 'cxx' 
		call setline(1,"#include <iostream>")
		call setline(2,"using ")
	endif
endfunction

set nobackup


" Multi_Cursor Edit Set
let g:multi_cursor_next_key='<C-n>'
let g:multi_cursor_prev_key='<C-p>'
let g:multi_cursor_skip_key='<C-x>'
let g:multi_cursor_quit_key='<Esc>'

set hlsearch

let g:tagbar_ctags_bin='/usr/bin/ctags'
let g:tagbar_width=20
let g:tagbar_left=1
autocmd BufNewFile,BufReadPost *.c,*.cpp,*.cxx,*.h call tagbar#autoopen()

set encoding=utf-8
let laststatus=2
set t_Co=256
"let g:Powerline_symbols='unicode'
"let g:Powerline_symbols='fancy'
"language messages en_US.UTF-8
let g:airline_powerline_fonts = 1
let g:airline#extensions#tabline#enabled = 1
let g:airline#extensions#tabline#buffer_nr_show = 1
let g:airline_theme='light'

