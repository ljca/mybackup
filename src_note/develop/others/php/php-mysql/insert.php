<?php

$conf = parse_ini_file(realpath(dirname(__FILE__) .'/../config/config.ini')) or die("error: ");
$conn = mysqli_connect($conf['host'],$conf['user'],$conf['psk'],'test') or die("Connect Faild".mysqli_connect_error($conn));

$user = 'meiseup';
$email = 'meiseup@yeah.net';
$comments = '临时账户.';

$sql = "insert into user_info(user,email,comments) values('$user','$email','$comments')";

if(mysqli_query($conn,$sql)){
  echo "<script>alert('添加成功！');window.location.href='select.php'</script>";
}else die("err: " . mysqli_error($conn));

mysqli_close($conn);

?>
