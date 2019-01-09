<?php
require_once("conn.php");

$id = $_GET['id'];

$sql = "select * from user_info where id = $id";

$rs = mysqli_query($conn,$sql);
$row = mysqli_fetch_row($rs);
var_dump($row);
$user = $row[1];
$email = $row[2];
$comments = $row[3];
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

<form action='control.php' method='post'>
<p><label>账户名：</label><input  size='40' type='rext' name='user' value='<?php echo $user?>'/></p>
<p><label>E-mail：</label><input size='40' type='text' name='email' value='<?php echo $email?>'/></p>
<p><label>备注：</label><textarea name='comments' cols='50' rows='5'value='<?php echo $comments?>'></textarea>
<p>
<input type='hidden' name='id' value='<?php echo $id ?>'/>
<input type='submit' value='更新' />
</p>

</form>


<?php mysqli_close($conn); ?>
