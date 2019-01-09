#  Android apk 分析工具 aapt 用法简介
&nbsp;&nbsp;Android apk 分析工具(Android Assiant Packging Tool)，不仅可以用来分析得到一些 apk 概况(比如列出 apk 包内的文件和列出 apk 权限)还可以用来更改 apk 包(添加或者删除 apk 包中的某个文件,甚至可以用来重新打包 apk)

&nbsp;&nbsp;这个工具是在编译 Android 系统镜像时交叉编译(为主机而编译)然后输出到安卓 sdk 源码下的`/out/host/linux-x86/bin`这个目录下的。这个工具不需要以根用户权限来执行，下面是它的几个基本使用方法：

+ 列出 apk 包中包含的文件：`aapt l[ist] [-v] [-a] apk_file_name`
 
 + list 表示列出文件,方括号和方括号中的字符表示这是可选输入的
 + -v 选项能以更详细的表格形式列出 apk 包中包含的文件信息
 + -a 选项能以更详细的输出显示 Android apk 包的资源表(Resources Table)

```Bash
#以表格详情列出 Test.apk 包中包含的文件
aapt list -v Test.apk
```

Test.apk

|Length|Method|Size|Ratio|Offset|Date/Time|CRC-32|Name|
|:-:|:-:|:-:|:-:|:-:|:-:|:-:|:-:|
|文件长度|使用的方法|未知|大小|偏移|时间|校验和|文件或者目录名称|
|.......|


+ 列出 apk 包详情 aapt d[ump]  //转存
 
```Bash
aapt dump badging Test.apk
```

输出类似于以下结果:

> 包名被提供给 adb 工具的 uninstall 参数时会卸载 Android 应用,系统应用不再此列
Android sdk tools 命令行创建项目时也需要指定包名
Android 的 am 工具运行 Android 应用时需要使用包名参数
package: name='led.test' versionCode='1' versionName='1.0'
Sdk 版本,API Levl
sdkVersion:'17'
Sdk target
targetSdkVersion:'17'
应用程序标签
application-label:'ledtest'
应用程序图标大小,运行时的图标及标签
application-icon-160:'res/drawable-hdpi/ic_launcher.png'
application-icon-240:'res/drawable-hdpi/ic_launcher.png'
application: label='ledtest' icon='res/drawable-hdpi/ic_launcher.png'
应用程序运行时加载的包和主活动
launchable-activity: name='led.test.Led'  label='ledtest' icon=''
uses-feature:'android.hardware.touchscreen'
uses-implied-feature:'android.hardware.touchscreen','assumed you require a touch screen unless explicitly made optional'
main
支持的 LCD 屏幕大小,分辨率大小
supports-screens: 'small' 'normal' 'large' 'xlarge'
supports-any-density: 'true'
locales: '--_--'
densities: '160' '240'

+ 列出 GoogleTTS.apk 权限
 
```Bash
aapt dump permissions GoogleTTS.apk
```

> package: com.google.android.tts //包名
uses-permission: android.permission.INTERNET //允许应用联网
uses-permission: android.permission.ACCESS_NETWORK_STATE //允许查看,访问网络状态
uses-permission: android.permission.WRITE_EXTERNAL_STORAGE //允许写入数据到外部 sd 卡
uses-permission: com.google.android.providers.gsf.permission.READ_GSERVICES


