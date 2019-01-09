<?php
echo "<h3> 数值型数组：以索引访问，遍历 </h3>";
$arra = array("Orange","Apple","Banena","石榴","榴莲","火龙果");
for($i = 0;$i < count($arra);$i++) echo "arra[$i] = ",$arra[$i],"<br>";

echo "<br>";
foreach($arra as $fruts) echo $fruts," ";

echo "<h3> 键值对数组：以键访问 </h3>";
#$arr_str1 = $arr_str = array("r" => "Red","b" => "Black","B" => "Blue","y" => "Yellow","g" => "Green","G" => "Gray","w" => "White","o" => "Orange","p" => "Pink");
$arr_str1 = $arr_str = array("r" => "Red","o" => "Orange","y" => "Yellow","g" => "Green","b" => "Blue","c" => "Cyan","p" => "Purple","B" => "Black",'W' => "White","P" => "Pink");

foreach($arr_str as $color => $c_value){
  #echo $color," = ",$c_value,"<br>";
  switch($color){
  case "r": echo $c_value," = ","赤<br>"; break;
  case "o": echo $c_value," = ","橙<br>"; break;
  case "y": echo $c_value," = ","黄<br>"; break;
  case "g": echo $c_value," = ","绿<br>"; break;
  case "b": echo $c_value," = ","蓝<br>";break;
  case "c": echo $c_value," = ","靛<br>";break;
  case "p": echo $c_value," = ","紫<br>";break;
  case "B": echo $c_value," = ","黑<br>"; break;
  case "W": echo $c_value," = ","白<br>";break;
  case "G": echo $c_value," = ","灰<br>";break;
  case "P": echo $c_value," = ","粉<br>"; break;
  default : echo $c_value," = ","未知颜色<br>"; break;
  }
}

echo "<p><b>如果对键值对型数组调用 sort / rsort 函数，它将会丢失键变成数值索引型数组.</b></p>";
echo "<br>";
var_dump($arr_str);
echo "<br><br>";
sort($arr_str);
var_dump($arr_str);
echo "<br><br>";
for($i = 0;$i < count($arr_str);$i++) echo "arr_str[$i] = ",$arr_str[$i],"<br>";
echo "<br>";
#
asort($arr_str1);
#ksort($arr_str1);
var_dump($arr_str1);
echo "<br><br>";
foreach($arr_str1 as $color => $c_value){
  #echo $color," = ",$c_value,"<br>";
  switch($color){
  case "r": echo $c_value," = ","赤<br>"; break;
  case "o": echo $c_value," = ","橙<br>"; break;
  case "y": echo $c_value," = ","黄<br>"; break;
  case "g": echo $c_value," = ","绿<br>"; break;
  case "b": echo $c_value," = ","蓝<br>";break;
  case "c": echo $c_value," = ","靛<br>";break;
  case "p": echo $c_value," = ","紫<br>";break;
  case "B": echo $c_value," = ","黑<br>"; break;
  case "W": echo $c_value," = ","白<br>";break;
  case "G": echo $c_value," = ","灰<br>";break;
  case "P": echo $c_value," = ","粉<br>"; break;
  default : echo $c_value," = ","未知颜色<br>"; break;
  }
}

#
unset($arra,$arr_str,$arr_str1);
echo "<h3> 数组排序 </h3>";

$rnum = $num = array(20,10,80,60,29,10,59,29,9);

echo "升序<br>";
foreach($num as $n) echo "$n ";
sort($num);
echo "<br><br>";
foreach($num as $n) echo "$n ";
echo "<br><br>";

echo "降序<br>";
foreach($rnum as $n) echo "$n ";
rsort($rnum);
echo "<br><br>";
foreach($rnum as $n) echo "$n ";
echo "<br><br>";

unset($num,$rnum);

echo "下一章：<a href='charpter9.php'>表单验证<a>";
?>
