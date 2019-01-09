<?php
echo "<h2>Charpter 2: PHP Variables.</h1>";
echo "<h3> PHP 局部变量 </h2>";
/*
$num = 2;

function echo_num($num)
{
  $num = 3;
  printf('$num = %d, ',$num);
  #global $num;
  printf('GLOBALS["num"] = %d, ',$GLOBALS['num']);
}

echo_num(5);
echo_num("num");
echo_num(50.2);
printf('$num + 5 = %d, ',$num + 5);
printf('$num - 5 = %d, ',$num - 5);
printf('$num + 20.5 = %d, ',$num + 20.5);
printf('$GLOBALS["num"] = %d, ',$GLOBALS['num']);
$GLOBALS['num'] = 79;
echo $num;
echo "<hr><br>";
$arr = array("1",2,0xFA,50.2,true);
print_r($arr);

echo "<br>";
var_dump($num);
echo "<br>";
var_dump($arr);
echo "<hr><br>";
 */

echo "<h3> 超级全局变量 </h3>";
echo '<h4><a href=""> 全局变量 $GLOBALS</a></h4>';
echo '<h4><a href=""> 获取 PHP 服务器运行参数 $_SERVER</a></h4>';

/*
printf('$_SERVER(["PHP_SELF"]) = %s',$_SERVER["PHP_SELF"]);
echo "<br>";
*/

/* 
foreach($_SERVER as $key => $value){
  printf("%s =  %s",$key,$value);
  echo "<br>";
}
*/

echo '<h4> <a href="php_get.html">获取表单数据 $_REQUEST</a></h4>';
/* <form method="post" action = "<?php echo $_SERVER['PHP_SELF']; ?> ">*/
/*
$name = $_REQUEST['fname'];
echo $name;
 */


echo '<h4> <a href="php_get.html">获取请求参数 $_GET</a></h4>';

printf('$_GET["wd"] = %s ',$_GET['wd']);
echo("<br>");
printf('$_GET["tn"] = %s ',$_GET['tn']);
echo "<br>";
printf('$_GET["ie"] = %s ',$_GET['ie']);
echo "<br>";

printf('$_GET["subject"] = %s ',$_GET['subject']);
echo "<br>";
printf('$_GET["web"] = %s ',$_GET['web']);
echo "<br>";
printf('$_GET["page"] = %s ',$_GET['page']);
echo "<hr>";


echo '<h4> <a href="">获取表单数据 $_POST</a></h4>';

echo("Charpter 3:<a href='php_sentence.php'>php sentences.</a>");

?>

