<?php
# PHP operators.
#
echo "<h2> PHP 基本运算符. + - * / % -- ++ </h2>";

$x = 20;
$y = 50;
printf('$x = %d,$y --> %d;',$x,$y);
echo "<br>";
printf('%d + %d --> ? %d;',$x,$y,$x + $y);
echo "<br>";
printf('%d - %d --> ? %d;',$x,$y,$x - $y);
echo "<br>";
printf('%d * %d --> ? %d;',$x,$y,$x * $y);
echo "<br>";
$rs = $y / $x;
echo "$rs<br>";
print("$rs<br>");
printf('$rs = %d',$rs);
echo "<br>";
printf('$rs = %.2f',$rs);
echo "<br>";
printf('%d / %d = ? %.2f;',$y,$x,$y / $x);
echo "<br>";
printf('%d %% %d = ? %d;',$y,$x,$y % $x);
echo "<br><br>";

printf('$x++ --> %d,$y++ --> %d;',$x++,$y++);
echo "<br>";
printf('$x --> %d,$y --> %d;',$x,$y);
echo "<Br>";
$x++;
$y++;
printf('$x --> %d,$y --> %d;',$x,$y);
echo "<br>";
printf('++$x --> %d,--$y --> %d;',++$x,--$y);
echo "<Br>";
printf('$x --> %d,$y --> %d;',$x,$y);
echo "<Br>";
++$x;
--$y;
printf('$x --> %d,$y --> %d;',$x,$y);
echo "<Br>";


unset($x,$y);

#
echo "<h2> 逻辑运算符. </h2>";
# 绝对等于
echo '(5 === "5") --> ',var_dump(5 === "5"),"<br>";

# 绝对不等于
echo '(5 !== "5") --> ',var_dump(5 !== "5"),"<br>";

echo '(5 == "5") --> ',var_dump(5 == "5"),"<br>";
echo '(5 != "5") --> ',var_dump(5 != "5"),"<br>";
# 不等于
echo '(5 <> "5") --> ',var_dump(5 <> "5"),"<br>";
#
# 太空船运算符
echo '<h2>PHP 组合比较运算符(太空船运算符) <=> </h2>';
echo '(1 <=> 2) --> ',var_dump(1 <=> 2),"<br>";
echo '(1 <=> 1) --> ',var_dump(1 <=> 1),"<br>";
echo '(2 <=> 1) --> ',var_dump(2 <=> 1),"<br>";

# 整除运算符
echo '<h2>PHP 整除运算符 intdiv($num,$num2)</h2>';
printf('intdiv(10,3) --> %d',intdiv(10,3));
echo "<br>";
echo 'intdiv(10,3) --> ',intdiv(10,3),"<br>";

# .
echo "<h2>PHP string . operators</h2>";
$str = "PHP";
echo '$str --> '."$str<br>";
$str .= " is very good!";

echo '$str .= --> '."$str<br>";

echo 'this is test '."string!"."<br>";

unset($str);

# 键值对数组运算
#
echo "<h2> 键值对数组(=> 定义)运算 </h2>";
$arra = array("r" => "red","g" => "green");
$arrb = array("b" => "black","w" => "white","y" => "yellow");
echo "<h3> +: 连接，合并 </h3>";
echo 'var_dump($arra) --> ',var_dump($arra),"<br>";
echo 'print_r($arra) --> ',print_r($arra),"<br>";
echo 'var_dump($arrb) --> ',var_dump($arrb),"<br>";
echo 'print_r($arrb) --> ',print_r($arrb),"<br>";
$arrc = $arra + $arrb;
echo '$arrc = $arra + $arrb --> ',var_dump($arrc),"<br>";
echo 'print_r($arrc) --> ',print_r($arrc),"<br>";

echo "<h3> 逻辑运算. </h3>";
echo 'var_dump($arra == $arrb) --> ',var_dump($arra == $arrb),"<br>";
echo 'var_dump($arra != $arrb) --> ',var_dump($arra != $arrb),"<br>";
echo 'var_dump($arra <> $arrb) --> ',var_dump($arra <> $arrb),"<br>";
#echo "$arra <> $arrb<br>";
echo 'var_dump($arra === $arrb) --> ',var_dump($arra === $arrb),"<br>";
echo 'var_dump($arra !== $arrb) --> ',var_dump($arra !== $arrb),"<br>";

unset($arra,$arrb,$arrc);

echo "<h3> 三元运算符 ?? ?: </h3>";

echo "(2 > 3) ? (2) : (3) --> ",(2 > 3) ? (2) : (3),"<br>";

echo "2 > 3 ?: 3 --> ",2 > 3 ?: 3,"<br>";

echo "<h3> PHP_EOL </h3>";
#echo "PHP_EOL",PHP_EOL;

$user = ($user ?? "nobody");

echo $user,PHP_EOL;

?>

