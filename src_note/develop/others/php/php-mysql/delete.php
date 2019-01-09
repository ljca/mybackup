<?php
require_once("conn.php");

#$user = 'meiseup';
#$email = 'meiseup@yeah.net';
#$coments = '临时账户.';
$id = $_GET['id'];

#$sql = "delete from user_info where id between 5 and 8 and user = '$user'";
$sql = "delete from user_info where id = $id";

if(mysqli_query($conn,$sql)){
  echo "<script>alert('删除成功！');window.location.href='page.php'</script>";
}else die("err: " . mysqli_error($conn));

mysqli_close($conn);

?>
