<?php
echo "冒泡排序<br>";

$arry = array(56,40,29,12,57,55,11,92,102,292);
/*
 * 0 9, 1 8, 2 7, 3 6, 4 5 ====> 
 * index = 4
 * 56,40,29,12,57,55,11,92,102,292 arry[4] = 57 
 * 56 40 29 12 11 55 57 92 102 292 arry[4] = 11
 * 11 56 40 29 12 55 57 92 102 292 arry[4] = 12
 * 11 12 56 40 29 55 57 92 102 292 arry[4] = 29
 * 11 12 29 56 40 55 57 92 102 292 arry[4] = 40
 * 11 12 29 40 56 55 57 92 102 292 
 *
 */

$len = count($arry);

for($i = 0;$i < $len;$i++){
  #printf('$arry[%d] = %d',$i,$arry[$i]); echo "<br>";
  echo $arry[$i]," ";
}
echo "<hr>";

#do{
#  printf("arry[%d] = %d",$len,$arry[$len]);
#  echo "<br>";
#}while(--$len > 0);

echo "<br>";

/*
for($i = 0;$i < count($arry) - 1;$i++){
  for($j = 0;$j < $i;$j++){
    if($arry[$j+1] < $arry[$j]){
      $tmp = $arry[$j];
      $arry[$j] = $arry[$j+1];
      $arry[$j+1] = $tmp;
    }
  }
}
*/

/*
for($j = 0;$j < $len - 1;$j++){
  echo 'j = ',$arry[$j],"<br>";
  for($i = 0;$i < $len -2;$i++){
  echo 'i = ',$arry[$i],"<br>";
    if($arry[$i] > $arry[i+1]){
      $tmp = $arry[$i];
      $arry[$i] = $arry[$i+1];
      $arry[$i+1] = $tmp;
    }
  }
}
 */

/*
 * 56 <-> 292 40 <-> 102 29 <-> 92 12 <-> 11 57 <-> 55 ===> 56 40 29 11 55  57 12 92 102 292
 */

for($i = 0;$i < $len - 1;$i++){
  for($j = $len - 1;$j > $i;$j--){
    printf('$arry[%d],$arry[%d] %d,%d ',$i,$j,$arry[$i],$arry[$j]);
    echo "<hr>";
    if($arry[$i] > $arry[$j]){
      $tmp = $arry[$i];
      $arry[$i] = $arry[$j];
      $arry[$j] = $tmp;
    }
  }
}


for($i = 0;$i < $len;$i++){
  #printf('$arry[%d] = %d',$i,$arry[$i]); echo "<br>";
  echo $arry[$i]," ";
}
echo "<hr>";

unset($arry,$len);
?>
