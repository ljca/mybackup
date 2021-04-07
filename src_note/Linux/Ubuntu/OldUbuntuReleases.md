<link href="../../css/style.css" rel="stylesheet" type="text/css" />


# Old Ubuntu Releases
对于一些非`LTS`版本的`Ubuntu`，`Canonical`公司可能在它们过了维护期后就不再进行维护。

> 如果有一天，你希望找到一些旧版本`Ubuntu`（非`LTS`版本）的资源文件（比如你希望找到一些旧版本`Ubuntu`的壁纸），可以尝试从 [Old Ubuntu Releases](http://old-releases.ubuntu.com/releases/)（也许未来的某一天，这个地址会迁移或者不再有效）处获取光盘镜像文件后手动提取[^1]，这真是够无聊的……

[^1]: 假如你真的要做这么无聊的事情，可以先以环回设备挂载`iso`(指令非常类似于上面的，挂载时需要根用户权限)，然后再次以环回设备挂载（据说`Live CD`也是这样做的，可以让系统跑的飞快）那个用`squashfs`压缩的根文件系统，就是镜像文件挂载后那个`casper`目录下的`filesystem.seuashfs`文件……

```Bash
# mkdir tmp fs
mount -o loop,ro ubuntu-*.iso tmp
# cd tmp
mount -o loop,ro casper/filesystem.squashfs ../fs
```

