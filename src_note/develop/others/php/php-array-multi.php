<?php
$arry = array(
  array("Volvo",100,96),
  array("BMW",60,59),
  array("Toyata",110,100)
);

print("<pre>");
var_dump($arry);
print("<pre>");

echo "<br>";

for($i = 0;$i < count($arry);$i++){
  for($j = 0;$j < count($arry);$j++){
    echo $arry[$i][$j] . " ";
  }
  echo "<br>";
}

foreach($arry as $first){
  foreach($first as $val){
    echo $val . " ";
  }
  echo "<br>";
}

unset($arry);

$sites = array(
  'runoob' => array('菜鸟教程','http://www.runoob.com'),
  'google' => array('Google','https://www.google.com/ncr'),
  'baidu' => array('Baidu','https://www.baidu.com'),
  'taobao' => array('淘宝','https://www.taobao.com')
);

print("<pre>");
var_dump($sites);
print("<pre>");

print("<pre>");
print_r($sites);
print("<pre>");


?>

