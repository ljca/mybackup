<?php
require_once("conn.php");
$operator = isset($_GET['operator']) ? $_GET['operator'] : 'select';
$id = intval($_POST['id']);
$user = $_POST['user'];
$email = $_POST['email'];
$comments = $_POST['comments'];

function con($db)
{
  $conf = parse_ini_file(realpath(dirname(__FILE__) .'/../config/config.ini'));
  $conn = mysqli_connect($conf['host'],$conf['user'],$conf['psk'],$db) or die("Connect Faild".mysqli_connect_error($conn));
  return $conn;
}

$conn = con("test");

function change($sql)
{
  switch($operator){
  case "insert":
    break;
  case "update":
    $sql = "update user_info set user = '$user',email = '$email',comments = '$comments' where id = '$id'";
    update($sql);
    if(mysqli_query($conn,$sql)){
      echo "<script>alert('更新数据成功！');window.location.href='page.php'</script>";
    }else die("err: " . mysqli_error($conn));
    break;
  case "delete":
    break;
  default:
    break;
  }
  $b = mysqli_query($conn,$sql);
  return $b;
}

function update($sql)
{
}

function del($sql)
{
}

function select($sql,$id)
{
}




mysqli_close($conn);

?>
