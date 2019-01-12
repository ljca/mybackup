# Firefox：一个免费的高自定义(扩展很多)浏览器的扩展小配置

> 与 Firefox 有关的设置项，可以直接在地址栏中输入：

+ Firefox 设置: `about:preferences#general`
+ Firefx 高级配置选项： `about:config`
+ 固定一组相同网址的网页缩放比列（`browser.zoom.full`），值为 true;
+ `browser.zoom.siteSpecific` &nbsp;&nbsp;  `browser.zoom.updateBackgroundTabs`此值为true 时可能会与 Firefox 扩展 Nosquint 冲突
+ 验证扩展的签名`xpinstall.signatures.required`，值如果为 false，则不对扩展的签名进行验证，默认为 true;
+ Firefox 扩展管理： `about:addons`

> 扩展集：

+ `Adblock plus`：专业级的广告拦截扩展，必要时，可使用此扩展拦截界面某个元素。不过，此扩展据说会占用多多的内存。
+ `uBlock`[^ublock]：页面元素过滤
+ `Firebug`：专业级网页 js..等调试工具
+ `Nosquint`：固定网页缩放比，高版本的 Firefox 不再支持。如果需要的话可以使用最新版本的 Nosquint plus 来固定网页缩放比。
+ `UnMHT`：Firefox 默认不能将网页存为单个网页，此扩展可以将网页另存为 mhtm 文档，也可以打开 mht 文档。
+ `flagfox`：一个可以在地址栏显示 ip 国旗的 firefox 扩展
+ `Download Status Bar`：一个增强的下载器。
+ `Downlaod Status Fixed`：下载状态控制
+ `Toggle animated GIFs`：一个可以控制是否播放 gif 动画的扩展。有些广告是以 gif 动图的形式出现的。
+ `Status-4-Evar`：默认的火狐并不会显示底部状态栏，只有在传输数据时显示短短的几秒时间，之后会自动隐藏。此空战可以打开古老的状态栏。
+ `StatusbarEx` 可以让状态栏显示更多的信息，包括 ip，内存等信息，仅在 windows 有效。 
+ `Stylish`[^stylish]：让火狐浏览器可以使用自定义样式表
+ `DownThemAll`：批量多线程下载扩展
+ `VimFx`：支持vim键盘映射的 Firefox 扩展
+ `解雇 IE`：允许将浏览器切换到 IE 内核
+ `Tab Utilities`：标签栏优化扩展

[^ublock]:  ublock origin 版本过滤广告效果要更好。

[^stylish]: &nbsp;&nbsp;在附加组件 about:addons -> 搜索并安装 Stylish -> 打开 Stylish，点击编写一个样式表或者搜索网络上的样式表来自定义页面样式样式表中设置的中英文字体必须已经安装到系统中，否则会使用系统字体而让样式表中设置的字体失效。最好不要在样式表重设字体参数，因为这可能会打乱原网页的页面布局和显示方式。当然，如果对这些并不在意，那么可以随意在样式表中对字体等样式进行重设，然而，仍旧不推荐重设字体大小。

> 参考：

+ 提高浏览体验的五十个最佳FireFox扩展插件-月光博客
