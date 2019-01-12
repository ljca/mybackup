#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QFileDialog>
#include <QDebug>
#include <QMessageBox>
#include <QFile>
#include <QString>

MainWindow::MainWindow(QWidget *parent) : QMainWindow(parent),ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    QObject::connect(ui->btnBrowser,SIGNAL(clicked(bool)),this,SLOT(openFile()));
    QObject::connect(ui->btnExit,SIGNAL(clicked(bool)),this,SLOT(close()));
}

MainWindow::~MainWindow()
{
    delete ui;
}

QString MainWindow::openFile()
{
    QString path = QFileDialog::getOpenFileName(this,"Select A File",".");
    if(!path.isEmpty()){
        QMessageBox::information(this,"Select File is",path);
        qDebug() << path;
        return path;
    }
    return "";
}

void MainWindow::close()
{
    QApplication::quit();
}
