<?php
$conf = parse_ini_file(realpath(dirname(__FILE__)) . '/../config/config.ini');

$conn = mysqli_connect($conf['host'],$conf['user'],$conf['psk'],"test");

#$con=mysqli_connect("localhost","mysql","mysql?","test"); 
#$conn=mysqli_connect("localhost","mysql","mysql?","test"); 

if(!$conn){
  die("connect error".mysqli_connect_error());
  exit;
}

#mysqli_select_db("test");
$stmt = mysqli_stmt_init($conn);
#$country = "CN";
$id = 4;
#if(mysqli_stmt_prepare($stmt,"select name from websites where country = ?"));
#var_dump($stmt);
if (mysqli_stmt_prepare($stmt,"SELECT name,country FROM websites WHERE id = ?")){
#if(mysqli_stmt_prepare($stmt,"select name from websites where country = ?")){
  #mysqli_stmt_bind_param($stmt,"s",$country);
  mysqli_stmt_bind_param($stmt,"i",$id);
  mysqli_stmt_execute($stmt);
  #mysqli_stmt_bind_result($stmt,$name);
  mysqli_stmt_bind_result($stmt,$name,$country);
  mysqli_stmt_fetch($stmt);
  #printf("%s 的网站为 %s",$country,$name);
  printf("id 为 %d 的网站是%s,所属国家是 %s",$id,$name,$country);
  echo "<br>";
  #printf("%s 网站的国家为 %s",$name,$country);
  mysqli_stmt_close($stmt);
}

/*
mysqli_select_db("test");
$country="CN";

// 创建预处理语句
$stmt=mysqli_stmt_init($con);

if (mysqli_stmt_prepare($stmt,"SELECT name FROM websites WHERE country=?"))
{

  // 绑定参数
  mysqli_stmt_bind_param($stmt,"s",$country);

  // 执行查询
  mysqli_stmt_execute($stmt);

  // 绑定结果变量
  mysqli_stmt_bind_result($stmt,$name);

  // 获取值
  mysqli_stmt_fetch($stmt);

  printf("%s 国家的网站为：%s",$country,$name);

  // 关闭预处理语句
  mysqli_stmt_close($stmt);
}
*/

mysqli_close($conn);


/*
$conn = new mysqli($conf['host'],$conf['user'],$conf['psk']);
print_r($conn);
echo "<br>";

$conn->select_db("test");
echo "...<br>";
$stmt = $conn->prepare("select name from websites where country = ?");

$stmt->execute();
$stmt->close();
$conn->close();
 */
echo "<br>";

?>
