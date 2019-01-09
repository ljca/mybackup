<?php
$conn = null;
if($conf = parse_ini_file(realpath(dirname(__FILE__) .'/../config/config.ini'))) echo "sucess!</br>";

if($conn = new mysqli($conf['host'],$conf['user'],$conf['psk'],$conf['db'])) echo "connect sucess!</br>";

if($conn->connect_error) die("connect mysql error: ".$conn->connect_error); 

if(!$stmt = $conn->prepare("insert into guests(firstname,lastname,email) values(?,?,?)")) echo "stmt error: </br>";

#var_dump($conf);
#echo "</br>";
#var_dump($conn);
#echo "</br>";
#var_dump($stmt);
#echo "</br>";
if(!$stmt->bind_param("sss",$fn,$ln,$el))  echo "bind params faild.</br>";
#echo "bind param success!</br>";

$fn = "Piter";
$ln = "Apl";
$el = "piter@gmail.com";
if(!$stmt->execute()) echo "execute faild!</br>";

$fn = "Lin";
$ln = "Ani";
$el = "ani_lin@gmail.com";
if(!$stmt->execute()) echo "execute faild!</br>";
echo "</br>";

$fn = "Bob";
$ln = "Aoa";
$el = "bob@gmail.com";
if(!$stmt->execute()) echo "execute faild!</br>";
echo "</br>";

echo 'data insert done.</br>';

if(!$stmt->close()) echo "stmt close error: </br>";

if(!$conn->close()) echo "conn close error: </br>";

?>
