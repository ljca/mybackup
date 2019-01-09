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
    <!-- 
      <form method = "post" action = "<?php echo $_SERVER['PHP_SELF']; ?>">
      <p> 帐号：<input type="text" name ="uname" /></p>
      <p> 密码：<input type="password" name ="psk" /></p>
      <p> <input type="submit" /> </p>
      </form>
      <?php 
      $uname = $_POST["uname"];
      echo "user: ",$uname;
      echo "<br>";
      $psk = $_POST["psk"];
      echo "psk: ",$psk;
      echo "<br>";
      ?>

      <form method = "post" action = "<?php echo $_SERVER['PHP_SELF']; ?>">
      <p>用户名：<input type="text" name = "user" ></p>
      </form>
      <?php 
      $user = $_POST['user'];
      $fname = $_REQUEST['user'];
      echo '$_REQUEST["user"]: ',$fname;
      echo "<br>";
      echo '$_POST["user"]: ',$user;
      unset($fname,$user);
      ?>

    -->

    <p><a href='charpter2.php?wd=localhox&tn=monline_dg&ie=utf-8&subject=PHP&web=charpter2.php&page=1'>获取请求参数</a></p>
  </body>
</html>
