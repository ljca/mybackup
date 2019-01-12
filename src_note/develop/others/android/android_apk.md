# android_apk
获取安卓sdk基本命令行工具包:
android-sdk_r21-linux.tgz
android-sdk_r24.4.1-linux.tgz

android-studio-ide-143.2821654-linux.zip
android-studio-ide-145.3537739-linux.zip

包含安卓平台及平台工具(Platform和platform tools)
android-17_r01.zip

swt java库 用于java图形界面编程
swt-3.7.1-gtk-linux-x86_64.zip
swt-3.7.1-win32-win32-x86_64.zip

安卓sdk命令行工具:
andorid有andorid sdk-tools提供.

还能通过android sdk获取android platform和platform tools
$an-sdk/tools/android [sdk]

Note:
1.直接运行andorid等效于运行android adk,获取帮助信息应该使用android --help
Usage:
android [global options] action [action options]
Global options:
  -h --help       : Help on a specific command.
  -v --verbose    : Verbose mode, shows errors, warnings and all messages.
     --clear-cache: Clear the SDK Manager repository manifest cache.
  -s --silent     : Silent mode, shows errors only.
                                                          actions
                                                          are
                                                          composed
                                                          of a verb
                                                          and an
                                                          optional
                                                          direct
                                                          object:
-    sdk              : Displays the SDK Manager window.
-    avd              : Displays the AVD Manager window.
-   list              : Lists existing targets or virtual devices.
-   list avd          : Lists existing Android Virtual Devices.
-   list target       : Lists existing targets.
-   list device       : Lists existing devices.
-   list sdk          : Lists remote SDK repository.
- create avd          : Creates a new Android Virtual Device.
-   move avd          : Moves or renames an Android Virtual Device.
- delete avd          : Deletes an Android Virtual Device.
- update avd          : Updates an Android Virtual Device to match the folders
                        of a new SDK.
- create project      : Creates a new Android project.
- update project      : Updates an Android project (must already have an
                        AndroidManifest.xml).
- create test-project : Creates a new Android project for a test package.
- update test-project : Updates the Android project for a test package (must
                        already have an AndroidManifest.xml).
- create lib-project  : Creates a new Android library project.
- update lib-project  : Updates an Android library project (must already have
                        an AndroidManifest.xml).
- create uitest-project: Creates a new UI test project.
- update adb          : Updates adb to support the USB devices declared in the
                        SDK add-ons.
- update sdk          : Updates the SDK by suggesting new platforms to install
                        if available.

创建安卓工程:
android create project
       Usage:
       android [global options] create project [action options]
       Global options:
  -h --help       : Help on a specific command.
  -v --verbose    : Verbose mode, shows errors, warnings and all messages.
     --clear-cache: Clear the SDK Manager repository manifest cache.
  -s --silent     : Silent mode, shows errors only.

                         Action "create project":
  Creates a new Android project.
Options:
  -n --name          : Project name.
  -v --gradle-version: Gradle Android plugin version.
  -t --target        : Target ID of the new project. [required]
  -p --path          : The new project's directory. [required]
  -g --gradle        : Use gradle template.
  -k --package       : Android package name for the application. [required]
  -a --activity      : Name of the default Activity that is created.
                       [required]
$ android create project --name test --target 1 --package com.test --activity Test --path ./test

编写Android Makefile(Android.mk,名字是固定的)
vim Android.mk
基本规则如下：
LOCAL_PATH := $(call my-dir)
LOCAL_SRC_FILES	:= $(call all-subdir-java-files)
LOCAL_PACKAGE_NAME	:= test
include $(BUILD_PACKAGE)

用m,mm,mmm编译安卓工程: m,mm,mmm等函数由andordid_src/build/envsetup.sh脚本提供
. build/envsetup.sh

mmm 安卓工程目录

Note:
1.每一个要被编译的工程目录下都要存在Android.mk并具有有效规则.
2.mmm由build/envsetup.sh脚本提供,每次在新的标签或者窗口时编译安卓工程时都要执行这个脚本.
3.编译安卓过程要到安卓源码目录下。

swt下载地址:
http://archive.eclipse.org/eclipse/downloads/drops/R-3.7.1-201109091335/#SWT
