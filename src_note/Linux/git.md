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

```Bash
git config --global color.ui true
git config --global alias.cm commit
git config --global alias.ck checkout
git config --global alias.br branch
git config --global alias.st status
git rev-parse --git-dir
git rev-parse --show-toplevel
git rev-parse --show-prefix
git rev-parse --show-cdup
git config -a
git config -e
git config -e --global
git commit -m "test commit" --allow-empty 
git log --pretty=fuller 
git log --stat 
git commit -m "Append a nice line."
git add welcome.txt 
git status 
git diff HEAD 
git diff --cached 
git commit -m "which version checked in?" 
git log --pretty=oneline 
git status -s
git diff
git checkout -- welcome.txt
```

`git status`

`git log`

`git reset HEAD`

`git remote remove origin`

## branch

`git checkout -b lex`

`git branch add lex`

`git checkout lex`

[git&ssh]: https://help.github.com/articles/connecting-to-github-with-ssh/

## 参考：

+ [Windows 系统下 Git 安装图解](http://www.w3cplus.com/node/74)
