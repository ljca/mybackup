<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8" />
    <title>Charpter 1: PHP syntax!</title>
    <style>
<!--
.error {color: red;}
-->
    </style>
  <script> 
  <!-- 
  -->
    </script>
  </head>
  <body>
<?php
$usererr = $pskerr = $emailerr = $gendererr = $websiteerr = "";
$user = $psk = $email = $gender = $comment = $website = "";

          if($_SERVER['REQUEST_METHOD'] == 'POST'){
          if(empty($_POST['user'])){
          $usererr = "用户名不能为空！";
          }else{
          $user = test_input($POST["user"]);
          if(!preg_match("/^[a-zA-Z]*$/",$user)) $usererr = "只允许字母和空格！";
          }

          if(empty($_POST['psk'])) $pskerr = "密码不能为空！";

          if(empty($_POST['email'])) $emailerr = "邮箱不能为空！";
          else{
          $email = test_input($_POST['email']);
          if(!preg_match("/([\w\-]+\@[\w\-]+\.[\w\-]+)/",$email)) $emailerr = "非法邮箱格式！";
          }

          if(empty($_POST['website'])) $websiteerr = "网址不能为空！";
          else{
          $email = test_input($_POST['website']);
          if(!preg_match("/\b(?:(?:https?|ftp):\/\/|www\.)[-a-z0-9+&@#\/%?=~_|!:,.;]*[-a-z0-9+&@#\/%=~_|]/i",$website)) $websiteerr = "非法 URL 地址！";
          }

          if(empty($_POST['gender'])) $gendererr = "性别不能为空！";
          else $gender = test_input($_POST['gender']);

          if(empty($_POST['comment'])) $comment = "";
          #else $comment = test_input($_POST['comment']);
          }
function test_input($data)
          {
          $data = trim($data);
          $data = stripslashes($data);
          $data = htmlspecialchars($data);
          return $data;
          }
?>

    <!--form method='post' action='<?php echo $_SERVER["PHP_SELF"];?> ' -->
    <p><span class='error'>*必须字段</span></p>
    <!--form method='post' action="test_form.php"-->
     <form method='post' action="<?php echo $_SERVER['PHP_SELF']; ?> ">
      <p>账户：<input type='text' name='user' />
      <span class='error'>* <?php echo $usererr;?></span>
      </p>
      <p>密码：<input type='password' name='psk' />
      <span class='error'> * <?php echo $pskerr;?></span>
      </p>
      <p>E-mail：<input type='text' name='email' />
      <span class='error'>* <?php echo $emailerr;?></span>
      </p>
      <p>网址：<input type='text' name='website'>
      <span class='error'> * <?php echo $websiteerr;?></span>
      </p>
      <p>备注：<textarea name='comment' rows='5' cols='40'>
       <?php echo $comment;?>
      </textarea>
      </p>

      <p><input type='radio' name='gender' <?php if(isset($gender) && $gender == "female") echo "checked";?> value='female'/> 女
      <input type='radio' name='gender' <?php if(isset($gender) && $gender == "male") echo "checked";?> value='male'/> 男
      <span class='error'>* <?php echo $gendererr;?></span>
 </p>
      <input type='submit' value='提交' />
    </form>

    <?php 
echo "<h2></h2>";
          echo "User: " . $user . "<br>";
          echo "Psk: " . $psk . "<br>";
          echo "E-mail: " . $email . "<br>";
          echo "Website: " . $website . "<br>";
          echo "Comment: " . $comment . "<br>";
          echo "Gender: " . $gender . "<br>";
    ?>


  </body>
</html>
