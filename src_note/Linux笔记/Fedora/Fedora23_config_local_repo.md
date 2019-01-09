# Fedora 23 设置本地 repo 源
+ 在 /etc/yum.repos.d 目录下创建 dnf 需要的 repo 文件
`/etc/yum.repos.d/local.repo `

```
[local]
name=Local Repo
baseurl=file:///media/Others/Temp/sr/
skip_if_unavailable=True
metadata_expire=1d
gpgcheck=0
enabled=1
```

+ 安装 repo 元数据创建工具 `createrepo`
`sudo dnf install -y createrepo`

+ 创建本地 repo 源数据
``` Bash
pushd /media/Others/Temp
createrepo -v sr/lin
```

+ 清除所有缓存
`sudo dnf clean all`

+ 创建 repo 缓存
`sudo dnf makecache`

