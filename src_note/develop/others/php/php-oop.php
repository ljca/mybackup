<?php
declare(encoding='UTF-8');

class Car{
}

class Site{
  var $title = "PHP-OOP";
  var $url = 'https://';

  function __construct($title,$url)
  {
    $this->title = $title;
    $this->url = $url;
    echo __CLASS__ . " 类构造函数调用...<br>";
  }
  function __destruct()
  {
    echo __CLASS__ . " 类析构函数调用...<br>";
    #delete($this->url);
    #delete($thie->title);
    #delete($this);
    unset($this->url,$this->title);
  }

  function setTitle($title)
  {
    $this->title = $title;
  }

  function getTitle()
  {
    return $this->title;
  }

  function setUrl($url)
  {
    $this->url = $url;
  }

  function getUrl()
  {
    return $this->url;
  }

}

$google = new Site("Google","https://www.google.com/ncr");
#$google->setTitle("Google");
#$google->setUrl("https://www.google.com/ncr");

$taobao = new Site("淘宝","https://www.taobao.com");
#$taobao->setTitle("淘宝");
#$taobao->setUrl("https://www.taobao.com");
#

$baidu = new Site("百度","https://www.baidu.com");

$runoob = new Site("菜鸟教程","http://www.runoob.com");

#printf("%s: %s",$google->getTitle(),$google->getUrl());
#echo "<br>";
echo "<a href='" . $google->getUrl() . "'>" . $google->getTitle() . "</a> ";
echo "<a href='" . $baidu->getUrl() . "'>" . $baidu->getTitle() . "</a> ";
echo "<a href='" . $taobao->getUrl() . "'>" . $taobao->getTitle() . "</a> ";
echo "<a href='" . $runoob->getUrl() . "'>" . $runoob->getTitle() . "</a> ";
echo "<br>";


class Child_Site extends Site{
  #var $meta;
  public $meta;
  protected $country;
  private $pages;

  function __construct($meta,$country,$pages)
  {
    $this->meta = $meta;
    $this->country = $country;
    $this->pages = $pages;
  }

  function __destruct()
  {
    #delete($this->meta,$this->country,$this->pages);
    unset($this->meta,$this->country,$this->pages);
  }

  function setMeta()
  {
  }

  function getMeta()
  {
  }

  function getUrl()
  {}

  function getTitle()
  {}

  function info()
  {
    echo $this->title,"<br>";
    echo $this->url,"<br>";
    echo $this->meta,"<br>";
    echo "$this->country\n";
    echo $this->pages,"<br>";
  }
}

$site = new Child_Site("encoding=utf-8","cn","200");
$site->info();

echo $site->meta,"<br>";
#echo $site->country,"<br>";
#echo $site->pages,"<br>";

?>

