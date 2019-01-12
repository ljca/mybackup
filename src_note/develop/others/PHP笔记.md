# PHP笔记：PHP 中文手册在[这里][php-man-zh].

## 基本输出/打印函数。
echo 
& print
printf();

`print_r("<pre")`：返回格式化后可读的变量或者函数的返回值数据信息。。

`var_dump()`：返回变量或者函数的返回值数据信息。

基本输入函数：

input();

## global & GLOBALS


## 超级全局变量：


## 数组

```php
$arry = new array("","","");


多维：

$google = new array
(
  "google" => new array("Google","https://www.google.com/ncr");
);
```

## 对象数组的遍历方式： foreach();

## 面向对象

# PHP 扩展：

**&nbsp;&nbsp;无论是 `Apache` 还是 `Nginx` 抑或 `IIS` 等 `web服务器`，默认都不会解释 php 代码，如果要临时调用浏览器解释 php，可以使用以 -S 和 -t 选项运行 php。 `php -S localhost:8000 -t /home/data/web` .**

## Nginx 集成 php：php-fpm

**&nbsp;&nbsp; Nginx 无论怎样也不会解释 php，但是它可以读取外部程序的解释结果。 php-fpm 是一个 cgi 程序，其实就是一个包装了的外壳程序，它可以调用 php 解释器读取 php 并对其解释，然后将解释后的代码返回给 Nginx 读取。**

```config
#....
# 启用 Ngnix 解析 php.
#location ~ \.php$ {
# 支持解析嵌入的 php 代码.
location ~ \.(php|html|htm)$ {
#root html;
root           /home/data/web;
#fastcgi_pass   127.0.0.1:9000;
fastcgi_pass  unix:/run/php-fpm.sock;
fastcgi_index  index.php;
#fastcgi_param  script_filename  /scripts$fastcgi_script_name;
#    proxy_pass   http://127.0.0.1;
fastcgi_param  script_filename  $document_root$fastcgi_script_name;
#include        fastcgi_params;
include        fastcgi.conf;
}
#.....
```

```ini
;........
user = http
group = http
listen = /run/php-fpm.sock
listen.owner = http
listen.group = http
listen.mode = 0660
;......
```


### php & mysql

**&nbsp;&nbsp;为了在 PHP 调用 MySQL，我们必须确认 PHP 已经启用了 mysql 模块。然后通过 php 的 -i 选项或者 phpinfo() 函数进行确认。**

```ini
...
# 载入 mysqli 模块.
extension = mysqli.so
[mysqli]
mysqli_default_socket = .
....
```


### phpmyadmin：可视化的 MySQL Web 管理器.

> **config.inc.php**

```php
<?php
.....
/* 似乎并不支持使用 localhost */
$cfg['Servers'][$i]['host'] = '127.0.0.1';
....
?>
```

## PHP 的命令行模式官方文档见[这里][php-cli].
**&nbsp;&nbsp;在 Unix 及其变体上，默认是启用了 php-cli 以及 php-cgi，通过 php -v 可以确认运行在那种模式下的。**

+ -r --run 运行单行 php 代码，如果使用变量，为了不被 shell 强行解释，因该对`$`去引用。
+ -s --syntax-hightlight  渲染 php 文档，输出 html 代码块。
+ -f php-file 解释一个 php 文档。
+ -a --interactive 进入交互式模式。
+ -l --syntax-check 语法检查，如果要检查致命错误，要和 -f 一起使用。
+ -m --modules 打印载入的模块信息。
+ -i --info 等同 phpinfo() 函数。
+ -w strip-space 去掉多余空格。
+ -c 指定新的 php 配置文件

**&nbsp;&nbsp;如果要使用 php 解释器解释 php 文档，除了使用 web 服务器，可以直接使用命令行模式下的 php 解释，但是 php 解释器不会解释非 php 代码。**

test.php
```php
#!/usr/bin/php
<?php phpinfo(); ?>
```

`chmod u+rx test.php` `./test.php`

等效与

`php [-f] test.php`

[php-cli]: https://secure.php.net/manual/zh/features.commandline.php
[php-man-zh]: https://secure.php.net/manual/zh/

