#  gtk
所有的gtk程序都要包含头文件gtk.h,然而这个头文件在不同的Linux发行的位置却不是一样的。
函数原型：gtk_init(int *argc,char ***argv);
从命令行参数初始化窗口，这是所有gtk图形程序都要做的工作
gtk_init(&argc,&argv);
创建一个新的顶级窗口,参数GTK_WINWOW_TOPLEVEL告诉这个窗口是顶级窗口
gtk_window_new(GTK_WINDOW_TOPLEVEL);
一旦这个函数成功调用，就会返回一个指向GtkWidget的指针。然而这个函数调用并不会让顺带将新创建的窗口显示出来。
要将窗口显示出来还要调用gtk_widget_show和gtk_main;这也是每个gtk程序都要做的工作。
gtk_widget_show(window);
gtk_main(); //开始主循环，等待X窗口事件连接.然而，在没有连接到信号之前，这个程序却是连自己退出都做不到。
GTK程序处理信号和事件的方式的函数:
g_signal_connect();
g_signal_connect_swapped();
事件：
activate
destroy
delete_event
 vim:set filetype=markdown: 
+ [Gtk透明窗口全攻略 - Linux Job - ITeye技术网站](http://socol.iteye.com/blog/519998)

+ [GTK+学习笔记 - Helloworld _Linux编程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2012-01/51947.htm)

+ [Qt for Linux：环境搭建（CentOS 6.5 32位）——完全从零安装 - findumars - 博客园](http://www.cnblogs.com/findumars/p/5034623.html)

+ [按钮构件 - GTK+学习笔记_Linux编程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2012-01/51947p3.htm)

+ [布局管理 - GTK+学习笔记_Linux编程_Linux公社-Linux系统门户网站](http://www.linuxidc.com/Linux/2012-01/51947p2.htm)

+ [【转载】linux更换启动时的小企鹅图片(转载)](http://www.fx114.net/qa-74-95815.aspx)

+ Linux Curses编程实现贪吃蛇 - 推酷

