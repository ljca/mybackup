#include <iostream>
#include "test.h"
#include <QApplication>
#include <QLabel>
#include <QDebug>
#include <QMessageBox>
#include <QString>
//using std::cout;

int main(int argc,char **argv)
{
	//Q_OBJECT;
	QApplication app(argc,argv);
	QWidget qwidget;
	QLabel label("Click here");
	label.show();
	//QMessageBox::information(&app,"Qt Called C Lib",(QString)test());
	QMessageBox::information(&qwidget,"Qt Called C Lib","this is test Messages!");
	QMessageBox::information(&qwidget,"Qt Called C Lib",(QString)test());
	qDebug() << (QString)test();
	//QObject::connect(&label,SIGNAL(clicked()),&app,SLOT(test()));
	//cout << test();
	return app.exec();
}
