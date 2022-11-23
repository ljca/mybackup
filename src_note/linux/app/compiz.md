<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# compiz
***~~如果你向往 Mac 那花哨的界面和动画，而又恰好使用的是 `Linux`，那么不妨尝试一下`堆叠式窗口管理器` `compiz`，请放心，最多就是桌面崩溃，而不是系统崩溃……~~~***

***~~很不幸，我使用的是 Linux 是 Arch Linux，而 Arch Linux 官方源中并不包含 `compiz`。 幸运的是：有人在`AUR`上提交了`compiz`的`PKGBUILD`。这意味着不需要自己解决依赖问题。以下的所有安装构建都是一步一步手动进行的，如果你不喜欢这样做，可以尝试使用`yaourt -S compiz`一步到位。~~***

> ！`AUR`上的软件包除了软件包的名字不相同，前面的地址基本一致。

构建`compiz`并使用`ccsm`对`compiz`窗口管理器进行配置……
> Note！

`compiz`存在 0.8 和 0.9 两种版本，这两种版本采用了不同的打包方式。0.8 的将插件和和`compiz`设置等分开打包了，而 0.9 的将所有的打包到了一起。这里安装的是`compiz-0.9`，如果你希望安装 0.8 版本的`compiz`，请阅读`Arch Linux` `Wiki`关于 [compiz][0] 的条目……
```Bash
# yaourt -Ss compiz ## 获取 AUR 上 compiz 的软件包名
# 获取 compiz-0.9 PKGBUILD...
git clone https://aur.archlinux.org/compiz-0.9
pushd compiz-0.9
makepkg -srCci # 构建安装 compiz-0.9
```

我们可以构建并安装`emerald 窗口装饰器`来调整窗口的装饰(窗口和边框)……
```Bash
# 获取 emerald PKGBUILD
# yaourt -Ss emerald
git clone https://aur.archlinux.org/emerald

# 构建安装 emerald
pushd emerald
makepkg -srCci 
```

这需要一起构建并安装`emerald`主题[^0](`emerald-themes`为`emerald`提供了所需要的主题)。

```Bash
# 首先从 AUR 上获取 emerald-themes PKGBUILD……
#！！！下面这是我对 emerald-themes PKGBUILD 的微小调整，因为，emerald-themes 项目地址已经因为开发者而发生了变化，如果下面这个 source 数组给出的地址仍然是错误的，请尝试 Google，并自行在 PKGBUILD 中调整……
source=('git+https://github.com/compiz-reloaded/emerald-themes/')
md5sums=("SKIP")
# ...
```

```Bash
# 接下来正常构建 emerald-themes
# ...........
```
> Note！

+ 在使用`compiz`窗口管理器之前，你需要先用`ccsm`调整一些基本的`compiz`配置（如果你需要这些东西的话，比如窗口管理中的窗口装饰(提供窗口的边框(包括标题栏，最大化等按钮)，移动、放置窗口、调整窗口大小……）。然后尝试手动运行`compiz --replace`查看`compiz`效果（`compiz`配置可以随时使用`ccsm`调整）。
+ `compiz`使用闭源的显卡驱动能更好的工作。

> if：你对此觉得满意，想要设置桌面环境的默认窗口管理器为`compiz` && 你的`Arch Linux`用的也是`Xfce4`桌面环境：

1. 设置`Xfce4`默认窗口管理器（可选）。
`file: ~/.config/xfce4/xfconf/xfce-perchannel-xml/xfce4-session.xml`
2. 删除会话缓存`~/.cache/sessions/`并注销一次系统（这一次注销记得不要勾选保存会话用于将来登录）。
3. 然后登录并检查设置是否生效（如果没有生效那就手动`compiz --replace`，再次注销一次系统并勾选保存会话用于将来登录）。如果没有意外，这次登录应该就有效了。

> 参考： 

+ `Arch Linux` `Wiki`[compiz][compiz] 条目……

[compiz]:https://wiki.archlinux.org/index.php/Compiz_(%E7%AE%80%E4%BD%93%E4%B8%AD%E6%96%87)

[^0]: compiz 项目几经变化调整，现在已经被移到了`Github`上……

z 窗口动画：
1. 窗口打开动画：

| 动画              | 对照 
| :-----------:     | :------: |
| Airplane          | 飞机
| Beam Up           | 束起来
| Explode           | 爆炸
| Bounce            | 弹跳
| Burn              | 烧伤
| Dissolve          | 溶解
| Domino            | 骨牌
| Wave              | 波
| Skewer            | 串
| Curved Fold       | 弯曲的折叠
| Horizontal Folds  | 水平折叠
| Sidekick          | 风车
| Sheet             | 片
| Rotate In         | 旋转
| Razr              | Razr手机
| Magic Lamp Wavy   | 魔术灯波浪
| Magic Lamp        | 魔灯
| Leaf Spread       | 叶蔓
| Glide             | 滑行
| Fold              | 折
| Fly In            | 飞入
| Fan               | 风扇
| Fade              | 淡出
| Expand            | 扩大
| Expand piecewise  | 分段展开
| Dream             | 梦想
| 缩放              | 脉冲

