<?php
$conn = null;

/*
try{
  $conf = parse_ini_file(realpath(dirname(__FILE__) .'/config/config.ini'));
  $conn = new mysqli($conf['host'],$conf['user'],$conf['psk'],$conf['db']);
  if(mysqli_connect_errno()) throw new Exception("Connect Error: ");
  else echo "connect mysql seccess!";
}catch(Exception $e){
  echo $e->getMessage();
}finally{
  $conn = null;
}
*/

$conf = parse_ini_file(realpath(dirname(__FILE__) .'/config/config.ini'));
$conn = mysqli_connect($conf['host'],$conf['user'],$conf['psk'],$conf['db']);

if($conn) echo "connect mysql sucess.</br>";
  else  die("Connect Faild".mysqli_connect_error());

$sql = "create table if not exists guests(
id INT(6) UNSIGNED auto_increment primary key,
firname varchar(30),
lastname varchar(30) NOT NULL,
email varchar(50),
reg_date TIMESTAMP
)";


if(mysqli_query($conn,$sql)) echo "create table done.</br>";
  else echo "Error: ".mysql_error($conn);

echo "</br>";
## Insert data.
#$sql = "insert into guests(firstname,lastname,email) values('John','Doe','john@gmail.com')";
$sql = "insert into guests(firstname,lastname,email) values('Mary','Moe','mary@gmail.com');";
$sql .= "insert into guests(firstname,lastname,email) values('Gulie','Dooley','mary@gmail.com');";
$sql .= "insert into guests(firstname,lastname,email) values('Julie','Coe','julie@gmail.com')";

#if(mysqli_query($conn,$sql)) echo "insert data done.</br>";
if(mysqli_multi_query($conn,$sql)) echo "insert data done.</br>";
  else echo "executeble insert sentence error: ".$sql.mysqli_error($conn);

echo "</br>";

mysqli_close($conn);

echo "close connection done.</br>";

?>


