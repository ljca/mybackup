<?php
# PHP 控制结构
echo "<h2> PHP 控制结构 </h2>";
echo "<h3> PHP 选择结构：if & if-else & if-elseif-else </h3>";
echo "<strong>当前时区：",date_default_timezone_get(),"</strong><br>";
echo "<strong>当前时间：",date("Y/m/d H:i:s"),"</strong><br>";
$t = date("H");

if($t >= 18){
  echo "<strong>夜幕降临，Have a good night!</strong><br>";
}
else if($t >= 21 && $t <= 23){
  echo "<strong>good night!</strong><br>";
}
else if($t >= 5 && $t <= 8){
  echo "<strong>旭日东升，Have a good mornning!</strong><br>";
}
else echo "<strong>好好学习，Have a good day!</strong><br>";

echo "<h3> PHP 选择结构：switch </h3>";

#$arr_str = array("r" => "Red","b" => "Black","B" => "Blue","y" => "Yellow","g" => "Green","w" => "White","o" => "Orange","p" => "Pink");

#$rs = 10;

echo "result<br>";

for($i = 0;$i <= 150;$i++){
  #
  echo "$i ∈ ";
  if($i >=30 && $i < 60){
    echo 'C , ';
    if($i == 30) echo "<br><br>30+ <br>";
  }else if($i >= 60 && $i < 70){
    echo 'B , ';
    if($i == 60) echo "<br><br>60+ <br>";
  }else if($i >= 70 && $i < 80){
    echo 'B+ , ';
    if($i == 70) echo "<br><br>70+ <br>";
  }else if($i >= 80 && $i < 90){
    echo 'A , ';
    if($i == 80) echo "<br><br>80+ <br>";
  }else if($i >= 90 && $i <= 150){
    echo 'A+ , ';
    if($i == 90) echo "<br><br>90+ <br>";
  }else echo 'D ,';
}

#
echo "<br>";
echo "<br>";
for($i = 0;$i <= 150;$i++){
  echo "$i ∈ ";
  switch(intval($i / 10)){
  case 3:
    echo "C | ";
    break;
  case 4:
  case 5:
    echo "C+ | ";
    break;
  case 6:
    echo 'B | ';
    break;
  case 7:
  case 8:
    echo 'B+ | ';
    break;
  case 9:
    echo 'A | ';
    break;
  case 10:
  case 11:
  case 12:
  case 13:
  case 14:
  case 15:
    echo 'A+ |  ';
    break;
  default:
    echo 'D | ';
    break;
  }
}


echo "<h3> PHP 循环结构：while & do-while </h3>";
echo "<h3> PHP 循环结构：for </h3>";
echo "<h3> PHP 循环结构：foreach </h3>";

unset($t);
?>
