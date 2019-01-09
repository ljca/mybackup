<?php 

$conf = parse_ini_file(realpath(dirname(__FILE__) .'/../config/config.ini')) or die("error: ");
$conn = mysqli_connect($conf['host'],$conf['user'],$conf['psk'],'test') or die("Connect Faild".mysqli_connect_error($conn));


$user = $_POST['user'];
$email = $_POST['email'];
$psk = $_POST['psk'];
$psk = $_POST['comments'];

$sql = "insert into userinfo() values('$user','$psk','$email','$comments');";

$conn = mysql_connect("localhost","mysql","mysql?","bookms");
if(mysqli_query($conn,$sql)){
  echo "<script>alert('添加成功！');window.location.href='select.php'</script>";
}else die("err: " . mysqli_error($conn));

echo "<script>window.location.href='index.php'</script>";

mysql_close($conn);


?>
<link rel='stylesheet' type='text/css' href='css/style.css' />

<script type='text/javascript'>
<!--

  function ck()
  {
    /*if(empty()*/
  }


-->
</script>

<form action='<?php echo $_SERVER["PHP_SELF"]?>' method='post'>
<p><label>账户名：</label><input  size='40' type='text' name='user' /></p>
<p><label>E-mail：</label><input size='40' type='text' name='email' /></p>
<p><label>密码：</label><input size='40' type='password' name='psk' /></p>
<p><label>备注：</label><textarea name='comments' cols='50' rows='5'></textarea>
<p>
<input type='reset' value='重置' />
<input type='submit' value='注册' />
</p>

</form>

