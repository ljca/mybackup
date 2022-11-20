<link href="../css/style.css" rel="stylesheet" type="text/css" />

# git[^git] 笔记

***~~如果你希望从命令行 push，那么你至少得有一个 git 帐号、一个 git repo(仓库，这需要你自己动手在 git 网站上创建)，除了这些，你还必须正确配置了 ssh key 或者 gpg key。git 官方配置文档的传送门在[这里][git&ssh]。~~***

```Bash
#首先，在终端上生成公钥对: 
ssh-keygen -t rsa -b 4096 -C "k_y_z_s@yeah.net"
# 然后将 ssh-key 私钥添加到 ssh-agent。
eval "$(ssh-agent -s)"
ssh-add ~/.ssh/id_rsa

#同时，还需要将 rsa 公钥（~/.ssh/id_rsa.pub）添加到 git 帐号上： 
xclip -sel clip < ~/.ssh/id_rsa.pub

#点击头像 -> Settings -> SSH and GPG keys -> New SSH key ....

#测试公钥：
ssh -vT git@github.com
```

***~~为了使命令行尽可能的简洁，可以对用户名和邮箱进行映射。当然，这些你完全可以通过 git config 进行设置。~~***

========== $HOME/.gitconfig ========== 

```cfg
[user]
email = 
name = 
```

## 初始化 git

```bash
git init
git add . 
git commit -m "mybackup" -a
git remote add origin git@github.com:ljca/mybackup.git
git push -u origin master 
```
```Bash
git push -u origin master 
git pull origin master 
```


[git&ssh]: https://help.github.com/articles/connecting-to-github-with-ssh/


> 运行`git push origin master` 出现：，见 [CSDN 博客](https://blog.csdn.net/iiiliuyang/article/details/104203197)

```log
ssh: connect to host github.com port 10086: Connection timed out
fatal: 无法读取远程仓库。
请确认您有正确的访问权限并且仓库存在。
```


## 参考：

+ [Windows 系统下 Git 安装图解](http://www.w3cplus.com/node/74)


## git subcmd

> config

```Bash
git config --global color.ui true
git config --global alias.cm commit
git config --global alias.ck checkout
git config --global alias.br branch
git config --global alias.st status
git config -a
git config -e
git config -e --global
```


> pull：

> rm：删除远程仓库的某个目录或者文件（对本地没有影响）

```Bash
#切回远程仓库对应的本地路径，移除远程仓库文件或者目录
git rm -r --cache [远程仓库地址/]目录，文件
#git commit -m update
#git push -u origin master 
```

> mv 
> add：`git add welcome.txt`

> commit 
git commit -m update
> push：
git push -u origin master

> status

`git status`
git status -s

> rev-parse

```Bash
git rev-parse --git-dir
git rev-parse --show-toplevel
git rev-parse --show-prefix
git rev-parse --show-cdup
```

> commit

```Bash
git commit -m "test commit" --allow-empty 
git commit -m "Append a nice line."
git commit -m "which version checked in?" 
```
> reset

`git reset HEAD`

> remote

`git remote remove origin`


> diff
```Bash
git diff
git diff HEAD 
git diff --cached 
```

> log

```Bash
`git log`
git log --pretty=fuller 
git log --stat 
git log --pretty=oneline 

git log --all --oneline --graph

```

> branch：管理分支

- branch
    - `git checkout -b lex`
    - `git branch add lex`
    - `git checkout lex`

> checkout

git checkout -- welcome.txt

> switch：切换分支

> rebase：切换到另一个分支并应用更改

git rebase HEAD master
git checkout master

参考：

+ [如何将分离的HEAD与master / origin协调？](https://www.javaroad.cn/questions/42269)
+ [如何在分离的HEAD状态下找到当前的git分支](https://www.javaroad.cn/questions/10400)

