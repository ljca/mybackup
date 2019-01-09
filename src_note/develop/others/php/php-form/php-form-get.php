<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8" />
    <title>Charpter 1: PHP syntax!</title>
  <script> 
  <!-- 
  -->
    </script>
  </head>
  <body>
    <form method='get' action='<?php echo $_SERVER["PHP_SELF"];?>'>
      <p>账户：<input name='user' type='text'/></p>
      <p>E-mail：<input name='email' type='text'/></p>
      <input type='submit' value='提交'/>
    </form>
    <?php 
      if($_SERVER['REQUEST_METHOD'] == 'GET'){
        #echo "User: ". $_GET['user'] . "<br>";
        echo "User: ". $_REQUEST['user'] . "<br>";
        echo "E-mail: ". $_REQUEST['email'] . "<br>";
        echo "<script>alert(" . $_GET['email'] . ")</script>";
      }
    ?>
  </body>
</html>
