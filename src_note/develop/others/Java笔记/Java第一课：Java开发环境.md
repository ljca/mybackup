# Java第一课：Java开发环境
&nbsp;&nbsp;如果你希望你的浏览器支持`Java`，你需要在你的计算机系统上安装并配置`JRE`……

&nbsp;&nbsp;如果你希望开发`Java`程序或者希望使用`NetBeans`、`Eclipse`等`JAVA 开发 IDE`，你需要在你的系统中安装并配置`JDK`……

&nbsp;&nbsp;如果你使用的是`MyEclipse`，或许不再需要安装和配置`JDK`和`JRE`……


&nbsp;&nbsp;因为实现等问题，Java 不太适合用来开发`PC`桌面应用程序（虽然可以，但很少有人愿意这样做）。但却被广泛应用于`Web`程序（动态网页），根据需要，可以运行在服务器端，或者依赖于中间件，最终需要浏览器来呈现其运行结果。另外，`Google`公司用它来实现`Android`程序的`GUI`呈现或者像某些公司或者个人一样干脆全用`Java`实现`Android`应用，最终通过`davlik`虚拟机解释其字节码。


> 获取 JDK1.7 64 位：

[[lin](http://download.oracle.com/otn/java/jdk/7u80-b15/jdk-7u80-linux-x64.tar.gz)] [[win](http://download.oracle.com/otn/java/jdk/7u80-b15/jdk-7u80-windows-x64.exe)]

> Note！！！一些程序需要`JAVA_HOME` `JRE_HOME`等系统环境变量才能正常工作。

Windows 平台：


```Batch
@echo off
:: 设置用户级环境变量 JAVA_HOME JRE_HOME CLASSPATH PATH
setx JAVA_HOME ""
setx JRE_HOME "%JAVA_HOME%\jre"
setx CLASSPATH "%JAVA_HOME%\"
setx PATH "%JAVA_HOME%\bin;%JRE_HOME%\bin" 

:: 打开新的命令提示符，测试
java 
pause
```

&nbsp;&nbsp;Linux 平台因为`OpenJDK`和`Oracle`提供的`JDK`在实现上可能存在着一些差异，因此一些人可能更希望移除系统中存在的`OpenJDK`并使用`Oracle`提供的`JDK`。而一些基于`Debian Linux`的发行使用了`update-alternatives`来调整多个版本的应用程序在系统中的默认版本。

```Bash
# 以根用户执行：
update-alternatives 

--install link name path 优先级 # 优先级是一个数字
--remove|--set name path 
--display --config  name


update-alternatives --config javac
update-alternatives --config java
update-alternatives --config jar
# ....
```

不管怎样，我使用了一个`Bash`脚本来安装和移除Java：

```Bash
#!/bin/bash - 
#===============================================================================
#
#          FILE: java.sh
# 
#         USAGE: ./java.sh install|uninstall
# 
#===============================================================================
#tmp=/home/external/usr/develop
#jdk_dir=${1:-/home/external/usr/develop}

case $# in
  1)
    if [[ $1 != "install" || $1 != "uninstall" ]];then
      if [ -d $1 ];then 
        jdk_dir=$1
      else jdk_dir=/home/external/usr/develop
      fi
    fi;;
  2)
    :;;
  0|*)
    :;;
    #echo "Usage: ./java.sh [dir] {install|uninstall}";;
  esac

#[ -d $tmp ] && {
#	JAVA_HOME=$tmp/Java_Web/jdk7u80
#	JRE_HOME=$JAVA_HOME/jre
#	PATH=$JAVA_HOME/bin:$JRE_HOME/bin:$PATH
#	export JAVE_HOME JRE_HOME PATH
#	unset tmp
#}
[ -n $jdk_dir ] && [ -d $jdk_dir ] && {
	jdk=$jdk_dir/Java_Web/jdk7u80
	jre=$jdk/jre
	dest=${dest:-$HOME/bin}
  #for i in $jdk/bin/* $jre/bin/*;do ln -sv $i $dest/$i;done
  #for i in "$jdk/bin/*" "$jre/bin/*";do readlink $dest/`basename $i` &>/dev/null || ln -sv $i $dest/;done;
  cd $dest
  case $1 in
    install)
	for i in $jdk/bin/* $jre/bin/*;do [ -L $dest/${i##*/} ] || ln -sv $i ;done;;
    uninstall)
	for i in $jdk/bin/* $jre/bin/*;do [ -L $dest/${i##*/} ] && rm -vf $dest/${i##*/};done;;
  *)
    echo "Usage ./java.sh install|uninstall"
  esac
	unset jdk_dir jdk jre dest 
}
```

