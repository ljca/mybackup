<link href="../../css/style.css" rel="stylesheet" type="text/css" />

# Qt开发环境搭建小记
# Qt开发环境搭建小记

  

检查Qt核心工具qmake是否安装

    
    
    `which qmake` --version
  
Qmake version: 1.07a (Qt 3.3.8b)  
Qmake is free software from Trolltech ASA.

如果没有在系统或者官方源(qt大多数都在扩展源中)中发现，qt官网上一定有。  

  

检查Qt核心头文件和库是否已经安装  

    
    
    sudo updatedb&& locate QApplication

  

测试Qt开发环境

 qmake -project  

  qmake 

  

test.cpp

    
    
    #include <QApplication>
    int main(int argc,char **argv)
    {  
      QApplication app(argc,argv);
      QMainwindow window;
      window.show();
      return app.exec();
    }
     

生成一个Qt程序。

    
    
    g++ -c -Wall -DQT_{CORE,GUI}_LIBS -I/usr/include/{QtGui,QtCore} -o test.o  test.cpp
    g++ -o  test -lQt{Core,Gui}  -lpthread test.o 

  

  

Qt官方下载地址：
http://download.qt.io/
#  qt_doc
C++ GUI Qt4编程
C++ Qt设计模式(第2版)
QT高级编程

 vim:set filetype=markdown: 
